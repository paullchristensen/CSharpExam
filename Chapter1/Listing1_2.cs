using System; 
using System.Threading;

namespace Chapter1 
{
    //LISTING 1-2 Using a background thread
    public static class Listing1_2    
    {        
        public static void ThreadMethod()      
        {          
            for (int i = 0; i < 10; i++)         
            {                 
                Console.WriteLine("ThreadProc: {0}", i);                
                Thread.Sleep(1000);             
            } 
        }          
        public static void Main()         
        {             
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = true; //Default is false.  If set to false then program will wait for thread to end before exiting.
            t.Start();               
           
        }
    }
}
