using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{

    class Menu
    {
        CoffeFactory coffeFactory = new CoffeFactory();
        AddingsFactory addings = null;
        
        public void Start()
        {
            bool shopFlag= true;
            bool addingsFlag = true;
            Cart cart = new Cart();



            while(shopFlag)
            {

                Console.WriteLine("  Shop \n" +
                    "1. Coffe & Addings. \n" +
                    "2. Cart. \n" +
                    "3. End program. \n"
                    );
                int menuValue = Convert.ToInt32(Console.ReadLine());

                switch (menuValue)
                {
                    case 1:

                        Console.WriteLine(" Choose coffe: \n" +
                    "1. Arabica \n" +
                    "2. Robusta \n" +
                    "3. Liberica \n");
                        int CoffeValue = Convert.ToInt32(Console.ReadLine());

                        //cart.AddToCart(coffeFactory.GetCoffe(CoffeValue));
                        AddingsFactory addings = new AddingsFactory(coffeFactory.GetCoffe(CoffeValue));
                        cart.AddToCart(addings);
                        while (addingsFlag)
                        {
                            Console.WriteLine(" Choose addings: \n" +
                            "1. Cinnamon \n" +
                            "2. Creamer \n" +
                            "3. Sugar \n" +
                            "4. Syrup \n" +
                            "5. No adding");
                            

                            int addingValue = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("in your cart:"+addings.GetAdding(addingValue).GetDescription() +'\n');
                            addings = new AddingsFactory(addings.GetAdding(addingValue));
                            cart.AddToCart(addings);


                            if (addingValue == 5)
                            {
                                Console.WriteLine("goods are added to cart \n");
                                addingsFlag = false;
                            }

                           

                        }
                        break;

                    case 2:
                       // Console.WriteLine(addings.GetAdding(addingValue).GetDescription());

                        cart.ShowCart();

                        break;

                    case 3:
                        shopFlag=false;
                        break;


                }


            }

        }

    }
}
