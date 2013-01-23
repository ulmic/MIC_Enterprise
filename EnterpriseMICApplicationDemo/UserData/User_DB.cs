using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EnterpriseMICApplicationDemo{
	static class User_DB {
		private static MySqlConnection connection;
		private static DBHelper db;
		public static int GetUserLevelById(int idUser) {
			string value = getUserValueByIdAndAttr(idUser, Const.USER_LEVEL);
			int userLevel = Const.THEREISNOT;
			try {
				userLevel = Int32.Parse(value);
			} catch { }
			return userLevel;
		}

		private static string getUserValueByIdAndAttr(int idUser, string attrName) {
			int attrId = getAttrIdByName(attrName);
			connectToDB();
			string condition = "id_user = '" + idUser.ToString() + "' and id_attr = '" + attrId.ToString() + "'";
			MySqlCommand command = new MySqlCommand(db.SelectSQLQuery("value", Const.USER_VALUES_TABLE, condition), connection);
			MySqlDataReader reader = command.ExecuteReader();
			if (reader.Read() == false) {
				return "";
			}
			string userValue = reader.GetString(0);
			connection.Close();
			return userValue;
		}

		private static int getAttrIdByName(string name) {
			connectToDB();
			string condition = "name = '" + name + "'";
			MySqlCommand command = new MySqlCommand(db.SelectSQLQuery("id_attr", Const.ATTRIBUTES_TABLE, condition), connection);
			MySqlDataReader reader = command.ExecuteReader();
			if (reader.Read() == false) {
				return Const.THEREISNOT;
			}
			int userLevel = Int32.Parse(reader.GetString(0));
			connection.Close();
			return userLevel;
		}

		private static void connectToDB() {
			db = new DBHelper();
			connection = new MySqlConnection(db.DataBaseConnectorString(Const.DB_NAME, Const.DATA_SOURCE, Const.DB_USER, Const.DB_USER_PASSWORD));
			connection.Open();
		}
	}
}