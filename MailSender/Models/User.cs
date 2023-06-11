using MailSender.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace MailSender.Models
{
    internal class User
    {
        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; private set; }
        public long Age { get; private set; }
        public string Password { get; private set; }

        public User(string Email, string FirstName, string LastName, string MiddleName, long Age, string Password)
        {
            this.Email = Email;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.MiddleName = MiddleName;
            this.Age = Age;
            this.Password = Password;
        }

    }
}

