using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_1
{
    public class Studio:Estate
    {
        public static List<Studio> StudioData()
        {
            List<Studio> output = new List<Studio>();
            output.Add(new Studio { Id = count, Addres = "Str.Teodor Codrescu,nr.7,C10", Price = 2000m, Dimensions = "200*200", Commission = 0.2, Name = "House" + count });
            output.Add(new Studio { Id = count, Addres = "Str.Gheorghe Asachi", Price = 2000m, Dimensions = "200*200", Commission = 0.2, Name = "House" + count });
            output.Add(new Studio { Id = count, Addres = "Aleea Veronica Micle,nr.7,C10", Price = 2000m, Dimensions = "200*200", Commission = 0.2, Name = "House" + count });
            output.Add(new Studio {  Id = count, Addres = "Str.Geeral Henru Mathias Berthelot", Price = 2000m, Dimensions = "200*200", Commission = 0.2, Name = "House" + count });
            output.Add(new Studio { Id = count, Addres = "Str.Pinului", Price = 2000m, Dimensions = "200*200", Commission = 0.2, Name = "House" + count });
            return output;
        }
        public static void Show(List<Studio> Studios)
        {
            foreach (var Studio in Studios)
            {
                Console.WriteLine($"{Studio.Id} {Studio.Addres} {Studio.Dimensions} {Studio.Price} {Studio.Name} ");
            }
           
        }

        public int rooms()
        {
            return 1;
        }
    }
}
