using PatternAbstractFactoryProj.Interfaces;
using PatternAbstractFactoryProj.Models;

namespace PatternAbstractFactoryProj.Factory
{
	public class BMWAutoFactory : AutoFactory
	{
		public Sedan CreateSedan()
		{
			return new BMWSedan();
		}

		public Hatchback CreateHatchback()
		{
			return new BMWHatchback();
		}
		public Universal CreateUniversal()
		{
			return new BMWUniversal();
		}
	}
}