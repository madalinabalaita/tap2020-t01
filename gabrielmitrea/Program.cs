using System;

namespace Tema1
{
   public  class House : Residence
    {
        protected override decimal AgentCommission(decimal price)
        {
            return (12m * price) / 100;
        }
    }
    public class Apartment : Residence
    {
        protected override decimal AgentCommission(decimal price)
        {
            return (15m * price)/100;
        }
    }
    public class StudioApartment : Residence
    {

        protected override decimal AgentCommission(decimal price)
        {
            return (8m * price)/100;
        }

    }

    public abstract class Residence
    {
        public decimal Price_normal { get; private set; }
       
        public decimal Price_agent { get; private set; }
        public decimal Price_total { get; private set; }
        public string Adress { get; private set; }
        public string Town { get; private set; }
        public string Zone { get; private set; }
        public string Type { get; private set; }
        public void Sell(string type,string adress, string town, string zone,decimal price)
        {
           
          
           Price_normal = price;
           Price_agent = AgentCommission(price);
           Price_total = price+AgentCommission(price);
           this.Adress = adress;
           this.Town = town;
           this.Zone = zone;
           this.Type = type;
            

        }
        
        
        protected abstract decimal AgentCommission(decimal price);
    }
    class Program
    {
        static void Main(string[] args)
        {
            var house = new House();
            var apartment = new Apartment();
            var studio_apartment = new StudioApartment();
            house.Sell("House","Aleea Decebal, nr.10", "Iasi", "Centru", 210000);
            Console.WriteLine("Type: "+house.Type + "\r\n"+ "Adress : "+house.Adress + "\r\n" + "Town: " +house.Town+ "\r\n" + "Zone: " +house.Zone+ "\r\n" + "Normal price: " +house.Price_normal+ "\r\n" + "Agent Price: " + house.Price_agent+ "\r\n" + "Total price: " +house.Price_total +"\r\n");
            apartment.Sell("Apartment","Calea Victoriei, nr.2", "Bucuresti", "Centru", 75000);
            Console.WriteLine("Type: " + apartment.Type + "\r\n" + "Adress : " + apartment.Adress + "\r\n" + "Town: " + apartment.Town + "\r\n" + "Zone: " + apartment.Zone + "\r\n" + "Normal price: " + apartment.Price_normal + "\r\n" + "Agent Price: " + apartment.Price_agent + "\r\n" + "Total price: " + apartment.Price_total + "\r\n");
            studio_apartment.Sell("Studio apartment","Calea Unirii, nr.24", "Suceava", "Periferie", 30000);
            Console.WriteLine("Type: " + studio_apartment.Type + "\r\n" + "Adress : " + studio_apartment.Adress + "\r\n" + "Town: " + studio_apartment.Town + "\r\n" + "Zone: " + studio_apartment.Zone + "\r\n" + "Normal price: " + studio_apartment.Price_normal + "\r\n" + "Agent Price: " + studio_apartment.Price_agent + "\r\n" + "Total price: " + studio_apartment.Price_total + "\r\n");
            

        }
    }
}
