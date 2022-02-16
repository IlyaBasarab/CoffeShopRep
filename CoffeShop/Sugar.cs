using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Sugar : Decorator
    {
        public Sugar(Coffe coffe) : base(coffe)
        {
        }

        public override string GetDescription()
        {
            return coffe.GetDescription() + " + sugar (5)";
        }

        public override double GetPrice()
        {
            return coffe.GetPrice() +5;
        }
    }
}
