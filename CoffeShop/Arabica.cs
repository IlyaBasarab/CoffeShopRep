﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class Arabica : Coffe
    {
        public override string GetDescription()
        {
            return " Arabica ";
        }

        public override double GetPrice()
        {

            return 35.5;
        }
    }
}
