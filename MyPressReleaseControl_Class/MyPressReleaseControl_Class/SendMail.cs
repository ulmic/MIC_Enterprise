using System;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
  public class SendMail {
    SmtpClient client;
    string smtpHost = "smtp.mail.ru";
    int smtpPort = 25;
    string smtpUserName = "logger.mic@mail.ru";
    string smtpUserPass = "ilovemic2012it";
    string FromAddr = "logger.mic@mail.ru";

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
        MessageBox.Show("yes");
        return "Completed!";
      } catch (SmtpException ex) {
        return ("Error! " + ex.InnerException.Message.ToString());
      }
    }

    public string Send(string[] addresses, string mess)
    {
        ContentType mimeType = new System.Net.Mime.ContentType("text/html");
        MailMessage message = new MailMessage();
        message.From = new MailAddress(FromAddr);
        foreach (string address in addresses)
        {
            message.To.Add(address);
        }

        AlternateView alternate = AlternateView.CreateAlternateViewFromString(mess, mimeType);
        message.AlternateViews.Add(alternate);
        try
        {
            this.client.Send(message);
            MessageBox.Show("yes");
            return "Completed!";
        }
        catch (SmtpException ex)
        {
            return ("Error! " + ex.InnerException.Message.ToString());
        }
    }
  }
}