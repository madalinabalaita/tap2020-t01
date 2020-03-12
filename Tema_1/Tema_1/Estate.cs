using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_1
{
    public class Estate
    {
       public static int count = 0;

       public int Id { get;  set; }
       public string Addres { get; set; }
       public decimal Price { get;  set; }
       public string Dimensions {  get; set; }
       public double Commission { get;  set; }
       public string Name { get; set; }
        public Estate()
        {
            count++;
        }
        ~Estate()
        {
            count--;
        }
        public static int getCount()
        {
            return count;
        }


    }
}
