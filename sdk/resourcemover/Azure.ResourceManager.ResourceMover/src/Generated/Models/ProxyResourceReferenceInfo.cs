// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ResourceMover;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines reference to a proxy resource. </summary>
    public partial class ProxyResourceReferenceInfo : MoverResourceReferenceInfo
    {
        /// <summary> Initializes a new instance of <see cref="ProxyResourceReferenceInfo"/>. </summary>
        /// <param name="sourceArmResourceId"> Gets the ARM resource ID of the tracked resource being referenced. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceArmResourceId"/> is null. </exception>
        public ProxyResourceReferenceInfo(ResourceIdentifier sourceArmResourceId) : base(sourceArmResourceId)
        {
            Argument.AssertNotNull(sourceArmResourceId, nameof(sourceArmResourceId));
        }

        /// <summary> Initializes a new instance of <see cref="ProxyResourceReferenceInfo"/>. </summary>
        /// <param name="sourceArmResourceId"> Gets the ARM resource ID of the tracked resource being referenced. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="name"> Gets the name of the proxy resource on the target side. </param>
        internal ProxyResourceReferenceInfo(ResourceIdentifier sourceArmResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData, string name) : base(sourceArmResourceId, serializedAdditionalRawData)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ProxyResourceReferenceInfo"/> for deserialization. </summary>
        internal ProxyResourceReferenceInfo()
        {
        }

        /// <summary> Gets the name of the proxy resource on the target side. </summary>
        public string Name { get; set; }
    }
}
