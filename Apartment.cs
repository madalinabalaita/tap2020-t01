using System;
using System.Collections.Generic;
using System.Text;

namespace Andreea523
{
    class Apartment : RealEstate
    {
        protected override double CalculationCommissionn(double price)
        {
            return price * 2.5 / 100;
        }
    } 
}
