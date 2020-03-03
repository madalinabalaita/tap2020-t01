namespace Imobile
{
    class House :Estate
    {
        public House( decimal price,int sm1,string location1,string condition1) : base(price, sm1, location1,condition1)
        {

        }
       /* public override decimal get_sm_price()
        {  //square metres of the house
           
            return price;
        }*/
        public override decimal get_poundage()
        {
            if (sm < 15) throw new SquareMetersException();
            if (sm < 70) price -= 500m;
            if (sm >= 70 && sm <= 80) price += 1000m;
            else if (sm > 80) price += 5000m;

            //location of the house
           if (location == "center") price += 15000m;
            else if (location == "suburbs") price -= 6000m;
            else if (location == "somewhere ok") price += 10000m;

            //condition of the house
            if (condition == "really old") throw new UninhabitableException();
            if (condition == "old") price -= 2000m;
            else if (condition == "medium") price += 6500m;
            else if (condition == "new") price += 10000m;

            //poundage depending on the price
            if (price < 200000m) return price * 0.035m;
            if (price >= 200000m && price <= 400000m) return price * 0.05m;
            else if (price > 400000m && price <= 500000m) return price * 0.08m;
            else return price * 0.1m;


        }


    }
}
