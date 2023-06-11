using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;

namespace MailSender.ViewModels
{
    internal class MailSenderModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler EventCloseWindow;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        private string strTo;
        public string StrTo
        {
            get
            {
                return strTo;
            }
            set
            {
                strTo = value;
                OnPropertyChanged();
            }
        }
        private string strMessage;
        public string StrMessage
        {
            get
            {
                return strMessage;
            }
            set
            {
                strMessage = value;
                OnPropertyChanged();
            }
        }
        private string strTheme;
        public string StrTheme
        {
            get
            {
                return strTheme;
            }
            set
            {
                strTheme = value;
                OnPropertyChanged();
            }
        }
        private string strFrom;
        public string StrFrom
        {
            get
            {
                return strFrom;
            }
            set
            {
                strFrom = value;
                OnPropertyChanged();
            }
        }
        
        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);
    }
}
/*
 using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;


EmailService service = new EmailService();
await service.SendEmailAsync("igor.bobrov.aleksandrovich@gmail.com", "gmailll", ")))");
internal class EmailService
{
    public async Task SendEmailAsync(string email, string subject, string message)
    {
        using var emailMessage = new MimeMessage();

        emailMessage.From.Add(new MailboxAddress("Администрация сайта", "igor.bobrov.aleksandrovichgmail@internet.ru"));
        emailMessage.To.Add(new MailboxAddress("", email));
        emailMessage.Subject = subject;
        emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
        {
            Text = message
        };

        using (var client = new SmtpClient())
        {
            await client.ConnectAsync("smtp.mail.ru", 25, false);
            await client.AuthenticateAsync("igor.bobrov.aleksandrovichgmail@internet.ru", "B6nQAwQxpXPYzGBe3x2W");
            await client.SendAsync(emailMessage);

            await client.DisconnectAsync(true);
        }
    }
}
 */