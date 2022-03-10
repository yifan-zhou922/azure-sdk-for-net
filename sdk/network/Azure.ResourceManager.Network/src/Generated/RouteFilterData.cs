// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the RouteFilter data model. </summary>
    public partial class RouteFilterData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of RouteFilterData. </summary>
        public RouteFilterData()
        {
            Rules = new ChangeTrackingList<RouteFilterRuleData>();
            Peerings = new ChangeTrackingList<ExpressRouteCircuitPeeringData>();
            IPv6Peerings = new ChangeTrackingList<ExpressRouteCircuitPeeringData>();
        }

        /// <summary> Initializes a new instance of RouteFilterData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="rules"> Collection of RouteFilterRules contained within a route filter. </param>
        /// <param name="peerings"> A collection of references to express route circuit peerings. </param>
        /// <param name="iPv6Peerings"> A collection of references to express route circuit ipv6 peerings. </param>
        /// <param name="provisioningState"> The provisioning state of the route filter resource. </param>
        internal RouteFilterData(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, IList<RouteFilterRuleData> rules, IReadOnlyList<ExpressRouteCircuitPeeringData> peerings, IReadOnlyList<ExpressRouteCircuitPeeringData> iPv6Peerings, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Etag = etag;
            Rules = rules;
            Peerings = peerings;
            IPv6Peerings = iPv6Peerings;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Collection of RouteFilterRules contained within a route filter. </summary>
        public IList<RouteFilterRuleData> Rules { get; }
        /// <summary> A collection of references to express route circuit peerings. </summary>
        public IReadOnlyList<ExpressRouteCircuitPeeringData> Peerings { get; }
        /// <summary> A collection of references to express route circuit ipv6 peerings. </summary>
        public IReadOnlyList<ExpressRouteCircuitPeeringData> IPv6Peerings { get; }
        /// <summary> The provisioning state of the route filter resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
