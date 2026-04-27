
#nullable enable

namespace Triverse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextureModelRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file")]
        public string? ImageFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_size")]
        public int? TextureSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("polygon_limit")]
        public int? PolygonLimit { get; set; }

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
        /// Initializes a new instance of the <see cref="TextureModelRequest" /> class.
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="imageUrl"></param>
        /// <param name="modelFile"></param>
        /// <param name="modelUrl"></param>
        /// <param name="modelVersion"></param>
        /// <param name="textureSize"></param>
        /// <param name="polygonLimit"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextureModelRequest(
            string? imageFile,
            string? imageUrl,
            string? modelFile,
            string? modelUrl,
            string? modelVersion,
            int? textureSize,
            int? polygonLimit,
            object? metadata)
        {
            this.ImageFile = imageFile;
            this.ImageUrl = imageUrl;
            this.ModelFile = modelFile;
            this.ModelUrl = modelUrl;
            this.ModelVersion = modelVersion;
            this.TextureSize = textureSize;
            this.PolygonLimit = polygonLimit;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextureModelRequest" /> class.
        /// </summary>
        public TextureModelRequest()
        {
        }
    }
}