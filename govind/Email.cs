using System;
using System.Net;
using System.Net.Mail;

public static class Email_Work
{
    //Use of Encapsulation
    public static bool SendEmail()
    {
        MailMessage mailMessage = new MailMessage();
        mailMessage.From = new MailAddress("gkmishra2009@gmail.com");
        mailMessage.To.Add("gkmishra2010@email.com");
        mailMessage.Subject = "Welcome";
        mailMessage.Body = "This is test email";

        SmtpClient smtpClient = new SmtpClient();
        smtpClient.Host = "smtp.mywebsitedomain.com";
        smtpClient.Port = 587;
        smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = new NetworkCredential("username", "password");
        smtpClient.EnableSsl = true;

        try
        {
            smtpClient.Send(mailMessage);
            Console.WriteLine("Email Sent Successfully.");
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return false;
        }
     }


}