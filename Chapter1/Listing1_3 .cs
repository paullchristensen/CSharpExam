using System; 
using System.Threading;

namespace Chapter1 
{
    //LISTING 1-1 Creating a thread with the Thread class 
    public static class Listing1_3    
    {        
        public static void ThreadMethod(object o)      
        {          
            for (int i = 0; i < (int)o; i++)         
            {                 
                Console.WriteLine("ThreadProc: {0}", i);                
                Thread.Sleep(500);             
            } 
        }          
        public static void Main()         
        {             
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);

            t.Join();
        }
    }
}
