using PatternAbstractFactoryProj.Interfaces;

namespace PatternAbstractFactoryProj.Models
{
    public class BMWHatchback : Hatchback
    {
         public bool Long()
        {
            return false;
        }

        public bool Short()
        {
            return true;
        }
         public bool Nobackdoor()
        {
            return false;
        }
    }
}