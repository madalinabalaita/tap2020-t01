namespace Imobile
{
    class Studio : Estate
    {
        public Studio(decimal  price1, int sm1,  string location1,string condition1) : base(price1,sm1, location1,condition1)
        {

        }
        public override decimal get_poundage()
        {  
            
            //squares metres
            if (sm < 15) throw new SquareMetersException();
             if (sm < 30) price -= 500m;
            else price += 500m;
            
            //location of the studio
            if (location == "center") price += 3000m;
            else if (location == "suburbs") price -= 500m;
            else if (location == "somewhere ok") price += 1000m;

            //condition of the studio
            if (condition == "really old") throw new UninhabitableException();
            if (condition == "old") price -= 1000m;
            else if (condition == "medium") price += 2000m;
            else if (condition == "new") price += 5000m;

            //poundage depending on the price
            if (price < 15000m) return price * 0.035m;
            if (price >= 15000m && price <= 30000m) return price * 0.05m;
            else if (price > 30000m && price <= 40000m) return price * 0.08m;
            return price * 0.1m;

        }
    }
}
