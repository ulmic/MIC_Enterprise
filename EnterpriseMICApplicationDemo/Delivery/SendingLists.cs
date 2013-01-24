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
		const string TABLE_NAME = "sendlists";
		List<SendingList> lists = new List<SendingList>();
		string connectionString = "Database=entermic;Data Source=localhost;User Id=root;Password=";
		/// <summary>
		/// Get all lists from base
		/// </summary>
		public SendingLists() {
			MySqlConnection myConnection = new MySqlConnection();
			try {
				myConnection = new MySqlConnection(connectionString);
				myConnection.Open();
			} catch {
				Console.WriteLine("ЖОПА!");
				myConnection.Close();
				Console.ReadKey();
				return;
			}
			string strSQL = "SELECT title FROM " + TABLE_NAME;
			MySqlCommand command = new MySqlCommand(strSQL, myConnection);
			MySqlDataReader reader = command.ExecuteReader();
			while (reader.Read()) {
				SendingList temp = new SendingList((string)reader[0]);
				//temp.GetFromDataBase(myConnection);
				lists.Add(temp);
			}
		}

		public void addEmptyList(string title) {
			MySqlConnection myConnection = new MySqlConnection();
			try {
				myConnection = new MySqlConnection(connectionString);
				myConnection.Open();
			} catch {
				Console.WriteLine("ЖОПА!");
				myConnection.Close();
				Console.ReadKey();
				return;
			}
			SendingList temp = new SendingList(title);
			temp.createNew(myConnection);
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

		public List<string> getTitles() {
			List<string> res = new List<string>();
			for (int i = 0; i < lists.Count; i++) {
				res.Add(lists[i].title);
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