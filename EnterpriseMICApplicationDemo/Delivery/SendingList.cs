using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// SendList class
	/// </summary>
	public class SendingList {
		private int id;
		private const string TABLE_NAME = "user_sendlists";
		private const string MEMBERS_TABLE_NAME = "user_sendlists_members";

		private const string ID_SENDLIST_COLUMN = "id_sendlist";

		public string title = "";
		public List<List<string>> members = new List<List<string>>();

		public SendingList(string _title) {
			MySqlConnection myConnection = new MySqlConnection();
			try {
				DBHelper db = new DBHelper();
				myConnection = db.CreateConnection();
				myConnection.Open();
			} catch {
				myConnection.Close();
				return;
			}
			title = _title;
		}

		public static List<string> GetFromDataBase(string sendListTitle) {
			DBHelper db = new DBHelper();
			string connectionString = db.SelectSQLQuery(ID_SENDLIST_COLUMN, TABLE_NAME, "title = '" + sendListTitle + "'");
			MySqlConnection newConnection = db.CreateConnection();
			newConnection.Open();
			MySqlCommand command = new MySqlCommand(connectionString, newConnection);
			MySqlDataReader reader = command.ExecuteReader();
			reader.Read();
			int id = (int)reader[0];
			reader.Close();
			List<string> members_lists = new List<string>();
			connectionString = db.SelectSQLQuery(Const.ID_USER_COLUMN, MEMBERS_TABLE_NAME, ID_SENDLIST_COLUMN + " = '" + id.ToString() + "'");
			command = new MySqlCommand(connectionString, newConnection);
			reader = command.ExecuteReader();
			while (reader.Read()) {
				members_lists.Add(Member_DB.GetFirstName(reader.GetInt32(0)) + " " + Member_DB.GetFamily(reader.GetInt32(0)) + " " + Member_DB.GetEmail(reader.GetInt32(0));
			}
			return members_lists;
		}

		public void createNew(MySqlConnection connection) {
			string strSQL = "INSERT INTO " + TABLE_NAME + " VALUES ('', '" + title + "')";
			DBHelper db = new DBHelper();
			MySqlConnection newConnection = db.CreateConnection();
			newConnection.Open();
			MySqlCommand command = new MySqlCommand(strSQL, newConnection);
			command.ExecuteNonQuery();
			strSQL = "SELECT id FROM " + TABLE_NAME + " WHERE title = '" + title + "'";
			command = new MySqlCommand(strSQL, connection);
			MySqlDataReader reader = command.ExecuteReader();
			reader.Read();
			id = (int)reader[0];
		}

		public void addMember(string name, string eMail) {
			for (int i = 0; i < members.Count; i++) {
				if (members[i][0] == name) {
					return;
				}
			}
			MySqlConnection myConnection = new MySqlConnection();
			try {
				DBHelper db = new DBHelper();
				myConnection = db.CreateConnection();
				myConnection.Open();
			} catch {
				myConnection.Close();
				return;
			}

			string strSQL = "INSERT INTO " + MEMBERS_TABLE_NAME + " VALUES (" + 0 + ", '" + name + "', '" + eMail + "', " + id + ")";
			MySqlCommand command = new MySqlCommand(strSQL, myConnection);
			command.ExecuteNonQuery();
			List<string> temp = new List<string>();
			temp.Add(name);
			temp.Add(eMail);
			members.Add(temp);
			myConnection.Close();
		}

		public void deleteMember(string name) {
			MySqlConnection myConnection = new MySqlConnection();
			try {
				DBHelper db = new DBHelper();
				myConnection = db.CreateConnection();
				myConnection.Open();
			} catch {
				myConnection.Close();
				Console.ReadKey();
				return;
			}

			string strSQL = "DELETE FROM " + MEMBERS_TABLE_NAME + " WHERE Name = '" + name + "'";
			MySqlCommand command = new MySqlCommand(strSQL, myConnection);
			command.ExecuteNonQuery();
			for (int i = 0; i < members.Count; i++) {
				if (members[i][0] == name) {
					members.RemoveAt(i);
					break;
				}
			}
			myConnection.Close();
		}

		public void clear() {
			MySqlConnection myConnection = new MySqlConnection();
			try {
				DBHelper db = new DBHelper();
				myConnection = db.CreateConnection();
				myConnection.Open();
			} catch {
				myConnection.Close();
				return;
			}

			string strSQL = "DELETE FROM " + MEMBERS_TABLE_NAME + " WHERE id_list = " + id;
			MySqlCommand command = new MySqlCommand(strSQL, myConnection);
			command.ExecuteNonQuery();
			members.Clear();
			myConnection.Close();
		}

		public void deleteList() {
			clear();
			MySqlConnection myConnection = new MySqlConnection();
			try {
				DBHelper db = new DBHelper();
				myConnection = db.CreateConnection();
				myConnection.Open();
			} catch {
				myConnection.Close();
				return;
			}

			string strSQL = "DELETE FROM " + TABLE_NAME + " WHERE id = " + id;
			MySqlCommand command = new MySqlCommand(strSQL, myConnection);
			command.ExecuteNonQuery();
		}
	}
}