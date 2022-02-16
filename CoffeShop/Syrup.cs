using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Syrup : Decorator
    {
        public Syrup(Coffe coffe) : base(coffe)
        {
        }

        public override string GetDescription()
        {
            return coffe.GetDescription() + " + syrup (15)";
        }

        public override double GetPrice()
        {
            return coffe.GetPrice() + 15;
        }
    }
}
