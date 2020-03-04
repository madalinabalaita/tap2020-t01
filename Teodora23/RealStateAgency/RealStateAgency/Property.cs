using System;
using System.Collections.Generic;
using System.Text;

namespace RealStateAgency
{
    public abstract class Property
    {
        public decimal PropertySellingPrice { get; protected set; }

        public decimal Commission { get; protected set; }

        public decimal PropertyPrice { get; protected set; }

        protected void CalculatePropertySellingPrice()
        {
            this.PropertySellingPrice = this.PropertyPrice + this.Commission;
        }

        protected abstract void CalculateCommission();
    }
}
