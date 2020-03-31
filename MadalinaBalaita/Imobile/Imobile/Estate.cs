namespace Imobile
{
    public abstract class Estate
    {   
        //a basic price, a starting point for the price which will increase or decrease based on the square meters,location and condition of the estate
        //the price the client is willing to pay
        protected decimal price;
        
        public abstract decimal get_poundage();
        public abstract decimal get_price_from_landlord();

        public decimal get_price()
        {
            return price + get_poundage();
        }

        public int sm;//square meters of the estate
        public string location;//the location of the estate:center,somewhere ok,suburbs
        public string condition;//condition of the estate:really old,old,medium,new
        public string usage;//land for buildings(intravilan) or agriculture(extravilan)
        public int cadastral_nr;//cadastral number
        public Estate()
        {
        }

        public Estate( int sm,   string location,string condition)
        {
            
            this.sm = sm;
            this.location = location;
            this.condition = condition;

        }
        public Estate(int sm, int cadastral_nr, string usage)
        {

            this.sm = sm;
            this.cadastral_nr = cadastral_nr;
            this.usage= usage;

        }
        
  

    } 
}
