using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
  static class Program {
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Data = new Middle();      
      Application.Run(MainWindow = new MainForm());
    }

    internal static MainForm MainWindow;
    internal static LoginForm LoginForm;
    internal static ForgotPasswordForm Forgot;
    internal static Middle Data;
  }
}