using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace EnterpriseMICApplicationDemo
{
    class SendingList
    {
        private int id;
        string connectionString = "Database=entermic;Data Source=localhost;User Id=root;Password=";
        public string title = "";
        public List<List<string>> members = new List<List<string>>();

        public SendingList(string _title)
        {
            MySqlConnection myConnection = new MySqlConnection();
            try
            {
                myConnection = new MySqlConnection(connectionString);
                myConnection.Open();
            }
            catch
            {
                Console.WriteLine("ЖОПА!");
                myConnection.Close();
                Console.ReadKey();
                return;
            }
            title = _title;
        }

        public void getFromDataBase(MySqlConnection connection)
        {
            string strSQL = "SELECT id FROM lists WHERE title = '" + title + "'";
            MySqlConnection newConnection = new MySqlConnection(connectionString);
            newConnection.Open();
            MySqlCommand command = new MySqlCommand(strSQL, newConnection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            id = (int)reader[0];
            reader.Close();
            strSQL = "SELECT Name, eMail FROM members INNER JOIN lists ON id_list = id WHERE id_list = ( SELECT id FROM lists WHERE title = '" + title + "')";
            command = new MySqlCommand(strSQL, newConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                List<string> temp = new List<string>();
                temp.Add(reader[0].ToString());
                temp.Add(reader[1].ToString());
                members.Add(temp);
            }
        }

        public void createNew(MySqlConnection connection)
        {
            string strSQL = "INSERT INTO lists VALUES ('', '" + title + "')";
            MySqlConnection newConnection = new MySqlConnection(connectionString);
            newConnection.Open();
            MySqlCommand command = new MySqlCommand(strSQL, newConnection);
            command.ExecuteNonQuery();
            strSQL = "SELECT id FROM lists WHERE title = '" + title + "'";
            command = new MySqlCommand(strSQL, connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            id = (int)reader[0];
        }
        public void addMember(string name, string eMail)
        {
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i][0] == name)
                {
                    Console.WriteLine("Wrong name. Equal name exist yet");
                    return;
                }
            }
            MySqlConnection myConnection = new MySqlConnection();
            try
            {
                myConnection = new MySqlConnection(connectionString);
                myConnection.Open();
            }
            catch
            {
                Console.WriteLine("ЖОПА!");
                myConnection.Close();
                Console.ReadKey();
                return;
            }

            string strSQL = "INSERT INTO members VALUES (" + 0 + ", '" + name + "', '" + eMail + "', " + id + ")";
            MySqlCommand command = new MySqlCommand(strSQL, myConnection);
            command.ExecuteNonQuery();
            List<string> temp = new List<string>();
            temp.Add(name);
            temp.Add(eMail);
            members.Add(temp);
            myConnection.Close();
        }

        public void deleteMember(string name)
        {
            MySqlConnection myConnection = new MySqlConnection();
            try
            {
                myConnection = new MySqlConnection(connectionString);
                myConnection.Open();
            }
            catch
            {
                Console.WriteLine("ЖОПА!");
                myConnection.Close();
                Console.ReadKey();
                return;
            }

            string strSQL = "DELETE FROM members WHERE Name = '" + name + "'";
            MySqlCommand command = new MySqlCommand(strSQL, myConnection);
            command.ExecuteNonQuery();
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i][0] == name)
                {
                    members.RemoveAt(i);
                    break;
                }
            }
            myConnection.Close();
        }

        public void clear()
        {
            MySqlConnection myConnection = new MySqlConnection();
            try
            {
                myConnection = new MySqlConnection(connectionString);
                myConnection.Open();
            }
            catch
            {
                Console.WriteLine("ЖОПА!");
                myConnection.Close();
                Console.ReadKey();
                return;
            }

            string strSQL = "DELETE FROM members WHERE id_list = " + id;
            MySqlCommand command = new MySqlCommand(strSQL, myConnection);
            command.ExecuteNonQuery();
            members.Clear();
            myConnection.Close();
        }

        public void deleteList()
        {
            clear();
            MySqlConnection myConnection = new MySqlConnection();
            try
            {
                myConnection = new MySqlConnection(connectionString);
                myConnection.Open();
            }
            catch
            {
                Console.WriteLine("ЖОПА!");
                myConnection.Close();
                Console.ReadKey();
                return;
            }

            string strSQL = "DELETE FROM lists WHERE id = " + id;
            MySqlCommand command = new MySqlCommand(strSQL, myConnection);
            command.ExecuteNonQuery();
        }

        public void print()
        {
            Console.WriteLine("Id = " + id + "\n------------------");
            Console.WriteLine("Title = " + title + "\n------------------");
            for (int i = 0; i < members.Count; i++)
            {
                Console.WriteLine("Name = " + members[i][0] + " email = " + members[i][1]);
            }


        }
    }
}

