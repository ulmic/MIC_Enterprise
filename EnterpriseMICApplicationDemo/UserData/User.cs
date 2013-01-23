using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Application User class
	/// </summary>
	public class User {
		/// <summary>
		/// User Attributes
		/// </summary>
		public int Id;
		public string Login;
		public string Password;

		/// <summary>
		/// User Functions
		/// </summary>
		public bool[] Functions;

		/// <summary>
		/// User Level
		/// </summary>
		protected Distribution.Level userLevel;

		#region Constructors

		public User() { }

		public User(string param) {
			if (param.Contains('@')) {
				getUserByIndex(getIndexByParam(param, Const.EMAIL));
			}
		}

		#endregion

		private void getUserByIndex(int index) {
			Id = index;
			Login = 
			Password = AnyCatches.TryReadAllLines("password.txt", System.Text.Encoding.Default)[index];
			if ((AnyCatches.IfThereIsNot(Login)) || (AnyCatches.IfThereIsNot(Password))) {
				return;
			}
			
		}

		private int getIndexByParam(string param, int paramType) {
			string[] parametrs = null;
			if (paramType == Const.EMAIL) {
				parametrs = AnyCatches.TryReadAllLines(@"email.txt", System.Text.Encoding.Default);
			}
			if (AnyCatches.IfThereIsNot(parametrs)) {
				return Const.THEREISNOT;
			}
			for (int i = 0; i < parametrs.Length; i++) {
				if (parametrs[i] == param) {
					return i;
				}
			}
			return Const.THEREISNOT;
		}
	}
}