using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1
{
  
    public abstract class RealEstate
    {
        protected decimal price;
        protected String location;
        protected RealEstate(decimal price,String location)
        {
            this.price = price;
            this.location = location;
        }
        public decimal CalculateCommission(decimal amount, decimal feePercentage)
        {
            return amount * feePercentage / 100;
        }
        public abstract decimal Commission();
       
    }
    public class House: RealEstate
    {
        public House(decimal price,String location) : base(price,location) { }
        
        public override decimal Commission()
        {
            decimal finalprice;
            if (price < 10000m && location == "periphery") //euro
                finalprice = price + CalculateCommission(price, 1m);
            else if (price < 10000m && location == "center")
                finalprice = price + CalculateCommission(price, 1.8m);
            else if (price < 20000m && location == "periphery")
                finalprice = price + CalculateCommission(price, 1.6m);
            else if (price < 20000m && location == "center")
                finalprice = price + CalculateCommission(price, 1.9m);
            else if (price < 30000m && location == "periphery")
                finalprice = price + CalculateCommission(price, 2m);
            else if (price < 30000m && location == "center")
                finalprice = price + CalculateCommission(price, 2.5m);
            else finalprice = price + CalculateCommission(price, 3m);
            return finalprice;
        }
    }
    public class Apartment: RealEstate
    {
        public Apartment(decimal price,String location) : base(price, location) { }
        public override decimal Commission()
        {
            decimal finalprice;
            if (location == "periphery")
                finalprice = price + CalculateCommission(price, 1.5m);
            else finalprice = price + CalculateCommission(price, 2m);
            return finalprice;
        }
        
    }
    public class Singleroom : RealEstate
    {
        public Singleroom(decimal price, String location) : base(price, location) { }
        public override decimal Commission()
        {
            decimal finalprice;
            if (location == "periphery")
                finalprice = price + CalculateCommission(price, 1.1m);
            else finalprice = price + CalculateCommission(price, 1.2m);
            return finalprice;
        }

    }
}
 
