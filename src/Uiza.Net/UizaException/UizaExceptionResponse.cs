﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uiza.Net.Extension;
using Uiza.Net.Response;

namespace Uiza.Net.UizaHandleException
{
    /// <summary>
    /// 
    /// </summary>
    public class UizaExceptionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("retryable")]
        public bool RetryAble { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ErrorData Error
        {
            get
            {
                return Errors.FirstOrDefault() ?? new ErrorData();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<ErrorData> Errors
        {
            get
            {
                if (Data.IsJArray())
                    return JsonConvert.DeserializeObject<List<ErrorData>>(JsonConvert.SerializeObject(Data));
                if (Data is string)
                    return new List<ErrorData>() {
                        new ErrorData()
                        {
                            Message = Message,
                            Type = Type
                        }
                    };
                return new List<ErrorData>() {
                    JsonConvert.DeserializeObject<ErrorData>(JsonConvert.SerializeObject(Data))
                };
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ErrorData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("field")]
        public string Field { get; set; }
    }
}
