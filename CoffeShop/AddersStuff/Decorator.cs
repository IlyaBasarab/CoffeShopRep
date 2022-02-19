using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    public abstract class Decorator:Coffe
    {
         protected Coffe coffe;

        public Decorator(Coffe coffe)
            {
            this.coffe = coffe;
            }

    }
}
