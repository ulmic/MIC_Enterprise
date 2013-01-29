using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using agsXMPP;
using agsXMPP.Collections;
using agsXMPP.protocol.client;
using agsXMPP.protocol.x.muc;
using agsXMPP.protocol.x.data;

namespace EnterpriseMICApplicationDemo {
    public partial class FormConferention : EnterpriseMICApplicationMiniForm {
        private Jid roomJid;
        private string mainJid;
        private string nickname;
        private string roomName;
        private string roomDesc;//описание комнаты
        private string savingHistory;
        private string persistRoom;
        private XmppClientConnection xmpp;
        private MucManager muc;

        /// <summary>
        /// Вызывается, если присоединяемся к конференции
        /// </summary>
        /// <param name="_roomJid"></param>
        /// <param name="password"></param>
        public FormConferention(string _roomJid, string password = null) {
            InitializeComponent();
            setInfoOfTheRoom();
            roomJid = new Jid(_roomJid);
            //   roomJid.Resource = roomName;
            mainJid = Settings.Jid;
            this.Text = roomName;
            nickname = Settings.NickName;
            xmpp = Settings.xmpp;
            muc = new MucManager(xmpp);
            muc.JoinRoom(roomJid, "as"/*NickName*/, password);
            xmpp.MesagageGrabber.Add(roomJid, new BareJidComparer(), new MessageCB(MessageCallback), null);
            xmpp.PresenceGrabber.Add(roomJid, new BareJidComparer(), new PresenceCB(PresenceCallback), null);
        }

        /// <summary>
        /// Вызывается при создании новой комнаты
        /// </summary>
        /// <param name="_roomJid"></param>
        /// <param name="_roomName">Название комнаты</param>
        /// <param name="_savingHistory">Сохранять историю на сервере</param>
        /// <param name="_persistRoom">Постоянная комната</param>
        /// <param name="users">Приглашенные юзеры</param>
        /// <param name="_roomDesc">Описание комнаты</param>
        /// <param name="password"></param>
        public FormConferention(string _roomJid, string _roomName, bool _savingHistory, bool _persistRoom, List<string> users = null, string _roomDesc = "", string password = null) {
            InitializeComponent();
            roomJid = new Jid(_roomJid);
            // roomJid.Resource = _roomName;
            mainJid = Settings.Jid;
            roomName = _roomName;
            roomDesc = _roomDesc;
            this.Text = _roomName;
            nickname = Settings.NickName;
            xmpp = Settings.xmpp;
            muc = new MucManager(xmpp);
            savingHistory = _savingHistory ? "1" : "0";
            persistRoom = _persistRoom ? "1" : "0";
            muc.CreateReservedRoom(roomJid);
            muc.GrantOwnershipPrivileges(roomJid, new Jid(mainJid));
            muc.JoinRoom(roomJid, nickname, password);
            initMucConfig();
            xmpp.MesagageGrabber.Add(roomJid, new BareJidComparer(), new MessageCB(MessageCallback), null);
            xmpp.PresenceGrabber.Add(roomJid, new BareJidComparer(), new PresenceCB(PresenceCallback), null);
            muc.Invite(users.ConvertAll<Jid>(deleg).ToArray(), roomJid, "Вы приглашены в конференцию " + roomName);
        }

        private Jid deleg(string jid) {
            return new Jid(jid);
        }

        private void initMucConfig() {
            muc.RequestConfigurationForm(roomJid, new IqCB(ReceiveFormConfiguration));
        }

        /// <summary>
        /// Отправляет запрос на получение иформации от комнаты и определяет обработчик её прихода.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="iq"></param>
        /// <param name="obj"></param>
        private void ReceiveFormConfiguration(object sender, IQ iq, object obj) {
            agsXMPP.protocol.x.muc.iq.owner.OwnerIq oIq = new agsXMPP.protocol.x.muc.iq.owner.OwnerIq();
            oIq.Type = IqType.get;
            oIq.To = roomJid;
            Settings.xmpp.IqGrabber.SendIq(oIq, new IqCB(OnRequestConfiguration), null);
        }

        private void addFieldInDataIQ(agsXMPP.protocol.x.data.Data data, string fieldname, string value) {
            Field field = new Field();
            field.Var = fieldname;
            agsXMPP.Xml.Dom.Element e = new agsXMPP.Xml.Dom.Element("value", value);
            field.AddChild(e);
            data.AddChild(field);
        }

        /// <summary>
        /// Отправляет конфигурацию комнаты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="iq"></param>
        /// <param name="obj"></param>
        private void OnRequestConfiguration(object sender, IQ iq, object obj) {
            agsXMPP.protocol.x.muc.iq.owner.OwnerIq oIq = new agsXMPP.protocol.x.muc.iq.owner.OwnerIq();
            oIq.Type = IqType.set;
            oIq.To = iq.From;
            agsXMPP.protocol.x.data.Data data = new agsXMPP.protocol.x.data.Data(XDataFormType.submit);

            addFieldInDataIQ(data, "FORM_TYPE", "http://jabber.org/protocol/muc#roomconfig");
            addFieldInDataIQ(data, "muc#roomconfig_roomname", roomName);
            addFieldInDataIQ(data, "muc#roomconfig_roomdesc", roomDesc);
            addFieldInDataIQ(data, "muc#roomconfig_persistentroom", persistRoom);
            addFieldInDataIQ(data, "muc#roomconfig_publicroom", "1");
            addFieldInDataIQ(data, "public_list", "1");
            addFieldInDataIQ(data, "muc#roomconfig_passwordprotectedroom", "0");//(password == "") ? "0" : "1");//сложно сказать
            addFieldInDataIQ(data, "muc#roomconfig_roomsecret", "");
            addFieldInDataIQ(data, "muc#roomconfig_maxusers", "1000");
            addFieldInDataIQ(data, "muc#roomconfig_whois", "moderators");
            addFieldInDataIQ(data, "muc#roomconfig_membersonly", "0");
            addFieldInDataIQ(data, "muc#roomconfig_moderatedroom", "1");
            addFieldInDataIQ(data, "members_by_default", "0");
            addFieldInDataIQ(data, "muc#roomconfig_membersonly", "0");
            addFieldInDataIQ(data, "muc#roomconfig_membersonly", "0");
            addFieldInDataIQ(data, "muc#roomconfig_changesubject", "1");
            addFieldInDataIQ(data, "allow_private_messages", "1");
            addFieldInDataIQ(data, "allow_private_messages_from_visitors", "anyone");
            addFieldInDataIQ(data, "allow_query_users", "1");
            addFieldInDataIQ(data, "muc#roomconfig_allowinvites", "0");
            addFieldInDataIQ(data, "muc#roomconfig_allowvisitorstatus", "1");
            addFieldInDataIQ(data, "muc#roomconfig_allowvisitornickchange", "0");
            addFieldInDataIQ(data, "muc#roomconfig_allowvoicerequests", "1");
            addFieldInDataIQ(data, "muc#roomconfig_voicerequestmininterval", "1800");
            addFieldInDataIQ(data, "muc#roomconfig_captcha_whitelist", "");
            addFieldInDataIQ(data, "muc#roomconfig_enablelogging", savingHistory);

            oIq.Query.AddChild(data);
            Settings.xmpp.IqGrabber.SendIq(oIq, new IqCB(OnGetFieldsResult), null);
        }

        public void OnGetFieldsResult(object sender, IQ iq, object data) {
            //
        }

        private void textBoxMessage_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && checkIfEnter.Checked) {
                SendConfMessage(textBoxSend.Text);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e) {
            SendConfMessage(textBoxSend.Text);
        }

        private void SendConfMessage(string message) {
            if (message.Length > 0) {
                agsXMPP.protocol.client.Message msg = new agsXMPP.protocol.client.Message();
                msg.Type = MessageType.groupchat;
                msg.To = roomJid;
                msg.Body = message;
                xmpp.Send(msg);
                textBoxSend.Clear();
            }
        }

        private void FormConferention_FormClosed(object sender, FormClosedEventArgs e) {
            muc.LeaveRoom(roomJid, nickname);
        }

        /// <summary>
        /// Ловит сообщения от заданного Jid(в этом случае используется Jid комнаты)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="msg"></param>
        /// <param name="data"></param>
        private void MessageCallback(object sender, agsXMPP.protocol.client.Message msg, object data) {
            if (InvokeRequired) {
                BeginInvoke(new MethodInvoker(delegate {
                    if (msg.Type == MessageType.groupchat)
                        IncomingMessage(msg);
                }));
            }
        }

        /// <summary>
        /// Ловит присутствия от заданного Jid(в этос случае от Jid комнаты)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="pres"></param>
        /// <param name="data"></param>
        private void PresenceCallback(object sender, agsXMPP.protocol.client.Presence pres, object data) {
            if (InvokeRequired) {
                BeginInvoke(new MethodInvoker(delegate {
                    string user = findListBoxItem(pres.From.Resource);
                    if (user != null)//если есть в списке присутствия 
                    {
                        if (pres.Type == PresenceType.unavailable) {
                            listBoxConfUsers.Items.Remove(user);
                        } else {
                            //хз что делает

                            //int imageIdx = Util.GetRosterImageIndex(pres);
                            //lvi.ImageIndex = imageIdx;
                            //lvi.SubItems[1].Text = ( pres.Status == null ? "" : pres.Status );
                            //User u = pres.SelectSingleElement(typeof(User)) as User;
                            //if ( u != null ) {
                            //    lvi.SubItems[2].Text = u.Item.Affiliation.ToString();
                            //    lvi.SubItems[3].Text = u.Item.Role.ToString();
                            //}
                        }
                    } else {
                        if (pres.Type != PresenceType.unavailable) {
                            listBoxConfUsers.Items.Add(pres.From.Resource);
                        }
                    }
                }));
            }
        }

        private string findListBoxItem(string jid) {
            foreach (string i in listBoxConfUsers.Items) {
                if (jid.ToLower() == i.ToLower())
                    return i;
            }
            return null;
        }

        private void IncomingMessage(agsXMPP.protocol.client.Message msg) {
            if (msg.Type == MessageType.error) {
                //не обрабатывается
                return;
            }
            //если в сообщении есть сведения о смене темы
            if (msg.Subject != null) {
                txtSubject.Text = msg.Subject;
                rtfChat.SelectionColor = Color.DarkGreen;
                rtfChat.AppendText(msg.From.Resource + " изменил тему: ");
                rtfChat.SelectionColor = Color.Black;
                rtfChat.AppendText(msg.Subject);
                rtfChat.AppendText("\r\n");
            } else {
                if (msg.Body == null)
                    return;
                rtfChat.SelectionColor = Color.Blue;//(msg.Nickname.InnerXml == NickName) ? Color.Green : Color.Red;
                // The Nickname of the sender is in GroupChat in the Resource of the Jid
                rtfChat.AppendText(msg.From.Resource + " : ");
                rtfChat.SelectionColor = Color.Black;
                rtfChat.AppendText(msg.Body);
                rtfChat.AppendText("\r\n");
            }
        }

        /// <summary>
        /// Изменение темы в комнате.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdChangeSubject_Click(object sender, EventArgs e) {
            agsXMPP.protocol.client.Message msg = new agsXMPP.protocol.client.Message();
            msg.Type = MessageType.groupchat;
            msg.To = roomJid;
            msg.Subject = txtSubject.Text;
            xmpp.Send(msg);
        }

        private void buttonDescr_Click(object sender, EventArgs e) {

        }

        //получает и задает значения названия комнаты и её описания
        private void setInfoOfTheRoom() {
            requestOnGetInfoTheRoom(delegate(object sender, IQ iq, object data) {
                roomDesc = iq.Query.LastNode.ChildNodes.Item(2).ChildNodes.Item(1).Value;
                roomName = iq.Query.FirstChild.Attribute("name");
            });
        }

        //делает запрос на получение информпции 
        private void requestOnGetInfoTheRoom(agsXMPP.IqCB handl) {
            if (InvokeRequired) {
                BeginInvoke(new MethodInvoker(delegate {
                    IQ iq = new IQ(IqType.get, new Jid(mainJid), roomJid);
                    agsXMPP.protocol.iq.disco.DiscoInfo info = new agsXMPP.protocol.iq.disco.DiscoInfo();
                    iq.Query = info;
                    iq.Id = "id_" + mainJid + "_" + roomJid.Bare + "_" + (Settings.requestId++);
                    xmpp.IqGrabber.SendIq(iq, handl, null);
                }));
            }
        }

        private void buttonHistory_Click(object sender, EventArgs e) {
            (new FormHistoryView(roomJid.Bare, "")).Show();
        }
    }
}
