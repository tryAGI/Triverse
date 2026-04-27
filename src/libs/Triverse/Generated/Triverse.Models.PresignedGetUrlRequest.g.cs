
#nullable enable

namespace Triverse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PresignedGetUrlRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignedGetUrlRequest" /> class.
        /// </summary>
        /// <param name="fileKey"></param>
        /// <param name="filename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresignedGetUrlRequest(
            string fileKey,
            string? filename)
        {
            this.FileKey = fileKey ?? throw new global::System.ArgumentNullException(nameof(fileKey));
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignedGetUrlRequest" /> class.
        /// </summary>
        public PresignedGetUrlRequest()
        {
        }
    }
}