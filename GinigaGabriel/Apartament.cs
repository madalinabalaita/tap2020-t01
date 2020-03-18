using System;
using System.Collections.Generic;
using System.Text;

namespace GinigaGabriel
{
    class Apartament: ClassForInheritance
    {
        public int Number;

        public override void DisplayThePrice()
        {

            if (CheckAreaInDictionary(Area) == 0)
            {
                PriceAfterCommission = CalculatesTheCommission(PriceBeforeCommission, Commission);
            }
            else
            {
                PriceAfterCommission = CalculatesTheCommission(PriceBeforeCommission, CheckAreaInDictionary(Area), Commission);
            }



            Console.WriteLine("From the area -> " + Area);
            Console.WriteLine("Cost : " + Convert.ToString(PriceAfterCommission) + " with the commission " + Convert.ToString(PriceAfterCommission - PriceBeforeCommission));
        }

        public Apartament(decimal PriceBeforeCommission, string Area)
        {
            this.PriceBeforeCommission = PriceBeforeCommission;
            this.Area = Area;
            Commission = 8.4m;
            VariableForIndex++;
            Number = VariableForIndex;
        }

    }
}
