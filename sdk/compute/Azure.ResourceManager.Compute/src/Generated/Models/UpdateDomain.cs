// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Defines an update domain for the cloud service. </summary>
    public partial class UpdateDomain
    {
        /// <summary> Initializes a new instance of UpdateDomain. </summary>
        public UpdateDomain()
        {
        }

        /// <summary> Initializes a new instance of UpdateDomain. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        internal UpdateDomain(string id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary> Resource Id. </summary>
        public string Id { get; }
        /// <summary> Resource Name. </summary>
        public string Name { get; }
    }
}
