using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace MyDatabaseTriggerFunction
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([QueueTrigger("myqueue-items", Connection = "")] string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}