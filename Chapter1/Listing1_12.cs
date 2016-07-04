using System; 
using System.Threading.Tasks;

namespace Chapter1 
{
    //LISTING  1-13 Using a TaskFactory
    public static class Listing1_13
    {
        public static void Main()        
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var result = new Int32[3];
                
                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(()=> result[0] = 0);
                tf.StartNew(() => result[1] = 1);
                tf.StartNew(() => result[2] = 2);
                return result;

            });

            var finalTask = parent.ContinueWith(parentTask =>
            {
                foreach (int i in parentTask.Result)
                    Console.WriteLine(i);
            });

            finalTask.Wait();
        }
    }
}
