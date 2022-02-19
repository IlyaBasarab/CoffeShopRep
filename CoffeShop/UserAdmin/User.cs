using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class User
    {
        public int UserId;
        public string name;
        public int age;
        public string coffeLiked;

        private Order userOrder;

        public User(int UId, string n, int a, string coffeToNotify)
        {
            UserId = UId;
            name = n;
            age = a;
            coffeLiked = coffeToNotify;
        }



        public string GetCoffeNotifier()
        {

            return coffeLiked;
        }



        public void GetOrder(Order order)
        {
            userOrder = order;
        }

        public void GetNotification( Notification notification)
        {
            if (notification.preferense==coffeLiked)
            {
                Console.WriteLine(" User  " + name + " userid " + UserId + " got notification for coffe " + coffeLiked);
            }


        }


    }
}
