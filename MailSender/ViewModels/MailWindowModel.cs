using MailSender.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.ViewModels
{
    internal class MailWindowModel : INotifyPropertyChanged
    {
        public event EventHandler EventCloseWindow;
        public event PropertyChangedEventHandler? PropertyChanged;

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
                        WinBuilder.ShowMailWindow();
                        CloseWindow();
                    }));
            }
        }
        private BaseCommands writeMessage;
        public BaseCommands WriteMessage
        {
            get
            {
                return writeMessage ??
                    (writeMessage = new BaseCommands(obj =>
                    {
                        DBmaneger maneger = DBmaneger.GetInstance();
                        {
                            WinBuilder.ShowMailSenderWindow();
                            CloseWindow();
                        }
                    }));
            }
        }
        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);
    }
}
