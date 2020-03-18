using System;

namespace Tema1
{
    public abstract class RealEstateAgency {
        public decimal price;
        public int yearBuilt;
        public int surface;
        
        public RealEstateAgency(decimal price,int surface, int yearBuilt) {
            this.price = price;
            this.surface = surface;
            this.yearBuilt = yearBuilt;
        }
        public abstract decimal calculate_commission();
        public decimal calculate_price() {
            return price + calculate_commission();
        }
    }

    public class Studio : RealEstateAgency
    {
        public Studio(decimal price,int surface, int yearBuilt) : base(price,surface, yearBuilt){}
        public override decimal calculate_commission()
        {
            if (yearBuilt < 1990)
            {
                if (surface < 15 || surface>30)
                    throw new Exception("No studios with this surface! Please introduce a valid value for surface(15-30 square meters).");
                else if (surface <= 30)
                    return price * 0.008m;
            }
            else
            {
                if (surface < 15|| surface>30)
                    throw new Exception("No studios with this surface! Please introduce a valid value for surface(15-30 square meters).");
                else if (surface <=30)
                    return price * 0.012m;
            }
            return price;
        }
    }

    public class Apartment : RealEstateAgency {
        public Apartment(decimal price, int surface, int yearBuilt) : base(price, surface, yearBuilt) { }
        public override decimal calculate_commission()
        {
            if (yearBuilt < 1990)
            {
                if (surface < 30 || surface > 90)
                    throw new Exception("No apartments with this surface! Please introduce a valid value for surface(30-90 square meters).");
                else if (surface <=60)
                    return price * 0.016m;
            }
            else
            {
                if (surface < 30 || surface > 90)
                    throw new Exception("No apartments with this surface! Please introduce a valid value for surface(30-90 square meters).");
                else if (surface <= 60)
                    return price * 0.02m;
            }
            return price;
        }
    }

    public class House : RealEstateAgency
    {
        public int floors;
        public House(decimal price, int surface, int yearBuilt,int floors) : base(price, surface, yearBuilt) {
            this.floors = floors;
        }
        public override decimal calculate_commission()
        {
            if (floors <1 || floors >3)
                throw new Exception("No houses with " + floors + " floor/floors. Please verifiy that dates are correct!");
            else if (floors > 0 || floors < 2)
            {
                if (yearBuilt < 1990)
                {
                    if (surface < 50 || surface > 350)
                        throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                    else if (surface <= 150)
                        return price * 0.01m;
                }
                else
                {
                    if (surface < 30 || surface > 90)
                        throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                    else if (surface <= 150)
                        return price * 0.015m;
                }
                return price;
            }
            else if (floors >= 2 || floors <= 3) {
                if (yearBuilt < 1990)
                {
                    if (surface < 50 || surface > 350)
                        throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                    else if (surface <= 150)
                        return price * 0.015m;
                }
                else
                {
                    if (surface < 30 || surface > 90)
                        throw new Exception("No houses with this surface!Please introduce a valid value for surface(50-350 square meters).");
                    else if (surface <= 150)
                        return price * 0.025m;
                } 
            }

         return price;
        }
    }

    class Program
    {
        static void Main(string[] args) {
            Studio studio = new Studio(25000m,20, 1985);
            Console.WriteLine("Studio price:" + studio.calculate_price() + " and commission: " + studio.calculate_commission());
            Apartment apartment = new Apartment(65000m,45, 1990);
            Console.WriteLine("Apartment price:" + apartment.calculate_price() + " and commission: " + apartment.calculate_commission());
            House house = new House(70000m, 70, 2014,3);
            Console.WriteLine("House price:" + house.calculate_price() + " and commission: " + house.calculate_commission());
            House house1 = new House(45000m, 50, 1975,1);
            Console.WriteLine("House price:" + house1.calculate_price() + " and commission: " + house1.calculate_commission());
        }
    }
}

