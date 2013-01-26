using System;
using System.Collections.Generic;
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

		public User() { }

		private void getUserByIndex(int index) {
			Id = index;
			Login = 
			Password = AnyCatches.TryReadAllLines("password.txt", System.Text.Encoding.Default)[index];
			if ((AnyCatches.IfThereIsNot(Login)) || (AnyCatches.IfThereIsNot(Password))) {
				return;
			}
			
		}
	}
}