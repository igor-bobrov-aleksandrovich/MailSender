using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
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
