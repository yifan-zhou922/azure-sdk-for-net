// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Models
{
    /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
    [PropertyReferenceType]
    public partial class ManagedServiceIdentity
    {
        /// <summary> Initializes a new instance of ManagedServiceIdentity. </summary>
        /// <param name="type"> Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed). </param>
        [InitializationConstructor]
        public ManagedServiceIdentity(ManagedServiceIdentityType type)
        {
            Type = type;
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of ManagedServiceIdentity. </summary>
        /// <param name="principalId"> The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="tenantId"> The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="type"> Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed). </param>
        /// <param name="userAssignedIdentities"> The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests. </param>
        [SerializationConstructor]
        internal ManagedServiceIdentity(Guid? principalId, Guid? tenantId, ManagedServiceIdentityType type, IDictionary<string, UserAssignedIdentity> userAssignedIdentities)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
            UserAssignedIdentities = userAssignedIdentities;
        }

        /// <summary> The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity. </summary>
        public Guid? TenantId { get; }
        /// <summary> Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed). </summary>
        public ManagedServiceIdentityType Type { get; set; }
        /// <summary> The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests. </summary>
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; }
    }
}
