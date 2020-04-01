using Imobile.Core.Estates;
namespace Imobile.Core.Calculators
{
    public interface IInitialPrice
    {
        decimal Get_price_fromLandlord(Estate estate);
    }
}