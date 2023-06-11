using MailSender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    class Settings
    {
        public string email { get; private set; }
        public string lastName { get; private set; }
        private static Settings? _instance = null;
        private Settings() { }
        public static Settings GetInstance()
        {
            if(_instance == null)
                _instance = new Settings();
            return _instance;
        }
        public void SetSettings(User user)
        {
            email = user.Email;
            lastName = user.LastName;
        }
    }
}
