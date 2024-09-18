using System.Net;
using System.Net.Mail;

namespace PanelinhasDoGallo.Services;

public interface EmailSender : IEmailSender
{
    public async Task SendEmailAsync(string emailAddress, string subject, string htmlMessage)
    {
        var mail = "gcook.app@outlook.com";
        var pw = "QV3E4khpZBEcL7K";
    }
        
}
