using System; 
using System.Threading;

namespace Chapter1 
{
    //LISTING 1-4  Using the ThreadStaticAttribute
    public static class Listing1_5    
    {
        [ThreadStatic]
        public  static int _field;
        public static void Main()         
        {
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thrad A {0}", _field);
                }

            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thrad B {0}", _field);
                }

            }).Start();

            Console.ReadKey();

        }
    }
}
