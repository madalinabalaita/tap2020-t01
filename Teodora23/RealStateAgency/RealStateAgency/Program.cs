using System;

namespace RealStateAgency
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Property Type: ");
            var propertyType = Console.ReadLine();

            Console.WriteLine("Enter Initial Selling Price: ");

            Property property;
            decimal propertyPrice;

            switch (propertyType)
            {
                case "Apartment":
                    propertyPrice = Convert.ToDecimal(Console.ReadLine());
                    property = new Apartment(propertyPrice);
                    Console.WriteLine("The final price is " + property.PropertySellingPrice + " from which the applied commission is " + property.Commission);
                    break;
                case "Single Room":
                    propertyPrice = Convert.ToDecimal(Console.ReadLine());
                    property = new SingleRoom(propertyPrice);
                    Console.WriteLine("The final price is " + property.PropertySellingPrice + " from which the applied commission is " + property.Commission);
                    break;
                case "House":
                    propertyPrice = Convert.ToDecimal(Console.ReadLine());
                    property = new House(propertyPrice);
                    Console.WriteLine("The final price is " + property.PropertySellingPrice + " from which the applied commission is " + property.Commission);
                    break;
                default:
                    throw new InvalidOperationException("This type does not exist!");
            }

        }
    }
}
