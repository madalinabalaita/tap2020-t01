using System;
using System.Collections.Generic;
using System.Text;

namespace PooPrincipii
{
    public class Apartment : RealEstateAgency
    {
        double TotalPrice = 0;
        public string SwitchError = "Something go wrong...";
        public string apartmentLocation;


        public double Surface { get;  set; }
        public double Price { get; set; }
        public bool Furnished { get;  set; }
        public bool CompartmentType { get;  set; }
        public bool ParkingSpace { get;  set; }
        public bool Balcony { get;  set; }
        public bool Floor { get;  set; }
        public Apartment(LocationType Location,
                      double Price,
                     double Surface,
                     bool Furnished,
                     bool CompartmentType,
                     bool ParkingSpace,
                     bool Balcony,
                     bool Floor) 
        {
            _locationType = Location;
            this.Price = Price;
            this.Surface = Surface;
            this.Furnished = Furnished;
            this.CompartmentType = CompartmentType;
            this.ParkingSpace = ParkingSpace;
            this.Balcony = Balcony;
            this.Floor = Floor;
        }
        public Apartment() { }

        protected override double LocationFee(LocationType location, double BuildingBasicPrice)
        {
            double LocationPrice = 0;
            switch (location)
            {
                case LocationType.Center:
                    {
                        double v = 0.45 * BuildingBasicPrice;
                        LocationPrice = v;
                        return LocationPrice;
                    }
                case LocationType.Tudor:
                    {
                        double v = 0.25 * BuildingBasicPrice;
                        LocationPrice = v;
                        return LocationPrice;
                    }
                case LocationType.Bucium:
                    {
                        double v = 0.2 * BuildingBasicPrice;
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
                        int SurfacePricePerM2 = 450;
                        double v = Surface * SurfacePricePerM2;
                        SurfacePrice = v;
                        return SurfacePrice;
                    }

                case LocationType.Tudor:
                    {
                        int SurfacePricePerM2 = 300;
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


                default:
                    {
                        int SurfacePricePerM2 = 200;
                        double v = Surface * SurfacePricePerM2;
                        SurfacePrice = v;
                        return SurfacePrice;
                    }
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

                            return 0.15 * BuildingBasicPrice;
                        }
                    case LocationType.Tudor:
                        {
                            return 0.01 * BuildingBasicPrice;
                        }
                    case LocationType.Bucium:
                        {
                            return 0.05 * BuildingBasicPrice;
                        }
                    default: return 0.05 * BuildingBasicPrice;
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
                return 0.18 * BuildingBasicPrice;


            }
            else return 0;

        }

        protected override double BalconyFee(bool Balcony, double BuildingBasicPrice)
        {
            if (Balcony == true)
            {
                return 0.03 * BuildingBasicPrice;


            }
            else return 0;
        }

        protected override double FloorFee(bool Floor, double BuildingBasicPrice)
        {
            if (Floor == true)
            {
                return 0.1 * BuildingBasicPrice;


            }
            else return 0;
        }

        internal void CalculatePrice(LocationType location, double Surface, bool CompartmentType, bool ParkingSpace, bool Balcony, bool Floor,bool Furnished, double BuildingBasicPrice)
        {
            Console.Write("For this apartment we have the following prices : \n");
            Console.WriteLine("Location Fee :" + LocationFee(location, BuildingBasicPrice) + "\n");
            Console.WriteLine("Surface Fee :" + SurfaceFee(Surface) + "\n");
            Console.WriteLine("CompartmentType Fee:" + CompartTypeFee(CompartmentType, BuildingBasicPrice) + "\n");
            Console.WriteLine("ParkingSpace Fee :" + ParkingSpaceFee(ParkingSpace, BuildingBasicPrice) + "\n");
            Console.WriteLine("Balcony Fee :" + BalconyFee(Balcony, BuildingBasicPrice) + "\n");
            Console.WriteLine("Floor Fee : " + FloorFee(Floor, BuildingBasicPrice) + "\n");
            if (Furnished == true)
                Console.WriteLine("Furnished fee :" + 0.17 * BuildingBasicPrice + "\n");
            TotalPrice = TotalPrice + LocationFee(location, BuildingBasicPrice) + SurfaceFee(Surface) +
                CompartTypeFee(CompartmentType, BuildingBasicPrice) + ParkingSpaceFee(ParkingSpace, BuildingBasicPrice) +
                BalconyFee(Balcony, BuildingBasicPrice) + FloorFee(Floor, BuildingBasicPrice);

            Console.WriteLine("The price for the apartment is :" + TotalPrice);
        }

        internal void CalculateAgentFee(LocationType location, double Surface, bool CompartmentType, bool ParkingSpace, bool Balcony, bool Floor, bool Furnished, double BasicFee, double BuildingBasicPrice)
        {
            double agentfee = BasicFee * TotalPrice;
            switch (location)
            {
                case LocationType.Center:
                    {
                        agentfee = agentfee + 0.02 * LocationFee(location, BuildingBasicPrice);
                        if (Surface > 100)
                            agentfee = agentfee + 0.02 * SurfaceFee(Surface);
                        else if (Surface < 100 && Surface > 70)
                            agentfee = agentfee + 0.015 * SurfaceFee(Surface);
                        else agentfee = agentfee + 0.01 * SurfaceFee(Surface);

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


        /* protected override void CalculatePrice(LocationType location, double Surface, bool CompartmentType, bool ParkingSpace, bool Balcony, bool Floor, double BuildingBasicPrice)
         {

             Console.Write("For this house we have the following prices : /n");
             Console.WriteLine("Location Fee :" + LocationFee(_locationType, BuildingBasicPrice) + "/n");
             Console.WriteLine("Surface Fee :" + SurfaceFee(Surface) + "/n");
             Console.WriteLine("CompartmentType Fee:" + CompartTypeFee(CompartmentType, BuildingBasicPrice) + "/n");
             Console.WriteLine("ParkingSpace Fee :" + ParkingSpaceFee(ParkingSpace, BuildingBasicPrice) + "/n");
             Console.WriteLine("Balcony Fee :" + BalconyFee(Balcony, BuildingBasicPrice) + "/n");
             Console.WriteLine("Floor Fee : " + FloorFee(Floor, BuildingBasicPrice) + "/n");

             TotalPrice = TotalPrice + LocationFee(_locationType, BuildingBasicPrice) + SurfaceFee(Surface) +
                 CompartTypeFee(CompartmentType, BuildingBasicPrice) + ParkingSpaceFee(ParkingSpace, BuildingBasicPrice) +
                 BalconyFee(Balcony, BuildingBasicPrice) + FloorFee(Floor, BuildingBasicPrice);

             Console.WriteLine("The price for the apartment is :" + TotalPrice);

         }*/

        /*  protected override void CalculateAgentFee(LocationType location, double Surface, bool CompartmentType, bool ParkingSpace, bool Balcony, bool Floor, bool Furnished, double BasicFee, double BuildingBasicPrice)
          {
              double agentfee = BasicFee * TotalPrice;
              switch (location)
              {
                  case LocationType.Center:
                      {
                          agentfee = agentfee + 0.02 * LocationFee(location, BuildingBasicPrice);
                          if (Surface > 100)
                              agentfee = agentfee + 0.02 * SurfaceFee(Surface);
                          else if (Surface < 100 && Surface > 70)
                              agentfee = agentfee + 0.015 * SurfaceFee(Surface);
                          else agentfee = agentfee + 0.01 * SurfaceFee(Surface);

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
