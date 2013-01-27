﻿using System;
using System.Collections.Generic;
using System.IO;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Login Functions
	/// </summary>
	public class Login {

		public Login() { }

		public int CheckEnter() {
			int userId;
			try {
				userId = Int32.Parse(File.ReadAllText(@Const.adressRememberUserFile, System.Text.Encoding.Default));
				Program.Data.SetMainUser(userId);
			} catch {
				File.WriteAllText(@Const.adressRememberUserFile, Const.THEREISNOT.ToString());
				return Const.THEREISNOT;
			}
			return userId;
		}

		private int getUserId(string login, string password) {
			int userId = 0;
			Log.LogTryCatch(delegate() {
				userId = Login_DB.GetUserIndexByLoginPassword(login, password);
			});
			return userId;
		}

		public bool Auth(string login, string password, bool remember) {
			int userId = getUserId(login, password);
			if (userId != Const.THEREISNOT) {
				if (remember) {
					File.WriteAllText(@Const.adressRememberUserFile, userId.ToString());
				}
				Program.Data.SetMainUser(userId);
				return true;
			}
			return false;
		}
	}
}