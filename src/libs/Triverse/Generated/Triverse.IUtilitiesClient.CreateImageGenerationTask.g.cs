#nullable enable

namespace Triverse
{
    public partial interface IUtilitiesClient
    {
        /// <summary>
        /// Generate an image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Triverse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Triverse.TaskCreatedResponse> CreateImageGenerationTaskAsync(

            global::Triverse.ImageGenerationRequest request,
            global::Triverse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="seed"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Triverse.TaskCreatedResponse> CreateImageGenerationTaskAsync(
            string prompt,
            string? negativePrompt = default,
            string? aspectRatio = default,
            int? width = default,
            int? height = default,
            int? seed = default,
            object? metadata = default,
            global::Triverse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}