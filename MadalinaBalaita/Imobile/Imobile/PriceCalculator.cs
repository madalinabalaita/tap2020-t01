namespace Imobile
{
    class PriceCalculator
    {
        public decimal get_price(Estate estate)
        {
            var comission = new ComissionCalculator();
            var initialPrice = new InitialPrice();

            return initialPrice.get_price_fromLandlord(estate) + comission.get_poundage(estate, initialPrice.get_price_fromLandlord(estate));

        }
    }
}
