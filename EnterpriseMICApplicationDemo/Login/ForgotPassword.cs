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
		static public void SendReminder(string email) {
			string[] emails = AnyCatches.TryReadAllLines(@"email.txt", System.Text.Encoding.Default);
			if (AnyCatches.IfThereIsNot(emails)) {
				return;
			}
			if (emails.Any(e => e == email)) {
				User sendUser = new User(emails.Single(e => e == email));
				SendMail s = new SendMail();
				s.Send(emails.Single(e => e == email), imposeMailText(sendUser.Login, sendUser.Password));
			}
		}
	}
}