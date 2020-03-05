using System;

namespace Tema1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House(18000m,"periphery");
            Console.WriteLine("House price: " + house.Commission()+"\n");
            Apartment apartment = new Apartment(9000m, "center");
            Console.WriteLine("Apartment price: " + apartment.Commission() + "\n");
            Singleroom sr = new Singleroom(9000m, "center");
            Console.WriteLine("Singleroom price: " + sr.Commission() + "\n");

        }
    }
}
