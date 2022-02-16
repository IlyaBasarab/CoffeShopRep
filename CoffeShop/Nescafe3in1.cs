using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Nescafe3in1 : Coffe
    {
        public override string GetDescription()
        {
           return "Nescafe 3in1";
        }

        public override double GetPrice()
        {
            return 1.5;
        }
    }
}
