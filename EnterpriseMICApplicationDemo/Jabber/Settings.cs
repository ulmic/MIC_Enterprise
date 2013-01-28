using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

using agsXMPP;

namespace EnterpriseMICApplicationDemo {
	public static class Settings {
		public static string Jid;
		public static XmppClientConnection xmpp;
		public static string NickName = "haukot"; 
		public static string Password = "123";
		public static string serverIp = "192.168.173.3";
		public static string Server = "haupc";
		public static string pathForMucHistory = "http://" + serverIp + "/muc_logs/";
		public static string pathToDBSqlite = @"Jabber\db\";
		public static System.Drawing.Color myColor = System.Drawing.Color.Green;
		public static System.Drawing.Color youColor = System.Drawing.Color.Red;
		public static int requestId = 0;

		public static FormConferention FormConferention {
			get {
				throw new System.NotImplementedException();
			}
			set {
			}
		}

		public static FormHistoryView FormHistoryView {
			get {
				throw new System.NotImplementedException();
			}
			set {
			}
		}

		public static FormJoinConferention FormJoinConferention {
			get {
				throw new System.NotImplementedException();
			}
			set {
			}
		}

		public static FormCreateConferention FormCreateConferention {
			get {
				throw new System.NotImplementedException();
			}
			set {
			}
		}

		public static FormSettings FormSettings {
			get {
				throw new System.NotImplementedException();
			}
			set {
			}
		}

		public static FormJabberStart FormJabberStart {
			get {
				throw new System.NotImplementedException();
			}
			set {
			}
		}
	}
}