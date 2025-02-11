﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Replication properties. </summary>
    public partial class NetAppReplicationObject
    {
        /// <summary> Id. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ReplicationId { get; set; }
    }
}
