#nullable enable

namespace Triverse
{
    public partial interface IUploadsClient
    {
        /// <summary>
        /// Create a presigned download URL for an uploaded file
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Triverse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Triverse.PresignedGetUrlResponse> CreatePresignedGetUrlAsync(

            global::Triverse.PresignedGetUrlRequest request,
            global::Triverse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a presigned download URL for an uploaded file
        /// </summary>
        /// <param name="fileKey"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Triverse.PresignedGetUrlResponse> CreatePresignedGetUrlAsync(
            string fileKey,
            string? filename = default,
            global::Triverse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}