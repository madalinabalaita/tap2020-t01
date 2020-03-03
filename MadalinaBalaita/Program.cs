using System;

namespace Imobile
{
    public class SquareMetersException : Exception
    {
        public SquareMetersException() { }
       
    }

    public class UninhabitableException : Exception
    {
        public UninhabitableException() { }

    }

    class Program
    {

      
        static void Main(string[] args)
        {
            
            try
           {
                House house = new House(200000m, 70, "center", "old");
                Console.WriteLine("The price of the house is: " + house.get_price());
            }
             catch(SquareMetersException e)
            {
                Console.WriteLine("Not a lot of space to live in!", e);
            }
            catch (UninhabitableException e)
            {
                Console.WriteLine("A place too old to live in! Danger zone!", e);
            }

            Flat flat1 = new Flat(58000m, 80, "somewhere ok", "new");
            Console.WriteLine("The price of the a flat is: " + flat1.get_price());
            try
            {
                Flat flat2 = new Flat(62000m,49, "suburbs", "really old");
                Console.WriteLine("The price of the a flat is: " + flat2.get_price());
            }
            catch (SquareMetersException e)
            {
                Console.WriteLine("Not a lot of space to live in !", e);
            }
            catch (UninhabitableException e)
            {
                Console.WriteLine("A place too old to live in! Danger zone!", e);
            }

            Studio studio1 = new Studio(31000m, 20, "somewhere ok", "old");
            Console.WriteLine("The price of the studio is: " + studio1.get_price());
            try
            {
                
                Studio studio2 = new Studio(30000m, 14, "somewhere ok", "old");
                Console.WriteLine("The price of the studio is: " + studio2.get_price());
            }
            catch(SquareMetersException e)
            {
                Console.WriteLine("Not a lot of space to live in !",e);
            }
            catch(UninhabitableException e)
            {
                Console.WriteLine("A place too old to live in! Danger zone!", e);
            }

        }
    }
}
