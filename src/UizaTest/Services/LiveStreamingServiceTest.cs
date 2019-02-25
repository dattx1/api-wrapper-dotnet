using Moq;
using System;
using Uiza.Net.Parameters;
using Uiza.Net.Services.Interface;
using Uiza.Net.UizaHandleException;
using UizaTest.Enums;
using UizaTest.MockParameter;
using UizaTest.MockResponse;
using Xunit;

namespace UizaTest.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class LiveStreamingServiceTest : UizaTestBase<ILiveStreaming>
    {
        [Fact]
        public void CreatLiveStreamingSuccess()
        {
            mockService.Setup(_ => _.Create(It.IsAny<CreateLiveStreamingParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Create(LiveStreamingMockParameter.CreateLiveStreamingParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void CreateLiveStreamingFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Create(It.IsAny<CreateLiveStreamingParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Create(LiveStreamingMockParameter.CreateLiveStreamingParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void RetrieveLiveStreamingSuccess()
        {
            mockService.Setup(_ => _.Retrieve(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Retrieve(Guid.NewGuid().ToString());
            Assert.NotNull(result);
        }

        [Fact]
        public void RetrieveLiveStreamingFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Retrieve(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Retrieve(Guid.NewGuid().ToString()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void UpdateLiveStreamingSuccess()
        {
            mockService.Setup(_ => _.Update(It.IsAny<UpdateLiveStreamingParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Update(LiveStreamingMockParameter.UpdateLiveStreamingParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void UpdateLiveStreamingFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Update(It.IsAny<UpdateLiveStreamingParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Update(LiveStreamingMockParameter.UpdateLiveStreamingParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void StartALiveFeedSuccess()
        {
            mockService.Setup(_ => _.StartALiveFeed(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.StartALiveFeed(Guid.NewGuid().ToString());
            Assert.NotNull(result);
        }

        [Fact]
        public void StartALiveFeedFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.StartALiveFeed(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.StartALiveFeed(Guid.NewGuid().ToString()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void GetViewOfLiveFeedSuccess()
        {
            mockService.Setup(_ => _.GetViewOfLiveFeed(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.GetViewOfLiveFeed(Guid.NewGuid().ToString());
            Assert.NotNull(result);
        }

        [Fact]
        public void GetViewOfLiveFeedFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.GetViewOfLiveFeed(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.GetViewOfLiveFeed(Guid.NewGuid().ToString()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void StopViewOfLiveFeedSuccess()
        {
            mockService.Setup(_ => _.StopALiveFeed(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.StopALiveFeed(Guid.NewGuid().ToString());
            Assert.NotNull(result);
        }

        [Fact]
        public void StopALiveFeedFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.StopALiveFeed(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.StopALiveFeed(Guid.NewGuid().ToString()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void ListAllRecordedFilesSuccess()
        {
            mockService.Setup(_ => _.ListAllRecordedFiles()).Returns(BaseMockResponse.ListSuccessResponse());
            var result = mockService.Object.ListAllRecordedFiles();
            Assert.NotNull(result);
        }

        [Fact]
        public void ListAllRecordedFilesFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.ListAllRecordedFiles()).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.ListAllRecordedFiles());
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void DeleteRecordFileSuccess()
        {
            mockService.Setup(_ => _.DeleteRecordFile(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.DeleteRecordFile(Guid.NewGuid().ToString());
            Assert.NotNull(result);
        }

        [Fact]
        public void DeleteRecordFileFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.DeleteRecordFile(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.DeleteRecordFile(Guid.NewGuid().ToString()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void ConvertIntoVODSuccess()
        {
            mockService.Setup(_ => _.ConvertIntoVOD(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.ConvertIntoVOD(Guid.NewGuid().ToString());
            Assert.NotNull(result);
        }

        [Fact]
        public void ConvertIntoVODFail()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.ConvertIntoVOD(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.ConvertIntoVOD(Guid.NewGuid().ToString()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }
    }
}
