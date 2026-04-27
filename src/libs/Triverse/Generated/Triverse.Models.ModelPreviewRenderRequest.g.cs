
#nullable enable

namespace Triverse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPreviewRenderRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_file")]
        public string? ModelFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_url")]
        public string? ModelUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPreviewRenderRequest" /> class.
        /// </summary>
        /// <param name="modelFile"></param>
        /// <param name="modelUrl"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPreviewRenderRequest(
            string? modelFile,
            string? modelUrl,
            int? width,
            int? height,
            object? metadata)
        {
            this.ModelFile = modelFile;
            this.ModelUrl = modelUrl;
            this.Width = width;
            this.Height = height;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPreviewRenderRequest" /> class.
        /// </summary>
        public ModelPreviewRenderRequest()
        {
        }
    }
}