#nullable enable

namespace Triverse
{
    public partial interface IUploadsClient
    {
        /// <summary>
        /// Upload an image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Triverse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Triverse.UploadResponse> UploadImageAsync(

            global::Triverse.FileUploadRequest request,
            global::Triverse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload an image
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Triverse.UploadResponse> UploadImageAsync(
            byte[] file,
            string filename,
            global::Triverse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}