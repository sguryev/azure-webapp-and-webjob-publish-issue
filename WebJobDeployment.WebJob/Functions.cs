using System.IO;
using Microsoft.Azure.WebJobs;

namespace WebJobDeployment.WebJob
{
    using Services;

    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        public static void ProcessQueueMessage([QueueTrigger("queue")] string message, TextWriter log)
        {
            var service = new TestService();
            log.WriteLine(message);
        }
    }
}
