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

            AutoFactory autoFactory;
            switch ((AutoBrand)autoBrand)
            {
                case AutoBrand.Audi:
                    autoFactory = new AudiAutoFactory();
                    break;
                case AutoBrand.BMW:
                    autoFactory = new BMWAutoFactory();
                    break;
                case AutoBrand.Mercedes:
                    autoFactory = new MercedesAutoFactory();
                    break;
                default:
                    autoFactory = new AudiAutoFactory();
                    break;
            }

            var newSedan = autoFactory.CreateSedan();
            Console.WriteLine($"New Sedan created: Sedan Type - {newSedan.GetType()}");
        }
    }
}
