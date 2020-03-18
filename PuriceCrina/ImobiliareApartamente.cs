using System;
using System.Collections.Generic;
using System.Text;

    class ImobiliareApartamente:Imobiliare
    {
        int rooms;
        bool balcony;
        public ImobiliareApartamente(int rooms, String location, double surface, String neighborhood, int bathroom_number,bool balcony, decimal price) {
            this.rooms = rooms;
            this.location = location;
            this.surface = surface;
            this.neighborhood = neighborhood;
            this.bathroom_number = bathroom_number;
            this.balcony = balcony;
            this.price = price;
        }    
        protected override decimal CalculateWithdrawalFee(decimal amount){
            return amount*0.5m/100;
        }

    }

