﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class CoffeFactory
    {

        public Coffe GetCoffe(int type)
        {
            try {
                if (type == 1)
                    return new Arabica();
                else if (type == 2)
                    return new Robusta();
                else if (type == 3)
                    return new Liberica();
            }
            catch( ArgumentException ex)
            { }
            return null;

        }


    }
}
