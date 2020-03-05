using System;
using System.Collections.Generic;
using System.Text;

namespace GinigaGabriel
{
    class ConsoleWriter
    {
        private static ConsoleWriter write;

        private ConsoleWriter() { }

        public static ConsoleWriter WRITE
        {
            get
            {
                if (write == null)
                {
                    write = new ConsoleWriter();
                }
                return write;
            }
        }

        public void Writer()
        {
            char choose;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            firstRows();
            choose = Console.ReadLine()[0];
            while (choose == '1' || choose == '2' || choose == '3' || choose == '4' || choose == '5' || choose == 'b' || choose == 'B')
            {


                if (choose == 'b' || choose == 'B')
                {
                    Console.Clear();
                    firstRows();
                }

                onetwothree(choose);
                show123(choose);
                showareas(choose);

                choose = Console.ReadLine()[0];
            }
            if (choose == 'e' || choose == 'E')
            { Environment.Exit(0); Console.WriteLine("Exiting ..."); }
            Console.WriteLine("Wrong Input.");

        }


        public void firstRows()
        {
            Console.WriteLine("-------------------Welcome to Buy-Your-Home------------------");
            Console.WriteLine("This app was created to find your perfect home on your budget.");
            Console.WriteLine("All copyright lies with Gabriel.");
            Console.WriteLine(" ");
            Console.WriteLine("->You can choose from the list below, either the type of house or the desired area");
            Console.WriteLine("[1]-> House List");
            Console.WriteLine("[2]-> One-Room Apartament List");
            Console.WriteLine("[3]-> Apartament List");
            Console.WriteLine("[4]-> Show me [1]+[2]+[3]");
            Console.WriteLine("[5]-> Desired area");
            Console.WriteLine("[E]-> Exit");

            Console.WriteLine("Type the number : ");
        }

        public void onetwothree(char choose)
        {

            if (choose == '1')
            {
                Console.Clear();
                Console.WriteLine("                                     For Houses commission is 5.3%");
                Console.WriteLine(""); Console.WriteLine("");
                for (int i = 0; i < Program.houses.Length; i++)
                {


                    Console.WriteLine("-> House nr." + Convert.ToString(i + 1));
                    Program.houses[i].DisplayThePrice();
                    Console.WriteLine("");
                }

                Console.WriteLine(" ");
                Console.WriteLine("-> [B]ack ");
                Console.WriteLine("-> [E]xit");
            }

            if (choose == '2')
            {
                Console.Clear();
                Console.WriteLine("                                   For One-Room Apartaments commission is 2.4%");
                Console.WriteLine(""); Console.WriteLine("");
                for (int i = 0; i < Program.oneRoomApartaments.Length; i++)
                {


                    Console.WriteLine("-> One-Room Apartament nr." + Convert.ToString(i + 1));
                    Program.oneRoomApartaments[i].DisplayThePrice();
                    Console.WriteLine("");
                }

                Console.WriteLine(" ");
                Console.WriteLine("-> [B]ack ");
                Console.WriteLine("-> [E]xit");
            }

            if (choose == '3')
            {
                Console.Clear();
                Console.WriteLine("                                     For  Apartaments commission is 8.4%");
                Console.WriteLine(""); Console.WriteLine("");
                for (int i = 0; i < Program.apartaments.Length; i++)
                {


                    Console.WriteLine("-> Apartament nr." + Convert.ToString(i + 1));
                    Program.apartaments[i].DisplayThePrice();
                    Console.WriteLine("");
                }

                Console.WriteLine(" ");
                Console.WriteLine("-> [B]ack ");
                Console.WriteLine("-> [E]xit");
            }
        }

        public void showareas(char choose)
        {
            if (choose == '5')
            {
                Console.Clear();
                int k = 1;
                string[] areasarray = new string[Program.Areas.Count + 1];
                char areachoose;
                foreach (KeyValuePair<string, decimal> index in Program.Areas)
                {
                    Console.WriteLine("[" + Convert.ToString(k) + "]- " + index.Key);
                    areasarray[k] = index.Key;
                    k++;
                }
                Console.WriteLine("[" + Convert.ToString(k) + "]- Other areas");

                areachoose = Console.ReadLine()[0];
                if (!(char.GetNumericValue(areachoose) <= k && char.GetNumericValue(areachoose) >= 1))
                { Console.WriteLine("Wrong Input"); Environment.Exit(0); }
                Console.Clear();

                if (char.GetNumericValue(areachoose) == k)
                {
                    Console.WriteLine("Houses : ");
                    Console.WriteLine(" ");
                    bool test = false;
                    foreach (House house in Program.houses)
                    {
                        test = false;
                        foreach (KeyValuePair<string, decimal> index in Program.Areas)
                            if (index.Key == house.Area)
                            { test = true; }

                        if (test == false)
                        { Console.WriteLine(" "); house.DisplayThePrice(); }
                    }

                    Console.WriteLine(" "); Console.WriteLine(" ");
                    Console.WriteLine("One-Room Apartament : ");
                    Console.WriteLine(" ");

                    foreach (OneRoomApartament house in Program.oneRoomApartaments)
                    {
                        test = false;
                        foreach (KeyValuePair<string, decimal> index in Program.Areas)
                            if (index.Key == house.Area)
                            { test = true; }

                        if (test == false)
                        { Console.WriteLine(" "); house.DisplayThePrice(); }
                    }


                    Console.WriteLine(" "); Console.WriteLine(" ");
                    Console.WriteLine("Apartament : ");
                    Console.WriteLine(" ");

                    foreach (Apartament house in Program.apartaments)
                    {
                        test = false;
                        foreach (KeyValuePair<string, decimal> index in Program.Areas)
                            if (index.Key == house.Area)
                            { test = true; }

                        if (test == false)
                        { Console.WriteLine(" "); house.DisplayThePrice(); }
                    }

                }
                else if (char.GetNumericValue(areachoose) < k && char.GetNumericValue(areachoose) > 0)
                {

                    Console.WriteLine("--> Houses in desired area are : ");
                    Console.WriteLine(" ");


                    foreach (House house in Program.houses)
                    {
                        if (areasarray[Convert.ToInt32(char.GetNumericValue(areachoose))] == house.Area)
                        { house.DisplayThePrice(); Console.WriteLine(" "); }
                    }
                    Console.WriteLine("--> One-Room Apartament in desired area are : ");
                    Console.WriteLine(" ");
                    foreach (OneRoomApartament house in Program.oneRoomApartaments)
                    {
                        if (areasarray[Convert.ToInt32(char.GetNumericValue(areachoose))] == house.Area)
                        { house.DisplayThePrice(); Console.WriteLine(" "); }
                    }
                    Console.WriteLine("--> Apartaments in desired area are : ");
                    Console.WriteLine(" ");
                    foreach (Apartament house in Program.apartaments)
                    {
                        if (areasarray[Convert.ToInt32(char.GetNumericValue(areachoose))] == house.Area)
                        { house.DisplayThePrice(); Console.WriteLine(" "); }
                    }

                }
                Console.WriteLine(" ");
                Console.WriteLine("-> [B]ack ");
                Console.WriteLine("-> [E]xit");

            }


        }


        public void show123(char choose)
        {

            if (choose == '4')
            {
                Console.Clear();
                Console.WriteLine("                                  All Properties    ");
                Console.WriteLine(""); Console.WriteLine("");
                for (int i = 0; i < Program.houses.Length; i++)
                {


                    Console.WriteLine("-> House nr." + Convert.ToString(i + 1));
                    Program.houses[i].DisplayThePrice();
                    Console.WriteLine("");
                }

                Console.WriteLine(""); Console.WriteLine("");

                for (int i = 0; i < Program.oneRoomApartaments.Length; i++)
                {


                    Console.WriteLine("-> One-Room Apartament nr." + Convert.ToString(i + 1));
                    Program.oneRoomApartaments[i].DisplayThePrice();
                    Console.WriteLine("");
                }

                Console.WriteLine(""); Console.WriteLine("");

                for (int i = 0; i < Program.apartaments.Length; i++)
                {


                    Console.WriteLine("-> Apartament nr." + Convert.ToString(i + 1));
                    Program.apartaments[i].DisplayThePrice();
                    Console.WriteLine("");
                }

                Console.WriteLine(" ");
                Console.WriteLine("-> [B]ack ");
                Console.WriteLine("-> [E]xit");

            }
        }
    }
}
