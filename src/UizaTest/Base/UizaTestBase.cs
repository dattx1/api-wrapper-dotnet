using Moq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Uiza.Net.Services;
using Uiza.Net.UizaHandleException;
using UizaTest.Enums;
using UizaTest.MockResponse;
using Xunit;

namespace UizaTest
{
    public class UizaTestBase<T> where T : class, IBaseServices
    {
        public Mock<T> mockService;
        Random r;

        protected List<int> StatusCodes
        {
            get
            {
                return new List<int>()
                {
                    (int)ResponseCodeEnums.Unprocessable,
                    (int)ResponseCodeEnums.BadRequest,
                    (int)ResponseCodeEnums.Unauthorized,
                    (int)ResponseCodeEnums.ServiceUnavailable,
                    (int)ResponseCodeEnums.NotFound,
                    (int)ResponseCodeEnums.InternalServerError,
                    GetRandomStatus4xx(),
                    GetRandomStatus5xx()
                };
            }
        }

        protected UizaTestBase()
        {
            mockService = new Mock<T>() { CallBase = true };
            r = new Random();
        }

        private int GetRandomStatus4xx()
        {
            return r.Next(400, 499);
        }

        private int GetRandomStatus5xx()
        {
            return r.Next(500, 599);
        }
    }
}