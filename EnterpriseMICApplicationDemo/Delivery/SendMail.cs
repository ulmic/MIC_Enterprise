using System;
using System.Net.Mail;
using System.Net.Mime;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Class which is organize connection to send server
	/// </summary>
	public class SendMail {
		private SmtpClient client;
		private string smtpHost = "smtp.yandex.ru";
		private int smtpPort = 25;
		private string smtpUserName = "aelaa@yandex.ru";
		private string smtpUserPass = "4815162342";
		private string FromAddr = "aelaa@yandex.ru";

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