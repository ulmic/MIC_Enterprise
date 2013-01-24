using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EnterpriseMICApplicationDemo {
	public class DBHelper {
		private string getGroupsQuery = "SELECT local FROM newMIC_9 GROUP BY local";
		private string getGroupShortsQuery = "SELECT family, firstName, lastName, number, email FROM newMIC_9 WHERE local = ";
		private string connectionString = "server=localhost;database=ENTERMIC;uid=root";
		private string getMemberQuery = "SELECT * FROM newMIC_9 WHERE number = ";

		private const string SELECT_LOCALS = "SELECT DISTINCT value FROM uservalues INNER JOIN attributes ON uservalues.id_attr = attributes.id_attr WHERE attributes.name = 'local' ORDER BY uservalues.value";

		/// <summary>
		/// Returns a list strings
		/// </summary>
		/// <param name="local">Place from which to get people</param>
		/// <returns></returns>
		public List<string> GetShort(string local) {
			MySqlConnection con = new MySqlConnection();
			try {
				con = new MySqlConnection(connectionString);
			} catch {
				return null;
			}
			MySqlCommand cmd = new MySqlCommand(getGroupShortsQuery + "'" + local + "'", con);
			List<string> str = new List<string>();
			try {
				con.Open();
			} catch {
				return null;
			}
			MySqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read()) {
				str.Add((new Short(reader["family"].ToString(), reader["firstName"].ToString(), reader["lastName"].ToString(), Int32.Parse(reader["number"].ToString()), reader["email"].ToString()).ToString()));
			}
			con.Close();
			return str;
		}

		/// <summary>
		/// Returns a list of places (local from the DB)
		/// </summary>
		/// <returns></returns>
		public List<string> GetLocals() {
			//MySqlConnection con = new MySqlConnection();
			//List<string> str = new List<string>();
			//try {
			//    con = new MySqlConnection(connectionString);
			//} catch {
			//    str.Add("Ошибка: не создано соединение.");
			//    return str;
			//}
			//MySqlCommand cmd = new MySqlCommand(getGroupsQuery, con);
			//try {
			//    con.Open();
			//} catch {
			//    str.Add("Ошибка: не установлено соединение.");
			//    return str;
			//}
			//MySqlDataReader reader = cmd.ExecuteReader();
			//while (reader.Read()) {
			//    str.Add(reader["local"].ToString());
			//}
			//con.Close();
			//str.Remove("");
			//return str;
			MySqlConnection connection = CreateConnection();
			List<string> locals = new List<string>();
			connection.Open();
			MySqlCommand command = new MySqlCommand(SELECT_LOCALS, connection);
			MySqlDataReader reader = command.ExecuteReader();
			while (reader.Read()) {
				locals.Add(reader.GetString(0));
			}
			connection.Close();
			locals.Remove("");
			return locals;
		}

		

		/// <summary>
		/// Returns an instance of the class Member
		/// </summary>
		/// <param name="id">Id man from the base</param>
		/// <returns></returns>
		public Member GetMember(int id) {
			MySqlConnection con = new MySqlConnection();
			try {
				con = new MySqlConnection(connectionString);
			} catch {
				return null;
			}
			MySqlCommand cmd = new MySqlCommand(getMemberQuery + id.ToString(), con);
			try {
				con.Open();
			} catch {
				return null;
			}
			MySqlDataReader reader = cmd.ExecuteReader();
			Member mmbr = new Member();
			while (reader.Read()) {
				mmbr.Area = reader["area"].ToString();
				mmbr.Local = reader["local"].ToString();
				mmbr.Family = reader["family"].ToString();
				mmbr.FirstName = reader["firstName"].ToString();
				mmbr.City = reader["city"].ToString();
				mmbr.LastName = reader["lastName"].ToString();
				mmbr.BDate = getDateTime(reader["b_Year"], reader["b_month"], reader["b_Day"]);
				mmbr.Education = reader["education"].ToString();
				mmbr.Job = reader["job"].ToString();
				mmbr.EnterDate = getDateTime(reader["enter_year"], reader["enter_month"], reader["enter_day"]);
				mmbr.Number = Int32.Parse(reader["number"].ToString());
				mmbr.IndexAdress = Int32.Parse(reader["index_adress"].ToString());
				mmbr.Contacts = reader["contacts"].ToString();
				mmbr.EnterMark = reader["enter_Mark"].ToString();
				//mmbr.ChangeDate = reader["change_date"].ToString();
				mmbr.GodFather = Int32.Parse(reader["godFather"].ToString());
				mmbr.Post = reader["post"].ToString();
				mmbr.Email = reader["email"].ToString();
			}
			con.Close();
			return mmbr;
		}

		private DateTime getDateTime(object year, object month, object day) {
			if ((Int32.Parse(day.ToString()) <= 0) || (Int32.Parse(month.ToString()) <= 0) || (Int32.Parse(year.ToString()) <= 0)) {
				return new DateTime();
			}
			return new DateTime(Int32.Parse(year.ToString()), Int32.Parse(month.ToString()), Int32.Parse(day.ToString()));
		}

		public List<string> GetSameBDayShorts(DateTime date) {
			string sameBDayShortsQuery = "SELECT family, firstName, lastName, number, email FROM newMIC_9 WHERE b_Day = " + date.Day + " AND b_month = " + date.Month;
			MySqlConnection con = new MySqlConnection();
			try {
				con = new MySqlConnection(connectionString);
			} catch {
				return null;
			}
			MySqlCommand cmd = new MySqlCommand(sameBDayShortsQuery, con);
			try {
				con.Open();
			} catch {
				return null;
			}
			MySqlDataReader reader = cmd.ExecuteReader();
			List<string> list = new List<string>();
			while (reader.Read()) {
				list.Add(new Short(reader["family"].ToString(), reader["firstName"].ToString(), reader["lastName"].ToString(), Int32.Parse(reader["number"].ToString()), reader["email"].ToString()).ToString());
			}
			return list;
		}

		public List<string> GetSameEnterDayShorts(DateTime date) {
			string sameBDayShortsQuery = "SELECT family, firstName, lastName, number, email FROM newMIC_9 WHERE enter_Day = " + date.Day + " AND enter_month = " + date.Month + " AND enter_year = " + date.Year;
			MySqlConnection con = new MySqlConnection();
			try {
				con = new MySqlConnection(connectionString);
			} catch {
				return null;
			}
			MySqlCommand cmd = new MySqlCommand(sameBDayShortsQuery, con);
			try {
				con.Open();
			} catch {
				return null;
			}
			MySqlDataReader reader = cmd.ExecuteReader();
			List<string> list = new List<string>();
			while (reader.Read()) {
				list.Add(new Short(reader["family"].ToString(), reader["firstName"].ToString(), reader["lastName"].ToString(), Int32.Parse(reader["number"].ToString()), reader["email"].ToString()).ToString());
			}
			return list;
		}

		public List<string> GetSameCityPeople(string city) {
			string sameBDayShortsQuery = "SELECT family, firstName, lastName, number FROM newMIC_9 WHERE city = '" + city + "'";
			MySqlConnection con = new MySqlConnection();
			try {
				con = new MySqlConnection(connectionString);
			} catch {
				return null;
			}
			MySqlCommand cmd = new MySqlCommand(sameBDayShortsQuery, con);
			try {
				con.Open();
			} catch {
				return null;
			}
			MySqlDataReader reader = cmd.ExecuteReader();
			List<string> list = new List<string>();
			while (reader.Read()) {
				list.Add(new Short(reader["family"].ToString(), reader["firstName"].ToString(), reader["lastName"].ToString(), Int32.Parse(reader["number"].ToString()), "").ToString());
			}
			return list;
		}

		private List<string> getContacts() {
			MySqlConnection con = new MySqlConnection();
			try {
				con = new MySqlConnection(connectionString);
			} catch {
				return null;
			}
			MySqlCommand cmd = new MySqlCommand("SELECT contacts FROM newMIC_9", con);
			List<string> str = new List<string>();
			try {
				con.Open();
			} catch {
				return null;
			}
			MySqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read()) {
				str.Add(reader["contacts"].ToString());
			}
			con.Close();
			return str;
		}

		public List<string> SplitContacts() {
			List<string> str = getContacts();
			List<string> emails = new List<string>();
			foreach (string p in str) {
				string email = "";
				foreach (string t in p.Split(new char[] { ',', ' ', ';' })) {
					if (t.Contains("@")) {
						email += t + " ";
					} else {
						email += "";
					}
				}
				emails.Add(email);
			}
			return emails;
		}

		private string dataBaseConnectorString(string dbName, string dataSource, string userName, string password) {
			if (password == "") {
				return "Database=" + dbName + ";Data Source=" + dataSource + ";User Id=" + userName;
			}
			return "Database=" + dbName + ";Data Source=" + dataSource + ";User Id=" + userName + ";User Password=" + password;
		}

		public MySqlConnection CreateConnection() {
			return new MySqlConnection(dataBaseConnectorString(Const.DB_NAME, Const.DATA_SOURCE, Const.DB_USER, Const.DB_USER_PASSWORD));
		}

		private string selectSQLQuery(string[] attrs, string table, string condition) {
			string query = "SELECT ";
			foreach (string attr in attrs) {
				query += attr + ", ";
			}
			query = query.Remove(query.Length - 2);
			query += " FROM " + table + " WHERE " + condition;
			return query;
		}

		public string SelectSQLQuery(string attr, string table, string condition) {
			return selectSQLQuery(new string[] { attr }, table, condition);
		}

		public string SelectSQLQuery(string[] attrs, string table, string condition) {
			return selectSQLQuery(attrs, table, condition);
		}
	}
}