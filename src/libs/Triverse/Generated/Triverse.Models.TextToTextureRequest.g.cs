
#nullable enable

namespace Triverse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToTextureRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompt")]
        public string? TextPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

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
        /// Initializes a new instance of the <see cref="TextToTextureRequest" /> class.
        /// </summary>
        /// <param name="textPrompt"></param>
        /// <param name="prompt"></param>
        /// <param name="modelFile"></param>
        /// <param name="modelUrl"></param>
        /// <param name="modelVersion"></param>
        /// <param name="textureSize"></param>
        /// <param name="polygonLimit"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToTextureRequest(
            string? textPrompt,
            string? prompt,
            string? modelFile,
            string? modelUrl,
            string? modelVersion,
            int? textureSize,
            int? polygonLimit,
            object? metadata)
        {
            this.TextPrompt = textPrompt;
            this.Prompt = prompt;
            this.ModelFile = modelFile;
            this.ModelUrl = modelUrl;
            this.ModelVersion = modelVersion;
            this.TextureSize = textureSize;
            this.PolygonLimit = polygonLimit;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToTextureRequest" /> class.
        /// </summary>
        public TextToTextureRequest()
        {
        }
    }
}