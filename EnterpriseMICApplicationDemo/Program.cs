using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NLog;

namespace EnterpriseMICApplicationDemo {

	static class Program {

        private static Logger logger = LogManager.GetCurrentClassLogger();
        public delegate void inlineCode();
        public static void logTryCatch(inlineCode code) {
            try {
                code();
            }
            catch (Exception ex) {
                logger.ErrorException("Got exception.", ex);
            }
        }

		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Data = new Middle();
            logTryCatch(delegate() {
                int i = Int32.Parse("1ыва1");
            });
			Application.Run(MainWindow = new MainForm());
		}

		internal static MainForm MainWindow;
		internal static LoginForm LoginForm;
		internal static ForgotPasswordForm Forgot;
		internal static Middle Data;
	}
}