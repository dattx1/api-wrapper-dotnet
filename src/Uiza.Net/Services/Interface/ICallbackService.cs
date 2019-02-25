using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    ///
    /// </summary>
    public interface ICallbackService : IBaseServices, 
        ICreate<UizaData, CreateCallbackParameter>,
        IRetrieve<UizaData>,
        IUpdate<UizaData, UpdateCallbackParameter>,
        IDelete<UizaData>
    {

    }
}