namespace Imobile
{
    public abstract class Estate
    {   
        //a basic price, a starting point for the price which will increase or decrease based on the square meters,location and condition of the estate
        protected decimal price;
        public Estate(decimal price)
        {
            this.price = price;
        }
        public abstract decimal get_poundage();
      
        public decimal get_price()
        {
            return price + get_poundage();
        }

        public int sm;//square meters of the estate
        public string location;//the location of the estate:center,somewhere ok,suburbs
        public string condition;//condition of the estate:really old,old,medium,new
       
        public Estate()
        {
        }

        public Estate( decimal price,int sm,  string location,string condition)
        {
            this.price = price;
            this.sm = sm;
            this.location = location;
            this.condition = condition;

        }
    
    } 
}
