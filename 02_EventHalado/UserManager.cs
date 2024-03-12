using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EventHalado
{
    internal class UserChangedEventArgs<T> : EventArgs
    {
        public UserChangedEventArgs(T oldUser, T newUser)
        {
            this.oldUser = oldUser;
            this.newUser = newUser;
        }

        public T oldUser { get;  }
        public T newUser { get; }
    }

    internal class UserManager
    {

        public event EventHandler<UserChangedEventArgs<Users>> UserChanged;
        public UserManager(int size)
        {
            userArray = new Users[size];
        }

        int index = 0;
        Users[] userArray;


        public void AddUser(Users user)
        {
            userArray[index++] = user;
        }

        public void ChangeUser(Users user, int index)
        {
            var old = userArray[index];
            userArray[index] = user;
            UserChanged?.Invoke(this, new UserChangedEventArgs<Users>(old, user));
        }

    }
}
