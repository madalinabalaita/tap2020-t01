namespace Imobile
{
    class StudioInitPrice : InitialPrice
    {
        
        protected override decimal GetInitPrice(Estate estate)
        {
            decimal price = 0;
            if (estate.sm >= 15 && estate.sm <= 30) price= 15000;
            else if (estate.sm > 30) price=22000;
            return price;
        }


    }
}
