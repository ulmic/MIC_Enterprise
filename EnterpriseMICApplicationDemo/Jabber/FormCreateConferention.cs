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

namespace EnterpriseMICApplicationDemo{
    public partial class FormCreateConferention : Form
    {
        Dictionary<string, string> users;

        public FormCreateConferention(Dictionary<string, string> _users)
        {
            InitializeComponent();
            users = _users;
            for (int i = 0; i < users.Count; i++)
            {
                CheckBox c = new CheckBox();
                ListViewItem item = new ListViewItem(users.Values.ElementAt(i), 0);
                item.Checked = true;//"true" for debug
                listViewUsers.Items.Add(item);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            List<string> selectedUsers = new List<string>();
            for (int i = 0; i < listViewUsers.Items.Count; i++ )
            {
                if (listViewUsers.Items[i].Checked)
                {
                    selectedUsers.Add(users.Keys.ElementAt(i));
                }
            }
            ( new FormConferention(textBoxConfIdent.Text.Trim() + "@conference." + Settings.server, textBoxConfName.Text,
                                    checkBoxHistory.Checked, checkBoxPersistentRoom.Checked, selectedUsers, textBoxDescription.Text ) ).Show();
			this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        
		
    }
}
