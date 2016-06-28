using System; 
using System.Threading;

namespace Chapter1 
{
    //LISTING 1-4  Using ThreadLocal<T>
    public static class Listing1_6    
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
        {
            return 22;// Thread.CurrentThread.ManagedThreadId;
        });

        public static void Main()         
        {
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thrad A {0}   {1}", x, _field.Value);
                }

            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thrad B {0}   {1}", x, _field.Value);
                }

            }).Start();

            Console.ReadKey();

        }
    }
}
