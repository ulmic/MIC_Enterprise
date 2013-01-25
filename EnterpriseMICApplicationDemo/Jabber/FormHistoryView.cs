using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using ModelText.ModelEditControl;

namespace EnterpriseMICApplicationDemo {
    public partial class FormHistoryView : Form {
        public FormHistoryView(string history) {
            InitializeComponent();
            comboBoxDay.Items.Add("За");
            comboBoxMonth.Items.Add("всё");
            comboBoxYear.Items.Add("время");
            controlView.SuspendLayout();
            controlView.editControl.Text = history;
            controlView.ResumeLayout();
        }

        public FormHistoryView(string roomname, string emptyStr) {
            InitializeComponent();
            comboBoxDay.Items.Add("За");
            comboBoxMonth.Items.Add("всё");
            comboBoxYear.Items.Add("время");
            controlView.SuspendLayout();
            controlView.ResumeLayout();
        }
		
		private string addressFromHtml(string day, string month, string year, string roomname){
			return (Settings.pathForMucHistory + roomname + "/" + year + "/" + month + "/" + day + ".html");
		}
		
		private void loadSimpleForm(string roomname)
        {
			WebClient myWebClient = new WebClient();
			string day = comboBoxDay.SelectedItem.ToString();
			string month = comboBoxMonth.SelectedItem.ToString();
			string year = comboBoxYear.SelectedItem.ToString();
            using (Stream stream = myWebClient.OpenRead(addressFromHtml(day, month, year, roomname)))
            {
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    load(streamReader);
                }
            }
        }

        private void load(StreamReader textReader)
        {
            controlView.editControl.openDocument(textReader);
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
