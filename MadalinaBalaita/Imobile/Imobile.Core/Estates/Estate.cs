 using Imobile.Core.Calculators;
namespace Imobile.Core.Estates
{
    public abstract class Estate :Assets
    {




        public  string Get_location()
        {   
            return location;
        }
      
        //constructor for buildings: Flats,studios,houses
        public Estate( double sm,string location,string condition)
        {
            
            this.sm = sm;
            this.location = location;
            this.condition = condition;

        }
        
        //constructor for land
        public Estate(double sm, int cadastral_nr, string usage)
        {

            this.sm = sm;
            this.cadastral_nr = cadastral_nr;
            this.usage= usage;

        }
        
  

    } 
}
