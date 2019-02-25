using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Uiza.Net.Enums
{
    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CallbackMethodTypes
    {
        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "GET")]
        Get,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "POST")]
        Post,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "PUT")]
        Put
    }
}