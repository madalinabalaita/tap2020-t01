using System;
using System.Collections.Generic;
using System.Text;

namespace PooPrincipii
{
   public class SingleRoom : RealEstateAgency
    {
        double TotalPrice = 0;
        public string SwitchError = "Something go wrong...";
        public string SingleRoomLocation;
        /* private const LocationType SingleRoom_Center = LocationType.Center;
         private const LocationType SingleRoom_Tudor = LocationType.Tudor;
         private const LocationType SingleRoom_Bucium = LocationType.Bucium;*/


        public double Surface { get;  set; }
        public double Price { get; set; }
        public bool Furnished { get;  set; }
        public bool CompartmentType { get;  set; }
        public bool ParkingSpace { get;  set; }
        public bool Balcony { get;  set; }
        public bool Floor { get;  set; }
        public SingleRoom(LocationType Location,
                     double Surface,
                     bool Furnished,
                     bool CompartmentType,
                     bool ParkingSpace,
                     bool Balcony,
                     bool Floor, 
                     double Price) 
        {
            _locationType = Location;
            this.Surface = Surface;
            this.Furnished = Furnished;
            this.CompartmentType = CompartmentType;
            this.ParkingSpace = ParkingSpace;
            this.Balcony = Balcony;
            this.Floor = Floor;
            this.Price = Price;
        }
        public SingleRoom() { }

        protected override double LocationFee(LocationType location, double BuildingBasicPrice)
        {
            double LocationPrice = 0;
            switch (location)
            {
                case LocationType.Center:
                    {
                        double v = 0.4 * BuildingBasicPrice;
                        LocationPrice = v;
                        return LocationPrice;
                    }
                case LocationType.Tudor:
                    {
                        double v = 0.2 * BuildingBasicPrice;
                        LocationPrice = v;
                        return LocationPrice;
                    }
                case LocationType.Bucium:
                    {
                        double v = 0.15 * BuildingBasicPrice;
                        LocationPrice = v;
                        return LocationPrice;
                    }
                default: return 0;
            }
        }
        protected override double SurfaceFee(double Surface)
        {
            double SurfacePrice = 0;
            switch (_locationType)
            {
                case LocationType.Center:
                    {
                        int SurfacePricePerM2 = 400;
                        double v = Surface * SurfacePricePerM2;
                        SurfacePrice = v;
                        return SurfacePrice;
                    }

                case LocationType.Tudor:
                    {
                        int SurfacePricePerM2 = 250;
                        double v = Surface * SurfacePricePerM2;
                        SurfacePrice = v;
                        return SurfacePrice;
                    }

                case LocationType.Bucium:
                    {
                        int SurfacePricePerM2 = 200;
                        double v = Surface * SurfacePricePerM2;
                        SurfacePrice = v;
                        return SurfacePrice;
                    }


                default: return 0;
            }
        }

        protected override double ParkingSpaceFee(bool ParkingSpace, double BuildingBasicPrice)
        {
            if (ParkingSpace == true)
            {
                switch (_locationType)
                {
                    case LocationType.Center:
                        {

                            return 0.13 * BuildingBasicPrice;
                        } 
                    case LocationType.Tudor:
                        {
                            return 0.08 * BuildingBasicPrice;
                        }
                    case LocationType.Bucium:
                        {
                            return 0.03 * BuildingBasicPrice;
                        }
                    default: throw new Exception(SwitchError);
                }

            }
            else
            {
                return 0;
            }

        }

        protected override double CompartTypeFee(bool CompartmentType, double BuildingBasicPrice)
        {

            if (CompartmentType == true)
            {
                return 0.09 * BuildingBasicPrice;


            }
            else return 0;

        }

        internal void CalculateAgentFee(LocationType location, double Surface, bool CompartmentType, bool ParkingSpace, bool Balcony, bool Floor, bool Furnished, double BasicFee, double BuildingBasicPrice)
        {
            double agentfee = BasicFee * BuildingBasicPrice;
            switch (location)
            {
                case LocationType.Center:
                    {
                        agentfee = agentfee + 0.01 * LocationFee(location, BuildingBasicPrice);
                        if (Surface > 100)
                            agentfee = agentfee + 0.01 * SurfaceFee(Surface);
                        else if (Surface < 100 && Surface > 70)
                            agentfee = agentfee + 0.01 * SurfaceFee(Surface);
                        else agentfee = agentfee + 0.008 * SurfaceFee(Surface);

                        if (CompartmentType == true)
                            agentfee = agentfee + 0.003 * CompartTypeFee(CompartmentType, BuildingBasicPrice);
                        else agentfee += 0;

                        if (ParkingSpace == true)
                            agentfee += 0.007 * ParkingSpaceFee(ParkingSpace, BuildingBasicPrice);
                        else agentfee += 0;
                        break;

                    }
                case LocationType.Tudor:
                    {
                        agentfee = agentfee + 0.018 * LocationFee(location, BuildingBasicPrice);
                        if (Surface > 100)
                            agentfee = agentfee + 0.019 * SurfaceFee(Surface);
                        else if (Surface < 100 && Surface > 70)
                            agentfee = agentfee + 0.015 * SurfaceFee(Surface);
                        else agentfee = agentfee + 0.01 * SurfaceFee(Surface);

                        if (CompartmentType == true)
                            agentfee = agentfee + 0.003 * CompartTypeFee(CompartmentType, BuildingBasicPrice);
                        else agentfee += 0;

                        if (ParkingSpace == true)
                            agentfee += 0.005 * ParkingSpaceFee(ParkingSpace, BuildingBasicPrice);
                        else agentfee += 0;
                        break;
                    }
                case LocationType.Bucium:
                    {
                        agentfee = agentfee + 0.01 * LocationFee(location, BuildingBasicPrice);
                        if (Surface > 100)
                            agentfee = agentfee + 0.02 * SurfaceFee(Surface);
                        else if (Surface < 100 && Surface > 70)
                            agentfee = agentfee + 0.015 * SurfaceFee(Surface);
                        else agentfee = agentfee + 0.01 * SurfaceFee(Surface);

                        if (CompartmentType == true)
                            agentfee = agentfee + 0.001 * CompartTypeFee(CompartmentType, BuildingBasicPrice);
                        else agentfee += 0;

                        if (ParkingSpace == true)
                            agentfee += 0.003 * ParkingSpaceFee(ParkingSpace, BuildingBasicPrice);
                        else agentfee += 0;
                        break;
                    }
                default: break;
            }
            Console.WriteLine("The fee for the real estate agent is :" + agentfee);
            Console.ReadKey();
        }

        internal void CalculatePrice(LocationType location, double Surface, bool CompartmentType, bool ParkingSpace, bool Balcony, bool Floor,bool Furnished, double BuildingBasicPrice)
        {
            Console.WriteLine();
            Console.Write("For this SingleRoom we have the following prices : \n");
            Console.WriteLine("Location Fee :" + LocationFee(_locationType, BuildingBasicPrice) + "\n");
            Console.WriteLine("Surface Fee :" + SurfaceFee(Surface) + "\n");
            Console.WriteLine("CompartmentType Fee:" + CompartTypeFee(CompartmentType, BuildingBasicPrice) + "\n");
            Console.WriteLine("ParkingSpace Fee :" + ParkingSpaceFee(ParkingSpace, BuildingBasicPrice) + "\n");
            Console.WriteLine("Balcony Fee :" + BalconyFee(Balcony, BuildingBasicPrice) + "\n");
            Console.WriteLine("Floor Fee : " + FloorFee(Floor, BuildingBasicPrice) + "\n");
            if (Furnished == true)
                Console.WriteLine("Furnished fee :" + 0.12 * BuildingBasicPrice + "\n");
            else Console.WriteLine("The SingleRoom is not furnished. \n");
            TotalPrice = TotalPrice + LocationFee(_locationType, BuildingBasicPrice) + SurfaceFee(Surface) +
                CompartTypeFee(CompartmentType, BuildingBasicPrice) + ParkingSpaceFee(ParkingSpace, BuildingBasicPrice) +
                BalconyFee(Balcony, BuildingBasicPrice) + FloorFee(Floor, BuildingBasicPrice)+0.2 * BuildingBasicPrice;

            Console.WriteLine("The price for the SingleRoom is :" + TotalPrice+ "\n");

        }

        protected override double BalconyFee(bool Balcony, double BuildingBasicPrice)
        {
            if (Balcony == true)
            {
                return 0.015 * BuildingBasicPrice;


            }
            else return 0;
        }

        protected override double FloorFee(bool Floor, double BuildingBasicPrice)
        {
            if (Floor == true)
            {
                return 0.09 * BuildingBasicPrice;


            }
            else return 0;
        }

       /* protected override void CalculatePrice(LocationType location, double Surface, bool CompartmentType, bool ParkingSpace, bool Balcony, bool Floor, double BuildingBasicPrice)
        {

            Console.Write("For this SingleRoom we have the following prices : /n");
            Console.WriteLine("Location Fee :" + LocationFee(_locationType, BuildingBasicPrice) + "/n");
            Console.WriteLine("Surface Fee :" + SurfaceFee(Surface) + "/n");
            Console.WriteLine("CompartmentType Fee:" + CompartTypeFee(CompartmentType, BuildingBasicPrice) + "/n");
            Console.WriteLine("ParkingSpace Fee :" + ParkingSpaceFee(ParkingSpace, BuildingBasicPrice) + "/n");
            Console.WriteLine("Balcony Fee :" + BalconyFee(Balcony, BuildingBasicPrice) + "/n");
            Console.WriteLine("Floor Fee : " + FloorFee(Floor, BuildingBasicPrice) + "/n");

            TotalPrice = TotalPrice + LocationFee(_locationType, BuildingBasicPrice) + SurfaceFee(Surface) +
                CompartTypeFee(CompartmentType, BuildingBasicPrice) + ParkingSpaceFee(ParkingSpace, BuildingBasicPrice) +
                BalconyFee(Balcony, BuildingBasicPrice) + FloorFee(Floor, BuildingBasicPrice);

            Console.WriteLine("The price for the SingleRoom is :" + TotalPrice);

        }*/

      /*  protected override void CalculateAgentFee(LocationType location, double Surface, bool CompartmentType, bool ParkingSpace, bool Balcony, bool Floor, bool Furnished, double BasicFee, double BuildingBasicPrice)
        {
            double agentfee = BasicFee * TotalPrice;
            switch (location)
            {
                case LocationType.Center:
                    {
                        agentfee = agentfee + 0.01 * LocationFee(location, BuildingBasicPrice);
                        if (Surface > 100)
                            agentfee = agentfee + 0.01 * SurfaceFee(Surface);
                        else if (Surface < 100 && Surface > 70)
                            agentfee = agentfee + 0.01 * SurfaceFee(Surface);
                        else agentfee = agentfee + 0.008 * SurfaceFee(Surface);

                        if (CompartmentType == true)
                            agentfee = agentfee + 0.003 * CompartTypeFee(CompartmentType, BuildingBasicPrice);
                        else agentfee += 0;

                        if (ParkingSpace == true)
                            agentfee += 0.007 * ParkingSpaceFee(ParkingSpace, BuildingBasicPrice);
                        else agentfee += 0;
                        break;

                    }
                case LocationType.Tudor:
                    {
                        agentfee = agentfee + 0.018 * LocationFee(location, BuildingBasicPrice);
                        if (Surface > 100)
                            agentfee = agentfee + 0.019 * SurfaceFee(Surface);
                        else if (Surface < 100 && Surface > 70)
                            agentfee = agentfee + 0.015 * SurfaceFee(Surface);
                        else agentfee = agentfee + 0.01 * SurfaceFee(Surface);

                        if (CompartmentType == true)
                            agentfee = agentfee + 0.003 * CompartTypeFee(CompartmentType, BuildingBasicPrice);
                        else agentfee += 0;

                        if (ParkingSpace == true)
                            agentfee += 0.005 * ParkingSpaceFee(ParkingSpace, BuildingBasicPrice);
                        else agentfee += 0;
                        break;
                    }
                case LocationType.Bucium:
                    {
                        agentfee = agentfee + 0.01 * LocationFee(location, BuildingBasicPrice);
                        if (Surface > 100)
                            agentfee = agentfee + 0.02 * SurfaceFee(Surface);
                        else if (Surface < 100 && Surface > 70)
                            agentfee = agentfee + 0.015 * SurfaceFee(Surface);
                        else agentfee = agentfee + 0.01 * SurfaceFee(Surface);

                        if (CompartmentType == true)
                            agentfee = agentfee + 0.001 * CompartTypeFee(CompartmentType, BuildingBasicPrice);
                        else agentfee += 0;

                        if (ParkingSpace == true)
                            agentfee += 0.003 * ParkingSpaceFee(ParkingSpace, BuildingBasicPrice);
                        else agentfee += 0;
                        break;
                    }
                default: break;
            }
            Console.WriteLine("The fee for the real estate agent is :" + agentfee);
            Console.ReadKey();
        }*/



       
    }
}
