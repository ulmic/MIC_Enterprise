using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

using EnterpriseMICApplicationDemo.Models.Global.Infrastructure;

namespace EnterpriseMICApplicationDemo.Models.Main.UsersLists {
    class DBRequest {
        public DBRequest() { }
        private string queryStringSelectMembersBy(string local) {
            return @"SELECT t1.id_user, t1.id_attr, t1.value
                            FROM uservalues AS t1
                            INNER JOIN uservalues AS t2 ON t1.id_user = t2.id_user
                            WHERE 
                            t2.value = '" + local + @"' 
                            AND t2.id_attr = " + DBAttributes.Local + " ORDER BY id_user";
        }
        private string queryStringSelectOrganization = @"SELECT DISTINCT value 
                                                                FROM uservalues 
                                                                WHERE uservalues.id_attr = " + DBAttributes.Local + @"  
                                                                ORDER BY uservalues.value";

        public MySqlConnection CreateConnection() {
            string passwordString = (Const.DB.DB_USER_PASSWORD == "") ? "" : ";User Password=" + Const.DB.DB_USER_PASSWORD;
            return new MySqlConnection("Database=" + Const.DB.DB_NAME + ";Data Source=" + Const.DB.DATA_SOURCE + ";User Id="
                        + Const.DB.DB_USER + passwordString);
        }

        public List<Dictionary<int, string>> getMembersBy(string local) {
            List<Dictionary<int, string>> members = new List<Dictionary<int, string>>();
            MySqlConnection connection = CreateConnection();
            connection.Open();
            MySqlCommand command = new MySqlCommand(queryStringSelectMembersBy(local), connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) {
                int memberId = reader.GetInt32("id_user");
                while (true) {
                    bool exit = false;
                    Dictionary<int, string> memberInfo = new Dictionary<int, string>(26);
                    memberInfo.Add(0, memberId.ToString());
                    while (true) {
                        memberInfo.Add(reader.GetInt32("id_attr"), reader.GetString("value"));
                        if (!reader.Read()) { //читаем новую запись
                            exit = true;
                            break;
                        }
                        int tempMemberId = reader.GetInt32("id_user");
                        if (tempMemberId != memberId) {
                            memberId = tempMemberId;
                            break;
                        }
                    }
                    for (int i = Const.DB.ATTRIBUTES_FIRST_INDEX; i <= Const.DB.ATTRIBUTES_MAX_INDEX; i++) {
                        if (!memberInfo.ContainsKey(i)) {
                            memberInfo.Add(i, null);
                        }
                    }
                    members.Add(memberInfo);
                    if (exit) {
                        break;
                    }
                }
            }
            connection.Close();
            return members;
        }

        public List<string> getOrganizations() {
            MySqlConnection connection = CreateConnection();
            List<string> locals = new List<string>();
            connection.Open();
            MySqlCommand command = new MySqlCommand(queryStringSelectOrganization, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                locals.Add(reader.GetString(0));
            }
            connection.Close();
            locals.Remove("");
            return locals;
        }
    }
}
