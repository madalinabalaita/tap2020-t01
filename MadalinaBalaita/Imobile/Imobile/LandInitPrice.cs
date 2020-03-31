namespace Imobile
{
    class LandInitPrice : InitialPrice
    {
        public int sm;
        public string usage;
        protected override decimal GetInitPrice(Estate estate)
        {
            decimal price = 0;
            if (estate.usage == "intravilan")
            {
                if (estate.sm < 500) price = 8000;
                else if (estate.sm >= 500 && estate.sm <= 1500) price = 14000;
                else if (estate.sm > 1500) price = 20000;
            }
            else if (estate.usage == "extravilan")
            {
                if (estate.sm < 500) price = 5000;
                else if (estate.sm >= 500 && estate.sm <= 1500) price = 10000;
                else if (estate.sm > 1500) price = 15000;
            }
            return price;
        }


    }
}
