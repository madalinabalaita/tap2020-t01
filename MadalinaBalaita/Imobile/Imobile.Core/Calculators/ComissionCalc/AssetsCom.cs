using Imobile.Core.Estates;
using Imobile.Core.Calculators.InitialPriceCalc;
namespace Imobile.Core.Calculators.Comissioncalc
{


    public class AssetsCom : IComissionCalculator
        {
            public decimal Get_poundage(Estate estate,decimal price)
            {
                return price*0.032m;
            }
            public decimal Get_price(Estate estate,decimal price)
            {
                price = new AssetsCalculator().Get_price_fromLandlord(estate);
                return price += estate.Comission;
                
            }
     

    }
}
