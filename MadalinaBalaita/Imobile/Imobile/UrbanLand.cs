namespace Imobile
{
    class UrbanLand:Estate
    {
        public UrbanLand(int sm1, int cadastral_nr, string usage) : base(sm1, cadastral_nr,usage)
        {

        }
       /* public override decimal get_price_from_landlord()
        {
            if (usage == "intravilan") {
                if (sm < 500) price = 8000;
                else if (sm >= 500 && sm <= 1500) price = 14000;
                else if (sm > 1500) price = 20000;
            }
            else if (usage == "extravilan") {
                if (sm < 500) price = 5000;
                else if (sm >= 500 && sm <= 1500) price = 10000;
                else if (sm > 1500) price = 15000;
            }
            
            return price;
        }
        public override decimal get_poundage()
        {

            decimal poundage1 = 0m;
            decimal poundage2 = 0m;
            decimal poundage3=0m;
            decimal poundage;

          
            if (sm < 500) poundage1 = 0.005m;
            else if (sm >= 500 && sm <= 1500) poundage1 = 0.007m;
            else if (sm >1500) poundage1 = 0.01m;

            //cadastral number
            if( cadastral_nr == 543345) poundage2 = 0.015m;
            else if (cadastral_nr == 23214) poundage2 = 0.005m;
            else if (cadastral_nr == 61321) poundage2 = 0.01m;

            //condition of the house

            if (usage == "intravilan") poundage3 = 0.001m;
            else if (usage == "extravilan") poundage3 = 0.005m;

            poundage = poundage1+poundage2 + poundage3;
            return price * poundage;
        }

    */
    }
}
