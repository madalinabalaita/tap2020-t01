using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace GinigaGabriel
{
   public class IOClass
    {

        private static IOClass files;

        private IOClass() { }

        public static IOClass FILES
        {
            get
            {
                if (files == null)
                {
                    files = new IOClass();
                }
                return files;
            }
        }

        public void readingFromFiles()
        {
            string[] lines = System.IO.File.ReadAllLines("Areas.txt");
            string[] splitting = null;
            foreach (string line in lines)//Reading Areas
            {
                splitting = line.Split('*');
              Program.Areas.Add(splitting[1], Convert.ToDecimal(splitting[0]));
            }


            int index = 0;
            string[] readingHouses = System.IO.File.ReadAllLines("House.txt");
            Program.houses = new House[readingHouses.Length];
            foreach (string line in readingHouses)
            {
                splitting = line.Split('*');
                Program.houses[index] = new House(Convert.ToDecimal(splitting[0]), splitting[1]);
                index++;
            }


            index = 0;
            string[] readingApartaments = System.IO.File.ReadAllLines("Apartament.txt");
            Program.apartaments = new Apartament[readingApartaments.Length];
            foreach (string line in readingApartaments)
            {
                splitting = line.Split('*');
                Program.apartaments[index] = new Apartament(Convert.ToDecimal(splitting[0]), splitting[1]);
                index++;
            }



            index = 0;
            string[] readingOneRoomApartaments = System.IO.File.ReadAllLines("OneRoomApartament.txt");
            Program.oneRoomApartaments = new OneRoomApartament[readingOneRoomApartaments.Length];
            foreach (string line in readingOneRoomApartaments)
            {
                splitting = line.Split('*');
                Program.oneRoomApartaments[index] = new OneRoomApartament(Convert.ToDecimal(splitting[0]), splitting[1]);
                index++;
            }
        }
    }
}
