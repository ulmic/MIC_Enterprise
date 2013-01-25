using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Class to work with sendlists
	/// </summary>
	public class SendingLists {
		const string TABLE_NAME = "user_sendlists";
		List<SendingList> lists = new List<SendingList>();
		string connectionString = "Database=entermic;Data Source=localhost;User Id=root;Password=";

		private const string TITLE_COLUMN = "title";

		/// <summary>
		/// Get all lists from base
		/// </summary>
		public SendingLists() {	}

		public void addEmptyList(string title) {
			MySqlConnection myConnection = new MySqlConnection();
			try {
				myConnection = new MySqlConnection(connectionString);
				myConnection.Open();
			} catch {
				myConnection.Close();
				return;
			}
			SendingList temp = new SendingList(title);
		}

		public void deleteList(string title) {
			for (int i = 0; i < lists.Count; i++) {
				if (lists[i].title == title) {
					lists[i].deleteList();
					return;
				}
			}
		}

		public void clearList(string title) {
			for (int i = 0; i < lists.Count; i++) {
				if (lists[i].title == title) {
					lists[i].clear();
					return;
				}
			}
		}

		public List<string> GetSendListsTitles() {
			DBHelper db = new DBHelper();
			MySqlConnection connection = db.CreateConnection();
			connection.Open();
			MySqlCommand command = new MySqlCommand(db.SelectSQLQuery(TITLE_COLUMN, TABLE_NAME), connection);
			MySqlDataReader reader = command.ExecuteReader();
			List<string> res = new List<string>();			
			while (reader.Read()) {
				res.Add(reader.GetString(0));
			}
			return res;
		}

		public List<string> getEmails(string title) {
			List<string> res = new List<string>();
			for (int i = 0; i < lists.Count; i++) {
				if (lists[i].title == title) {
					for (int j = 0; j < lists[i].members.Count; i++) {
						res.Add(lists[i].members[j][1]);
					}
				}
			}
			return res;
		}

		public List<string> getNameAndEmails(string title) {
			List<string> res = new List<string>();
			for (int i = 0; i < lists.Count; i++) {
				if (lists[i].title == title) {
					for (int j = 0; j < lists[i].members.Count; j++) {
						res.Add(lists[i].members[j][0] + "; " + lists[i].members[j][1]);
					}
				}
			}
			return res;
		}
	}
}