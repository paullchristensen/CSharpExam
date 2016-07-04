using System; 
using System.Threading.Tasks;

namespace Chapter1 
{
    //LISTING  1-11 Scheduling different continuation tasks
    public static class Listing1_11 
    {
        public static void Main()        
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });
            
            t.ContinueWith((i) =>
            {    
                Console.WriteLine("Canceled"); 
            }, TaskContinuationOptions.OnlyOnCanceled);  


            t.ContinueWith((i) =>
            {     Console.WriteLine("Faulted"); 
            }, TaskContinuationOptions.OnlyOnFaulted);  


            var completedTask =  t.ContinueWith((i) => 
            {      Console.WriteLine("Completed");  
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();

            //The ContinueWith method has a couple of overloads that you can use to configure when the continuation will run. 
            //This way you can add different continuation methods that will run when an exception happens, the Task is canceled, or the Task completes successfully. 
  
        }
    }
}
