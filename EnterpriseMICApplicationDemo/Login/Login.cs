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
			int loginIndex;
			try {
				loginIndex = Int32.Parse(File.ReadAllText(@Const.adressRememberUserFile, System.Text.Encoding.Default));
			} catch {
				writeToRememberFile(Const.THEREISNOT);
				return Const.THEREISNOT;
			}
			return loginIndex;
		}

		public int GetLoginIndex(string login, string password, bool remember) {
			int userIndex = Login_DB.GetUserIndexByLoginPassword(login, password);
			if (remember) {
				writeToRememberFile(userIndex);
			}
			return userIndex;
		}

		private int checkLogin(string login) {
			return 1;
			string[] logins = AnyCatches.TryReadAllLines(@"login.txt", System.Text.Encoding.Default);
			if (AnyCatches.IfThereIsNot(logins)) {
				return Const.THEREISNOT;
			}
			for (int i = 0; i < logins.Length; i++) {
				if (login == logins[i]) {
					return i;
				}
			}
			return Const.THEREISNOT;
		}

		private bool checkPassword(string password, int index) {
			string passes = AnyCatches.TryReadAllLines(@"password.txt", System.Text.Encoding.Default)[index];
			if (AnyCatches.IfThereIsNot(passes)) {
				return false;
			}
			return password == passes;
		}

		private void writeToRememberFile(int userIndex) {
			StreamWriter fileWrite = File.CreateText(@Const.adressRememberUserFile);
			fileWrite.Write(userIndex);
		}
	}
}