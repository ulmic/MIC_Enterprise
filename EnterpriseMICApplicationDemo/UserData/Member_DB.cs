using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Reflection;

namespace EnterpriseMICApplicationDemo{
	static class Member_DB {
		private static MySqlConnection connection;
		private static DBHelper db;

		#region DataBaseConstants

		private const string ID_ATTR_COLUMN = "id_attr";
		private const string VALUE_COLUMN = "value";
		private const string ID_USER_COLUMN = "id_user";

		#endregion

		private const string SELECT_MEMBER_ATTRS_QUERY = "SELECT " + ID_ATTR_COLUMN + ", " + VALUE_COLUMN + "FROM " + Const.USER_VALUES_TABLE + " WHERE " + ID_USER_COLUMN + " = '";

		#region GetMemberAttributes

		public static string GetFamily(int idUser) {
			return getUserValueByIdAndAttr(idUser, Const.FAMILY);
		}

		public static string GetFirstName(int idUser) {
			return getUserValueByIdAndAttr(idUser, Const.FIRST_NAME);
		}

		public static string GetLastName(int idUser) {
			return getUserValueByIdAndAttr(idUser, Const.LAST_NAME);
		}

		public static int GetNumber(int idUser) {
			return parseStringToInt(getUserValueByIdAndAttr(idUser, Const.NUMBER));
		}

		public static string GetLocal(int idUser) {
			return getUserValueByIdAndAttr(idUser, Const.LOCAL);
		}

		public static DateTime GetBDate(int idUser) {
			List<string> values = getUserValuesArrayByIdAndAttrs(idUser, Const.B_DATE.Split(','));
			return new DateTime(parseStringToInt(values[2]), parseStringToInt(values[1]), parseStringToInt(values[0]));
		}

		public static string GetEducation(int idUser) {
			return getUserValueByIdAndAttr(idUser, Const.EDUCATION);
		}

		public static string GetJob(int idUser) {
			return getUserValueByIdAndAttr(idUser, Const.JOB);
		}

		public static DateTime GetEnterDate(int idUser) {
			List<string> values = getUserValuesArrayByIdAndAttrs(idUser, Const.ENTER_DATE.Split(','));
			return new DateTime(parseStringToInt(values[2]), parseStringToInt(values[1]), parseStringToInt(values[0]));
		}

		public static int GetIndexAdress(int idUser) {
			return parseStringToInt(getUserValueByIdAndAttr(idUser, Const.INDEX_ADRESS));
		}

		public static string GetState(int idUser) {
			return getUserValueByIdAndAttr(idUser, Const.STATE);
		}

		public static string GetCity(int idUser) {
			return getUserValueByIdAndAttr(idUser, Const.CITY);
		}

		public static string GetHomeAdress(int idUser) {
			return getUserValueByIdAndAttr(idUser, Const.HOME_ADRESS);
		}

		public static string GetContacts(int idUser) {
			return getUserValueByIdAndAttr(idUser, Const.CONTACTS);
		}

		public static string GetEnterMark(int idUser) {
			return getUserValueByIdAndAttr(idUser, Const.ENTER_MARK);
		}

		public static DateTime GetChangeDate(int idUser) {
			return parseStringToDateTime(getUserValueByIdAndAttr(idUser, Const.CHANGE_DATE));
		}

		public static int GetGodFather(int idUser) {
			return parseStringToInt(getUserValueByIdAndAttr(idUser, Const.GOD_FATHER));
		}

		public static string GetPost(int idUser) {
			return getUserValueByIdAndAttr(idUser, Const.POST);
		}

		public static string GetEmail(int idUser) {
			return getUserValueByIdAndAttr(idUser, Const.EMAIL);
		}

		public static int GetUserLevel(int idUser) {
			return parseStringToInt(getUserValueByIdAndAttr(idUser, Const.USER_LEVEL));
		}

		public static int GetMemberIdByEmail(string email) {
			return getUserIdByValue(Const.EMAIL, email);
		}

		#endregion

		public static List<string> GetMemberAttrWithOneQuery(int userId) {
			openConnection();
			MySqlCommand command = new MySqlCommand(SELECT_MEMBER_ATTRS_QUERY + userId.ToString() + "'", connection);
			MySqlDataReader reader = command.ExecuteReader();
			while (reader.Read()) {
				string attrName = db.GetAttrNameById(reader.GetInt32(ID_ATTR_COLUMN));
				Member m = new Member();
				foreach (FieldInfo f in m.GetType().GetFields()) {
					if (f.Name == attrName) {
						System.Windows.Forms.MessageBox.Show("yes");
					}
				}
			}
			return new List<string>();
		}

		private static int getUserIdByValue(string attrName, string value) {
			int attrId = db.GetAttrIdByName(attrName);
			openConnection();
			string condition = "id_attr = '" + attrId.ToString() + "' and value = '" + value + "'";
			MySqlCommand command = new MySqlCommand(db.SelectSQLQuery("id_user", Const.USER_VALUES_TABLE, condition), connection);
			MySqlDataReader reader = command.ExecuteReader();
			if (reader.Read() == false) {
				return Const.THEREISNOT;
			}
			int userId = Int32.Parse(reader.GetString(0));
			connection.Close();
			return userId;
		}

		private static int parseStringToInt(string valueString) {
			int value = Const.THEREISNOT;
			try {
				value = Int32.Parse(valueString);
			} catch { }
			return value;
		}

		private static DateTime parseStringToDateTime(string valueString) {
			DateTime value = new DateTime();
			try {
				value = DateTime.Parse(valueString);
			} catch { }
			return value;
		}

		private static string getUserValueByIdAndAttr(int idUser, string attrName) {
			db = new DBHelper();
			int attrId = db.GetAttrIdByName(attrName);
			openConnection();
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

		private static List<string> getUserValuesArrayByIdAndAttrs(int idUser, string[] attrsNames) {
			List<string> values = new List<string>();
			foreach (string attrName in attrsNames) {
				int attrId = db.GetAttrIdByName(attrName);
				openConnection();
				string condition = "id_user = '" + idUser.ToString() + "' and id_attr = '" + attrId.ToString() + "'";
				MySqlCommand command = new MySqlCommand(db.SelectSQLQuery("value", Const.USER_VALUES_TABLE, condition), connection);
				MySqlDataReader reader = command.ExecuteReader();
				if (reader.Read() == false) {
					values.Add("");
					continue;
				}
				string userValue = reader.GetString(0);
				reader.Close();
				connection.Close();
				values.Add(userValue);
			}
			return values;
		}

		private static void openConnection() {
			db = new DBHelper();
			connection = db.CreateConnection();
			connection.Open();
		}
	}
}