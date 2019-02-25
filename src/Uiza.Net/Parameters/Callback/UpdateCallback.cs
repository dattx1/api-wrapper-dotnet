using Newtonsoft.Json;
using System.Collections.Generic;
using Uiza.Net.Enums;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class UpdateCallbackParameter : RetrieveItemParameter
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("method")]
        public CallbackMethodTypes Method { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("jsonData")]
        public Dictionary<string, object> JsonData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("headersData")]
        public Dictionary<string, object> HeadersData { get; set; }
    }
}