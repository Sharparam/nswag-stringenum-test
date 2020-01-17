namespace NSwagStringEnum.WebApi.Data
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AnnotatedEnum
    {
        These,

        Generate,

        As,

        Strings
    }
}
