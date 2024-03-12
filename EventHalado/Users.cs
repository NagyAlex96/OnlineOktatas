using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHalado
{
    internal class Users
    {
        public Users(string userName, string passWord, bool isAdmin)
        {
            UserName = userName;
            PassWord = passWord;
            IsAdmin = isAdmin;
        }

        public string UserName { get; private set; }
        public string PassWord { get; private set; }
        public double Salary { get; private set; }
        public bool IsAdmin { get; private set; }
    }
}
