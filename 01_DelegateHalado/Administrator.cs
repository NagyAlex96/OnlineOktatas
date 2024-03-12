using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DelegateHalado
{
    internal class Administrator
    {
        public delegate void UserKiiratasDelegate(Users user);
        List<Users> administrators;

        public Administrator()
        {
            administrators = new List<Users>();
        }

        public void AddUser(Users user)
        {
            administrators.Add(user);
        }

        public void Kiiratas(UserKiiratasDelegate userKiiratasDelegate)
        {
            foreach (var user in administrators)
            {
                userKiiratasDelegate?.Invoke(user);
            }
        }

    }
}
