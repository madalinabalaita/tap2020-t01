using System;

namespace Imobile
{
    abstract class ComissionCalculator
    {
       
        protected abstract decimal CalculateComission(Estate estate);
        public decimal Get_poundage(Estate estate,decimal price)
        {
            var comission = CalculateComission(estate);
            return price * comission;
        }

        public decimal Get_price(Estate estate, decimal price)
        {

            var comission = Get_poundage(estate,price);
            return price += comission;

            if(estate is House)
            {
                decimal poundage1 = 0m;
                decimal poundage2 = 0m;
                decimal poundage3;
                decimal poundage;

                if (estate.sm < 15) throw new SquareMetersException();
                else if (estate.sm < 70) poundage1 = 0.005m;
                else if (estate.sm >= 70 && estate.sm <= 80) poundage1 = 0.007m;
                else if (estate.sm > 80) poundage1 = 0.01m;

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
                return  poundage;
            }
            if (estate is Flat)
            {

                decimal poundage1 = 0m;
                decimal poundage2 = 0m;
                decimal poundage3;
                decimal poundage;

                if (estate.sm < 15) throw new SquareMetersException();
                else if (estate.sm < 43) poundage1 = 0.005m;
                else if (estate.sm >= 43 && estate.sm <= 59) poundage1 = 0.01m;//one room flat
                else if (estate.sm >= 60 && estate.sm <= 69) poundage1 = 0.015m;//two rooms flat
                else if (estate.sm >= 70 && estate.sm <= 90) poundage1 = 0.02m;//three rooms flat
                else if (estate.sm > 90) poundage1 = 0.05m;//penthouse

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
            if (estate is Studio)
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
            if(estate is UrbanLand)
            {
                decimal poundage1 = 0m;
                decimal poundage2 = 0m;
                decimal poundage3 = 0m;
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
           throw new InvalidOperationException("Unknown estate type!"); 

        }
    }
}
