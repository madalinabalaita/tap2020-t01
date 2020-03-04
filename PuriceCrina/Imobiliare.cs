using System;
using System.Collections.Generic;
using System.Text;


    abstract class Imobiliare{
    //We declare variables for the principal caracteristics of a real estate(imobiliar)
        protected String location;
        protected double surface;
        protected String neighborhood;
        protected int bathroom_number;
        protected decimal price;
    
        public decimal Price { get { return price; } private set { this.price = value; } }

        public void Change_Price(decimal money)
        {
        this.Price = money;
        }

        public void Selling_Price(decimal amount)
        {
            var fee = CalculateWithdrawalFee(amount);
            amount = amount + fee;
            if (Price <= amount)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            this.Price -= amount;
        }

        protected abstract decimal CalculateWithdrawalFee(decimal amount);
    }

