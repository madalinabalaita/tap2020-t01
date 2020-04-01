using Imobile.Core.Calculators;
namespace Imobile.Core.Estates
{
    public abstract class Assets
    {
        public decimal Price { get; protected set; }
        public decimal Comission { get; set; }
        public decimal IPrice { get; set; }
        public decimal Get_poundage(decimal comission)
        {
            Comission = comission;
            return Comission;
        }
        public decimal Get_price(decimal price)
        {
            Price = price;
            return Price;
        }
        public decimal Get_price_fromLandlord(decimal price)
        {
            IPrice = price;
            return IPrice;
        }

    }
}
