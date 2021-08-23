using System.Threading.Tasks;

namespace Billing.Shared.Extensions
{
    public static class TaskExtensions
    {
        /// <summary>
        /// Asynchronous function result getter
        /// </summary>
        public static T Await<T>(this Task<T> task)
        {
            // Waiting for the result
            task.Wait();

            // Returning the result of the task
            return task.Result;
        }
    }
}