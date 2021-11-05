using System.Threading;
using PatternAbstractFactoryProj.Interfaces;
using PatternAbstractFactoryProj.Models;

namespace PatternAbstractFactoryProj.Factory
{
    public class MercedesAutoFactory : AutoFactory
    {
         public Sedan CreateSedan()
		{
			return new MercedesSedan();
		}

		public Hatchback CreateHatchback()
		{
			return new MercedesHatchback();
		}
		public Universal CreateUniversal()
		{
			return new MercedesUniversal();
    }
}
}