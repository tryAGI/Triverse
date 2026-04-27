
#nullable enable

namespace Triverse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelRemeshRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("polygon_limit")]
        public int? PolygonLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public string? OutputFormat { get; set; }

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
        /// Initializes a new instance of the <see cref="ModelRemeshRequest" /> class.
        /// </summary>
        /// <param name="modelFile"></param>
        /// <param name="modelUrl"></param>
        /// <param name="polygonLimit"></param>
        /// <param name="outputFormat"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelRemeshRequest(
            string? modelFile,
            string? modelUrl,
            int? polygonLimit,
            string? outputFormat,
            object? metadata)
        {
            this.ModelFile = modelFile;
            this.ModelUrl = modelUrl;
            this.PolygonLimit = polygonLimit;
            this.OutputFormat = outputFormat;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRemeshRequest" /> class.
        /// </summary>
        public ModelRemeshRequest()
        {
        }
    }
}