using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Reflection;

namespace EnterpriseMICApplicationDemo {
    static class Member_DB {
        private static MySqlConnection connection;
        private static DBHelper db;

        #region DataBaseConstants

        private const string ID_ATTR_COLUMN = "id_attr";
        private const string VALUE_COLUMN = "value";

        #endregion

        private const string SELECT_MEMBER_ATTRS_QUERY = "SELECT " + ID_ATTR_COLUMN + ", " + VALUE_COLUMN + " FROM " + Const.USER_VALUES_TABLE + " WHERE " + Const.ID_USER_COLUMN + " = '";
        private static string SELECT_MEMBER_ALL_VALUES(string userId) {
            return "SELECT us.id_attr, us.value, att.name FROM attributes AS att INNER JOIN uservalues AS us ON att.id_attr = us.id_attr WHERE us.id_user = '" + userId + "' ORDER BY id_attr";
        }
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

        public static Member GetMemberAttrWithOneQuery(int userId) {
            openConnection();
            MySqlCommand command = new MySqlCommand(SELECT_MEMBER_ALL_VALUES(userId.ToString()), connection);
            MySqlDataReader reader = command.ExecuteReader();
            Member m = new Member();
            int b_day = 0;
            int b_month = 0;
            int b_year = 0;
            int enter_day = 0;
            int enter_month = 0;
            int enter_year = 0;
            while (reader.Read()) {
                string attrName = reader.GetString("name");
                switch (attrName) {
                    case "b_day":
                        b_day = reader.GetInt32(VALUE_COLUMN);
                        continue;
                    case "b_month":
                        b_month = reader.GetInt32(VALUE_COLUMN);
                        continue;
                    case "b_year":
                        b_year = reader.GetInt32(VALUE_COLUMN);
                        continue;
                    case "enter_day":
                        enter_day = reader.GetInt32(VALUE_COLUMN);
                        continue;
                    case "enter_month":
                        enter_month = reader.GetInt32(VALUE_COLUMN);
                        continue;
                    case "enter_year":
                        enter_year = reader.GetInt32(VALUE_COLUMN);
                        continue;
                }
                if (b_day != 0 || b_month != 0 || b_year != 0) {
                    m.BDate = new DateTime(b_year, b_month, b_day);
                    b_year = b_day = b_month = 0;
                }
                if (enter_day != 0 || enter_month != 0 || enter_year != 0) {
                    m.EnterDate = new DateTime(enter_year, enter_month, enter_day);
                    enter_day = enter_month = enter_year = 0;
                }
                string value = reader.GetString(VALUE_COLUMN);
                foreach (FieldInfo f in m.GetType().GetFields()) {
                    if (String.Compare(f.Name, attrName, true) == 0) {
                        if (f.FieldType == typeof(Int32)) {
                            try {
                                m.GetType().GetField(f.Name).SetValue(m, Int32.Parse(value));
                            } catch {
                            }
                            continue;
                        }
                        if ((f.FieldType == typeof(DateTime)) && (f.Name != "BDate") && (f.Name != "EnterDate")) {
                            try {
                                m.GetType().GetField(f.Name).SetValue(m, DateTime.Parse(value));
                            } catch {
                            }
                            continue;
                        }
                        m.GetType().GetField(f.Name).SetValue(m, value);
                    }
                }
            }
            return m;
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
            } catch {
            }
            return value;
        }

        private static DateTime parseStringToDateTime(string valueString) {
            DateTime value = new DateTime();
            try {
                value = DateTime.Parse(valueString);
            } catch {
            }
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

        private static int getIdByFIO(string FIO) {
            string[] fio = FIO.Split(' ');
            if (fio.Length != 3) {
                return Const.THEREISNOT;
            }
            DBHelper db = new DBHelper();
            MySqlConnection connection = db.CreateConnection();
            connection.Open();
            string subsubquery = db.SelectSQLQuery(Const.ID_USER_COLUMN, Const.USER_VALUES_TABLE, ID_ATTR_COLUMN + " = '" + Const.FAMILY + "' AND " + VALUE_COLUMN + " = '" + fio[0] + "' AND " + Const.ID_USER_COLUMN + " = ");
            string subquery = "(" + db.SelectSQLQuery(Const.ID_USER_COLUMN, Const.USER_VALUES_TABLE, ID_ATTR_COLUMN + " = '" + Const.FIRST_NAME + "' AND " + VALUE_COLUMN + " = '" + fio[1] + "' AND " + Const.ID_USER_COLUMN + " = ");
            string query = "(" + db.SelectSQLQuery(Const.ID_USER_COLUMN, Const.USER_VALUES_TABLE, ID_ATTR_COLUMN + " = '" + Const.LAST_NAME + "' AND " + VALUE_COLUMN + " = '" + fio[2] + "'") + "))";
            MySqlCommand command = new MySqlCommand(db.SelectSQLQuery(Const.ID_USER_COLUMN, Const.USER_VALUES_TABLE, ID_ATTR_COLUMN + " = '" + db.GetAttrIdByName(Const.FAMILY).ToString() + "' AND " + VALUE_COLUMN + " = '" + fio[0] + "'"), connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == false) {
                return Const.THEREISNOT;
            }
            int id = reader.GetInt32(0);
            connection.Close();
            return id;
        }

        public static bool FindUserByFIO(string titleSendList, string FIO) {
            int id = getIdByFIO(FIO);
            if (id == Const.THEREISNOT) {
                return false;
            }
            SendingList.AddMemberFromDB(titleSendList, id);
            return true;
        }
    }
}