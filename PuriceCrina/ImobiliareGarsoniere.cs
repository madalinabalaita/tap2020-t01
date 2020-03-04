using System;
using System.Collections.Generic;
using System.Text;


    class ImobiliareGarsoniere:Imobiliare
    {
        bool balcony;

        public ImobiliareGarsoniere( String location, double surface, String neighborhood, int bathroom_number, bool balcony, decimal price)
        {
            this.location = location;
            this.surface = surface;
            this.neighborhood = neighborhood;
            this.bathroom_number = bathroom_number;
            this.balcony = balcony;
            this.price = price;
        }

        protected override decimal CalculateWithdrawalFee(decimal amount)
        {
            return 0;
        }


    }

