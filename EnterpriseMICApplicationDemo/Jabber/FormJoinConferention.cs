using System;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
    public partial class FormJoinConferention : Form {

        public FormJoinConferention() {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e) {
            (new FormConferention(textBoxConfName.Text.Trim() + "@conference." + Settings.Server)).Show();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
