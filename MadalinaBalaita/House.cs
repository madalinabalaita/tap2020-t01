namespace Imobile
{
    class House :Estate
    {
        public decimal price_added;
        public House( decimal price,int sm1,string location1,string condition1) : base(price, sm1, location1,condition1)
        {

        }
        public override decimal get_price_to_pay()
        { 
            if (sm < 15) throw new SquareMetersException();
            else if (sm < 70) price -= 500m;
            else if (sm >= 70 && sm <= 80) price += 1000m;
            else if (sm > 80) price += 5000m;

            //location of the house
            if (location == "center") price += 15000m;
            else if (location == "suburbs") price -= 6000m;
            else if (location == "somewhere ok") price += 10000m;

            //condition of the house
            if (condition == "really old") throw new UninhabitableException();
            else if (condition == "old") price -= 2000m;
            else if (condition == "medium") price += 6500m;
            else if (condition == "new") price += 10000m;

            price_added = price;
            return price;
        }
        public override decimal get_poundage()
        {
            if (price < 150000m) return price * 0.035m;
            if (price >= 15000m && price <= 300000m) return price * 0.05m;
            else if (price > 300000m && price <= 500000m) return price * 0.08m;
            return price * 0.1m;

        }


    }
}
