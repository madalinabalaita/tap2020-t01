using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_1
{
    public class Apartment:Estate
    {
        public static List<Apartment> ApartmentData()
        {
            List<Apartment> output = new List<Apartment>();
            output.Add(new Apartment { Id = count, Addres = "Str.Teodor Codrescu,nr.7,C10", Price = 1231m, Dimensions = "200*200", Commission = 0.3, Name = "House" + count });
            output.Add(new Apartment { Id = count, Addres = "Str. Doctor Victor Babes, Iasi", Price = 2222m, Dimensions = "130m*m", Commission = 0.1, Name = "House"+count });
            output.Add(new Apartment { Id = count, Addres = "Str.Pojaniciei", Price = 123123m, Dimensions = "200*200", Commission = 4.0, Name = "House" + count });
            output.Add(new Apartment { Id = count, Addres = "Str.Toma Cozma", Price = 9754m, Dimensions = "200*200", Commission = 0.5, Name = "House" + count });
            output.Add(new Apartment { Id = count, Addres = "Str.Florilor", Price = 3834m, Dimensions = "200*200", Commission = 0.3, Name = "House" + count });
            return output;
        }
        public static void Show(List<Apartment> Apartments)
        {
            foreach (var Apartment in Apartments)
            {
                Console.WriteLine($"{Apartment.Id} {Apartment.Addres} {Apartment.Dimensions} {Apartment.Price} {Apartment.Name} ");
            }
        }
        public int rooms()
        {
            return 1;
        }
    }
}
