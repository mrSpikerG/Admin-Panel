using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Panel
{
    class Account
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DataTime { get; set; }
        public Account()
        {
            Login = "admin";
            Password = "admin";
            DataTime = new DateTime(2000, 1, 1);
        }

        public Account(string login, string password, DateTime birthday)
        {
            Login = login;
            Password = password;
            DataTime = birthday;
        }

    }
}
