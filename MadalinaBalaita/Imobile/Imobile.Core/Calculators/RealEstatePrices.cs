using System;
using Imobile.Core.Estates;
using Imobile.Core.Calculators.InitialPriceCalc;
using Imobile.Core.Calculators.Comissioncalc;

namespace Imobile.Core.Calculators
{

    public class RealEstatePrices
        {
            public static void GetInitialPriceFrom(Estate estate, IInitialPrice initPrice)
            {
                var iPrice = initPrice.Get_price_fromLandlord(estate);
              
            // Console.WriteLine("{0}: {1}",estate.GetType().Name,estate.IPrice);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.Out.WriteLine("The initial price is " + estate.Get_price_fromLandlord(iPrice) +"€");
            

        }

           public static void GetComissionFrom(Estate estate, IComissionCalculator comission, IInitialPrice initPrice)
            {
                var iPrice = initPrice.Get_price_fromLandlord(estate);
                var com = comission.Get_poundage(estate, estate.Get_price_fromLandlord(iPrice));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.Out.WriteLine("The poundage is " + estate.Get_poundage(com) + "€");
        }

           public static void GetPriceFrom(Estate estate, IComissionCalculator calculator, IInitialPrice initPrice)
            {

                var iPrice = initPrice.Get_price_fromLandlord(estate);
                var price = calculator.Get_price(estate, iPrice);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.Out.WriteLine("The total price is " + estate.Get_price(price)+"€");

        }

    }
}
