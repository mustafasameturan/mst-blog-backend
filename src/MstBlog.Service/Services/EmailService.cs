using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;
using MstBlog.Core.Domain;
using MstBlog.Core.Services;

namespace MstBlog.Service.Services;

public class EmailService : IEmailService
{
    private string _smtpServer;
    private string _smtpPort;
    private string _smtpUsername;
    private string _smtpPassword;
    
    public EmailService(IConfiguration configuration)
    {
        _smtpServer = configuration[SettingNames.SmtpServer];
        _smtpPort = configuration[SettingNames.SmtpPort];
        _smtpUsername = configuration[SettingNames.SmtpUsername];
        _smtpPassword = configuration[SettingNames.SmtpPassword];
    }
    
    public void SendEmail(string from, string to, string subject, string body)
    {
        using (var client = new SmtpClient(_smtpServer, Convert.ToInt32(_smtpPort)))
        {
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(_smtpUsername, _smtpPassword);
            client.EnableSsl = true;

            var message = new MailMessage(from, to, subject, body);
            
            client.Send(message);
        }
    }
}