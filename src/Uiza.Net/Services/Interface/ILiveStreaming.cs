using System;
using System.Collections.Generic;
using System.Text;
using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILiveStreaming :
        IBaseServices,
        ICreate<UizaData, CreateLiveStreamingParameter>,
        IRetrieve<UizaData>,
        IUpdate<UizaData, BaseParameter>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        UizaData StartALiveFeed(string eventId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        UizaData GetViewOfLiveFeed(string eventId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        UizaData StopALiveFeed(string eventId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        UizaData ConvertIntoVOD(string recordId);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        UizaData ListAllRecordedFiles();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        UizaData DeleteRecordFile(string recordId);
    }
}
