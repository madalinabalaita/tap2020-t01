using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App

{
    public class NumberOfRoomsException : Exception
    {
        public NumberOfRoomsException() { }
        public NumberOfRoomsException(String message) : base(message) { }
        public NumberOfRoomsException(String message, Exception exception) : base(message, exception) { }
    }
    public class TypeNotFoundException : Exception
    {
        public TypeNotFoundException() { }
        public TypeNotFoundException(String message) : base(message) { }
        public TypeNotFoundException(String message, Exception ex) : base(message, ex) { }
    }
    public class YearBoundException : Exception
    {
        public YearBoundException() { }
        public YearBoundException(String message) : base(message) { }
        public YearBoundException(String message, Exception exception) : base(message, exception) { }
    }
 
    public class RealEstateAgency 
    {

        public List<Immobile> immobiles;

        public static RealEstateAgency realEstateAgency = null;
        public static RealEstateAgency GetInstance
        {
            get
            {
                if (realEstateAgency == null)
                    realEstateAgency = new RealEstateAgency();
                return realEstateAgency;
            }
        }

        private RealEstateAgency()
        {
            immobiles = new List<Immobile>();
        }

        public void AddImmobile(Immobile immobile)
        {
            immobiles.Add(immobile);
        }

        public void ShowList()
        {
            foreach (var immobile in immobiles)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Tip imobil: " + immobile.Type);
                Console.WriteLine("Numar camere: " + immobile.NumberOfRooms);
                Console.WriteLine("An constructie: " + immobile.ConstructionYear);
                Console.WriteLine("Pret: " + immobile.Price);
                Console.WriteLine("Comision: " + immobile.Commission);
                Console.WriteLine("----------------------------------------");
            }
        }
    }

    public abstract class Immobile
    {
        protected String type;
        protected byte numberOfRooms;
        protected int constructionYear;
        protected decimal price;
        protected decimal commission;
        public Immobile(byte numberOfRooms, int constructionYear)
        {
            this.numberOfRooms = numberOfRooms;
            this.constructionYear = constructionYear;
        }
        public byte NumberOfRooms { get { return numberOfRooms; } private set { } }
        public int ConstructionYear { get { return constructionYear; } private set { } }
        public decimal Price { get { return price; } private set { } }
        public decimal Commission { get { return commission; } private set { } }
        public String Type { get { return type; } private set { } }
        protected abstract decimal CalculatePrice(Immobile immobile);
        protected abstract decimal CalculateCommission(decimal immobilePrice, decimal immobileTypeFee);
    }

    public class House : Immobile
    {
        private readonly decimal HOUSE_COMMISSION = 0.5m;
        public House(byte numberOfRooms, int constructionYear) 
            : base(numberOfRooms, constructionYear)
        {
            price = CalculatePrice(this);
            commission = CalculateCommission(price, HOUSE_COMMISSION);
            type = "Casa";
        }

        protected override decimal CalculateCommission(decimal immobilePrice, decimal immobileTypeFee)
        {
            return immobilePrice * immobileTypeFee / 100;
        }

        protected override decimal CalculatePrice(Immobile immobile)
        {
            decimal var1 = 100, var2 = 0, var3 = 0; 

            if (NumberOfRooms < 1 || NumberOfRooms > 20)
                throw new NumberOfRoomsException("Room Bound Exception");
            if (NumberOfRooms < 4) var2 = 100;
            else if (NumberOfRooms >= 4 && NumberOfRooms < 6) var2 = 140;
            else if (NumberOfRooms >= 6) var2 = 170;

            if (ConstructionYear < 1900 || ConstructionYear > 2020)
                throw new YearBoundException("Year Bound Exception");
            if (ConstructionYear < 1970) var3 = 10;
            else if (ConstructionYear >= 1970 && ConstructionYear < 2000) var3 = 20;
            else if (ConstructionYear >= 2000) var3 = 30;

            return var1 * var2 * var3 / 3;
        }
    }
    public class Apartment : Immobile
    {
        private readonly decimal APARTMENT_COMMISSION = 0.7m;
        public Apartment(byte numberOfRooms, int constructionYear) 
            : base(numberOfRooms, constructionYear)
        {
            price = CalculatePrice(this);
            commission = CalculateCommission(price, APARTMENT_COMMISSION);
            type = "Apartament";
        }

        protected override decimal CalculateCommission(decimal immobilePrice, decimal immbobileTypeFee)
        {
            return immobilePrice * immbobileTypeFee / 100;
        }

        protected override decimal CalculatePrice(Immobile immobile)
        {
            decimal var1 = 150, var2 = 0, var3 = 0;

            if (NumberOfRooms < 1 || NumberOfRooms > 20)
                throw new NumberOfRoomsException("Room Bound Exception");
            if (NumberOfRooms < 4) var2 = 100;
            else if (NumberOfRooms >= 4 && NumberOfRooms < 6) var2 = 140;
            else if (NumberOfRooms >= 6) var2 = 170;

            if (ConstructionYear < 1900 || ConstructionYear > 2020)
                throw new YearBoundException("Year Bound Exception");
            if (ConstructionYear < 1970) var3 = 10;
            else if (ConstructionYear >= 1970 && ConstructionYear < 2000) var3 = 20;
            else if (ConstructionYear >= 2000) var3 = 30;

            return var1 * var2 * var3 / 3;
        }
    }
    public class SingleRoom : Immobile
    {
        private readonly decimal SINGLEROOM_COMMISSION = 0.3m;
        public SingleRoom(byte numberOfRooms, int constructionYear) : base(numberOfRooms, constructionYear)
        {
            price = CalculatePrice(this);
            commission = CalculateCommission(price, SINGLEROOM_COMMISSION);
            type = "Garsoniera";
        }


        protected override decimal CalculateCommission(decimal immobilePrice, decimal immbobileTypeFee)
        {
            return immobilePrice * immbobileTypeFee / 100;
        }

        protected override decimal CalculatePrice(Immobile immobile)
        {
            decimal var1 = 120, var2 = 0, var3 = 0;

            if (NumberOfRooms < 1 || NumberOfRooms > 20)
                throw new NumberOfRoomsException("Room Bound Exception");
            if (NumberOfRooms < 4) var2 = 100;
            else if (NumberOfRooms >= 4 && NumberOfRooms < 6) var2 = 140;
            else if (NumberOfRooms >= 6) var2 = 170;

            if (ConstructionYear < 1900 || ConstructionYear > 2020)
                throw new YearBoundException("Year Bound Exception");
            if (ConstructionYear < 1970) var3 = 10;
            else if (ConstructionYear >= 1970 && ConstructionYear < 2000) var3 = 20;
            else if (ConstructionYear >= 2000) var3 = 30;

            return var1 * var2 * var3 / 3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House(3, 2010);
            Apartment apartment = new Apartment(5, 1999);
            SingleRoom singleroom = new SingleRoom(2, 2015);

            RealEstateAgency agentie1 = RealEstateAgency.GetInstance;
            agentie1.AddImmobile(house);
            agentie1.AddImmobile(apartment);
            agentie1.AddImmobile(singleroom);
            agentie1.ShowList();
            RealEstateAgency agentie2 = RealEstateAgency.GetInstance;
            agentie2.ShowList();
            Console.ReadKey();
        }
    }

}