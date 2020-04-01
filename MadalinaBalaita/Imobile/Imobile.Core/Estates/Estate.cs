 using Imobile.Core.Calculators;
namespace Imobile.Core.Estates
{
    public abstract class Estate :EstateBase
    {
   
        public int sm { get; set; }//square meters of the estate
        public string location;//the location of the estate:center,somewhere ok,suburbs
        public string condition;//condition of the estate:really old,old,medium,new
        public string usage;//land for buildings(intravilan) or agriculture(extravilan)
        public int cadastral_nr;//cadastral number
      

       /* public string Get_location(string location)
        {
            return location;
        }
        public int Get_location(int cadastral_nr)
        {
            return cadastral_nr;
        }
        */
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
