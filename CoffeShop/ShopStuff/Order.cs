using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Order
    {
        public int Id;

        
        Cart[] carts = new Cart[50];
        int indx = 0;
        double price=0;

        public Order(int id)
        {
            this.Id = id;
        }


        public void AddToOrder(Cart cart)
        {
            carts[indx] = cart;
            indx++;

        }

        public void ShowOrder()
        {
            

            for(int i=0; i<indx; i++)
            {
                carts[i].ShowCart();
                price=price+ carts[i].ShowPrice();

            }

            Console.Write("Total price: " + price+'\n');
        }


        public double GetTotalPrice()
        {
            return price;
        }


    }
}
