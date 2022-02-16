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
                Console.WriteLine("In your cart:\n");
                coffeCart.GetDescription();
                Console.WriteLine("Total price:\n");
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
