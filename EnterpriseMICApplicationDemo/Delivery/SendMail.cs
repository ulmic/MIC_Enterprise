using System;
using System.Net.Mail;
using System.Net.Mime;

namespace EnterpriseMICApplicationDemo {
  public class SendMail {
    SmtpClient client;
    string smtpHost = "smtp.yandex.ru";
    int smtpPort = 25;
    string smtpUserName = "aelaa@yandex.ru";
    string smtpUserPass = "4815162342";
    string FromAddr = "aelaa@yandex.ru";

    public SendMail() {
      this.client = new SmtpClient(smtpHost, smtpPort);
      this.client.Credentials = new System.Net.NetworkCredential(smtpUserName, smtpUserPass);
    }

    public string Send(string to, string mess) {
      ContentType mimeType = new System.Net.Mime.ContentType("text/html");
      MailMessage message = new MailMessage(FromAddr, to, "", mess);
      AlternateView alternate = AlternateView.CreateAlternateViewFromString(mess, mimeType);
      message.AlternateViews.Add(alternate);
      try {
        this.client.Send(message);
        return "Completed!";
      } catch (SmtpException ex) {
        return ("Error! " + ex.InnerException.Message.ToString());
      }
    }
  }
}