﻿using System;
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
        IUpdate<UizaData, BaseParameter>,
        IDelete<UizaData>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        UizaData StartFeed(string eventId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        UizaData GetView(string eventId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        UizaData StopFeed(string eventId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        UizaData ConvertToVOD(string recordId);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        UizaData ListRecorded();
    }
}
