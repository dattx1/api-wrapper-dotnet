using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Uiza.Net.Enums;

namespace Uiza.Net.Parameters
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateLiveStreamingParameter : RetrieveItemParameter
    {
        /// <summary>
        /// The event name (limit 100 characters)
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Feed after streamed will be recorded as a mp4 file
        /// 0: No record
        /// 1: Active Feature record
        /// </summary>
        [JsonProperty("drv")]
        public DvrTypes Drv { get; set; }

        /// <summary>
        /// Type of event can be pull or push
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Mode of live stream (0 = no encode, 1 = encode)
        /// </summary>
        [JsonProperty("encode")]
        public EncodeTypes Encode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resourceMode")]
        public ResourceModes ResourceMode { get; set; }
    }
}
