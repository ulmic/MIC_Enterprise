using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Login Functions
	/// </summary>
	public class Login {

		public Login() { }

		public int CheckEnter() {
			return 1;
			//int loginIndex;
			//try {
			//  loginIndex = Int32.Parse(File.ReadAllText(@Const.adressRememberUserFile, System.Text.Encoding.Default));
			//} catch {
			//  return Const.THEREISNOT;
			//}
			//return loginIndex;
		}

		public int getLoginIndex(string login, string password, bool remember) {
			return 1;
			//int loginIndex = checkLogin(login);
			//if (loginIndex != Const.THEREISNOT) {
			//  if (checkPassword(password, loginIndex)) {
			//    if (remember) {
			//      File.WriteAllText(@Const.adressRememberUserFile, loginIndex.ToString(), System.Text.Encoding.Default);
			//    }
			//    return loginIndex;
			//  }
			//}
			//return Const.THEREISNOT;
		}

		private int checkLogin(string login) {
			return 1;
			//string[] logins = AnyCatches.TryReadAllLines(@"login.txt", System.Text.Encoding.Default);
			//if (AnyCatches.IfThereIsNot(logins)) {
			//  return Const.THEREISNOT;
			//}
			//for (int i = 0; i < logins.Length; i++) {
			//  if (login == logins[i]) {
			//    return i;
			//  }
			//}
			//return Const.THEREISNOT;
		}

		private bool checkPassword(string password, int index) {
			string passes = AnyCatches.TryReadAllLines(@"password.txt", System.Text.Encoding.Default)[index];
			if (AnyCatches.IfThereIsNot(passes)) {
				return false;
			}
			return password == passes;
		}
	}
}