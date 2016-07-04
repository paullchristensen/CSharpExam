using System; 
using System.Threading.Tasks;

namespace Chapter1 
{
    //LISTING  1-9 Using a Task that returns a value. 
    public static class Listing1_9   
    {
        public static void Main()        
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });

            Console.WriteLine(t.Result);// Displays 42

            //Attempting to read the Result property on a Task will force the 
            //thread that’s trying to read the result to wait until the Task is
            //finished before continuing. As long as the Task has not finished, 
            //it is impossible to give the result. If the Task is not finished, this call will block the current thread. 
  
        }
    }
}
