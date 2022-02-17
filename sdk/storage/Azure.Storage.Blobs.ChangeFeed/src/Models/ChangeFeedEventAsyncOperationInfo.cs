﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Storage.Blobs.Models;

namespace Azure.Storage.Blobs.ChangeFeed.Models
{
    /// <summary>
    /// ChangeFeedEventAsyncOperationInfo.
    /// </summary>
    public class ChangeFeedEventAsyncOperationInfo
    {
        internal ChangeFeedEventAsyncOperationInfo() { }

        /// <summary>
        /// DestinationAccessTier.
        /// </summary>
        public AccessTier? DestinationAccessTier { get; internal set; }
    }
}
