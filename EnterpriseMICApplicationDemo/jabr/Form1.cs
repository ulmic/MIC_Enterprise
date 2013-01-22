using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace serializ2
{

    delegate void TemplateEvent();

    public partial class Form1 : Form
    {
        ClientSide client;
        Form2 formDialog;
        TabControl tabsDialog;
        Conferentions conferentions = new Conferentions();
        private int idConf = 0;


        public Form1()
        {
            InitializeComponent();
            //login.Text = "misha@192.168.0.2";
            //password.Text = "12232";
            login.Text = "khelek@jabberd.eu";
            password.Text = "abe2b33519";
            //login.Text = "khelek@jabber.ru";
            //password.Text = "haukot1994";
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        void Form1_Paint(object sender, PaintEventArgs e) {
          Graphics g = e.Graphics;
          DrawRectangle(g, 0, 0, this.Width, this.Height);
        }

        private void DrawRectangle(Graphics g, int x, int y, int widht, int height) {
          Rectangle rec = new Rectangle(x, y, widht, height);
          if ((widht != 0) && (height != 0)) {
            System.Drawing.Drawing2D.LinearGradientBrush gradient;
            gradient = new System.Drawing.Drawing2D.LinearGradientBrush(rec, Color.FromArgb(251, 188, 59), Color.White, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
         
            g.FillRectangle(gradient, rec);
            return;
          }
          Brush brush = new SolidBrush(Color.FromArgb(251, 188, 59));
          g.FillRectangle(brush, rec);
        }
        private void createTabPage(string tabName, string insideText = null, string key = "")
        {
            TabPage p = new TabPage(tabName);
            p.Name = key;
            TextBox dialog = new TextBox();
            dialog.Location = tabsDialog.Location;
            dialog.Size = new System.Drawing.Size(450, 170);
            dialog.Multiline = true;
            dialog.ScrollBars = ScrollBars.Vertical;
            dialog.ReadOnly = true;
            dialog.BackColor = Color.White;
            if (insideText != null)
            {
                dialog.AppendText(insideText);
            }

            TextBox textBoxSend = new TextBox();
            textBoxSend.Location = new Point(dialog.Location.X, dialog.Location.Y + dialog.Height);
            textBoxSend.Size = new System.Drawing.Size(240, 45);
            textBoxSend.Multiline = true;

            Button send = new Button();
            send.Click += delegate(object s, EventArgs a)
            {
                if (p.Name == "")
                    client.sendMessage(tabName, textBoxSend.Text);
                else
                {
                    int index = conferentions.Find(p.Name);
                    for (int i = 0; i < conferentions[index].length; i++)
                    {
                        string sendUser = conferentions[index].GetUser(i);
                        if (sendUser != login.Text)
                            client.sendMessage(conferentions[index].GetUser(i), textBoxSend.Text, p.Name);
                    }
                }
                dialog.AppendText("user (" + DateTime.Now.ToString() + ")"
                    + Environment.NewLine + textBoxSend.Text + Environment.NewLine + Environment.NewLine);
                textBoxSend.Clear();
            };
            send.Text = "send";
            send.Location = new Point(dialog.Location.X + dialog.Width - 80, dialog.Location.Y + dialog.Height + 10);

            CheckBox enter = new CheckBox();
            enter.Text = "Send if Enter";
            enter.Location = new Point(textBoxSend.Location.X + textBoxSend.Width + 10, dialog.Location.Y + dialog.Height + 5);
            enter.Checked = true;

            textBoxSend.KeyDown += delegate(object o, KeyEventArgs k)
            {
                if (k.KeyCode == Keys.Enter && enter.Checked)
                {
                    if (p.Name == "")
                        client.sendMessage(tabName, textBoxSend.Text);
                    else
                    {
                        int index = conferentions.Find(p.Name);
                        for (int i = 0; i < conferentions[index].length; i++)
                        {
                            string sendUser = conferentions[index].GetUser(i);
                            //if (sendUser != login.Text)
                                client.sendMessage(conferentions[index].GetUser(i), textBoxSend.Text, p.Name);
                        }
                    }
                    dialog.AppendText("user (" + DateTime.Now.ToString() + ")"
                        + Environment.NewLine + textBoxSend.Text + Environment.NewLine + Environment.NewLine);
                    textBoxSend.Clear();
                }
            };

            p.Controls.AddRange(new Control[] { dialog, textBoxSend, send, enter });
            tabsDialog.TabPages.Add(p);
        }

        private int findTagPage(string name)
        {
            for (int i = 0; i < tabsDialog.TabPages.Count; i++)
            {
                if (name == tabsDialog.TabPages[i].Text)
                {
                    return i;
                }
            }
            return -1;
        }

        private void HandlerOnMessege()
        {
            tabsDialog.Invoke(new MethodInvoker(delegate
            {
                if (client.thread == null)
                {
                    int indexTab = findTagPage(client.from);
                    if (indexTab != -1)
                    {
                        
                        ((TextBox)tabsDialog.TabPages[indexTab].Controls[0]).AppendText(tabsDialog.TabPages[indexTab].Text + " (" + DateTime.Now.ToString() + ")"
                            + Environment.NewLine + client.mess + Environment.NewLine + Environment.NewLine);

                    }
                    else
                    {
                        if (client.mess.Substring(0,6) == "<conf>") 
                        {
                            OneConferention conferention = new OneConferention();
                            string message = client.mess.Substring(6);

                            String[] arr = message.Split('-');
                            byte[] b = new byte[arr.Length];
                            for (int i = 0; i < arr.Length; i++) b[i] = Convert.ToByte(arr[i], 16);

                            using (var stream = new MemoryStream())
                            {
                                BinaryFormatter formatter = new BinaryFormatter();
                                stream.Write(b,0, b.Length);
                                stream.Seek(0,0);
                                object ob = formatter.Deserialize(stream);
                                if (ob is OneConferention)
                                    conferention = (OneConferention)ob;
                            }

                            if (conferention.id == null);// хуи тут, а не обработка

                            if (MessageBox.Show("Вас пригласили в конференцию " + conferention.name + ". Желаете принять участие?", "Приглашение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                initForm2();
                                string conferenceName = conferention.name;
                                string createrJid = conferention.users[0];
                                List<string> users = conferention.users;
                                conferentions.Add(conferention);
                                createTabPage(conferenceName, null, conferention.id);
                            }
                            else
                            {
                                
                            }
                        }
                        createTabPage(client.from, client.from + " (" + DateTime.Now.ToString() + ")"
                            + Environment.NewLine + client.mess + Environment.NewLine + Environment.NewLine);
                    }
                }
                else
                {
                    int indexTab = tabsDialog.TabPages.IndexOfKey(client.thread);
                    if (indexTab != -1)
                    {//t.TabPages[indexTab].Control[0] - textBox с диалогом
                        ((TextBox)tabsDialog.TabPages[indexTab].Controls[0]).AppendText(client.from + " (" + DateTime.Now.ToString() + ")"
                            + Environment.NewLine + client.mess + Environment.NewLine + Environment.NewLine);
                    }
                }
            }));
        }

        private void HandlerOnPresence()
        {
            listBox2.Invoke(new MethodInvoker(delegate
            {
                if (client.presence == "unavailable")
                {
                    listBox2.Items.Remove(client.talker);
                }
                else
                {
                    listBox2.Items.Add(client.talker);
                }
            }));
        }

        private void createConference_Click(object sender, EventArgs e)
        {
            initForm2();
            string conferenceName = "конференция ёпт" + idConf;
            string createrJid = login.Text;
            List<string> users = new List<string> { "haudvd@gmail.com", "khelek@jabber.ru", "olegzotov73@gmail.com" };
            OneConferention conf = new OneConferention(idConf.ToString(), conferenceName, createrJid, users);
            conferentions.Add(conf);
            client.sendInviteConferention(users, conf);
            createTabPage(conferenceName, createrJid + " (" + DateTime.Now.ToString() + ")"
                + Environment.NewLine + "Го! Я создал!" + Environment.NewLine + Environment.NewLine, idConf.ToString());
        }

        private void textBoxStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                client.setStatus(textBoxStatus.Text);
                textBoxStatus.Clear();
            }
        }

        private void initForm2()
        {
            if (formDialog == null)
            {
                formDialog = new Form2();
                tabsDialog = new TabControl();
                tabsDialog.Size = new System.Drawing.Size(500, 260);
                tabsDialog.Location = new Point(10, 10);
                formDialog.Controls.AddRange(new Control[] { tabsDialog });
                formDialog.Show();
            }
            if (!formDialog.Visible)
            {
                formDialog.Show();
            }
            else
            {
                formDialog.Focus();
            }
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                initForm2();
                string tabName = listBox2.SelectedItem.ToString();
                if (findTagPage(tabName) == -1)
                {
                    createTabPage(tabName);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            client.setStatus(textBoxStatus.Text);

        }

        private void login_MouseClick(object sender, MouseEventArgs e)
        {
            //login.Clear();
        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            //password.Clear();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string nickname = login.Text.Substring(0, login.Text.IndexOf("@"));
                string conserver = login.Text.Substring(login.Text.IndexOf("@") + 1);
                //khelek@jabberd.eu
                //abe2b33519
                login.Hide();
                password.Hide();
                Login_Button.Hide();
                Add_Users.Hide();

                client = new ClientSide(conserver, conserver, nickname, password.Text);
                client.Receive += new TemplateEvent(HandlerOnMessege);
                client.getPresence += new TemplateEvent(HandlerOnPresence);
                client.onLoginEvent += new TemplateEvent(delegate()
                    {
                        checkBox1.Invoke(new MethodInvoker(delegate()
                        {
                            checkBox1.Checked = !checkBox1.Checked;
                            Exit.Show();
                        }));
                    });
            }
            catch
            {
                MessageBox.Show("Неверный логин или пароль, попробуйте еще раз");
                login.Clear();
                password.Clear();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            client.CloseConnection();
            Exit.Hide();
            login.Show();
            password.Show();
            Login_Button.Show();
            Add_Users.Show();
            listBox2.Items.Clear();
        }

        private void Add_Users_Click(object sender, EventArgs e)
        {
            Form3 add_us = new Form3();
            add_us.Show();
        }


    }
}
