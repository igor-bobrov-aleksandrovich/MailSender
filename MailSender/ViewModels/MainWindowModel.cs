using MailSender.Commands;
using MailSender.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MailSender.ViewModels
{
    internal class MainWindowModel : INotifyPropertyChanged
    {
        public event EventHandler EventCloseWindow;
        public event PropertyChangedEventHandler? PropertyChanged;
        /*public string CurrentUserLogin
        {
            get { return currentUserLogin; }
            set
            {
                currentUserLogin = value;
                OnPropertyChanged("CurrentUserLogin");
            }
        }*/
        private string strEmail;
        public string StrEmail
        {
            get
            {
                return strEmail;
            }
            set
            {
                strEmail = value;
                OnPropertyChanged();
            }
        }
        private string strFirst;
        public string StrFirst
        {
            get
            {
                return strFirst;
            }
            set
            {
                strFirst = value;
                OnPropertyChanged();
            }
        }
        private string strLast;
        public string StrLast
        {
            get
            {
                return strLast;
            }
            set
            {
                strLast = value;
                OnPropertyChanged();
            }
        }
        private string strMiddle;
        public string StrMiddle
        {
            get
            {
                return strMiddle;
            }
            set
            {
                strMiddle = value;
                OnPropertyChanged();
            }
        }
        private string strRepPassword;
        public string StrRepPassword
        {
            get
            {
                return strRepPassword;
            }
            set
            {
                strRepPassword = value;
                OnPropertyChanged();
            }
        }
        private string strDot;
        public string StrDot
        {
            get
            {
                return strDot;
            }
            set
            {
                strDot = value;
                OnPropertyChanged();
            }
        }
        private DateTime bd = DateTime.Now;
        public DateTime Bd
        {
            get
            {
                return bd;
            }
            set
            {
                bd = value;
                OnPropertyChanged();
            }
        }

        private string strLogin;
        public string StrLogIn
        {
            get
            {
                return strLogin;
            }
            set
            {
                strLogin = value;
                OnPropertyChanged();
            }
        }
        private string strPassword;
        public string StrPassword
        {
            get
            {
                return strPassword;
            }
            set
            {
                strPassword = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
        private BaseCommands logIn;
        public BaseCommands LogIn
        {
            get
            {
                return logIn ??
                    (logIn = new BaseCommands(obj =>
                    {
                        DBmaneger maneger = DBmaneger.GetInstance();
                        //if (maneger.UserExist(StrLogIn, StrPassword))
                        {
                            WinBuilder.ShowMailWindow();
                            CloseWindow();
                        }
                    }));
            }
        }
        private BaseCommands regUser;
        public BaseCommands RegUser
        {
            get
            {
                return regUser ??
                    (regUser = new BaseCommands(obj =>
                    {
                        DBmaneger maneger = DBmaneger.GetInstance();
                        int age = (int)(DateTime.Now - bd).TotalDays/365;
                        if(strEmail != "" && strFirst!="" && StrLast!="" && strMiddle!="" && strPassword != "" && strPassword == strRepPassword)
                        {
                            User newUser = new User(strEmail, strFirst, StrLast, strMiddle, age, strPassword);
                            maneger.InsertUser(newUser);
                        }
                    }));
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
