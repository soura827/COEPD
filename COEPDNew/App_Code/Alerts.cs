using System.IO;
using System.Net;
using System.Net.Mail;

namespace BusinessLayer
{
    public partial class Alerts
    {
        //public static void SendErrorMail(string toEmail, string subject, string body)
        //{

        //    try
        //    {
        //        //System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
        //        //msg.From = new System.Net.Mail.MailAddress("adminnoreply@coepdglobal.com");
        //        //msg.To.Add(toEmail);
        //        //msg.Subject = subject.Replace("\n", "").Replace("\r", "");
        //        //msg.Body = body;
        //        //msg.IsBodyHtml = true;
        //        //msg.Priority = System.Net.Mail.MailPriority.Normal;
        //        //msg.IsBodyHtml = true;
        //        //SmtpClient smtpclient = new SmtpClient();
        //        //smtpclient.Host = "webmail.coepdglobal.com";
        //        //smtpclient.EnableSsl = false;
        //        //smtpclient.UseDefaultCredentials = false;
        //        ////smtpclient.Port = 8025;
        //        //smtpclient.Port = 465;
        //        //smtpclient.Credentials = new System.Net.NetworkCredential("adminnoreply@coepdglobal.com", "Y?e874xp");
        //        //smtpclient.Send(msg);

        //        System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
        //        //msg.From = new System.Net.Mail.MailAddress("adminnoreply@coepd.com");
        //        msg.From = new System.Net.Mail.MailAddress("timesheetnoreply@coepd.com");
        //        msg.To.Add(toEmail);
        //        msg.Subject = subject.Replace("\n", "").Replace("\r", "");
        //        msg.Body = body;
        //        msg.IsBodyHtml = true;
        //        msg.Priority = System.Net.Mail.MailPriority.Normal;
        //        SmtpClient smtpclient = new SmtpClient();
        //        smtpclient.Host = "relay-hosting.secureserver.net";
        //        smtpclient.Port = 25;
        //        smtpclient.UseDefaultCredentials = false;
        //        //smtpclient.Credentials = new System.Net.NetworkCredential("adminnoreply@coepd.com", "g9G2T%YP");
        //        smtpclient.Credentials = new System.Net.NetworkCredential("timesheetnoreply@coepd.com", "E=mW>9L*");
        //        smtpclient.Send(msg);
        //    }
        //    catch (SmtpException ex)
        //    {
        //        string msg = "Mail cannot be sent:";
        //        msg += ex.Message;
        //        throw new Exception(msg);
        //    }

        //}

        public static void SendEmail(string receipient, string subject, string body)
        {
            // Set the SMTP server and port for Gmail
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            // Enable SSL encryption for secure communication
            smtpClient.EnableSsl = true;

            // Set the credentials for authentication
            smtpClient.Credentials = new NetworkCredential("developer2@coepd.com", "Manuguru123#");

            // Create a new email message
            MailMessage message = new MailMessage();
            message.From = new MailAddress("developer2@coepd.com");
            message.To.Add(receipient);
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;
            // Send the email
            smtpClient.Send(message);
        }

        //public static void SendErrorMail(string receipient,string subject, string body)
        //{
        //    //string senderEmail = "timesheetnoreply@coepd.com";
        //    //string senderPassword = "E=mW>9L*";
        //    //MailMessage message = new MailMessage(senderEmail, receipient, subject, body);
        //    //SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
        //    //smtpClient.Host = "relay-hosting.secureserver.net";
        //    //smtpClient.EnableSsl = true;
        //    //smtpClient.UseDefaultCredentials = true;
        //    //smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
        //    //try
        //    //{
        //    //    smtpClient.Send(message);
        //    //}
        //    //catch(SmtpException ex)
        //    //{
        //    //    string errorMessage = "Mail can not be Sent:";
        //    //    errorMessage += ex.Message;
        //    //    throw new Exception(errorMessage);

        //    //}

        //    // Set the SMTP server and port for Gmail
        //    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

        //    // Enable SSL encryption for secure communication
        //    smtpClient.EnableSsl = true;

        //    // Set the credentials for authentication
        //    smtpClient.Credentials = new NetworkCredential("developer1@coepd.com", "@123@Sateesh");

        //    // Create a new email message
        //    MailMessage message = new MailMessage();
        //    message.From = new MailAddress("developer1@coepd.com");
        //    message.To.Add(receipient);
        //    message.Subject = subject;
        //    message.Body = body;
        //    message.IsBodyHtml = true;
        //    // Send the email
        //    smtpClient.Send(message);
        //}
        //public static void SendParticipantMail(string toEmail, string subject, string body)
        //{

        //    try
        //    {
        //        System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
        //        msg.From = new System.Net.Mail.MailAddress("supportdesknoreply@coepd.com");
        //        msg.To.Add(toEmail);
        //        msg.Subject = subject.Replace("\n", "").Replace("\r", "");
        //        msg.Body = body;
        //        msg.IsBodyHtml = true;
        //        msg.Priority = System.Net.Mail.MailPriority.Normal;

        //        //SmtpClient smtpclient = new SmtpClient();
        //        //smtpclient.Host = "webmail.coepdglobal.com";
        //        //smtpclient.EnableSsl = false;
        //        //smtpclient.UseDefaultCredentials = false;
        //        //smtpclient.Port = 465;
        //        //smtpclient.Credentials = new System.Net.NetworkCredential("supportdesk@coepdglobal.com", "#1t7j9Qa");
        //        //smtpclient.Send(msg);

        //        SmtpClient smtpclient = new SmtpClient();
        //        smtpclient.Host = "relay-hosting.secureserver.net";
        //        smtpclient.Port = 25;
        //        smtpclient.UseDefaultCredentials = false;
        //        smtpclient.Credentials = new System.Net.NetworkCredential("supportdesknoreply@coepd.com", "eKPr7<y6");
        //        smtpclient.Send(msg);
        //    }
        //    catch (SmtpException ex)
        //    {
        //        string msg = "Mail cannot be sent:";
        //        msg += ex.Message;
        //        throw new Exception(msg);
        //    }

        //}
        //public static void SendEmployeeMail(string toEmail, string subject, string body)
        //{

        //    try
        //    {
        //        System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
        //        msg.From = new System.Net.Mail.MailAddress("webhelpnoreply@coepd.com");
        //        msg.To.Add(toEmail);
        //        msg.Subject = subject.Replace("\n", "").Replace("\r", "");
        //        msg.Body = body;
        //        msg.IsBodyHtml = true;
        //        msg.Priority = System.Net.Mail.MailPriority.Normal;

        //        //SmtpClient smtpclient = new SmtpClient();
        //        //smtpclient.Host = "webmail.coepd.in";
        //        //smtpclient.EnableSsl = false;
        //        //smtpclient.UseDefaultCredentials = false;
        //        //smtpclient.Port = 8025;
        //        //smtpclient.Credentials = new System.Net.NetworkCredential("webhelpnoreply@coepd.in", "4Kbkn%56");
        //        //smtpclient.Send(msg);

        //        SmtpClient smtpclient = new SmtpClient();
        //        smtpclient.Host = "relay-hosting.secureserver.net";
        //        smtpclient.Port = 25;
        //        smtpclient.UseDefaultCredentials = false;
        //        smtpclient.Credentials = new System.Net.NetworkCredential("webhelpnoreply@coepd.com", "Q>PqT9mg");
        //        smtpclient.Send(msg);
        //    }
        //    catch (SmtpException ex)
        //    {
        //        string msg = "Mail cannot be sent:";
        //        msg += ex.Message;
        //        throw new Exception(msg);
        //    }

        //}
        //public static void SendHelpdeskMail(string toEmail, string subject, string body)
        //{

        //    try
        //    {
        //        System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
        //        msg.From = new System.Net.Mail.MailAddress("helpdesknoreply@coepd.com");
        //        msg.To.Add(toEmail);
        //        msg.Subject = subject.Replace("\n", "").Replace("\r", "");
        //        msg.Body = body;
        //        msg.IsBodyHtml = true;
        //        msg.Priority = System.Net.Mail.MailPriority.Normal;

        //        //SmtpClient smtpclient = new SmtpClient();
        //        //smtpclient.Host = "webmail.coepdglobal.com";
        //        //smtpclient.EnableSsl = false;
        //        //smtpclient.UseDefaultCredentials = false;
        //        //smtpclient.Port = 8025;
        //        //smtpclient.Credentials = new System.Net.NetworkCredential("helpdesk@coepdglobal.com", "969#ryfK");
        //        //smtpclient.Send(msg);

        //        SmtpClient smtpclient = new SmtpClient();
        //        smtpclient.Host = "relay-hosting.secureserver.net";
        //        smtpclient.Port = 25;
        //        smtpclient.UseDefaultCredentials = false;
        //        smtpclient.Credentials = new System.Net.NetworkCredential("helpdesknoreply@coepd.com", "b5Fn>Fa>");
        //        smtpclient.Send(msg);
        //    }
        //    catch (SmtpException ex)
        //    {
        //        string msg = "Mail cannot be sent:";
        //        msg += ex.Message;
        //        throw new Exception(msg);
        //    }

        //}

        public static void SendSMS(string toMobile, string Message)
        {
            WebClient client = new WebClient();
            Stream s = client.OpenRead(string.Format("http://nimbusit.co.in/api/swsend.asp?username=t1chandushekar&password=50360014&sender=TSTReg&sendto={0}&message={1}", toMobile, Message));
            StreamReader reader = new StreamReader(s);
            string result = reader.ReadToEnd();
        }
    }
}
