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
            string estate;
            decimal initial_price;
            int sqm;
            string loc, cond;
            Console.WriteLine("Welcome to our Real Estate Agency!");
            Console.WriteLine("What are you looking for?(House/Flat/Studio)");
            estate= Console.ReadLine();
            Console.WriteLine(" ");

            if (estate == "House")
            {
                Console.WriteLine("How much are you willing to pay?");
                initial_price = decimal.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("How many square meters?");
                sqm = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Choose a location (center/somewhere ok/suburbs)");
                loc = Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine("Choose the house condition(new/medium/old)");
                cond = Console.ReadLine();
                Console.WriteLine(" ");
                try
                {
                    House house = new House(initial_price, sqm, loc, cond);
                    Console.WriteLine("The price of this house(based on the price you are willing to pay) is: " + house.get_price_to_pay() + " with the poundage:" + house.get_poundage() + ", so the total price will be " + house.get_price());

                }
                catch (SquareMetersException e)
                {
                    Console.WriteLine("Not a lot of space to live in! Reconsider your option!", e);
                }
                catch (UninhabitableException e)
                {
                    Console.WriteLine("A place too old to live in! Danger zone!", e);
                }
            }
            else if (estate == "Flat")
            {
                Console.WriteLine("How much are you willing to pay?");
                initial_price = decimal.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("How many square meters?");
                sqm = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Choose a location (center/somewhere ok/suburbs)");
                loc = Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine("Choose the house condition(new/medium/old)");
                cond = Console.ReadLine();
                Console.WriteLine(" ");
                try
                {
                    Flat flat = new Flat(initial_price, sqm, loc, cond);
                    Console.WriteLine("The price of this flat(based on the price you are willing to pay) is: " + flat.get_price_to_pay() + " with the poundage:" + flat.get_poundage() + ", so the total price will be " + flat.get_price());
                }
                catch (SquareMetersException e)
                {
                    Console.WriteLine("Not a lot of space to live in! Reconsider your option!", e);
                }
                catch (UninhabitableException e)
                {
                    Console.WriteLine("A place too old to live in! Danger zone!", e);
                }

            }
            else if (estate == "Studio")
            {
                Console.WriteLine("How much are you willing to pay?");
                initial_price = decimal.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("How many square meters?");
                sqm = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Choose a location (center/somewhere ok/suburbs)");
                loc = Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine("Choose the house condition(new/medium/old)");
                cond = Console.ReadLine();
                Console.WriteLine(" ");
                try
                {

                    Studio studio = new Studio(initial_price, sqm, loc, cond);
                    Console.WriteLine("The price of this studio(based on the price you are willing to pay) is: " + studio.get_price_to_pay() + " with the poundage:" + studio.get_poundage() + ", so the total price will be" + studio.get_price());
                }
                catch (SquareMetersException e)
                {
                    Console.WriteLine("Not a lot of space to live in! Reconsider your option!", e);
                }
                catch (UninhabitableException e)
                {
                    Console.WriteLine("A place too old to live in! Danger zone!", e);
                }
                
            }
               
              
               
                Console.WriteLine("Thank you for choosing us! We hope you found what you were looking for!");
        }
    }
}
