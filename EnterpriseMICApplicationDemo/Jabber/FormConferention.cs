using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using agsXMPP;
using agsXMPP.Collections;
using agsXMPP.protocol;
using agsXMPP.protocol.client;
using agsXMPP.protocol.x.muc;

namespace EnterpriseMICApplicationDemo {
    public partial class FormConferention : Form {
        private Jid roomJid;
        private string mainJid;
        private string nickname;
        private string roomName;
        private XmppClientConnection xmpp;
        private MucManager muc;

        public FormConferention(string _roomJid) {
            InitializeComponent();
            roomJid = new Jid(_roomJid);
            xmpp = Settings.xmpp;
            mainJid = Settings.jid;
            nickname = Settings.nickname;
            muc = new MucManager(xmpp);
            xmpp.MesagageGrabber.Add(roomJid, new BareJidComparer(), new MessageCB(MessageCallback), null);
            xmpp.PresenceGrabber.Add(roomJid, new BareJidComparer(), new PresenceCB(PresenceCallback), null);
        }

        public FormConferention(string _roomJid, List<string> users) {
            InitializeComponent();
            roomJid = new Jid(_roomJid);
            xmpp = Settings.xmpp;
            mainJid = Settings.jid;
            nickname = Settings.nickname;
            muc = new MucManager(xmpp);
            xmpp.MesagageGrabber.Add(roomJid, new BareJidComparer(), new MessageCB(MessageCallback), null);
            xmpp.PresenceGrabber.Add(roomJid, new BareJidComparer(), new PresenceCB(PresenceCallback), null);
            muc.Invite(users.ConvertAll<Jid>(
                delegate(string jid) {
                    return new Jid(jid);
                }
            ).ToArray(), roomJid, "Вы приглашены в конференцию Конф.");
        }

        private void textBoxMessage_KeyDown(object sender, KeyEventArgs e) {
            if ( e.KeyCode == Keys.Enter && checkIfEnter.Checked ) {
                SendConfMessage(textBoxSend.Text);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e) {
            SendConfMessage(textBoxSend.Text);
        }

        private void SendConfMessage(string message) {
            if ( message.Length > 0 ) {
                agsXMPP.protocol.client.Message msg = new agsXMPP.protocol.client.Message();
                msg.Type = MessageType.groupchat;
                msg.To = roomJid;
                msg.Body = message;
                xmpp.Send(msg);
                textBoxSend.Clear();
            }
        }

        private void FormConferention_Load(object sender, EventArgs e) {
        }

        private void FormConferention_FormClosed(object sender, FormClosedEventArgs e) {
            muc.LeaveRoom(roomJid, nickname);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="msg"></param>
        /// <param name="data"></param>
        private void MessageCallback(object sender, agsXMPP.protocol.client.Message msg, object data) {
            if ( InvokeRequired ) {
                // Windows Forms are not Thread Safe, we need to invoke this :(
                // We're not in the UI thread, so we need to call BeginInvoke				
                BeginInvoke(new MessageCB(MessageCallback), new object[] { sender, msg, data });
                return;
            }
            if ( msg.Type == MessageType.groupchat )
                IncomingMessage(msg);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="pres"></param>
        /// <param name="data"></param>
        private void PresenceCallback(object sender, agsXMPP.protocol.client.Presence pres, object data) {
            if ( InvokeRequired ) {
                // Windows Forms are not Thread Safe, we need to invoke this :(
                // We're not in the UI thread, so we need to call BeginInvoke				
                BeginInvoke(new PresenceCB(PresenceCallback), new object[] { sender, pres, data });
                return;
            }
            string user = findListBoxItem(pres.From.Resource);
            if ( user != null ) {
                if ( pres.Type == PresenceType.unavailable ) {
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
                listBoxConfUsers.Items.Add(pres.From.Resource);
            }
        }

        private string findListBoxItem(string jid) {
            foreach ( string i in listBoxConfUsers.Items ) {
                if ( jid.ToLower() == i.ToLower() )
                    return i;
            }
            return null;
        }

        private void IncomingMessage(agsXMPP.protocol.client.Message msg) {
            if ( msg.Type == MessageType.error ) {
                //Handle errors here
                // we dont handle them in this example
                return;
            }
            if ( msg.Subject != null ) {
                //txtSubject.Text = msg.Subject;

                rtfChat.SelectionColor = Color.DarkGreen;
                // The Nickname of the sender is in GroupChat in the Resource of the Jid
                rtfChat.AppendText(msg.From.Resource + " changed subject: ");
                rtfChat.SelectionColor = Color.Black;
                rtfChat.AppendText(msg.Subject);
                rtfChat.AppendText("\r\n");
            } else {
                if ( msg.Body == null )
                    return;

                rtfChat.SelectionColor = Color.Blue;//(msg.Nickname.InnerXml == nickname) ? Color.Green : Color.Red;
                // The Nickname of the sender is in GroupChat in the Resource of the Jid
                rtfChat.AppendText(msg.From.Resource + " : ");
                rtfChat.SelectionColor = Color.Black;
                rtfChat.AppendText(msg.Body);
                rtfChat.AppendText("\r\n");
            }
        }

        private void cmdSend_Click(object sender, EventArgs e) {
            // Make sure that the users send no empty messages
            if ( textBoxSend.Text.Length > 0 ) {
                agsXMPP.protocol.client.Message msg = new agsXMPP.protocol.client.Message();

                msg.Type = MessageType.groupchat;
                msg.To = roomJid;
                msg.Body = textBoxSend.Text;

                xmpp.Send(msg);

                textBoxSend.Text = "";
            }
        }

        /// <summary>
        /// Changing the subject in a chatroom
        /// in MUC rooms this could return an error when you are a normal user and not allowed
        /// to change the subject.
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

    }
}
