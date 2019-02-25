using Uiza.Net.Parameters;
using Uiza.Net.Response;
using Uiza.Net.Services.Interface;
using Uiza.Net.Utility;

namespace Uiza.Net.Services
{
    internal class LiveStreamingServices : Service, ILiveStreaming
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Create(CreateLiveStreamingParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.CREATE);
            return this.PostRequest<UizaData>(Constants.ApiAction.LIVE_STREAMING, param);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Update(BaseParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.UPDATE);
            return this.PutRequest<UizaData>(Constants.ApiAction.LIVE_STREAMING, param);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public UizaData ListAllRecordedFiles()
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.LIVE_STREAMING_RECORDED, new BaseParameter()
            {
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.LIST_ALL_RECORDED_FILES)
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public UizaData Retrieve(string eventId)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.LIVE_STREAMING, new RetrieveItemParameter()
            {
                Id = eventId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.RETRIEVE)
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recordId">Identifier of record (get from list record)</param>
        /// <returns></returns>
        public UizaData DeleteRecordFile(string recordId)
        {
            return this.DeleteRequest<UizaData>(Constants.ApiAction.LIVE_STREAMING_RECORDED, new RetrieveItemParameter()
            {
                Id = recordId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.DELETE_A_RECORD_FILE)
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public UizaData GetViewOfLiveFeed(string eventId)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.LIVE_STREAMING, new RetrieveItemParameter()
            {
                Id = eventId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.RETRIEVE)
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public UizaData StartALiveFeed(string eventId)
        {
            return this.PostRequest<UizaData>(Constants.ApiAction.LIVE_STREAMING_FEED, new RetrieveItemParameter()
            {
                Id = eventId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.START_A_LIVE_FEED)
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public UizaData StopALiveFeed(string eventId)
        {
            return this.PutRequest<UizaData>(Constants.ApiAction.LIVE_STREAMING_FEED, new RetrieveItemParameter()
            {
                Id = eventId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.STOP_A_LIVE_FEED)
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        public UizaData ConvertIntoVOD(string recordId)
        {
            return this.PostRequest<UizaData>(Constants.ApiAction.LIVE_STREAMING_CONVERT_VOD, new RetrieveItemParameter()
            {
                Id = recordId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.STOP_A_LIVE_FEED)
            });
        }
    }
}
