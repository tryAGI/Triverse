#nullable enable

namespace Triverse
{
    public partial interface ITexturingClient
    {
        /// <summary>
        /// Texture an existing 3D model from an image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Triverse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Triverse.TaskCreatedResponse> CreateTextureModelTaskAsync(

            global::Triverse.TextureModelRequest request,
            global::Triverse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Texture an existing 3D model from an image
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="imageUrl"></param>
        /// <param name="modelFile"></param>
        /// <param name="modelUrl"></param>
        /// <param name="modelVersion"></param>
        /// <param name="textureSize"></param>
        /// <param name="polygonLimit"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Triverse.TaskCreatedResponse> CreateTextureModelTaskAsync(
            string? imageFile = default,
            string? imageUrl = default,
            string? modelFile = default,
            string? modelUrl = default,
            string? modelVersion = default,
            int? textureSize = default,
            int? polygonLimit = default,
            object? metadata = default,
            global::Triverse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}