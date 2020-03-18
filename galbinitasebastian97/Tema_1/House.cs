using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_1
{
    public class House:Estate
    {


        public  static List<House> HouseData()
        {
            List<House> Houses = new List<House>();
            Houses.Add(new House { Id = count, Addres = "Str.Bacinschi", Price = 101231m, Dimensions = "200*200", Commission = 0.9, Name = "House" + count });
            Houses.Add(new House { Id = count, Addres = "Str.Costache Negruzzi", Price = 32321m, Dimensions = "200*200", Commission = 0.2, Name = "House" + count });
            Houses.Add(new House { Id = count, Addres = "Str.Cuza Voda", Price = 2312m, Dimensions = "200*200", Commission = 0.3, Name = "House" + count });
            Houses.Add(new House { Id = count, Addres = "Str.Ioan C.Bratianu", Price = 1999m, Dimensions = "200*200", Commission = 0.4, Name = "House" + count });
            Houses.Add(new House { Id = count, Addres = "Str.Golia", Price = 31231m, Dimensions = "200*200", Commission = 0.34, Name = "House" + count });
            return Houses;
        }
        public static void Show(List<House> Houses)
        {
            foreach (var House in Houses)
            {
                Console.WriteLine($"{House.Id} {House.Addres} {House.Dimensions} {House.Price} {House.Name}");
            }
        }
        public int rooms()
        {
            return 1;
        }
    }
}
