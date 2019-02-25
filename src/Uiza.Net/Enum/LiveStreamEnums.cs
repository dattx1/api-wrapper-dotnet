using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Uiza.Net.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum DvrTypes
    {
        /// <summary>
        /// No record
        /// </summary>
        NoRecord = 0,

        /// <summary>
        /// Active Feature record
        /// </summary>
        ActiveFeatureRecord,
    }

    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResourceModes
    {
        /// <summary>
        /// single = only 1 feed and output
        /// </summary>
        [EnumMember(Value = "single")]
        Single,

        /// <summary>
        /// redundant = more than 1 feed and output to backup
        /// </summary>
        [EnumMember(Value = "redundant")]
        Redundant,
    }

    /// <summary>
    /// 
    /// </summary>
    public enum EncodeTypes
    {
        /// <summary>
        /// No record
        /// </summary>
        NoEncode = 0,

        /// <summary>
        /// Active Feature record
        /// </summary>
        Encode,
    }
}
