using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using MySql.Data.MySqlClient;

namespace EnterpriseMICApplicationDemo {
    public class DBHelper {
        private string connectionString = "Server=localhost;database=ENTERMIC;uid=root";
        private string getMemberQuery = "SELECT * FROM newMIC_9 WHERE number = ";

        private const string SELECT_LOCALS = "SELECT DISTINCT value FROM uservalues INNER JOIN attributes ON uservalues.id_attr = attributes.id_attr WHERE attributes.name = 'local' ORDER BY uservalues.value";
        public const string EMPTY_CONDITION = "";
        /// <summary>
        /// Returns a list strings
        /// </summary>
        /// <param name="local">Place from which to get people</param>
        /// <returns></returns>
        public List<string> GetShort(string local) {
            MySqlConnection connection = CreateConnection();
            List<string> members = new List<string>();
            connection.Open();
            MySqlCommand command = new MySqlCommand(SelectMembersByLocals(local), connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (true) {
                string firstName = "";
                string family = "";
                string lastName = "";
                bool stop = true;
                for (int i = 0; i < 3 && reader.Read(); i++) {
                    switch (reader.GetUInt32(1)) {
                        case 2:
                            family = reader.GetString(2);
                            break;
                        case 3:
                            firstName = reader.GetString(2);
                            break;
                        case 4:
                            lastName = reader.GetString(2);
                            break;
                    };
                    stop = false;
                }
                if (stop) {
                    break;
                }
                members.Add(reader.GetString(0) + " " + family + " " + firstName + " " + lastName);
            }
            connection.Close();
            members.RemoveAll(item => item == "");
            return members;
        }

        private string SelectMembersByLocals(string local) {
            int familyAttrId = GetAttrIdByName(Const.FAMILY);
            int firstNameAttrId = GetAttrIdByName(Const.FIRST_NAME);
            int lastNameAttrId = GetAttrIdByName(Const.LAST_NAME);

            return @"SELECT t1.id_user, t1.id_attr, t1.value 
                FROM uservalues AS t1
                INNER JOIN attributes AS ta1 
                ON t1.id_attr = ta1.id_attr
                INNER JOIN uservalues AS t2 
                ON t1.id_user = t2.id_user
                INNER JOIN attributes AS ta2 
                ON t2.id_attr = ta2.id_attr
                WHERE (t2.value = '" + local + "' and ta2.name = 'local') AND (ta1.name = 'family' OR ta1.name = 'firstName' or ta1.name = 'lastName') ORDER BY id_user";
        }

        /// <summary>
        /// Returns a list of places (local from the DB)
        /// </summary>
        /// <returns></returns>
        public List<string> GetLocals() {
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
            return new Member(id);
        }

        private DateTime getDateTime(object year, object month, object day) {
            if ((Int32.Parse(day.ToString()) <= 0) || (Int32.Parse(month.ToString()) <= 0) || (Int32.Parse(year.ToString()) <= 0)) {
                return new DateTime();
            }
            return new DateTime(Int32.Parse(year.ToString()), Int32.Parse(month.ToString()), Int32.Parse(day.ToString()));
        }

        public List<string> GetSameBDayShorts(DateTime date) {
            string sameBDayShortsQuery = "SELECT Family, firstName, lastName, number, email FROM newMIC_9 WHERE b_Day = " + date.Day + " AND b_month = " + date.Month;
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
                list.Add(new Short(reader["Family"].ToString(), reader["firstName"].ToString(), reader["lastName"].ToString(), Int32.Parse(reader["number"].ToString()), reader["email"].ToString()).ToString());
            }
            return list;
        }

        public List<string> GetSameEnterDayShorts(DateTime date) {
            string sameBDayShortsQuery = "SELECT Family, firstName, lastName, number, email FROM newMIC_9 WHERE enter_Day = " + date.Day + " AND enter_month = " + date.Month + " AND enter_year = " + date.Year;
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
                list.Add(new Short(reader["Family"].ToString(), reader["firstName"].ToString(), reader["lastName"].ToString(), Int32.Parse(reader["number"].ToString()), reader["email"].ToString()).ToString());
            }
            return list;
        }

        public List<string> GetSameCityPeople(string city) {
            string sameBDayShortsQuery = "SELECT Family, firstName, lastName, number FROM newMIC_9 WHERE city = '" + city + "'";
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
                list.Add(new Short(reader["Family"].ToString(), reader["firstName"].ToString(), reader["lastName"].ToString(), Int32.Parse(reader["number"].ToString()), "").ToString());
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

        #region MySQL Query

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

        public string SelectSQLQuery(string attr, string table) {
            return selectSQLQuery(new string[] { attr }, table, "").Remove(selectSQLQuery(new string[] { attr }, table, "").Length - 5);
        }

        public string InsertSQLQuery(string insertIntoTable, string[] values) {
            string query = "INSERT INTO " + insertIntoTable;
            query += " VALUES (";
            foreach (string value in values) {
                query += "'" + value + "', ";
            }
            query = query.Remove(query.Length - 2);
            query += ")";
            return query;
        }

        #endregion

        public int GetAttrIdByName(string name) {
            MySqlConnection connection = CreateConnection();
            connection.Open();
            string condition = "name = '" + name + "'";
            MySqlCommand command = new MySqlCommand(SelectSQLQuery("id_attr", Const.ATTRIBUTES_TABLE, condition), connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == false) {
                return Const.THEREISNOT;
            }
            int attrId = Int32.Parse(reader.GetString(0));
            connection.Close();
            return attrId;
        }

        public string GetAttrNameById(int id_attr) {
            MySqlConnection connection = CreateConnection();
            connection.Open();
            string condition = "id_attr = '" + id_attr + "'";
            MySqlCommand command = new MySqlCommand(SelectSQLQuery("name", Const.ATTRIBUTES_TABLE, condition), connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == false) {
                return "";
            }
            string attrName = reader.GetString(0);
            connection.Close();
            return attrName;
        }
    }
}