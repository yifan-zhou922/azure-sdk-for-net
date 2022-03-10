// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network Intent Policy resource. </summary>
    public partial class NetworkIntentPolicy : NetworkResourceData
    {
        /// <summary> Initializes a new instance of NetworkIntentPolicy. </summary>
        public NetworkIntentPolicy()
        {
        }

        /// <summary> Initializes a new instance of NetworkIntentPolicy. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        internal NetworkIntentPolicy(string id, string name, string type, string location, IDictionary<string, string> tags, string etag) : base(id, name, type, location, tags)
        {
            Etag = etag;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
    }
}
