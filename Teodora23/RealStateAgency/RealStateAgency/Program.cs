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
            var propertyPrice = Convert.ToDecimal(Console.ReadLine());

            Property property;

            property = new House(propertyPrice);
            Console.WriteLine("The final price is " + property.PropertySellingPrice + " from which the applied commission is " + property.Commission);
        }
    }
}