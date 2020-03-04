using System;
public enum ImobilType
{
    House,
    Apartment,
    SingleRoom
}

public class Imobil
{
    public decimal price;
    public int[] price_house = new int[5];
    public int[] price_apartment = new int[5];
    public int[] price_singleroom = new int[5];
    private readonly ImobilType _imobilType;

    public void set_price_house()
    {
        this.price_house[1] = 100000;
        this.price_house[2] = 200000;
        this.price_house[3] = 300000;
    }

    public void set_price_apartment()
    {
        this.price_apartment[1] = 20000;
        this.price_apartment[2] = 30000;
        this.price_apartment[3] = 40000;
    }

    public void set_price_singleroom()
    {
        this.price_singleroom[1] = 10000;
        this.price_singleroom[2] = 20000;
        this.price_singleroom[3] = 30000;
    }

    public int CalculatePrice(int criterion)
    {
        switch (_imobilType)

        {
            case ImobilType.House:
                return price_house[criterion];
            case ImobilType.Apartment:
                return this.price_apartment[criterion];
            case ImobilType.SingleRoom:
                return this.price_singleroom[criterion];
            default:
                return 0;
        }
    }

    public Imobil(ImobilType imobilType)
    {
        _imobilType = imobilType;
    }

    public ImobilType ImobilType { get { return _imobilType; } }


    public int set_get_price(int price)
    {
        this.price = price;
        return price;
    }

    public double CalculateCoomission(double amount)
    {
        switch(_imobilType)
        
        { case ImobilType.House:
            return amount /15;
        case ImobilType.Apartment:
            return amount /15;
        case ImobilType.SingleRoom:
            return amount / 15;
        default:
            return 0;
        }
    }
}
namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Imobil e2 = new Imobil(ImobilType.Apartment);
            Imobil e3 = new Imobil(ImobilType.SingleRoom); 
            Imobil e1 = new Imobil(ImobilType.House);
            e2.set_price_apartment();
            e1.set_price_house();
            e3.set_price_singleroom();

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("||Please select the type of place you want :   ||");
            Console.WriteLine("||1)House                                      ||");
            Console.WriteLine("||2)Apartment                                  ||");
            Console.WriteLine("||3)Single Room                                ||");
            Console.WriteLine("||(select 1, 2 or 3)                           ||");
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Console.WriteLine("||You selected: "+e1.ImobilType+"                          ||");
                Console.WriteLine("||How many floors do want ?                    ||");
                Console.WriteLine("||1)Single floor                               ||");
                Console.WriteLine("||2)Two floors                                 ||");
                Console.WriteLine("||3)Two floors and attic                       ||");
                Console.WriteLine("||(select 1, 2 or 3)                           ||");
                int nr_rooms = int.Parse(Console.ReadLine());
                Console.WriteLine("||The price is: "+ e1.CalculatePrice(nr_rooms) + "$                         ||");
                Console.WriteLine("||Our commission is: "+ e1.CalculateCoomission(e1.CalculatePrice(nr_rooms))+"$  :)                  ");
            }

            if (select == 3)
            {
                Console.WriteLine("||You selected: " + e3.ImobilType + "                     ||");
                Console.WriteLine("||How many square feet do you want ?           ||");
                Console.WriteLine("||1)20                                         ||");
                Console.WriteLine("||2)25                                         ||");
                Console.WriteLine("||3)25 and balcony                             || ");
                Console.WriteLine("||(select 1, 2 or 3)                           ||");
                int nr_rooms = int.Parse(Console.ReadLine());
                Console.WriteLine("||The price is: " + e3.CalculatePrice(nr_rooms) + "$                         ||");
                Console.WriteLine("||Our commission is: " + e3.CalculateCoomission(e3.CalculatePrice(nr_rooms)) + "$  :)                  ");
            }

            if (select == 2)
            {
                Console.WriteLine("||You selected: " + e2.ImobilType + "                      ||");
                Console.WriteLine("||How many rooms do you want ?                 ||");
                Console.WriteLine("||1)Two rooms                                  ||");
                Console.WriteLine("||2)Three rooms                                ||");
                Console.WriteLine("||3)Four rooms                                 || ");
                Console.WriteLine("||(select 1, 2 or 3)                           ||");
                int nr_rooms = int.Parse(Console.ReadLine());
                Console.WriteLine("||The price is: " + e2.CalculatePrice(nr_rooms) + "$                         ||");
                Console.WriteLine("||Our commission is: " + e2.CalculateCoomission(e2.CalculatePrice(nr_rooms)) + "$  :)                  ");
            }


        }
    }
}
