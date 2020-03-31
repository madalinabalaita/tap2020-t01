namespace Imobile
{
    class Flat : Estate
    {   
        public Flat(int sm1,string location1,string condition1) : base(sm1,location1,condition1)
        {

        }
        public override decimal get_price_from_landlord()
        {
 
            if (sm < 43) price = 20000;
            else if (sm >= 43 && sm <= 59) price = 35000;//one room flat
            else if (sm >= 60 && sm <= 69) price = 47000;//two rooms flat
            else if (sm >= 70 && sm <= 90) price =60000;//three rooms flat
            else if (sm > 90) price = 95000 ;//penthouse
            return price;
        }
        public override decimal get_poundage()
        {

            decimal poundage1 = 0m;
            decimal poundage2 = 0m;
            decimal poundage3;
            decimal poundage;

            if (sm < 15) throw new SquareMetersException();
            else if (sm < 43) poundage1 = 0.005m;
            else if (sm >= 43 && sm <= 59) poundage1 = 0.01m;//one room flat
            else if (sm >= 60 && sm <= 69) poundage1 = 0.015m;//two rooms flat
            else if (sm >= 70 && sm <= 90) poundage1 = 0.02m;//three rooms flat
            else if (sm > 90) poundage1 = 0.05m;//penthouse

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
