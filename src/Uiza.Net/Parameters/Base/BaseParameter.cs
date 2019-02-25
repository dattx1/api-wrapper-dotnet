using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net.Parameters
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseParameter : IBaseParameter
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        private Dictionary<string, object> extraParams = new Dictionary<string, object>();

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public Dictionary<string, object> ExtraParams
        {
            get { return this.extraParams; }
            set { this.extraParams = value; }
        }

        [JsonIgnore]
        internal string DescriptionLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void AddExtraParam(string key, object value)
        {
            this.ExtraParams.Add(key, value);
        }
    }
}
