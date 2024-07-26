using System.Net.Mail;

namespace MySMTP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MailSend.Send();
        }
    }

    public class MailSend
    {
        public static void Send()
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = true;
                mail.From = new MailAddress("murat_b@mail.ru");
                mail.To.Add("dinash6145@mail.ru");
                mail.Subject = "test666";
                mail.Body = "body666";
                using (System.Net.Mail.SmtpClient server = new System.Net.Mail.SmtpClient("smtp.mail.ru", 587))
                {
                    server.UseDefaultCredentials = false;
                    server.Credentials = new System.Net.NetworkCredential("murat_b@mail.ru", "");
                    server.EnableSsl = true;
                    server.DeliveryMethod = SmtpDeliveryMethod.Network;
                    server.Send(mail);
                    server.Dispose();
                    Console.WriteLine("Send");
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}