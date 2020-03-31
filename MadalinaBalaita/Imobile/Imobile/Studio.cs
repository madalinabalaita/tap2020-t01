namespace Imobile
{
    class Studio : Estate
    {
        public Studio( int sm1,  string location1,string condition1) : base(sm1, location1,condition1)
        {

        }
        public override decimal get_price_from_landlord()
        {
             if (sm >= 15 && sm <= 30) price =15000;
            else if (sm > 30) price=22000;
            return price;
        }
        public override decimal get_poundage()
        {

            decimal poundage1 = 0m;
            decimal poundage2 = 0m;
            decimal poundage3;
            decimal poundage;

            if (sm < 15) throw new SquareMetersException();
            else if (sm>=15 && sm<=30) poundage1 = 0.005m;
            else if (sm >30) poundage1 = 0.01m;
         

            //location of the house
            if (location == "center") poundage2 = 0.015m;
            else if (location == "suburbs") poundage2 = 0.005m;
            else if (location == "somewhere ok") poundage2 = 0.01m;

            //condition of the house

            if (condition == "old") poundage3 = 0.001m;
            else if (condition == "medium") poundage3 = 0.005m;
            else if (condition == "new") poundage3 = 0.01m;
            else throw new UninhabitableException();


            poundage = poundage1 + poundage2 + poundage3;
            return price * poundage;
        }

    }
}
