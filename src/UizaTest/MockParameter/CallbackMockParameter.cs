using System;
using Uiza.Net.Enums;
using Uiza.Net.Parameters;

namespace UizaTest.MockData
{
    public static class CallbackMockParameter
    {
        public static CreateCallbackParameter CreateValidCallbackParameter()
        {
            return new CreateCallbackParameter()
            {
                Url = "https://callback-url.uiza.co",
                Method = CallbackMethodTypes.Post,
            };
        }

        public static CreateCallbackParameter CreateInValidCallbackParameter()
        {
            return new CreateCallbackParameter()
            {
                Url = "",
                Method = CallbackMethodTypes.Post,
            };
        }

        public static UpdateCallbackParameter UpdateValidCallbackParameter()
        {
            return new UpdateCallbackParameter()
            {
                Id = Guid.NewGuid().ToString(),
                Url = "https://callback-url.uiza.co/update",
                Method = CallbackMethodTypes.Post
            };
        }

        public static UpdateCallbackParameter UpdateInValidCallbackParameter()
        {
            return new UpdateCallbackParameter()
            {
                Url = "https://callback-url.uiza.co/update",
                Method = CallbackMethodTypes.Post
            };
        }
    }
}