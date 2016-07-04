using System; 
using System.Threading.Tasks;

namespace Chapter1 
{
    //LISTING 1-8  Starting a new Task
    public static class Listing1_8   
    {
        public static void Main()        
        {
            Task t = Task.Run(() => 
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write('*');
                }
            });

            t.Wait();
  
        }
    }
}
