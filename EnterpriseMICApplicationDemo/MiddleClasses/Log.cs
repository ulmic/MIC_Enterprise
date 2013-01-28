using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;

namespace EnterpriseMICApplicationDemo {
	public static class Log {
		private static Logger logger = LogManager.GetCurrentClassLogger();

		public static MainForm MainForm {
			get {
				throw new System.NotImplementedException();
			}
			set {
			}
		}
	
		public delegate void inlineCode();
		public static void LogTryCatch(inlineCode code) {
			try {
				code();
			} catch (Exception ex) {
				System.Windows.Forms.MessageBox.Show("Произошла неизвестная ошибка. Данные об ошибке отправлены администратору. Для вашей безопасности окошко было закрыто. Сохраняйте спокойствие :)");
				logger.ErrorException("Got exception.", ex);
			}
		}
	}
}