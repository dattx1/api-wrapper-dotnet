﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Uiza.Net.Enums;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class UpdateStorageParameter : RetrieveItemParameter
    {
        /// <summary>
        /// Name of the storage
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Host name of the server or IP address	
        /// </summary>
        [JsonProperty("host")]
        public string Host { get; set; }

        /// <summary>
        /// Used port for FTP server. Normally will be 21
        /// </summary>
        [JsonProperty("port")]
        public int Port { get; set; }

        /// <summary>
        /// Storage can be FTP or S3. Allowed values: [S3, FTP]	
        /// </summary>
        [JsonProperty("storageType")]
        public StorageInputTypes StorageType { get; set; }

        /// <summary>
        /// Account username
        /// </summary>
        [JsonProperty("username")]
        public string UserName { get; set; }

        /// <summary>
        /// Account password
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// AWS Access key ID
        /// </summary>
        [JsonProperty("awsAccessKey")]
        public string AwsAccessKey { get; set; }

        /// <summary>
        /// AWS Secret key ID
        /// </summary>
        [JsonProperty("awsSecretKey")]
        public string AwsSecretKey { get; set; }

        /// <summary>
        /// Prefix for objects store in AWS S3	
        /// </summary>
        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// Bucket data of AWS S3
        /// </summary>
        [JsonProperty("bucket")]
        public string Bucket { get; set; }

        /// <summary>
        /// AWS S3 region
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }

        /// <summary>
        /// Storage's description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}