namespace Imobile
{
    public abstract class Estate
    {
        //a basic price, a starting point for the price which will increase or decrease based on the square meters,location and condition of the estate
        //the price the client is willing to pay
        public decimal Price;
        public decimal comission;
        public decimal Get_poundage( decimal comission) {
            
            return comission;
        }
        public decimal Get_price(decimal price)
        {
            Price = price;
            return price ;
        }
        public decimal Get_price_fromLandlord(decimal price)
        {
            return price;
        }


        public int sm { get; set; }//square meters of the estate
        public string location;//the location of the estate:center,somewhere ok,suburbs
        public string condition;//condition of the estate:really old,old,medium,new
        public string usage;//land for buildings(intravilan) or agriculture(extravilan)
        public int cadastral_nr;//cadastral number
        public Estate()
        {
        }
        //constructor for buildings: Flats,studios,houses
        public Estate( int sm,string location,string condition)
        {
            
            this.sm = sm;
            this.location = location;
            this.condition = condition;

        }
        
        //constructor for land
        public Estate(int sm, int cadastral_nr, string usage)
        {

            this.sm = sm;
            this.cadastral_nr = cadastral_nr;
            this.usage= usage;

        }
        
  

    } 
}
