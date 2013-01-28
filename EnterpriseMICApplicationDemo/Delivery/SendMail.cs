using System;
using System.Net.Mail;
using System.Net.Mime;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Class which is organize connection to send Server
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

		public Middle Middle {
			get {
				throw new System.NotImplementedException();
			}
			set {
			}
		}

		public string Send(string to, string mess) {
			ContentType mimeType = new System.Net.Mime.ContentType("text/html");
			MailMessage message = new MailMessage(FromAddr, to, "", mess);
			AlternateView alternate = AlternateView.CreateAlternateViewFromString(mess, mimeType);
			message.AlternateViews.Add(alternate);
			Log.LogTryCatch(delegate() {
				this.client.Send(message);
			});
			return "Complete!";
		}
	}
}