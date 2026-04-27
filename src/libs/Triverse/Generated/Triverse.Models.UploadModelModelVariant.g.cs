
#nullable enable

namespace Triverse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadModelModelVariant
    {
        /// <summary>
        /// 
        /// </summary>
        Geometry,
        /// <summary>
        /// 
        /// </summary>
        Textured,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadModelModelVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadModelModelVariant value)
        {
            return value switch
            {
                UploadModelModelVariant.Geometry => "geometry",
                UploadModelModelVariant.Textured => "textured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadModelModelVariant? ToEnum(string value)
        {
            return value switch
            {
                "geometry" => UploadModelModelVariant.Geometry,
                "textured" => UploadModelModelVariant.Textured,
                _ => null,
            };
        }
    }
}