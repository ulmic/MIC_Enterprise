using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Organize the action, if user forget the password
	/// </summary>
	public class ForgotPassword {

		public ForgotPassword() { }
		/// <summary>
		/// Impose mail text to send to user
		/// </summary>
		/// <param name="login">user login</param>
		/// <param name="password">user password</param>
		/// <returns>Main text</returns>
		static private string imposeMailText(string login, string password) {
			return "Ваш логин: " + login + "<br/>Ваш пароль: " + password + "";
		}

		/// <summary>
		/// Send Reminder to user
		/// </summary>
		/// <param name="email">user email</param>
		public void SendReminder(string email) {
			Member sendUser = new Member();
			SendMail s = new SendMail();
			try {
				sendUser = Login_DB.GetUserById(Member_DB.GetMemberIdByEmail(email));
			} catch {
				s.Send(email, "Приносим свои извинения, но вы не зарегистрированы в нашей системе. Подробности admin@ulmic.ru.");
				return;
			}

			s.Send(email, imposeMailText(sendUser.Login, sendUser.Password));
		}
	}
}