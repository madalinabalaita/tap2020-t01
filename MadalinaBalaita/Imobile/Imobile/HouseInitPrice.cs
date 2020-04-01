﻿namespace Imobile
{
    class HouseInitPrice : InitialPrice
    {
       
        protected override decimal GetInitPrice(Estate estate)
        {
            decimal price=0;
            if (estate.sm < 70) price=80000;
            else if (estate.sm >= 70 && estate.sm <= 80) price= 130000;
            else if (estate.sm > 80) price=200000;
            return price;
            //throw new NotImplementedException();
        }


    }
}