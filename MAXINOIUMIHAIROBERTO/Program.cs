/*
 We have to analyze 3 real estate:
 House:The basic price is around 30.000(30k)
 Apartment:The basic price is around 25.000(25k)
 SingleRoom:The basic price is around 18.000(18k)
Factors that influence the price:
location,surface, furnished, compartmentalization type, parking space, balcony, floor;
Each feature has a percentage by which it influences the price of the building and each feature
is different for the three types of real estate:
                House:          Apartment:          SingleRoom:
Location:       25-50%           20-45%                 15-40%
Surface:        15-30%           10-20%                 10-20%   
Furnished:       5-20%            7-18%                  4-15%  
Compart_Type:    0-15%            0-12%                   0-9%
Balcony:          0-5%             0-3%                 0-1.5%  
ParckingSpace: yard=0-15%          5-15%                 3-13% 
Floor:           -------          3-12%                   1-9%
 
Let's calculate the fee for the real estate agent:
                   House:          Apartment:          SingleRoom:
Basic:              3%                 2%                1%
Location:           1-3%               1-2%            0.5-1%
Surface:            1-2%             1-1.5%         0.5-0.75%  
Furnished:          0.5%              0.25%                -  
ParckingSpace:    0.5-1%          0.25-0.5%        0.15-0.25% 
  
BuildingBasicPrice(BBP)
 Surface :                                                   Balcony:
 ------>1m^2--->Center= 500$                                  House: 5% * BBP
 ------>1m^2--->Tudor/Pacurari= 300$                           Apartment: 3% * BBP
 ------>1m^2--->Bucium= 200$                                    SingleRoom: 2% * BBP        
 Compart_Type: furnished: 20% * BBP
 
 ParkingSpace:                                              Floor:
 House: 10% * BBP                                           House: 10% * BBP
 Apartment: 15% * BBP                                       Apartment: 15% * BBP
 SingleRoom: 5% * BBP                                       SingleRoom: 5% * BBP
  
  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static PooPrincipii.RealEstateAgency;

namespace PooPrincipii
{
    
    public abstract class RealEstateAgency {
        public enum LocationType
        {
            Center = 50,
            Tudor = 35,
            Bucium = 25
        }
       /* public enum BuildingType { 
        House=0,
        Apartment=1,
        SingleRoom=2
        }*/

        /*double Surface;
        bool Furnished;
        bool CompartmentType;
        bool ParkingSpace, Balcony, Floor;*/
        protected string filepath = "D:\\.net projects\\PooPrincipii\\Buildings.txt";

        protected double AgentHouseFee, AgentApartmentFee, AgentSingleRoomFee;
        protected  LocationType _locationType;

        public object Surface { get; private set; }
        public object Price { get;  private set; }
        public object Furnished { get; private set; }
        public object CompartmentType { get; private  set; }
        public object ParkingSpace { get; private  set; }
        public object Balcony { get; private  set; }
        public object Floor { get; private  set; }
        

        /* public RealEstateAgency(LocationType Location)
         {
             _locationType = Location;
         }*/

        protected abstract double LocationFee(LocationType location, double BuildingBasicPrice);
        protected abstract double SurfaceFee(double Surface);
        protected abstract double CompartTypeFee(bool CompartmentType, double BuildingBasicPrice);
        protected abstract double ParkingSpaceFee(bool ParkingSpace, double BuildingBasicPrice);
        protected abstract double BalconyFee(bool Balcony, double BuildingBasicPrice);
        protected abstract double FloorFee(bool Floor, double BuildingBasicPrice);


        //  protected abstract void CalculatePrice(LocationType location,double Surface,bool CompartmentType,bool ParkingSpace,bool Balcony, bool Floor, double BuildingBasicPrice);
        //protected abstract void CalculateAgentFee(LocationType location, double Surface, bool CompartmentType, bool ParkingSpace, bool Balcony, bool Floor,bool Furnished, double BasicFee, double BuildingBasicPrice);

        public void CalculateFromFile(string filepath)
        {
            if (filepath is null)
            {
                throw new ArgumentNullException(nameof(filepath));
            }

            else
            {

                List<RealEstateAgency> Buildings = new List<RealEstateAgency>();

                List<string> lines = File.ReadAllLines(filepath).ToList();
                foreach (string line in lines)
                {
                    string[] block = line.Split(",");
                    if (String.Compare(block[0],"House")==0)
                    {
                        AgentHouseFee = 0.03;
                        House newHouse = new House();
                        newHouse.houseLocation = block[1];
                        newHouse.Surface = Convert.ToDouble( block[2]);
                        newHouse.Furnished = Convert.ToBoolean(block[3]);
                        newHouse.CompartmentType = Convert.ToBoolean(block[4]);
                        newHouse.ParkingSpace = Convert.ToBoolean(block[5]);
                        newHouse.Balcony = Convert.ToBoolean(block[6]);
                        newHouse.Floor = Convert.ToBoolean(block[7]);
                        newHouse.Price = Convert.ToDouble(block[8]);

                        Buildings.Add(newHouse);

                    }
                    else if (String.Compare(block[0], "Apartment") == 0)
                    {
                        AgentApartmentFee = 0.02;
                        Apartment newApartment = new Apartment();
                        newApartment.apartmentLocation = block[1];
                        newApartment.Surface = Convert.ToDouble(block[2]);
                        newApartment.Furnished = Convert.ToBoolean(block[3]);
                        newApartment.CompartmentType = Convert.ToBoolean(block[4]);
                        newApartment.ParkingSpace = Convert.ToBoolean(block[5]);
                        newApartment.Balcony = Convert.ToBoolean(block[6]);
                        newApartment.Floor = Convert.ToBoolean(block[7]);
                        newApartment.Price = Convert.ToDouble(block[8]);

                        Buildings.Add(newApartment);
                    }
                    else {
                        AgentSingleRoomFee = 0.01;
                        SingleRoom newSingleRoom = new SingleRoom();
                        newSingleRoom.SingleRoomLocation = block[1];
                        newSingleRoom.Surface = Convert.ToDouble(block[2]);
                        newSingleRoom.Furnished = Convert.ToBoolean(block[3]);
                        newSingleRoom.CompartmentType = Convert.ToBoolean(block[4]);
                        newSingleRoom.ParkingSpace = Convert.ToBoolean(block[5]);
                        newSingleRoom.Balcony = Convert.ToBoolean(block[6]);
                        newSingleRoom.Floor = Convert.ToBoolean(block[7]);
                        newSingleRoom.Price = Convert.ToDouble(block[8]);

                        Buildings.Add(newSingleRoom); 
                    }

                    
                }
                foreach (var building in Buildings) {
                    Console.WriteLine($"{building._locationType } {building.Surface } { building.Furnished} {building.CompartmentType} " +
                        $"{building.ParkingSpace} {building.Balcony} {building.Floor} {building.Price}");
                }
            }

        }

        public class RealEstateBuilding : RealEstateAgency
        {
            public RealEstateAgency b;
            protected override double BalconyFee(bool Balcony, double BuildingBasicPrice)
            {
                throw new NotImplementedException();
            }

            protected override double CompartTypeFee(bool CompartmentType, double BuildingBasicPrice)
            {
                throw new NotImplementedException();
            }

            protected override double FloorFee(bool Floor, double BuildingBasicPrice)
            {
                throw new NotImplementedException();
            }

            protected override double LocationFee(LocationType location, double BuildingBasicPrice)
            {
                throw new NotImplementedException();
            }

            protected override double ParkingSpaceFee(bool ParkingSpace, double BuildingBasicPrice)
            {
                throw new NotImplementedException();
            }

            protected override double SurfaceFee(double Surface)
            {
                throw new NotImplementedException();
            }

            public RealEstateBuilding() {
                

            }
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {

            House house1 = new House(RealEstateAgency.LocationType.Center, 150, true, true, true, true, true,30000);
            house1.CalculatePrice(RealEstateAgency.LocationType.Center, 150, true, true, true, true, true, 30000);
            Console.WriteLine();
            house1.CalculateAgentFee(RealEstateAgency.LocationType.Center, 150, true, true, true, true, true,0.03, 30000);
           
            Console.WriteLine("\n"); Console.WriteLine("\n");
            
            SingleRoom SG1 = new SingleRoom(RealEstateAgency.LocationType.Tudor, 80, true, false, false, true, true,18000);
            SG1.CalculatePrice(RealEstateAgency.LocationType.Tudor, 80, true, false, false, true, true,18000);
            Console.WriteLine();
            SG1.CalculateAgentFee(RealEstateAgency.LocationType.Tudor, 80, true, false, false, true, true,0.01, 18000);
            
            Apartment apartment1 = new Apartment();
            apartment1.CalculatePrice(RealEstateAgency.LocationType.Bucium, 120, true, true, true, true, true,25000);
            Console.WriteLine();
            apartment1.CalculateAgentFee(RealEstateAgency.LocationType.Bucium, 120, true, true, true, true, true, 0.02, 25000);
        
            string filepath = @"D:\.net projects\PooPrincipii\Buildings.txt";
            RealEstateAgency newBuilding = new RealEstateBuilding();
            newBuilding.CalculateFromFile(filepath);
            
            
            
        }
   
    }
}
