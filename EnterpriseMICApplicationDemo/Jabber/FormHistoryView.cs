using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
    public partial class FormHistoryView : Form {
        public FormHistoryView(string history) {
            InitializeComponent();
            textBoxView.SuspendLayout();
            textBoxView.Text = history;
            textBoxView.ResumeLayout();
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
