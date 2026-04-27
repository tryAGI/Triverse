#nullable enable

namespace Triverse
{
    public partial interface IUploadsClient
    {
        /// <summary>
        /// Create a presigned upload URL
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Triverse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Triverse.PresignedUploadUrlResponse> CreatePresignedUploadUrlAsync(

            global::Triverse.PresignedUploadUrlRequest request,
            global::Triverse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a presigned upload URL
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="contentType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Triverse.PresignedUploadUrlResponse> CreatePresignedUploadUrlAsync(
            string filename,
            string? contentType = default,
            global::Triverse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}