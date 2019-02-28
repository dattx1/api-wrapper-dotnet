﻿namespace Uiza.Net
{
    /// <summary>
    ///
    /// </summary>
    internal static class Constants
    {
        internal static string DEFAULT_API_ROUTE => "api/public/v3";

        internal struct ApiAction
        {
            public const string CATEGORY = "media/metadata";
            public const string ENTITY = "media/entity";
            public const string STORAGE = "media/storage";
            public const string CATEGORY_RELATION = "media/entity/related/metadata";
            public const string AWS_UPLOAD_KEY = "admin/app/config/aws";
            public const string ENTITY_STATUS_PUBLISH = "media/entity/publish/status";
            public const string ENTITY_PUBLISH = "media/entity/publish";
            public const string ENTITY_SEARCH = "media/entity/search";
            public const string CALLBACK = "media/entity/callback";
            public const string LIVE_STREAMING = "live/entity";
            public const string LIVE_STREAMING_FEED = "live/entity/feed";
            public const string LIVE_STREAMING_GET_VIEW = "live/entity/tracking/current-view";
            public const string LIVE_STREAMING_RECORDED = "live/entity/dvr";
            public const string LIVE_STREAMING_CONVERT_VOD = "live/entity/dvr/convert-to-vod";
            public const string ANALYTIC_TOTAL_LINE = "analytic/entity/video-quality/total-line-v2";
            public const string ANALYTIC_TYPE = "analytic/entity/video-quality/type";
            public const string ANALYTIC_LINE = "analytic/entity/video-quality/line";
            public const string USER = "admin/user";
            public const string USER_CHANGE_PASSWORD = "admin/user/changepassword";
            public const string USER_LOGOUT = "admin/user/logout";
        }

        internal struct ErrorMessages
        {
            public const string REQUIRED = "{0} must be present";
            public const string INPUT_TYPE_REQUIRED = "InputType must be present and must be in [http, s3, ftp, s3-uiza]";
            public const string PUBLISH_TO_CDN = "PublishToCdn must be in [queue, not-ready, success, failed]";
            public const string STORAGE_REQUIRED = "Type must be present and must be in [S3, FTP]";
            public const string STORAGE_TYPE_REQUIRED = "Type must be present and must be in [S3, FTP]";
            public const string CATEGORY_TYPE_REQUIRED = "Type must be present and must be in [ folder, playlist, tag ]";
        }

        internal struct ResponseStatusMessages
        {
            public const string BAD_REQUEST = "The request was unacceptable, often due to missing a required parameter.";
            public const string UNAUTHORIZED = "No valid API key provided.";
            public const string NOT_FOUND = "The requested resource doesn't exist.";
            public const string UNPROCESSABLE = "The syntax of the request is correct (often cause of wrong parameter).";
            public const string INTERNAL_SERVER = "We had a problem with our server. Try again later.";
            public const string SERVICE_UNAVAILABLE = "The server is overloaded or down for maintenance.";
            public const string CLIENT = "The error seems to have been caused by the client.";
            public const string SERVER = "The server is aware that it has encountered an error.";
        }
    }
}