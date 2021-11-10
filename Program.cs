using System;
using PatternAbstractFactoryProj.Factory;

namespace PatternAbstractFactoryProj
{
    class Program
    {
        enum AutoBrand
        {
            Audi, // 0
            BMW, // 1
            Mercedes // 2
        }
       
        static void Main(string[] args)
        { 
            Console.WriteLine(@"Please write auto brand (Audi = 0\BMW = 1\Mercedes = 2):");
            int autoBrand = Int32.Parse(Console.ReadLine());
            while (autoBrand < 0 || autoBrand > 2)
            {
                Console.WriteLine("Please write again");
                autoBrand = Int32.Parse(Console.ReadLine());
            }

          
            switch ((AutoBrand)autoBrand)
            {
                case AutoBrand.Audi:
                    SingletonAutoFactory<AutoFactory>.SetInstance(new AudiAutoFactory());
                    break;
                case AutoBrand.BMW:
                    SingletonAutoFactory<AutoFactory>.SetInstance(new BMWAutoFactory());
                    break;
                case AutoBrand.Mercedes:
                    SingletonAutoFactory<AutoFactory>.SetInstance(new MercedesAutoFactory());
                    break;
                default:
                    SingletonAutoFactory<AutoFactory>.SetInstance(new AudiAutoFactory());
                    break;
            }
            

            var newSedan = SingletonAutoFactory<AutoFactory>.GetInstance().CreateSedan();
            Console.WriteLine($"New Sedan created: Sedan Type - {newSedan.GetType()}");
        }
    }
}
