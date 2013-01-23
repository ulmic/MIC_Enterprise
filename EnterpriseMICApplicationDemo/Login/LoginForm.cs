using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using serializ2;

namespace EnterpriseMICApplicationDemo {

	public partial class LoginForm : Form {

		private string notLoginSymbols = "!@#$%^&*()_+-=\";:?~`\\'|/.,{}[]";

		public bool ReLogin = false;

		public LoginForm() {
			InitializeComponent();
			this.loginTextBox.Click += new EventHandler(loginTextBox_Click);
			this.passwordTextBox.TextChanged += new EventHandler(passwordTextBox_Click);
			this.passwordTextBox.Click += new EventHandler(passwordTextBox_Click);
			this.rememberCheckBox.MouseEnter += new EventHandler(rememberCheckBox_MouseEnter);
			this.forgotPasswordLinkLabel.MouseEnter += new EventHandler(forgotPasswordLinkLabel_MouseEnter);
			this.forgotPasswordLinkLabel.Click += new EventHandler(forgotPasswordLinkLabel_Click);
			this.loginTextBox.TextChanged += new EventHandler(loginTextBox_TextChanged);
			this.passwordTextBox.TextChanged += new EventHandler(loginTextBox_TextChanged);
			enterButton.Enabled = false;
			MessageLabel.formSize = MessageLabel.FormSize.Small;
			MessageLabel.PutMessage("Введите свой логин и пароль");

			InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[1];

		}

		private void loginTextBox_TextChanged(object sender, EventArgs e) {
			enterButton.Enabled = (loginTextBox.Text.Length > 0) && (passwordTextBox.Text.Length > 0);
		}

		private void forgotPasswordLinkLabel_Click(object sender, EventArgs e) {
			Program.Forgot = new ForgotPasswordForm();
			Program.Forgot.Show();
			this.Visible = false;
		}

		private void forgotPasswordLinkLabel_MouseEnter(object sender, EventArgs e) {
			MessageLabel.PutMessage("Забыли пароль? Нажмите для подсказки.", Const.GOOD_MESSAGE);
		}

		private void rememberCheckBox_MouseEnter(object sender, EventArgs e) {
			MessageLabel.PutMessage("Отметьте, если не хотите в следующий раз вводить логин и пароль.", Const.GOOD_MESSAGE);
		}

		private void passwordTextBox_Click(object sender, EventArgs e) {
			MessageLabel.PutMessage("Вводите пароль", Const.GOOD_MESSAGE);
		}

		private void loginTextBox_Click(object sender, EventArgs e) {
			MessageLabel.PutMessage("Вводите логин", Const.GOOD_MESSAGE);
		}

		private void enterButton_Click(object sender, EventArgs e) {
			if (loginTextBox.Text.Length < Const.LOGIN_LENGHT) {
				MessageLabel.PutMessage("Логин не может быть меньше " + Const.LOGIN_LENGHT.ToString() + " символов!", Const.BAD_MESSAGE);
				return;
			}
			if (passwordTextBox.Text.Length < Const.PASSWORD_LENGHT) {
				MessageLabel.PutMessage("Пароль не может быть меньше " + Const.PASSWORD_LENGHT.ToString() + " символов!", Const.BAD_MESSAGE);
				return;
			}
			if ((loginTextBox.Text.ToCharArray().Any(t => notLoginSymbols.Contains(t))) || ((passwordTextBox.Text.ToCharArray().Any(t => notLoginSymbols.Contains(t))))) {
				MessageLabel.PutMessage("Логин или пароль не могут содержать управляющие символы и разделители. !@#$%^&*()_+-=\";:?~`\\'|/.,{}[]", Const.BAD_MESSAGE);
				return;
			}
			Login login = new Login(); // bad code
			bool authSuccess = login.Auth(loginTextBox.Text, passwordTextBox.Text, rememberCheckBox.Checked);
			if (authSuccess != false) {
				if (ReLogin) {
					Program.MainWindow.Clear();
				}
				Program.MainWindow.Initialization(Program.Data.MainUser.Id);
				this.Visible = false;
			}
			MessageLabel.PutMessage("Неверный логин или пароль!", Const.BAD_MESSAGE);
		}
	}
}