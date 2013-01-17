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
		public int Index;
		public string Login;
		public string Password;
		public string Email;
		public string EmailPassword;
		public string Name;
		public string Post;
		public string FullName;

		/// <summary>
		/// User Functions
		/// </summary>
		public bool[] Functions = new bool[Const.FUNCTIONS_COUNT];

		public string[] Params;

		/// <summary>
		/// User Level
		/// </summary>
		private Distribution.Level userLevel;

		#region Constructors

		public User() {
			Params = new string[] { Login, Password, Email, EmailPassword, Name, Post, FullName };
		}

		public User(string param) {
			if (param.Contains('@')) {
				getUserByIndex(getIndexByParam(param, Const.EMAIL));
			}
		}

		public User(int userIndex) {
			getUserByIndex(userIndex);
		}

		#endregion

		private void getUserByIndex(int index) {
			Index = index;
			Login = AnyCatches.TryReadAllLines("login.txt", System.Text.Encoding.Default)[index];
			Password = AnyCatches.TryReadAllLines("password.txt", System.Text.Encoding.Default)[index];
			Email = AnyCatches.TryReadAllLines("email.txt", System.Text.Encoding.Default)[index];
			Name = AnyCatches.TryReadAllLines("user.txt", System.Text.Encoding.Default)[index];
			Post = AnyCatches.TryReadAllLines("post.txt", System.Text.Encoding.Default)[index];
			FullName = AnyCatches.TryReadAllLines("fullName.txt", System.Text.Encoding.Default)[index];
			if ((AnyCatches.IfThereIsNot(Login)) || (AnyCatches.IfThereIsNot(Password)) || (AnyCatches.IfThereIsNot(Email)) ||
				(AnyCatches.IfThereIsNot(Name)) || (AnyCatches.IfThereIsNot(Post)) || (AnyCatches.IfThereIsNot(FullName))) {
				return;
			}
			for (int i = 0; i < Functions.Length; i++) {
				Functions[i] = false;
			}
			Distribution.SetLevel(ref userLevel, Int32.Parse(AnyCatches.TryReadAllLines("level.txt", System.Text.Encoding.Default)[index]));
			Distribution.SetFunctions(userLevel, ref Functions);
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