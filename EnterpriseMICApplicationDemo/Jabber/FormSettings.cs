using System;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
    public partial class FormSettings : Form {
        public FormSettings() {
            InitializeComponent();
        }

        private void applySettings() {
            Settings.serverIp = textBoxIP.Text;
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            applySettings();
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e) {
            applySettings();
        }

    }
}
