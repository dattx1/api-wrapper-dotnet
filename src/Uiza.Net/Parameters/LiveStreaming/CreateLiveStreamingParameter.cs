using Newtonsoft.Json;
using System.Collections.Generic;
using Uiza.Net.Enums;

namespace Uiza.Net.Parameters
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateLiveStreamingParameter : BaseParameter
    {
        /// <summary>
        /// The event name (limit 100 characters)
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

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
        /// Feed after streamed will be recorded as a mp4 file
        /// 0: No record
        /// 1: Active Feature record
        /// </summary>
        [JsonProperty("drv")]
        public DvrTypes Drv { get; set; }

        /// <summary>
        /// Description of the live stream	
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// thumbnail
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("poster")]
        public string Poster { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("linkStream")]
        public List<string> LinkStream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resourceMode")]
        public ResourceModes ResourceMode { get; set; }

        /// <summary>
        /// Info to share live into social
        /// </summary>
        [JsonProperty("linkPublishSocial")]
        public List<InfoShareSocial> LinkPublishSocial { get; set; }

    }

    /// <summary>
    /// 
    /// </summary>
    public class InfoShareSocial
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dropdown")]
        public TypeOfSocials Dropdown { get; set; }

        /// <summary>
        /// stream URL.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("streamKey")]
        public string StreamKey { get; set; }
    }
}
