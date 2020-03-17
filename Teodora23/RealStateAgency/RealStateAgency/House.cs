using System;
using System.Collections.Generic;
using System.Text;

namespace RealStateAgency
{
    public class House : Property
    {
        public House(decimal propertyPrice)
        {
            this.PropertyPrice = propertyPrice;
            this.CalculateCommission();
            this.CalculatePropertySellingPrice();
        }
        protected override void CalculateCommission()
        {
            this.Commission = this.PropertyPrice * 7 / 100;
        }

    }
}

