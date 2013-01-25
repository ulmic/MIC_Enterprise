using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;


namespace EnterpriseMICApplicationDemo
{
    public partial class FormHistoryView : Form
    {
        private string roomjid;

        public FormHistoryView(string history)
        {
            InitializeComponent();
            comboBoxDay.Items.Add("За");
            comboBoxMonth.Items.Add("всё");
            comboBoxYear.Items.Add("время");
            comboBoxDay.Text = "За";
            comboBoxMonth.Text = "всё";
            comboBoxYear.Text = "время";
            controlView.SuspendLayout();
            history = history.Replace("\n", "<br/>");
            controlView.DocumentText = "<html><body><div>" + history + "</div></body></html>";
            controlView.ResumeLayout();
        }

        public FormHistoryView(string roomJid, string emptyStr)
        {
            InitializeComponent();
            comboBoxDay.Text = "26";
            comboBoxMonth.Text = "01";
            comboBoxYear.Text = "2013";
            addItems();
            roomjid = roomJid;
        }

        public void addItems()
        {
            for (int i = 1; i < 32; i++)
            {
                comboBoxDay.Items.Add(i);
            }
            for (int i = 1; i < 13; i++)
            {
                comboBoxMonth.Items.Add(i);
            }
            for (int i = 2012; i < 2015; i++)
            {
                comboBoxYear.Items.Add(i);
            }
        }

        private string addressFromHtml(string day, string month, string year, string roomname)
        {
            return (Settings.pathForMucHistory + roomname + "/" + year + "/" + month + "/" + day + ".html");
        }

        private void loadSimpleForm(string roomname)
        {
            WebClient myWebClient = new WebClient();
            string day = comboBoxDay.Text;
            string month = comboBoxMonth.Text;
            string year = comboBoxYear.Text;
            try
            {
                using (Stream stream = myWebClient.OpenRead(new Uri(addressFromHtml(day, month, year, roomname))))
                {
                    using (StreamReader streamReader = new StreamReader(stream))
                    {
                        string res = streamReader.ReadToEnd();
                        controlView.SuspendLayout();
                        controlView.DocumentText = res;
                        controlView.ResumeLayout();
                    }
                }
            }
            catch (Exception ex)
             {
                string mess = ex.Message;
                if (mess.IndexOf("(404)") != -1)
                {
                    controlView.DocumentText = "<html><body><h1>В данный день истории нет</h1></body></html>";
                }
            }

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSee_Click(object sender, EventArgs e)
        {
            loadSimpleForm(roomjid);
        }

    }
}
