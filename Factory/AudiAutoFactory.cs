using PatternAbstractFactoryProj.Interfaces;
using PatternAbstractFactoryProj.Models;

namespace PatternAbstractFactoryProj.Factory
{
	public class AudiAutoFactory : AutoFactory
	{
		public Sedan CreateSedan()
		{
			return new AudiSedan();
		}

		public Hatchback CreateHatchback()
		{
			return new AudiHatchback();
		}
		public Universal CreateUniversal()
		{
			return new AudiUniversal();
	}
}
}