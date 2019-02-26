﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net
{
    internal static class DescriptionLinkConstants
    {
        internal const string BASE_DESCRIPTION_LINK = "https://docs.uiza.io/";
        public const string AUTHENTICATION = "authentication";
        internal struct ENTITY
        {
            public const string CREATE = "create-entity";
            public const string RETRIEVE = "retrieve-an-entity";
            public const string LIST = "list-all-entities";
            public const string UPDATE = "update-an-entity";
            public const string DELETE = "delete-an-entity";
            public const string SEARCH = "search-entity";
            public const string PUBLISH_ENTITY_TO_CDN = "publish-entity-to-cdn";
            public const string GET_STATUS_PUBLISH = "get-status-publish";
            public const string GET_AWS_UPLOAD_KEY = "get-aws-upload-key";
        }

        internal struct CATEGORY
        {
            public const string CREATE = "create-category";
            public const string RETRIEVE = "retrieve-category";
            public const string LIST = "retrieve-category-list";
            public const string UPDATE = "update-category";
            public const string DELETE = "delete-category";
            public const string CREATE_CATEGORY_RELATION = "create-category-relation";
            public const string DELETE_CATEGORY_RELATION = "delete-category-relation";
        }

        internal struct STORAGE
        {
            public const string ADD = "add-a-storage";
            public const string RETRIEVE = "retrieve-a-storage";
            public const string UPDATE = "update-storage";
            public const string REMOVE = "remove-storage";
        }

        internal struct CALLBACK
        {
            public const string CREATE = "create-a-callback";
            public const string RETRIEVE = "retrieve-a-callback";
            public const string UPDATE = "update-a-callback";
            public const string DELETE = "delete-a-callback";
        }
    }
}
