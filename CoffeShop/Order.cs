using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Order
    {
        
        Cart[] carts = new Cart[5];
        int indx = 0;
        double price=0;


        public void AddToOrder(Cart cart)
        {
            carts[indx] = cart;
            indx++;

        }

        public void ShowOrder()
        {
            foreach (Cart cart in carts)
            {
                if (cart != null)
                {
                    cart.ShowCart();
                    price = price + cart.ShowPrice();
                }
                
            }

            Console.Write("Total price: " + price);


        }


    }
}
