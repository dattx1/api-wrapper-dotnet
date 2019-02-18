﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Uiza.Net.Enums
{
    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityInputTypes
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "s3-uiza")]
        S3Uiza,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "http")]
        Http,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "s3")]
        S3,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "ftp")]
        Ftp
    }
}
