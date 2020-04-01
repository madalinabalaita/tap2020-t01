using System;
using Imobile.Core.Estates;

namespace Imobile.Core.Calculators
{

    public class RealEstatePrices
        {
            public static void GetInitialPriceFrom(Estate estate, IInitialPrice initPrice)
            {
                var iPrice = initPrice.Get_price_fromLandlord(estate);
                Console.WriteLine("The initial price is " + estate.Get_price_fromLandlord(iPrice));
                // Console.WriteLine("{0}: {1}",estate.GetType().Name,estate.IPrice);
            }

           public static void GetComissionFrom(Estate estate, IComissionCalculator comission, IInitialPrice initPrice)
            {
                var iPrice = initPrice.Get_price_fromLandlord(estate);
                var com = comission.Get_poundage(estate, estate.Get_price_fromLandlord(iPrice));
                Console.WriteLine("The poundage is: " + estate.Get_poundage(com));

            }

           public static void GetPriceFrom(Estate estate, IComissionCalculator calculator, IInitialPrice initPrice)
            {

                var iPrice = initPrice.Get_price_fromLandlord(estate);
                var price = calculator.Get_price(estate, iPrice);
                Console.WriteLine("The total price is: " + estate.Get_price(price));
            }
       
    }
}
