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
            int sqm,cad_nr;
            string loc, cond;
            Console.WriteLine("Welcome to our Real Estate Agency!");
            Console.WriteLine("What are you looking for?(House/Flat/Studio/Land)");
            estate = Console.ReadLine();
            Console.WriteLine(" ");

            if (estate == "House")
            {
                var finalPrice = new PriceCalculator();
                var initialPrice = new InitialPrice();
                var calculator = new ComissionCalculator();
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
                    House house = new House(sqm, loc, cond);
                    Console.WriteLine("(Price withouth fee:" + initialPrice.get_price_fromLandlord(house) + " , the poundage:" + calculator.get_poundage(house, initialPrice.get_price_fromLandlord(house)) + ")" + "The total price of this house is: " + finalPrice.get_price(house));

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
                var finalPrice = new PriceCalculator();
                var initialPrice = new InitialPrice();
                var calculator = new ComissionCalculator();
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
                      Flat flat = new Flat( sqm, loc, cond);
                    Console.WriteLine("(Price withouth fee:" + initialPrice.get_price_fromLandlord(flat) + " , the poundage:" + calculator.get_poundage(flat, initialPrice.get_price_fromLandlord(flat)) + ")" + "The total price of this house is: " + finalPrice.get_price(flat));
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
                var finalPrice = new PriceCalculator();
                var initialPrice = new InitialPrice();
                var calculator = new ComissionCalculator();
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

                      Studio studio = new Studio( sqm, loc, cond);
                    Console.WriteLine("(Price withouth fee:" + initialPrice.get_price_fromLandlord(studio) + " , the poundage:" + calculator.get_poundage(studio, initialPrice.get_price_fromLandlord(studio)) + ")" + "The total price of this house is: " + finalPrice.get_price(studio));
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
          /*  else if (estate == "Land")
            {

                Console.WriteLine("How many square meters?");
                sqm = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Choose a location (543345/23214/61321)");
                cad_nr = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Choose the usage(intravilan/extravilan)");
                cond = Console.ReadLine();
                Console.WriteLine(" ");
                
                    UrbanLand land = new UrbanLand(sqm, cad_nr, cond);
                    Console.WriteLine("(Price withouth fee:" + land.get_price_from_landlord() + " , the poundage:" + land.get_poundage() + ")" + "The total price of this land is: " + land.get_price());
              

            }*/



            Console.WriteLine("Thank you for choosing us! We hope you found what you were looking for!");
        }

    }
    }
