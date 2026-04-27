#nullable enable

namespace Triverse
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Get task status
        /// </summary>
        /// <param name="taskUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Triverse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Triverse.TaskStatusResponse> GetTaskAsync(
            string taskUuid,
            global::Triverse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}