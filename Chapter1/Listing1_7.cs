using System; 
using System.Threading;

namespace Chapter1 
{
    //LISTING 1-4  Queuing some work to the thread pool
    public static class Listing1_7    
    {
        public static void Main()        
        {             
            ThreadPool.QueueUserWorkItem((s) =>
            {                 
                Console.WriteLine("Working on a thread from threadpool");             
            });  
            Console.ReadLine();        
        }
    }
}
