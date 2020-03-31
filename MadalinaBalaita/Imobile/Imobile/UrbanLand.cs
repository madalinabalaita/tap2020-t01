namespace Imobile
{
    class UrbanLand:Estate
    {
        public UrbanLand(int sm, int cadastral_nr, string usage) : base(sm, cadastral_nr,usage)
        {

        }
        public override decimal get_price_from_landlord()
        {

            if (sm < 500) price =2500;
            else if (sm >= 500 && cadastral_nr <= 1500) price = 8000;
            else if (sm > 1500) price= 15000;

            return price;
        }
        public override decimal get_poundage()
        {

            decimal poundage1 = 0m;
            decimal poundage2 = 0m;
            decimal poundage3;
            decimal poundage;

            if (sm< 150) throw new SquareMetersException();
            else if (sm < 500) poundage1 = 0.005m;
            else if (sm >= 500 && cadastral_nr <= 1500) poundage1 = 0.007m;
            else if (sm >1500) poundage1 = 0.01m;

            //location of the house
            if( cadastral_nr == 12321) poundage2 = 0.015m;
            else if (cadastral_nr == 13) poundage2 = 0.005m;
            else if (cadastral_nr == 2312) poundage2 = 0.01m;

            //condition of the house

            if (condition == "intravilan") poundage3 = 0.001m;
            else if (condition == "extravilan") poundage3 = 0.005m;
            else throw new UninhabitableException();


            poundage = poundage1 + poundage2 + poundage3;
            return price * poundage;
        }


    }
}
