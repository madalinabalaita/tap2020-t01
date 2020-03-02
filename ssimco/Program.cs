using System;
using re=real_estate;
namespace ssimco
{
    class Program
    {
        static void Main(string[] args)
        {
            re.House house=new re.House(350000m);
            re.Flat flat=new re.Flat(50000m);
            re.Studio_Flat studio_Flat=new re.Studio_Flat(25000m);
            Console.WriteLine("House price:"+house.get_price());
            Console.WriteLine("Flat price:"+flat.get_price());
            Console.WriteLine("Studio Flat price:"+studio_Flat.get_price());
        }
    }
}
