using System;

public abstract class Elements {
    public decimal Price;
    public string Address;
    public decimal Commision;
   
}

public class House: Elements
{
    public House(string Address, decimal price, decimal Commision)
    {
        this.Address = Address;
        this.Price = price;
        this.Commision = Commision;
    }
}
public class Apartment : Elements
{
    public Apartment(string Address, decimal price, decimal Commision)
    {
        this.Address = Address;
        this.Price = price;
        this.Commision = Commision;
    }
}
public class OneRoomApartment : Elements
{
    public OneRoomApartment(string Address, decimal price, decimal Commision)
    {
        this.Address = Address;
        this.Price = price;
        this.Commision = Commision;
    }

}
class Program: Elements
{
        static void Main(string[] args)
        {
        Console.WriteLine("Choose an option: ");
        Console.WriteLine("House -> price and comission for house");
        Console.WriteLine("Apartment -> price and comission for an apartment");
        Console.WriteLine("OneRoomApartment -> price and comission for a one-room apartment");
        Console.WriteLine("Option: ");     
        String option = Console.ReadLine();       
        switch (option)
        {
            case "House":
                House house = new House("Middle Street nr.78", 270500m, 0.025m);
                House house2 = new House("Middle Street nr.77", 425000m, 0.025m);
                House house3 = new House("Right Street nr.5", 165000m, 0.087m);
                Console.WriteLine("");
                Console.WriteLine("Address: "+house.Address);
                Console.WriteLine("Price for the house situated in " + house.Address + " is: " + house.Price);
                Console.WriteLine("Commision for the house situated in " + house.Address + " is: " + house.Commision*house.Price);
                Console.WriteLine("");
                Console.WriteLine("Address: " + house2.Address);
                Console.WriteLine("Price for the house situated in " + house2.Address + " is: " + house2.Price);
                Console.WriteLine("Commision for the house situated in " + house2.Address + " is: " + house2.Commision * house2.Price);
                Console.WriteLine("");
                Console.WriteLine("Address: " + house3.Address);
                Console.WriteLine("Price for the house situated in " + house3.Address + " is: " + house3.Price);
                Console.WriteLine("Commision for the house situated in " + house3.Address + " is: " + house3.Commision * house3.Price);
                break;
            case "Apartment":
                Apartment apartment = new Apartment("Fox Street nr.2", 105000m, 0.0825m);
                Apartment apartment2 = new Apartment("Train Boulevard nr.201", 850000m, 0.125m);
                Console.WriteLine("");
                Console.WriteLine("Address: " + apartment.Address);
                Console.WriteLine("Price for the apartment situated in " + apartment.Address + " is: " + apartment.Price);
                Console.WriteLine("Commision for the apartment situated in " + apartment.Address + " is: " + apartment.Commision * apartment.Price);
                Console.WriteLine("");
                Console.WriteLine("Address: " + apartment2.Address);
                Console.WriteLine("Price for the apartment situated in " + apartment2.Address + " is: " + apartment2.Price);
                Console.WriteLine("Commision for the apartment situated in " + apartment2.Address + " is: " + apartment.Commision * apartment2.Price);
                break;
            case "OneRoomApartment":
                OneRoomApartment oneroomapartment = new OneRoomApartment("Grove Street nr.55", 89999m, 0.05m);
                Console.WriteLine("");
                Console.WriteLine("Address: " + oneroomapartment.Address);
                Console.WriteLine("Price for the singleroom situated in " + oneroomapartment.Address + " is: " + oneroomapartment.Price);
                Console.WriteLine("Commision for the singleroom situated in " + oneroomapartment.Address + " is: " + oneroomapartment.Commision * oneroomapartment.Price);
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
        }
}

