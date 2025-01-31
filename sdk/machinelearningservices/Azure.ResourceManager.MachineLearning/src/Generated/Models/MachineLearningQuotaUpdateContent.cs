// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Quota update parameters. </summary>
    public partial class MachineLearningQuotaUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningQuotaUpdateContent"/>. </summary>
        public MachineLearningQuotaUpdateContent()
        {
            Value = new ChangeTrackingList<MachineLearningQuotaProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningQuotaUpdateContent"/>. </summary>
        /// <param name="value"> The list for update quota. </param>
        /// <param name="location"> Region of workspace quota to be updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningQuotaUpdateContent(IList<MachineLearningQuotaProperties> value, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list for update quota. </summary>
        public IList<MachineLearningQuotaProperties> Value { get; }
        /// <summary> Region of workspace quota to be updated. </summary>
        public AzureLocation? Location { get; set; }
    }
}
