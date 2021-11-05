using PatternAbstractFactoryProj.Interfaces;

namespace PatternAbstractFactoryProj.Factory
{
    public interface AutoFactory
    {
         Sedan CreateSedan();
         Hatchback CreateHatchback();
         Universal CreateUniversal();
    }
}