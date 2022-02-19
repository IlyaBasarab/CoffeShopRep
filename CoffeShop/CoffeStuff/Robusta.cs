using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Robusta : Coffe
    {
        public override string GetDescription()
        {
            return "Robusta (16) ";
        }

        public override double GetPrice()
        {
            return 16;
        }
    }
}
