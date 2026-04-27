
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Triverse
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Triverse.JsonConverters.UploadModelModelVariantJsonConverter),

            typeof(global::Triverse.JsonConverters.UploadModelModelVariantNullableJsonConverter),

            typeof(global::Triverse.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.UserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.BalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.FileUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.UploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.PresignedUploadUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.PresignedUploadUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.PresignedGetUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.PresignedGetUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.TextToModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.ImageToModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.TextureModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.TextToTextureRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.ConvertModelFormatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.ModelPreviewRenderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.ModelRemeshRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.ImageGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.TaskCreatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.TaskStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Triverse.TaskFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.TaskFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.TaskAssetUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Triverse.UploadModelModelVariant), TypeInfoPropertyName = "UploadModelModelVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Triverse.TaskFile>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}