using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.com.singleton
{
    class TestLogger
    {
        static void Main()
        {
            // Logger obj1 = new Logger();
            // Logger obj2 = new Logger();
            Console.WriteLine("----Singleton----");
            //Logger obj1 = Logger.GetInstance();
            //Logger obj2 = Logger.GetInstance();
            Logger obj1 = Logger.Instance;
            Logger obj2 = Logger.Instance;
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            Console.WriteLine("----Non Singleton----");
            Test obj3 = new Test();
            Test obj4 = new Test();
            Console.WriteLine(obj3.GetHashCode());
            Console.WriteLine(obj4.GetHashCode());
        }
    }

     class Test
    {

    }
}
