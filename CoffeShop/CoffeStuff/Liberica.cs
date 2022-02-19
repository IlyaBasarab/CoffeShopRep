using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Liberica : Coffe
    {
        public override string GetDescription()
        {
            return "Liberica (27) ";
        }

        public override double GetPrice()
        {
            return 27;
        }
    }
}
