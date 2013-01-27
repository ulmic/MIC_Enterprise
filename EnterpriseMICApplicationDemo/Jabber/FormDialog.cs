using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using agsXMPP;
using agsXMPP.protocol.client;

namespace EnterpriseMICApplicationDemo {
    public partial class FormDialog : Form {
        public TabControl conversation;
        public FormDialog() {
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e) {
            e.Cancel = true;
            Hide();
        }

        public void createTabPage(object sender, string tabName, string key, string insideText) {
            tabControlDialogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkSendIfEnter
            // 
            CheckBox checkSendIfEnter = new CheckBox();
            checkSendIfEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            checkSendIfEnter.AutoSize = true;
            checkSendIfEnter.Checked = true;
            checkSendIfEnter.CheckState = System.Windows.Forms.CheckState.Checked;
            checkSendIfEnter.Location = new System.Drawing.Point(3, 297);
            checkSendIfEnter.Name = "checkSendIfEnter";
            checkSendIfEnter.Size = new System.Drawing.Size(288, 17);
            checkSendIfEnter.TabIndex = 4;
            checkSendIfEnter.Text = "Отправлять сообщение при нажатии клавиши Enter";
            checkSendIfEnter.UseVisualStyleBackColor = true;
            // 
            // textBoxSend
            // 
            TextBox textBoxSend = new TextBox();
            textBoxSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            textBoxSend.Location = new System.Drawing.Point(0, 322);
            textBoxSend.Multiline = true;
            textBoxSend.Name = "textBoxSend";
            textBoxSend.Size = new System.Drawing.Size(367, 49);
            textBoxSend.TabIndex = 2;
            // 
            // rtfDialog
            // 
            RichTextBox rtfDialog = new RichTextBox();
            rtfDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
             | System.Windows.Forms.AnchorStyles.Left)
             | System.Windows.Forms.AnchorStyles.Right)));
            rtfDialog.Location = new System.Drawing.Point(0, 0);
            rtfDialog.Name = "rtfDialog";
            rtfDialog.Size = new System.Drawing.Size(462, 291);
            rtfDialog.TabIndex = 1;
            rtfDialog.Text = "";
            rtfDialog.ReadOnly = true;
            rtfDialog.BackColor = Color.White;
            // 
            // buttonHistory
            // 
            Button buttonHistory = new Button();
            buttonHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            buttonHistory.Location = new System.Drawing.Point(370, 295);
            buttonHistory.Name = "buttonSend";
            buttonHistory.Size = new System.Drawing.Size(80, 24);
            buttonHistory.TabIndex = 7;
            buttonHistory.Text = "История";
            buttonHistory.UseVisualStyleBackColor = true;
            buttonHistory.Click += delegate(object s, EventArgs a) {
                (new FormHistoryView((((FormJabberStart)sender).getHistoryFromDB(key, 8072)))).Show();
            };
            // 
            // buttonSend
            // 
            Button buttonSend = new Button();
            buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            buttonSend.Location = new System.Drawing.Point(373, 322);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new System.Drawing.Size(89, 49);
            buttonSend.TabIndex = 3;
            buttonSend.Text = "Отправить";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += delegate(object s, EventArgs a) {
                ((FormJabberStart)sender).SendTextMessage(new Jid(key), rtfDialog, textBoxSend.Text);
                textBoxSend.Clear();
            };
            textBoxSend.KeyDown += delegate(object o, KeyEventArgs k) {
                if (k.Shift && k.KeyCode == Keys.Enter) {
                    return;
                }
                if (k.KeyCode == Keys.Enter && checkSendIfEnter.Checked) {
                    ((FormJabberStart)sender).SendTextMessage(new Jid(key), rtfDialog, textBoxSend.Text);
                    textBoxSend.Clear();
                    k.SuppressKeyPress = true;
                }
            };

            TabPage tabPage = new TabPage();
            tabPage.SuspendLayout();
            tabPage.Controls.Add(buttonSend);
            tabPage.Controls.Add(buttonHistory);
            tabPage.Controls.Add(checkSendIfEnter);
            tabPage.Controls.Add(textBoxSend);
            tabPage.Controls.Add(rtfDialog);
            tabPage.Location = new System.Drawing.Point(4, 22);
            tabPage.Name = key;
            tabPage.Padding = new System.Windows.Forms.Padding(3);
            tabPage.Size = new System.Drawing.Size(482, 355);
            tabPage.Text = tabName;
            tabPage.UseVisualStyleBackColor = true;
            tabPage.ContextMenuStrip = contextMenuStrip1;
            tabPage.MouseClick += delegate(object s, MouseEventArgs e) {
                if (e.Button == System.Windows.Forms.MouseButtons.Right) {

                }
            };

            tabControlDialogs.TabPages.Add(tabPage);

            tabPage.ResumeLayout(false);
            tabPage.PerformLayout();
            tabControlDialogs.ResumeLayout();
            this.ResumeLayout();
        }

    }
}
