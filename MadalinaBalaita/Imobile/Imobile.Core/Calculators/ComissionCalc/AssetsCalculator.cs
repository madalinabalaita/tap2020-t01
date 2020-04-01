
using Imobile.Core.Estates;
using Imobile.Core.Calculators.InitialPriceCalc;
namespace Imobile.Core.Calculators.Comissioncalc
{

   
        public class AssetsCalculator : IInitialPrice
        {
            public decimal Get_price_fromLandlord(Estate estate)
            {
                return 130000;
            }
        }

}
