
#nullable enable

namespace Triverse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageToModelRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("polygon_limit")]
        public int? PolygonLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_size")]
        public int? TextureSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

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
        /// Initializes a new instance of the <see cref="ImageToModelRequest" /> class.
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="imageUrl"></param>
        /// <param name="modelVersion"></param>
        /// <param name="polygonLimit"></param>
        /// <param name="textureSize"></param>
        /// <param name="seed"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageToModelRequest(
            string? imageFile,
            string? imageUrl,
            string? modelVersion,
            int? polygonLimit,
            int? textureSize,
            int? seed,
            object? metadata)
        {
            this.ImageFile = imageFile;
            this.ImageUrl = imageUrl;
            this.ModelVersion = modelVersion;
            this.PolygonLimit = polygonLimit;
            this.TextureSize = textureSize;
            this.Seed = seed;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToModelRequest" /> class.
        /// </summary>
        public ImageToModelRequest()
        {
        }
    }
}