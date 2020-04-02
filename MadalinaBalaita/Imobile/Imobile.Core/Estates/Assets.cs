using Imobile.Core.Calculators;
namespace Imobile.Core.Estates
{
    public abstract class Assets
    {
        public decimal Price { get; protected set; }
        public decimal Comission { get; set; }
        public decimal IPrice { get; set; }
        public double sm;//square meters of the estate
        public string location { get; set; }//the location of the estate:center,somewhere ok,suburbs
        public string condition;//condition of the estate:really old,old,medium,new
        public string usage;//land for buildings(intravilan) or agriculture(extravilan)
        public int cadastral_nr { get; set; }//cadastral number
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
        public int Get_locationLand()
        {
            return cadastral_nr;
        }

    }
}
