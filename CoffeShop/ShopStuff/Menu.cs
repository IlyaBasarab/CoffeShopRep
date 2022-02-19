using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{

    class Menu
    {
        
        
        
        public void Start()
        {


            Console.WriteLine("  Ented your id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("  Ented your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("  Ented your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("  Which coffe type would you like to get notification about: ");
            string coffeToNotify = Console.ReadLine();

            User user= new User(id,name, age, coffeToNotify);

            if(coffeToNotify!=null)
            {
                Notification notification = new Notification(coffeToNotify);
                user.GetNotification(notification);
            }
            


            Order order = new Order(id);
            Console.WriteLine("\n");
            bool shopFlag= true;


            while(shopFlag)
            {

               bool addingsFlag = true;
                Console.WriteLine("  Shop \n" +
                    "1. Coffe & Addings. \n" +
                    "2. Cart. \n" +
                    "3. End program. \n"
                    );
                int menuValue = Convert.ToInt32(Console.ReadLine());

                switch (menuValue)
                {
                    case 1:
                        Cart cart = new Cart();
                        CoffeFactory coffeFactory = new CoffeFactory();
                        
                        Console.WriteLine(" Choose coffe: \n" +
                            "1. Arabica \n" +
                            "2. Robusta \n" +
                            "3. Liberica \n"+
                            "4. Nescafe \n");
                        int CoffeValue = Convert.ToInt32(Console.ReadLine());

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

                            Console.WriteLine("In your cart:"+addings.GetAdding(addingValue).GetDescription() +'\n');
                            addings = new AddingsFactory(addings.GetAdding(addingValue));
                            cart.AddToCart(addings);
                            

                            if (addingValue == 5)
                            {
                                
                                Console.WriteLine("goods are added to cart \n");
                                order.AddToOrder(cart);
                                addingsFlag = false;
                            }

                            user.GetOrder(order);
                          
                        }
                        
                        break;

                    case 2:

                        Console.WriteLine('\n'+" User " + user.name + " id: " + user.UserId + " made order: ") ;
                        
                        order.ShowOrder();

                        Console.WriteLine("");
                        break;

                    case 3:
                        shopFlag=false;
                        break;


                }


            }

        }

    }
}
