using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Tema_1
{
    class Menu
    {
        public static void ConsoleMenu()
        {
            Console.SetCursorPosition(15, 11);
            Console.WriteLine("1.Display Available real estates");

            Console.SetCursorPosition(15, 12);
            Console.WriteLine("2.Calculate the commission from an estate:");

            Console.SetCursorPosition(15, 13);
            Console.WriteLine("3.Add Estates");

            Console.SetCursorPosition(15, 14);
            Console.WriteLine("4.");

            Console.SetCursorPosition(15, 15);
            Console.WriteLine("5.Exit");
            Console.SetCursorPosition(30, 16);

        }
        public static void AddMenu()
        {
            char ch;
            List<House> Houses = House.HouseData();
            List<Studio> Studios = Studio.StudioData();
            List<Apartment> Apartments = Apartment.ApartmentData();
            ConsoleMenu();
            ch = Char.Parse(Console.ReadLine());

            switch (ch)
            {
                case '1':
                    Console.WriteLine("1.List of Housese available:");
                    Console.WriteLine("2.List of Studios available:");
                    Console.WriteLine("3.List of Apartments available:");
                    Console.WriteLine("4.Previous");
                    ch = Char.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            House.Show(Houses);
                            break;
                        case '2':
                            Studio.Show(Studios);
                            break;
                        case '3':
                            Apartment.Show(Apartments);
                            break;
                        case '4':
                            Console.Clear();
                            ConsoleMenu();
                            break;
                    }
                    break;
                case '2':
                    string number = Console.ReadLine();
                    int newch;
                    int.TryParse(number, out newch);
                    if (Houses.ElementAt(Houses.Count - 1).Id >= newch)
                    {
                        foreach (var House in Houses) if (House.Id == newch)
                            {
                                Console.WriteLine("Seller's commission:{0}", House.Price * (decimal)House.Commission);
                                Console.WriteLine("Owner's commission:{0}", House.Price - (House.Price * (decimal)House.Commission));
                            }
                    }
                    else if (Studios.ElementAt(Studios.Count - 1).Id >= newch)
                    {

                        foreach (var Studio in Studios) if (Studio.Id == newch)
                            {
                                Console.WriteLine("Seller's commission:{0}", Studio.Price * (decimal)Studio.Commission);
                                Console.WriteLine("Owner's commission:{0}", Studio.Price - (Studio.Price * (decimal)Studio.Commission));
                            }
                    }
                    else if (Apartments.ElementAt(Apartments.Count - 1).Id > newch)
                    {
                        foreach (var Apartment in Apartments) if (Apartment.Id == newch)
                            {
                                Console.WriteLine("Seller's commission:{0}", Apartment.Price * (decimal)Apartment.Commission);
                                Console.WriteLine("Owner's commission:{0}", Apartment.Price - (Apartment.Price * (decimal)Apartment.Commission));
                            }
                    }
                    break;
                case '3':

                    break;
                case '4':

                    break;
                case '5':
                    Environment.Exit(0);
                    break;
            }

        }

    }
}
