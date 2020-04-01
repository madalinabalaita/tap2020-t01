using System;
using Imobile.Core.Estates;
namespace Imobile.Core.Calculators
{
    public abstract class InitialPrice : IInitialPrice
    {

        protected abstract decimal GetInitPrice(Estate estate);
        public decimal Get_price_fromLandlord(Estate estate)
        {
            var price = GetInitPrice(estate);
            return price;
        }




    }
}
