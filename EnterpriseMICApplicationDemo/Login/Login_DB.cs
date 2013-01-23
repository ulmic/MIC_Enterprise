using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EnterpriseMICApplicationDemo {
	static class Login_DB {
		private static MySqlConnection connection;
		private static DBHelper db;
		public const string LOGIN_ATTR = "login";
		public const string PASSWORD_ATTR = "password";

		public static int GetUserIndexByLoginPassword(string login, string password) {
			openConnection();
			string condition = "login = '" + login + "' and password = '" + password + "'";
			MySqlCommand command = new MySqlCommand(db.SelectSQLQuery("id_user", Const.USERS_TABLE, condition), connection);
			MySqlDataReader reader = command.ExecuteReader();
			if (reader.Read() == false) {
				return Const.THEREISNOT;
			}
			int userIndex = reader.GetInt32(0);
			connection.Close();
			return userIndex;
		}

		public static Member GetUserById(int idUser) {
			openConnection();
			string condition = "id_user = '" + idUser + "'";
			MySqlCommand command = new MySqlCommand(db.SelectSQLQuery(new string[] { LOGIN_ATTR, PASSWORD_ATTR }, Const.USERS_TABLE, condition), connection);
			MySqlDataReader reader = command.ExecuteReader();
			if (reader.Read() == false) {
				return null;
			}
			Member m = new Member(idUser, reader.GetString(LOGIN_ATTR), reader.GetString(PASSWORD_ATTR));
			connection.Close();
			return m;
		}

		private static void openConnection() {
			db = new DBHelper();
			connection = db.CreateConnection();
			connection.Open();
		}
	}
}