using System;
using System.Collections.Generic;

namespace IacobEduard
{

    class Program
    {
        static void Main(string[] args)
        {
            string raspuns = null;
            int m_P = 0, camere = 0, etaj = 0, etaje = 0;
            Case casa;//= new Case(250, 4, 2);
            Garsoniere garsoniera;//= new Garsoniere(35, 1, 13);
            Apartamente apartament; //= new Apartamente(40, 3, 1);
            
            List<string[]> localizari = new List<string[]>();

            string[] locatie_apartament = { "Ciurchi", "47.1550049", "27.6140996" }, locatie_garsoniera = 
                { "Silvestru", "47.1707698", "27.561663" },  locatie_casa = {"Podisului", "47.1504339", "27.5527682" },
                locatie_centru = { "Palat", "47.1600983", "27.5863742" };
               
            
            localizari.Add(locatie_apartament);
            localizari.Add(locatie_garsoniera);
            localizari.Add(locatie_casa);

            /* casa.SetLocatie(locatie_casa);
             garsoneria.SetLocatie(locatie_garsoniera);
             apartament.SetLocatie(locatie_apartament);
             */

            /*int pret_garsoniera = garsoneria.CalcPret();
            int pret_apartament = apartament.CalcPret();
            int pret_casa = casa.CalcPret();

            Console.WriteLine(pret_apartament);
            Console.WriteLine(pret_garsoniera);
            Console.WriteLine(pret_casa);
            */
            Console.WriteLine("Welcome!\n");
            Console.WriteLine("To start press 'Enter'");
            ConsoleKeyInfo tasta = Console.ReadKey();

            while (tasta.Key == ConsoleKey.Enter) {
                Console.WriteLine("Do you want to add a new estate to calculate the comission?(Y/N): ");
                raspuns = Console.ReadLine();
                if (raspuns == "y" || raspuns == "Y")
                {
                    Console.WriteLine("What type of estate do you want to add(house/flat/one room)");
                    raspuns = Console.ReadLine();
                    if(raspuns == "house")
                    {
                        Console.WriteLine("How many square meters does have the house?");
                        raspuns = Console.ReadLine();
                        if(!int.TryParse(raspuns, out m_P)) { Console.WriteLine("You must enter a number"); }
                        /* Am folosit metoda de mai sus in care verific daca parsarea sa facut sau nu
                         * o alta metoda ar fi cea de mai jos cu blocuri try catch
                         * try { m_P = Int32.Parse(raspuns); }
                         * catch { Console.WriteLine("You must enter a number"); }*/
                        Console.WriteLine("How many rooms does have the house?");
                        raspuns = Console.ReadLine();
                        if (!int.TryParse(raspuns, out camere)) { Console.WriteLine("You must enter a number"); }
                        Console.WriteLine("How many floors does have the house?");
                        raspuns = Console.ReadLine();
                        if (!int.TryParse(raspuns, out etaje)) { Console.WriteLine("You must enter a number"); }
                        casa = new Case(m_P, camere, etaje);
                        Console.WriteLine("The price of the house is {0}, and the obtained comission is {1}.", casa.CalcPret(), casa.Calc_comision());
                        Console.WriteLine("The house is located on {0} street.", localizari[2][0]);
                    }
                    else if(raspuns == "flat")
                    {
                        Console.WriteLine("How many square meters does have the flat?");
                        raspuns = Console.ReadLine();
                        if (!int.TryParse(raspuns, out m_P)) { Console.WriteLine("You must enter a number"); }
                        Console.WriteLine("How many rooms does have the flat?");
                        raspuns = Console.ReadLine();
                        if (!int.TryParse(raspuns, out camere)) { Console.WriteLine("You must enter a number"); }
                        Console.WriteLine("On what floor is the flat?");
                        raspuns = Console.ReadLine();
                        if (!int.TryParse(raspuns, out etaj)) { Console.WriteLine("You must enter a number"); }
                        apartament= new Apartamente(m_P, camere, etaj);
                        Console.WriteLine("The price of the flat is {0}, and the obtained comission is {1}.", apartament.CalcPret(), apartament.Calc_comision());
                        Console.WriteLine("The house is located on {0} street.", localizari[0][0]);
                    }
                    else if(raspuns == "one room")
                    {
                        Console.WriteLine("How many square meters does have the one room?");
                        raspuns = Console.ReadLine();
                        if (!int.TryParse(raspuns, out m_P)) { Console.WriteLine("You must enter a number"); }
                        Console.WriteLine("How many rooms does have the one room?");
                        Console.WriteLine("You really answered to that? C'mon that's why is called one room.");
                        Console.WriteLine("On what floor is the one room?");
                        raspuns = Console.ReadLine();
                        if (!int.TryParse(raspuns, out etaj)) { Console.WriteLine("You must enter a number"); }
                        garsoniera = new Garsoniere(m_P, 1, etaj);
                        Console.WriteLine("The price of the flat is {0}, and the obtained comission is {1}.", garsoniera.CalcPret(), garsoniera.Calc_comision());
                        Console.WriteLine("The house is located on {0} street.", localizari[1][0]);
                    }
                }
                else
                {
                    Console.WriteLine("There is no second chance to add another house. You fool!");
                    break;
                }
            }
            Console.WriteLine("\nThx for using us. Have a nice day!");
            

        }
    }
}
