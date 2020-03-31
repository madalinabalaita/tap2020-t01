namespace Imobile
{
    class StudioComissionCalculator : ComissionCalculator
    {
        public int sm;//square meters of the estate
        public string location;//the location of the estate:center,somewhere ok,suburbs
        public string condition;//condition of the estate:really old,old,medium,new


        protected override decimal CalculateComission(Estate estate)
        {

            decimal poundage1 = 0m;
            decimal poundage2 = 0m;
            decimal poundage3;
            decimal poundage;

            if (estate.sm < 15) throw new SquareMetersException();
            else if (estate.sm >= 15 && estate.sm <= 30) poundage1 = 0.005m;
            else if (estate.sm > 30) poundage1 = 0.01m;


            //location of the house
            if (estate.location == "center") poundage2 = 0.015m;
            else if (estate.location == "suburbs") poundage2 = 0.005m;
            else if (estate.location == "somewhere ok") poundage2 = 0.01m;

            //condition of the house

            if (estate.condition == "old") poundage3 = 0.001m;
            else if (estate.condition == "medium") poundage3 = 0.005m;
            else if (estate.condition == "new") poundage3 = 0.01m;
            else throw new UninhabitableException();


            poundage = poundage1 + poundage2 + poundage3;
            return poundage;
        }


    }
}
