#nullable enable

namespace Triverse
{
    public partial interface IUtilitiesClient
    {
        /// <summary>
        /// Remesh a model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Triverse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Triverse.TaskCreatedResponse> CreateModelRemeshTaskAsync(

            global::Triverse.ModelRemeshRequest request,
            global::Triverse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remesh a model
        /// </summary>
        /// <param name="modelFile"></param>
        /// <param name="modelUrl"></param>
        /// <param name="polygonLimit"></param>
        /// <param name="outputFormat"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Triverse.TaskCreatedResponse> CreateModelRemeshTaskAsync(
            string? modelFile = default,
            string? modelUrl = default,
            int? polygonLimit = default,
            string? outputFormat = default,
            object? metadata = default,
            global::Triverse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}