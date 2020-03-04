using System.IO;
using System;
public abstract class Building
{
    public decimal Price, AgentCommission;
    public string Address;
    
    public abstract decimal CalculateAgentCommission(decimal price);
}

public class House : Building
{   
    public House (string Address, decimal price){
        this.Address=Address;
        this.Price=price;
        this.AgentCommission=CalculateAgentCommission(price);
    }

    public override decimal CalculateAgentCommission(decimal price){
        return 0.03m*price;
    }
}

public class Apartment : Building
{
    public Apartment (string Address, decimal price){
        this.Address=Address;
        this.Price=price;
        this.AgentCommission=CalculateAgentCommission(price);
    }

    public override decimal CalculateAgentCommission(decimal price){
        return 0.027m*price;
    }
}

public class StudioApartment : Building
{
    public StudioApartment (string Address, decimal price){
        this.Address=Address;
        this.Price=price;
        this.AgentCommission=CalculateAgentCommission(price);
    }

    public override decimal CalculateAgentCommission(decimal price){
        return 0.02m*price;
    }
}
					
public class Program
{
	public static void Main()
	{
		 House casa=new House("Strada Casei", 100000m);
		Apartment apartament= new Apartment("Strada Blabla", 45000m);
		StudioApartment garsoniera = new StudioApartment("Strada 2", 25000m);
		Console.WriteLine("Agent's comission for listing in " + casa.Address+": "+casa.AgentCommission);
		Console.WriteLine("Agent's comission for listing in " + apartament.Address+": "+apartament.AgentCommission);
		Console.WriteLine("Agent's comission for listing in " + garsoniera.Address+": "+garsoniera.AgentCommission);
	}					
}
