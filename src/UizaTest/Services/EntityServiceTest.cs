using Moq;
using Uiza.Net.Parameters;
using Uiza.Net.Services;
using Uiza.Net.Services.Interface;
using Uiza.Net.UizaHandleException;
using UizaTest.Enums;
using UizaTest.MockData;
using UizaTest.MockResponse;
using Xunit;

namespace UizaTest.Services
{
    public class EntityServiceTest : UizaTestBase<IEntityService>
    {
        [Fact]
        public void CreateSuccess()
        {
            mockService.Setup(_ => _.Create(It.IsAny<CreateEntityParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Create(EntityMockParameter.CreateValidEntityParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void CreateFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Create(It.IsAny<CreateEntityParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Create(EntityMockParameter.CreateInValidEntityParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void RetrieveSuccess()
        {
            mockService.Setup(_ => _.Retrieve(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse);
            var result = mockService.Object.Retrieve("2e173ee3-be45-46bd-a355-c9182a2a41ec");
            Assert.NotNull(result);
        }

        [Fact]
        public void RetrieveFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Retrieve(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Retrieve(""));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void ListEntitiesSuccess()
        {
            mockService.Setup(_ => _.List(It.IsAny<RetrieveListEntitiesParameter>())).Returns(BaseMockResponse.ListSuccessResponse());
            var result = mockService.Object.List(EntityMockParameter.ListValidEntityParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void UpdateSuccess()
        {
            mockService.Setup(_ => _.Update(It.IsAny<UpdateEntityParameter>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Update(EntityMockParameter.UpdateValidEntityParameter());
            Assert.NotNull(result);
        }

        [Fact]
        public void UpdateFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Update(It.IsAny<UpdateEntityParameter>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Update(EntityMockParameter.UpdateInValidEntityParameter()));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void DeleteSuccess()
        {
            mockService.Setup(_ => _.Delete(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.Delete("2e173ee3-be45-46bd-a355-c9182a2a41ec");
            Assert.NotNull(result);
        }

        [Fact]
        public void DeleteFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.Delete(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.Delete(""));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void SearchSuccess()
        {
            mockService.Setup(_ => _.SearchEntity(It.IsAny<string>())).Returns(BaseMockResponse.ListSuccessResponse());
            var result = mockService.Object.SearchEntity("Sample");
            Assert.NotNull(result);
        }

        [Fact]
        public void SearchFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.SearchEntity(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.SearchEntity(""));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void PublishEntitySuccess()
        {
            mockService.Setup(_ => _.PublishEntity(It.IsAny<string>())).Returns(BaseMockResponse.SuccessResponse());
            var result = mockService.Object.PublishEntity("2e173ee3-be45-46bd-a355-c9182a2a41ec");
            Assert.NotNull(result);
        }

        [Fact]
        public void PublishEntityFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.PublishEntity(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.PublishEntity(""));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void GetStatusPublishSuccess()
        {
            mockService.Setup(_ => _.GetEntityStatusPublish(It.IsAny<string>())).Returns(EntityResponse.GetStatusPublishSuccessResponse());
            var result = mockService.Object.GetEntityStatusPublish("2e173ee3-be45-46bd-a355-c9182a2a41ec");
            Assert.NotNull(result);
        }

        [Fact]
        public void GetStatusPublishFailWithAPIResponse()
        {
            foreach (var statusCode in this.StatusCodes)
            {
                mockService.Setup(_ => _.GetEntityStatusPublish(It.IsAny<string>())).Throws(BaseMockResponse.ErrorResponse(statusCode));
                var ex = Assert.Throws<UizaException>(() => mockService.Object.GetEntityStatusPublish(""));
                Assert.Equal(statusCode, ex.UizaInnerException.Code);
            }
        }

        [Fact]
        public void GetAWSUploadKeySuccess()
        {
            mockService.Setup(_ => _.GetEntityAWSUploadKey()).Returns(EntityResponse.GetAWSUploadKeySuccessResponse());
            var result = mockService.Object.GetEntityAWSUploadKey();
            Assert.NotNull(result);
        }
    }
}