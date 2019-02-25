using Uiza.Net.Parameters;
using Uiza.Net.Response;
using Uiza.Net.Services.Interface;
using Uiza.Net.Utility;

namespace Uiza.Net.Services
{
    /// <summary>
    ///
    /// </summary>
    internal class CallbackService : Service, ICallbackService
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public virtual UizaData Create(CreateCallbackParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.CALLBACK.CREATE);
            return this.PostRequest<UizaData>(Constants.ApiAction.CALLBACK, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="callbackId"></param>
        /// <returns></returns>
        public virtual UizaData Delete(string callbackId)
        {
            return this.DeleteRequest<UizaData>(Constants.ApiAction.CALLBACK, new RetrieveItemParameter()
            {
                Id = callbackId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.CALLBACK.DELETE)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="callbackId"></param>
        /// <returns></returns>
        public virtual UizaData Retrieve(string callbackId)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.CALLBACK, new RetrieveItemParameter()
            {
                Id = callbackId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.CALLBACK.RETRIEVE)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public virtual UizaData Update(UpdateCallbackParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.CALLBACK.UPDATE);
            return this.PutRequest<UizaData>(Constants.ApiAction.CALLBACK, param);
        }
    }
}