using PatternAbstractFactoryProj.Interfaces;
namespace PatternAbstractFactoryProj.Models
{
    public class MercedesUniversal : Universal
    {
        public bool Long()
        {
            return true;
        }

        public bool Short()
        {
            return false;
        }
         public bool Nobackdoor()
        {
            return false;
        }
    }
}