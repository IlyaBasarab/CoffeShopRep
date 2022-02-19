using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Cinnamon : Decorator
    {
        public Cinnamon(Coffe coffe) : base(coffe)
        {
        }

        public override string GetDescription()
        {
            return coffe.GetDescription() + " + cinnamon (12.5)";
        }

        public override double GetPrice()
        {
            return coffe.GetPrice() + 12.5;
        }
    }
}
