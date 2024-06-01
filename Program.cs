using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace MailerNamespace
{
	public class MailMainClass
	{
		static void Main(string[] args)
		{
			var smtpClient = new SmtpClient()
			{
				Host = "smtp.gmail.com",
				Port = 587,
				DeliveryMethod = SmtpDeliveryMethod.Network,
				UseDefaultCredentials = false,
				EnableSsl = true,
				Credentials = new NetworkCredential(
												Convert.ToString(ConfigurationManager.AppSettings["SERVER_MAIL_ADDRESS"]),
												Convert.ToString(ConfigurationManager.AppSettings["SERVER_MAIL_PASSWORD"])
												)
			};
			try
			{
				smtpClient.Send("dummy.chetan.mail@gmail.com", "cmehra890@gmail.com", "dummy test", "nothing special");
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}