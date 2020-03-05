using System;
using System.Collections.Generic;
using System.Text;

namespace GinigaGabriel
{
    abstract class ClassForInheritance
    {
        protected decimal PriceBeforeCommission { get; set; }
        protected decimal PriceAfterCommission { get; set; }
        public string Area { get; set; }
        protected decimal Commission { get; set; }
        public abstract void DisplayThePrice();
        protected static int VariableForIndex = 0;

        public decimal CalculatesTheCommission(decimal PriceBeforeCommission, decimal AreaCommission, decimal Commission)
        {
            return PriceBeforeCommission + PriceBeforeCommission * (Commission / 100) + PriceBeforeCommission * (AreaCommission / 100);
        }

        public decimal CalculatesTheCommission(decimal PriceBeforeCommission, decimal Commission)// standard Area Commision 1% // Area not found in Dictionary
        {
            return PriceBeforeCommission + PriceBeforeCommission * (Commission / 100) + PriceBeforeCommission * (1 / 100);
        }

        protected decimal CheckAreaInDictionary(string Area)
        {
            foreach (KeyValuePair<string, decimal> search in Program.Areas)
                if (search.Key == Area)
                    return search.Value;
            return 0;
            
        }
    }
}
