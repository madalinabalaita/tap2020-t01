using System;

namespace Imobile
{
    class InitialPrice
    {
        public int sm;
        public decimal get_price_fromLandlord(Estate estate)
        {
            var price = GetInitPrice(estate);
            return price;
        }
        private decimal GetInitPrice(Estate estate)
        {
            if (estate is House)
            {
                if (estate.sm < 70) return 80000;
                else if (estate.sm >= 70 && estate.sm <= 80) return 130000;
                else if (estate.sm > 80) return 200000;

            }
            if (estate is Flat)
            {
                if (estate.sm < 43) return 20000;
                else if (estate.sm >= 43 && estate.sm <= 59) return 35000;//one room flat
                else if (estate.sm >= 60 && estate.sm <= 69) return 47000;//two rooms flat
                else if (estate.sm >= 70 && estate.sm <= 90) return 60000;//three rooms flat
                else if (estate.sm > 90) return 95000;//penthouse
            }
            if (estate is Studio)
            {
                if (estate.sm >= 15 && estate.sm <= 30) return 15000;
                else if (sm > 30) return 22000;
                
            }
            throw new InvalidOperationException("Unknown estate type!");
        }
    }
}
