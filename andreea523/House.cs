using System;
using System.Collections.Generic;
using System.Text;

namespace Andreea523
{
    class House : RealEstate
    {
        protected override double CalculationCommissionn(double price)
        {
            return price * 3/ 100;
        }
    }
}
