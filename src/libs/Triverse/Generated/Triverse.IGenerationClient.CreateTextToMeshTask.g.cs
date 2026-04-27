#nullable enable

namespace Triverse
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Generate geometry from text
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Triverse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Triverse.TaskCreatedResponse> CreateTextToMeshTaskAsync(

            global::Triverse.TextToModelRequest request,
            global::Triverse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate geometry from text
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="modelVersion"></param>
        /// <param name="polygonLimit"></param>
        /// <param name="textureSize"></param>
        /// <param name="seed"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Triverse.TaskCreatedResponse> CreateTextToMeshTaskAsync(
            string prompt,
            string? negativePrompt = default,
            string? modelVersion = default,
            int? polygonLimit = default,
            int? textureSize = default,
            int? seed = default,
            object? metadata = default,
            global::Triverse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}