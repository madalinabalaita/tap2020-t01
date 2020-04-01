using System;
using Imobile.Core.Estates;
namespace Imobile.Core.Calculators
{
    public abstract class ComissionCalculator : IComissionCalculator
    {

        protected abstract decimal CalculateComission(Estate estate);
        public decimal Get_poundage(Estate estate, decimal price)
        {
            var comission = CalculateComission(estate);
            return price * comission;
        }

        public decimal Get_price(Estate estate, decimal price)
        {

            var comission = Get_poundage(estate, price);
            return price += comission;

        }
    }
}
