using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Administrator
    {
        public string name;


        public User[] users = new User[50];
        int indx = 0;

        public Administrator(string n)
        {
            name = n;
        }


        public void AddUser(User user)
        {
            users[indx]=user;
            indx++;
        }

        public void NotifyUsers(Notification notificator)
        {
            for (int i = 0; i < indx; i++)
            {
               users[i].GetNotification(notificator);
            }


        }





    }
}
