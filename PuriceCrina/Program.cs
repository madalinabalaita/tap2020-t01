using System;

namespace PuriceCrina
{
    class Program
    {
        static void Main(string[] args)
        {   //we create a small data base with 5 exemples of each type
            var apartament1 = new ImobiliareApartamente(3,"Str. Pacurari",63,"Centru",1,true,45000m);
            var apartament2 = new ImobiliareApartamente(4, "Aleea Privmaverii", 75, "Periferie", 2, true, 30000m);
            var apartament3 = new ImobiliareApartamente(2, "Bulevardul Luchian", 40, "Periferie", 1, true, 15000m);
            var apartament4 = new ImobiliareApartamente(3, "Calea Plevnei", 50, "Centru", 1, false, 25000m);
            var apartament5 = new ImobiliareApartamente(4, "Str. Pacii", 67, "Centru", 2, true,65000m);

            var garoniera1 = new ImobiliareGarsoniere("Aleea Criva",40,"Centru",1,true,28000m);
            var garoniera2 = new ImobiliareGarsoniere("Strada Oierilor", 43, "Centru", 1, false, 30000m);
            var garoniera3 = new ImobiliareGarsoniere("Strada Cuza Voda", 50, "Periferie", 1, true, 15000m);
            var garoniera4 = new ImobiliareGarsoniere("Aleea Voievozilor", 49, "Periferie", 1, false, 14000m);
            var garoniera5 = new ImobiliareGarsoniere("Strada Duzilor", 54, "Centru", 1, true, 32000m);

            var casa1 = new ImobliareCase(5,"Strada Viilor",100,"Periferie",2,false,55000m);
            var casa2 = new ImobliareCase(9, "Aleea Ciresilor", 130, "Periferie", 4, true, 95000m);
            var casa3 = new ImobliareCase(7, "Strada George Stan", 120, "Periferie", 3, true, 85000m);
            var casa4 = new ImobliareCase(6, "Strada Ghica", 110, "Periferie", 2, false, 65000m);
            var casa5 = new ImobliareCase(4, "Bulevardul Cuza", 90, "Centru", 2, false, 65000m);

            //we apply the selling price in every case
            //the price commission on the apartament is 0.5%
            apartament1.Change_Price(15000m);
            apartament1.Selling_Price(11000m);
            //the price commission on the garsoniera is 0%
            garoniera1.Change_Price(15000m);
            garoniera1.Selling_Price(9000m);
            //the price commission on the casa is 0.9%
            casa1.Change_Price(60000m);
            casa1.Selling_Price(58000m);

            Console.WriteLine(apartament1.Price);
            Console.WriteLine(garoniera1.Price);
            Console.WriteLine(casa1.Price);

        }
    }
}
