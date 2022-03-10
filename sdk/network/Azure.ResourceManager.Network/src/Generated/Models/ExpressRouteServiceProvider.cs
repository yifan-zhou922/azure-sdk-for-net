// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> A ExpressRouteResourceProvider object. </summary>
    public partial class ExpressRouteServiceProvider : NetworkResourceData
    {
        /// <summary> Initializes a new instance of ExpressRouteServiceProvider. </summary>
        public ExpressRouteServiceProvider()
        {
            PeeringLocations = new ChangeTrackingList<string>();
            BandwidthsOffered = new ChangeTrackingList<ExpressRouteServiceProviderBandwidthsOffered>();
        }

        /// <summary> Initializes a new instance of ExpressRouteServiceProvider. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="peeringLocations"> A list of peering locations. </param>
        /// <param name="bandwidthsOffered"> A list of bandwidths offered. </param>
        /// <param name="provisioningState"> The provisioning state of the express route service provider resource. </param>
        internal ExpressRouteServiceProvider(string id, string name, string type, string location, IDictionary<string, string> tags, IList<string> peeringLocations, IList<ExpressRouteServiceProviderBandwidthsOffered> bandwidthsOffered, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            PeeringLocations = peeringLocations;
            BandwidthsOffered = bandwidthsOffered;
            ProvisioningState = provisioningState;
        }

        /// <summary> A list of peering locations. </summary>
        public IList<string> PeeringLocations { get; }
        /// <summary> A list of bandwidths offered. </summary>
        public IList<ExpressRouteServiceProviderBandwidthsOffered> BandwidthsOffered { get; }
        /// <summary> The provisioning state of the express route service provider resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
