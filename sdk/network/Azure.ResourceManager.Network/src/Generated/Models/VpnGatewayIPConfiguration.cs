// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> IP Configuration of a VPN Gateway Resource. </summary>
    public partial class VpnGatewayIPConfiguration
    {
        /// <summary> Initializes a new instance of VpnGatewayIPConfiguration. </summary>
        internal VpnGatewayIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of VpnGatewayIPConfiguration. </summary>
        /// <param name="id"> The identifier of the IP configuration for a VPN Gateway. </param>
        /// <param name="publicIPAddress"> The public IP address of this IP configuration. </param>
        /// <param name="privateIPAddress"> The private IP address of this IP configuration. </param>
        internal VpnGatewayIPConfiguration(string id, string publicIPAddress, string privateIPAddress)
        {
            Id = id;
            PublicIPAddress = publicIPAddress;
            PrivateIPAddress = privateIPAddress;
        }

        /// <summary> The identifier of the IP configuration for a VPN Gateway. </summary>
        public string Id { get; }
        /// <summary> The public IP address of this IP configuration. </summary>
        public string PublicIPAddress { get; }
        /// <summary> The private IP address of this IP configuration. </summary>
        public string PrivateIPAddress { get; }
    }
}
