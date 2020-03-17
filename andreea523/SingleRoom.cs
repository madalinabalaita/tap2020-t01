using System;
using System.Collections.Generic;
using System.Text;

namespace Andreea523
{
    class SingleRoom : RealEstate
    {
        private int v;

        public SingleRoom()
        {
        }

        protected override double CalculationCommissionn(double price)
        {
            return price * 2.0 / 100;
        }
    }
}
