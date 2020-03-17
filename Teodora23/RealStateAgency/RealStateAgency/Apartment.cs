using System;
using System.Collections.Generic;
using System.Text;

namespace RealStateAgency
{
    class Apartment : Property
    {
        public Apartment(decimal propertyPrice)
        {
            this.PropertyPrice = propertyPrice;
            this.CalculateCommission();
            this.CalculatePropertySellingPrice();
        }
        protected override void CalculateCommission()
        {
            this.Commission = this.PropertyPrice * 5 / 100;
        }

    }
}