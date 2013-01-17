using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Create New Send List Form
	/// </summary>
	public partial class CreateNewSendListForm : EnterpriseMICApplicationMiniForm {
		public CreateNewSendListForm() {
			InitializeComponent();
			textBox1.DisText = "Название нового списка";
		}

		private void button1_Click(object sender, EventArgs e) {

		}
	}
}