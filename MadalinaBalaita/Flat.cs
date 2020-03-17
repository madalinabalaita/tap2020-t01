namespace Imobile
{
    class Flat : Estate
    {   
        public Flat(decimal price1,int sm1,string location1,string condition1) : base(price1,sm1,location1,condition1)
        {

        }
        public override decimal get_price_to_pay()
        {   //squares metres
            if (sm < 15) throw new SquareMetersException();
            else if (sm < 43) price += 500m;
            else if (sm >= 43 && sm <= 59) price += 1000m;//apartament cu o camera
            else if (sm >= 60 && sm <= 69) price += 1750m;//apartament cu 2 camere
            else if (sm >= 70 && sm <= 90) price += 2250m;//apartament cu 3 camere

            //location of the flat
            if (location == "center") price += 5000m;
            else if (location == "suburbs") price -= 2000m;
            else if (location == "somewhere ok") price += 1000m;

            //condition of the flat
            if (condition == "really old") throw new UninhabitableException();
            else if (condition == "old") price -= 1000m;
            else if (condition == "medium") price += 2000m;
            else if (condition == "new") price += 5000m;
            return price;
        }
        public override decimal get_poundage()
        {  

            //poundage depending on the price
            if (price < 30000m) return price * 0.035m;
            if (price >= 30000m && price <= 50000m) return price * 0.05m;
            else if (price > 50000m && price <= 70000m) return price * 0.08m;
            return price * 0.1m;

        }

    }
}
