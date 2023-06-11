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
                        if (maneger.UserLogin(StrLogIn, StrPassword))
                        {
                            User user = maneger.SelectUsers()[strLogin];
                            Settings sett = Settings.GetInstance();
                            sett.SetSettings(user);
                            WinBuilder.ShowMailWindow();
                            CloseWindow();
                        }
                        else
                        {
                            MessageBox.Show("Пароль или логин не верны");
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
                            if(!maneger.UserExist(newUser.Email))
                            {
                                maneger.InsertUser(newUser);
                                MessageBox.Show("Полбзователь создан!");
                            }
                            else
                            {
                                MessageBox.Show("Полбзователь уже существвует!");
                            }
                        }
                    }));
            }
        }

        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);
    }
}

