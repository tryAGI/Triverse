
#nullable enable

namespace Triverse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskAssetUrlResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::Triverse.TaskFile>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskAssetUrlResponse" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="downloadUrl"></param>
        /// <param name="previewUrl"></param>
        /// <param name="files"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskAssetUrlResponse(
            string? url,
            string? downloadUrl,
            string? previewUrl,
            global::System.Collections.Generic.IList<global::Triverse.TaskFile>? files)
        {
            this.Url = url;
            this.DownloadUrl = downloadUrl;
            this.PreviewUrl = previewUrl;
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskAssetUrlResponse" /> class.
        /// </summary>
        public TaskAssetUrlResponse()
        {
        }
    }
}