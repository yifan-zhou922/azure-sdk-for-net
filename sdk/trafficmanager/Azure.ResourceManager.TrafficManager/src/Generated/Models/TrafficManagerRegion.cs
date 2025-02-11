// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.TrafficManager;

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> Class representing a region in the Geographic hierarchy used with the Geographic traffic routing method. </summary>
    public partial class TrafficManagerRegion
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TrafficManagerRegion"/>. </summary>
        public TrafficManagerRegion()
        {
            Regions = new ChangeTrackingList<TrafficManagerRegion>();
        }

        /// <summary> Initializes a new instance of <see cref="TrafficManagerRegion"/>. </summary>
        /// <param name="code"> The code of the region. </param>
        /// <param name="name"> The name of the region. </param>
        /// <param name="regions"> The list of Regions grouped under this Region in the Geographic Hierarchy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrafficManagerRegion(string code, string name, IList<TrafficManagerRegion> regions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Name = name;
            Regions = regions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The code of the region. </summary>
        public string Code { get; set; }
        /// <summary> The name of the region. </summary>
        public string Name { get; set; }
        /// <summary> The list of Regions grouped under this Region in the Geographic Hierarchy. </summary>
        public IList<TrafficManagerRegion> Regions { get; }
    }
}
