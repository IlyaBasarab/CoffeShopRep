using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class AddingsFactory
    {
        Coffe coffe ;
        public AddingsFactory(Coffe coffe)
        { this.coffe = coffe;
        }

        public Coffe GetAdding(int type)
        {
            if (type == 1)
                return new Cinnamon(coffe);
            else if (type == 2)
                return new Creamer(coffe);
            else if (type == 3)
                return new Sugar(coffe);
            else if (type == 4)
                return new Syrup(coffe);
            else if (type == 5)
                return coffe;
            return null;
        }

        public void GetDescription()
        {
            Console.WriteLine(coffe.GetDescription());
        }
        public void GetPrice()
        {
            Console.WriteLine( coffe.GetPrice());
        }

    }
}
