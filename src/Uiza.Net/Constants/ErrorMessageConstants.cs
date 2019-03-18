﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net
{
    internal static partial class Constants
    {
        internal struct ValidationErrors
        {
            public const string REQUIRED = "{0} must be present";
            public const string INPUT_TYPE_REQUIRED = "InputType must be present and must be in [http, s3, ftp, s3-uiza]";
            public const string PUBLISH_TO_CDN = "PublishToCdn must be in [queue, not-ready, success, failed]";
            public const string STORAGE_REQUIRED = "Type must be present and must be in [S3, FTP]";
            public const string STORAGE_TYPE_REQUIRED = "Type must be present and must be in [S3, FTP]";
            public const string CATEGORY_TYPE_REQUIRED = "Type must be present and must be in [ folder, playlist, tag ]";
        }

        internal struct ResponseStatusErrors
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
