using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EnterpriseMICApplicationDemo {
  public class ForgotPassword {
    public ForgotPassword() { }

    static private string imposeMailText(string login, string password) {
      return "Ваш логин: " + login + "<br/>Ваш пароль: " + password + "";
    }

    static public void SendReminder(string email) {
      string[] emails = AnyCatches.ReadAllLines(@"email.txt", System.Text.Encoding.Default);
      if (AnyCatches.IfThereIsNot(emails)) {
        return;
      }
      if (emails.Any(e => e == email)) {
        User sendUser = new User(emails.Single(e => e == email));
        SendMail s = new SendMail();
        s.Send(emails.Single(e => e == email), imposeMailText(sendUser.Login, sendUser.Password));
      }
    }
  }
}