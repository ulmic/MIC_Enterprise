using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using agsXMPP;

namespace EnterpriseMICApplicationDemo {
    class Settings {
        public static string jid;
        public static XmppClientConnection xmpp;
        public static string nickname = "haukot";
        public static string serverIp = "192.168.1.2";
        public static string server = "haupc";
        public static string pathForMucHistory = "http://" + serverIp + "/muc_logs/";
        public static string pathToDBSqlite = @"C:\Users\Оксана\Desktop\ddv\xmpp\serializ2\db\";
        public static System.Drawing.Color myColor = System.Drawing.Color.Green;
        public static System.Drawing.Color youColor = System.Drawing.Color.Red;
        public static int requestId = 0;
    }
}
