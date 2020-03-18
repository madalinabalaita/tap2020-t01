using System;
using System.Collections.Generic;
using System.Text;



    class ImobliareCase:Imobiliare
    {
        int rooms;
        bool yard;
        public ImobliareCase(int rooms, String location, double surface, String neighborhood, int bathroom_number,bool yard, decimal price) {
            this.rooms = rooms;
            this.location = location;
            this.surface = surface;
            this.neighborhood = neighborhood;
            this.bathroom_number = bathroom_number;
            this.yard = yard;
            this.price = price;
        }
        protected override decimal CalculateWithdrawalFee(decimal amount)
        {
            return amount*0.9m/100;
        }

    }

