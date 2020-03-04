using System;
using System.Collections.Generic;
using System.Text;

namespace RealStateAgency
{
    class SingleRoom : Property
    {
        public SingleRoom(decimal propertyPrice)
        {
            this.PropertyPrice = propertyPrice;
            this.CalculateCommission();
            this.CalculatePropertySellingPrice();
        }
        protected override void CalculateCommission()
        {
            this.Commission = this.PropertyPrice * 3 / 100;
        }

    }
}
