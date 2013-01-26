using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Forgot Password Form. Send to user email his password
	/// </summary>
	public partial class ForgotPasswordForm : Form {
		public ForgotPasswordForm() {
			InitializeComponent();
			sendButton.Enabled = false;
		}

		private void rememberCheckBox_CheckedChanged(object sender, EventArgs e) {
			sendButton.Enabled = iWillNeverCheckBox.Checked;
		}

		private void sendButton_Click(object sender, EventArgs e) {
			ForgotPassword f = new ForgotPassword();
			f.SendReminder(mailTextBox.Text);
			Program.LoginForm.Visible = true;
			Program.LoginForm.MessageLabel.PutMessage("Письмо с Вашим логином и паролем уже отправлено на ваш адрес электронной почты.", Const.GOOD_MESSAGE);
			this.Close();
		}
	}
}