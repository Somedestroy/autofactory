using System;
using PatternAbstractFactoryProj.Interfaces;
namespace PatternAbstractFactoryProj.Factory
{
    public sealed class SingletonAutoFactory<T> where T : AutoFactory
    {
      private SingletonAutoFactory() {
          //..hide singleton constructor
      }
      private static T _instance;

      //...
      public static T GetInstance()
      {
          
          if (_instance == null)
          {
              
             throw new ArgumentNullException("instance not created");
          }
          
          return _instance;

          
      }
      public static void SetInstance(T instance)
      {
          _instance = instance;

      }
      

    }
}
