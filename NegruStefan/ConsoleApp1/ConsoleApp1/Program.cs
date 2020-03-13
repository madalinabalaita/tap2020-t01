using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ConsoleApp1.Building[] buildings = new ConsoleApp1.Building[20];
            ConsoleApp1.House Casa1= new ConsoleApp1.House(150000);
            ConsoleApp1.Apartment apartament1 = new ConsoleApp1.Apartment(35000);
            ConsoleApp1.StudioApartment garsoniera1 = new ConsoleApp1.StudioApartment(15000);
            buildings[0] = Casa1;
            buildings[1] = apartament1;
            buildings[2] = garsoniera1;
            Console.WriteLine(buildings[0].get_price());
        }
    }
}
