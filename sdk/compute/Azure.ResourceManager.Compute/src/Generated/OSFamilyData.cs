// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the OSFamily data model. </summary>
    public partial class OSFamilyData : ResourceData
    {
        /// <summary> Initializes a new instance of OSFamilyData. </summary>
        internal OSFamilyData()
        {
        }

        /// <summary> Initializes a new instance of OSFamilyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="properties"> OS family properties. </param>
        internal OSFamilyData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string location, OSFamilyProperties properties) : base(id, name, type, systemData)
        {
            Location = location;
            Properties = properties;
        }

        /// <summary> Resource location. </summary>
        public string Location { get; }
        /// <summary> OS family properties. </summary>
        public OSFamilyProperties Properties { get; }
    }
}
