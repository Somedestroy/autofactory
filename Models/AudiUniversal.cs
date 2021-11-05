using System.Threading;
using PatternAbstractFactoryProj.Interfaces;

namespace PatternAbstractFactoryProj.Models
{
    public class AudiUniversal : Universal
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