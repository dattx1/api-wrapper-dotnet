using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using Uiza.Net.Response;
using Uiza.Net.UizaHandleException;
using UizaTest.Enums;

namespace UizaTest.MockResponse
{
    public class BaseMockResponse
    {
        public static UizaData SuccessResponse()
        {
            dynamic data = new JObject();
            data.id = Guid.NewGuid().ToString();

            return new UizaData() { Data = data };
        }

        public static UizaException ErrorResponse(int statusCode)
        {
            return new UizaException()
            {
                UizaInnerException = new UizaExceptionResponse()
                {
                    Code = (int)statusCode
                }
            };
        }

        public static UizaData ListSuccessResponse()
        {
            dynamic firstObj = new JObject();
            dynamic seconrdObj = new JObject();
            dynamic metaData = new JObject();
            return new UizaData()
            {
                Data = new List<dynamic>
                {
                   firstObj,
                   seconrdObj
                },

                MetaData = metaData
            };
        }

    }
}
