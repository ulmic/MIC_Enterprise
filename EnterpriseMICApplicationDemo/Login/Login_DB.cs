using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EnterpriseMICApplicationDemo {
	static class Login_DB {
		private static MySqlConnection connection;
		public static int GetUserIndexByLoginPassword(string login, string password) {
			DBHelper db = new DBHelper();
			connection = new MySqlConnection(db.DataBaseConnectorString(Const.DB_NAME, Const.DATA_SOURCE, Const.DB_USER, Const.DB_USER_PASSWORD));
			connection.Open();
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
	}
}