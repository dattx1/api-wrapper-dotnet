using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using Uiza.Net.Response;
using Uiza.Net.UizaHandleException;
using UizaTest.Enums;

namespace UizaTest.MockResponse
{
    public static class EntityResponse 
    {
        public static UizaData GetStatusPublishSuccessResponse()
        {
            dynamic data = new JObject();

            return new UizaData() { Data = data };
        }

        public static UizaData GetAWSUploadKeySuccessResponse()
        {
            dynamic data = new JObject();

            return new UizaData() { Data = data };
        }
    }
}