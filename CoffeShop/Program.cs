using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Start();



            //Cart cart = new Cart();

            //CoffeFactory factory = new CoffeFactory();

            //Coffe coffe = factory.GetCoffe(1);


            //AddingsFactory addings = new AddingsFactory(coffe);

            //addings.GetAdding(1).GetDescription();
            //addings.GetAdding(2).GetPrice();

            //Console.WriteLine(addings.GetAdding(1).GetDescription() +'\n'+ addings.GetAdding(2).GetPrice());
        }
    }
}
