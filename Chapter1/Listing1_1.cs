using System; 
using System.Threading;

namespace Chapter1 
{
    //LISTING 1-1 Creating a thread with the Thread class 
    public static class Listing1_2    
    {        
        public static void ThreadMethod()      
        {          
            for (int i = 0; i < 10; i++)         
            {                 
                Console.WriteLine("ThreadProc: {0}", i);                
                Thread.Sleep(0);             
            } 
        }          
        public static void Main()         
        {             
            Thread t = new Thread(new ThreadStart(ThreadMethod));             
            t.Start();               
            for (int i = 0; i < 4; i++)             
            {                
                Console.WriteLine("Main thread: Do some work.");                 
                Thread.Sleep(0);             
            }
             t.Join();

             Console.ReadLine();
         }
     }
}
