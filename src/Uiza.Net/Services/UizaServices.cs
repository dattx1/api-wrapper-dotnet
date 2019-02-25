using Uiza.Net.Services.Interface;

namespace Uiza.Net.Services
{
    /// <summary>
    ///
    /// </summary>
    public static class UizaServices
    {
        #region PUBLIC PROPERTIES

        /// <summary>
        ///
        /// </summary>
        public static IEntityService Entity
        {
            get
            {
                if (_entity == null)
                    _entity = new EntityService();
                return _entity;
            }
        }

        /// <summary>
        ///
        /// </summary>
        public static ICategoryService Category
        {
            get
            {
                if (_category == null)
                    _category = new CategoryService();
                return _category;
            }
        }

        /// <summary>
        ///
        /// </summary>
        public static IStorageService Storage
        {
            get
            {
                if (_storage == null)
                    _storage = new StorageService();
                return _storage;
            }
        }

        /// <summary>
        ///
        /// </summary>
        public static ICallbackService Callback
        {
            get
            {
                if (_storage == null)
                    _callback = new CallbackService();
                return _callback;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static ILiveStreaming LiveStreaming
        {
            get
            {
                if (_liveStreaming == null)
                    _liveStreaming = new LiveStreamingServices();
                return _liveStreaming;
            }
        }

        #endregion PUBLIC PROPERTIES

        #region PRIVATE PROPERTY

        private static IEntityService _entity;
        private static ICategoryService _category;
        private static IStorageService _storage;
        private static ICallbackService _callback;
        private static ILiveStreaming _liveStreaming;

        #endregion PRIVATE PROPERTY
    }
}