using System;
using System.Collections.Generic;

namespace IacobEduard
{

    class Program
    {
        static void Main(string[] args)
        {
            Case casa = new Case(250, 4, 2);
            Garsoniere garsoneria = new Garsoniere(35, 1, 13);
            Apartamente apartament = new Apartamente(40, 3, 1);

            List<string[]> localizari = new List<string[]>();


            string[] locatie_apartament = { "Str.Ciurchi", "47.1550049", "27.6140996" }, locatie_garsoniera = 
                { "Str.Silvestru", "47.1707698", "27.561663" },  locatie_casa = {"Str.Podisului", "47.1504339", "27.5527682" },
                locatie_centru = { "Str.Palat", "47.1600983", "27.5863742" };
                
            localizari.Add(locatie_apartament);
            localizari.Add(locatie_garsoniera);
            localizari.Add(locatie_casa);

            casa.SetLocatie(locatie_casa);
            garsoneria.SetLocatie(locatie_garsoniera);
            apartament.SetLocatie(locatie_apartament);

            
            int pret_garsoniera = garsoneria.CalcPret();
            int pret_apartament = apartament.CalcPret();
            int pret_casa = casa.CalcPret();

            Console.WriteLine(pret_apartament);
            Console.WriteLine(pret_garsoniera);
            Console.WriteLine(pret_casa);

            /*
            string[] casa1 = casa.GetLocatie();
            Console.WriteLine("Coordonatele casei sunt: " + localizari[0][1] + ", " + localizari[0][2]);
            */


        }
    }
}
