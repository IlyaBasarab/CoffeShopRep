using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Cart
    {
        AddingsFactory coffeCart;

        public void AddToCart(AddingsFactory coffeToCart)
        {
            coffeCart = coffeToCart;
        }


        public void ShowCart()
        {
            try {
                
                coffeCart.GetDescription();
                Console.WriteLine("Total price:");
                coffeCart.GetPrice();
                Console.WriteLine("");
            }
            catch(NullReferenceException ex)
            { 
                Console.WriteLine(" No coffe in cart");             
            }
        }

    }
}
