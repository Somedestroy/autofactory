using System.Threading;
using PatternAbstractFactoryProj.Interfaces;

namespace PatternAbstractFactoryProj.Models
{
    public class MercedesSedan : Sedan
    {
       public bool Long()
        {
            return false;
        }

        public bool Short()
        {
            return false;
        }
         public bool Nobackdoor()
        {
            return true;
        }
    }
}