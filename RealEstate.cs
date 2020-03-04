using System;
namespace Andreea523
{
    public abstract class RealEstate
    {
       static private double[] housePrice = { 200, 150.34, 450.12, 100 };
       static private double[] apartmentPrice = { 50.58, 85.55, 110.87, 76.87 };
       static private double[] singleRoomPrice = { 20.34, 25.87, 21.98, 30.50 };
        static private string choose, val, realEstate, priceRealEstate;
        static private double priceRealEstateDouble;
        public double Price{get; private set; }
        protected abstract double CalculationCommissionn(double price);
        static void Main(string[] args)
        {

            Console.WriteLine("Choose 1 if you want to calculate the commission for the real estate give by you, or 2 for calculate commission for the real estate from data base!");

            val = Console.ReadLine();
            switch (val)
            {
                case "1":
                    Console.Write("Choose for what type of real estate you need to calculate the commission (single room, apartment, house): ");
                    realEstate = Console.ReadLine();
                    switch (realEstate)
                    {
                        case "single room":
                            SingleRoom room = new SingleRoom();
                            Console.Write("The price for a single room is: ");
                            priceRealEstate = Console.ReadLine();
                            priceRealEstateDouble = Convert.ToDouble(priceRealEstate);
                                Console.Write("Commission for single room  with price " + priceRealEstateDouble + " is: ");
                                Console.WriteLine(room.CalculationCommissionn(priceRealEstateDouble));
                            
                            break;
                        case "apartment":
                            Apartment apartment = new Apartment();
                            Console.Write("The price for an apartment is: ");
                            priceRealEstate = Console.ReadLine();
                            priceRealEstateDouble = Convert.ToDouble(priceRealEstate);
                            Console.Write("Commission for apratment with price " + priceRealEstateDouble  + " is: ");
                                Console.WriteLine(apartment.CalculationCommissionn(priceRealEstateDouble));
                         
                            break;
                        case "house":
                            House house = new House();
                            Console.Write("The price for a house is: ");
                            priceRealEstate = Console.ReadLine();
                            priceRealEstateDouble = Convert.ToDouble(priceRealEstate);
                            Console.Write("Commission for house with price " + priceRealEstateDouble + " is: ");
                                Console.WriteLine(house.CalculationCommissionn(priceRealEstateDouble));
                            
                            break;
                            default:
                               Console.Write("You must to choose one of the single room, apartment, hose!");
                               break;

                    }

                    break;
                case "2":
                    Console.Write("Choose for what type of real estate you need to calculate the commission (single room, apartment, house): ");
                    choose = Console.ReadLine();
                    switch (choose)
                    {
                        case "single room":
                            SingleRoom room = new SingleRoom();
                            for (int i = 0; i < singleRoomPrice.Length; i++)
                            {
                                Console.Write("Commission for single room  with price " + singleRoomPrice[i] + " is: ");
                                Console.WriteLine(room.CalculationCommissionn(singleRoomPrice[i]));
                            }
                            break;
                        case "apartment":
                            Apartment apartment = new Apartment();
                            for (int i = 0; i < apartmentPrice.Length; i++)
                            {
                                Console.Write("Commission for apratment with price " + apartmentPrice[i] + " is: ");
                                Console.WriteLine(apartment.CalculationCommissionn(apartmentPrice[i]));
                            }
                            break;
                        case "house":
                            House house = new House();
                            for (int i = 0; i < housePrice.Length; i++)
                            {
                                Console.Write("Commission for house with price " + housePrice[i] + " is: ");
                                Console.WriteLine(house.CalculationCommissionn(housePrice[i]));
                            }
                            break;
                            default:
                               Console.Write("You must to choose one of the single room, apartment, hose!");
                               break;

                    }
                    break;
                default:
                    Console.Write("You can choose 1 or 2!");
                    break;

            }


        }
       
    }
}
