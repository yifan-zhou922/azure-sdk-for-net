// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.SignalR;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> ACL for a private endpoint. </summary>
    public partial class SignalRPrivateEndpointAcl : SignalRNetworkAcl
    {
        /// <summary> Initializes a new instance of <see cref="SignalRPrivateEndpointAcl"/>. </summary>
        /// <param name="name"> Name of the private endpoint connection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public SignalRPrivateEndpointAcl(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="SignalRPrivateEndpointAcl"/>. </summary>
        /// <param name="allow"> Allowed request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI. </param>
        /// <param name="deny"> Denied request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="name"> Name of the private endpoint connection. </param>
        internal SignalRPrivateEndpointAcl(IList<SignalRRequestType> allow, IList<SignalRRequestType> deny, IDictionary<string, BinaryData> serializedAdditionalRawData, string name) : base(allow, deny, serializedAdditionalRawData)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="SignalRPrivateEndpointAcl"/> for deserialization. </summary>
        internal SignalRPrivateEndpointAcl()
        {
        }

        /// <summary> Name of the private endpoint connection. </summary>
        public string Name { get; set; }
    }
}
