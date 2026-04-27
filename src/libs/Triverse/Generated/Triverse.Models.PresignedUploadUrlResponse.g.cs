
#nullable enable

namespace Triverse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PresignedUploadUrlResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        public string? UploadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_key")]
        public string? FileKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignedUploadUrlResponse" /> class.
        /// </summary>
        /// <param name="uploadUrl"></param>
        /// <param name="fileKey"></param>
        /// <param name="headers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresignedUploadUrlResponse(
            string? uploadUrl,
            string? fileKey,
            object? headers)
        {
            this.UploadUrl = uploadUrl;
            this.FileKey = fileKey;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignedUploadUrlResponse" /> class.
        /// </summary>
        public PresignedUploadUrlResponse()
        {
        }
    }
}