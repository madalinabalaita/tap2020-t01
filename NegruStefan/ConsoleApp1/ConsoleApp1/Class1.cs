using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Building
    {
        public decimal price;

        public abstract decimal commission();
        public decimal get_price()
        {
            return price + commission();
        }
    }

    public class House : Building
    {
        public House(decimal price)
        {
            this.price = price;
        }
        public override decimal commission()
        {
            return 0.05m * price;
        }
    }

    public class Apartment : Building
    {
        public Apartment(decimal price)
        {
            this.price = price;
        }
        public override decimal commission()
        {
            return 0.04m * price;
        }
    }

    public class StudioApartment: Building
    {
        public StudioApartment(decimal price)
        {
            this.price = price;
        }

        public override decimal commission()
        {
            return 0.3m * price;
        }
    }
}
