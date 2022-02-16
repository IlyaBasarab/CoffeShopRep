using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Creamer : Decorator
    {
        public Creamer(Coffe coffe) : base(coffe)
        {
        }

        public override string GetDescription()
        {
            return coffe.GetDescription() + " + creamer (12)";
        }

        public override double GetPrice()
        {
            return coffe.GetPrice() + 12;
        }
    }
}
