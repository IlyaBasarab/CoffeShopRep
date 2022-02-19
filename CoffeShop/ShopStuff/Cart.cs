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
                Console.WriteLine("Item price:");
                
                Console.WriteLine(coffeCart.GetPrice());
            }
            catch(NullReferenceException ex)
            { 
                Console.WriteLine(" No coffe in cart");             
            }
        }
        public double ShowPrice()
        {

            return coffeCart.GetPrice();

        }

    }
}
