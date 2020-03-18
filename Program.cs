using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GinigaGabriel
{
    class Program
    {
        public static Dictionary<string, decimal> Areas = new Dictionary<string, decimal>();
        public static House[] houses;
        public static Apartament[] apartaments;
        public static OneRoomApartament[] oneRoomApartaments;

        static void Main(string[] args)
        {        
            IOClass.FILES.readingFromFiles();
            ConsoleWriter.WRITE.Writer(); 
        }
    }
}
