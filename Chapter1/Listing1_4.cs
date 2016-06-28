using System; 
using System.Threading;

namespace Chapter1 
{
    //LISTING 1-4  Stopping a thread 
    public static class Listing1_4    
    {        
               
        public static void Main()         
        {
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;

            t.Join();
        }
    }
}
