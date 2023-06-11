using MailSender.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;

namespace MailSender
{
    class DBmaneger
    {
        private static DBmaneger? maneger = null;
        private DBmaneger() 
        { 
            
        }
        public static DBmaneger GetInstance()
        {
            if (maneger == null)
            {
                maneger = new DBmaneger();
            }
            return maneger;
        }
        public Dictionary<string, User> SelectUsers()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnString()))
            {
                List<User> users = conn.Query<User>("SELECT * FROM [User]").ToList();
                return users.ToDictionary(keySelector: u => u.Email, elementSelector: m => m);
            }
        }
        public void InsertUser(User user)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnString()))
            {
                conn.Execute("INSERT INTO [User] (Email, FirstName, LastName, MiddleName, Age, Password) " +
                    "VALUES(@Email, @FirstName, @LastName, @MiddleName, @Age, @Password)", user);
            }
        }
        public string LoadConnString(string id = "default")
        {
            return "Data Source=.\\User.db; Version=3";
        }
        public bool UserLogin(string login, string password)
        {
            Dictionary<string, User> users = SelectUsers();
            if(login != null && login.Length>0)
                return users.ContainsKey(login) && users[login].Password == password;
            return false;
        }
        public bool UserExist(string login)
        {
            Dictionary<string, User> users = SelectUsers();
            return users.ContainsKey(login) && login!=null;
        }
    }
}
