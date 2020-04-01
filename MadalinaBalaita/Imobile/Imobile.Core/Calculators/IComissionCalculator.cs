using Imobile.Core.Estates;
namespace Imobile.Core.Calculators
{
    public interface IComissionCalculator
    {
        decimal Get_poundage(Estate estate, decimal price);
        decimal Get_price(Estate estate, decimal price);
    }
}