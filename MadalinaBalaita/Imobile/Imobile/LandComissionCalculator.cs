namespace Imobile
{
    class LandComissionCalculator : ComissionCalculator
    {
        public int sm;//square meters of the estate
        public int cadastral_nr;//the location of the estate:center,somewhere ok,suburbs
        public string usage ;//condition of the estate:really old,old,medium,new


        protected override decimal CalculateComission(Estate estate)
        {
            decimal poundage1 = 0m;
            decimal poundage2 = 0m;
            decimal poundage3=0m;
            decimal poundage;

            if (estate.sm < 500) poundage1 = 0.005m;
            else if (estate.sm >= 500 && estate.sm <= 1500) poundage1 = 0.007m;
            else if (estate.sm > 1500) poundage1 = 0.01m;

            //cadastral number
            if (estate.cadastral_nr == 543345) poundage2 = 0.015m;
            else if (estate.cadastral_nr == 23214) poundage2 = 0.005m;
            else if (estate.cadastral_nr == 61321) poundage2 = 0.01m;

            //condition of the house

            if (estate.usage == "intravilan") poundage3 = 0.001m;
            else if (estate.usage == "extravilan") poundage3 = 0.005m;

            poundage = poundage1 + poundage2 + poundage3;
            return  poundage;
        }


    }
}
