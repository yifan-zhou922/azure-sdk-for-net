// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The sensitivity settings properties. </summary>
    public partial class SensitivitySettingsProperties
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

        /// <summary> Initializes a new instance of <see cref="SensitivitySettingsProperties"/>. </summary>
        internal SensitivitySettingsProperties()
        {
            SensitiveInfoTypesIds = new ChangeTrackingList<Guid>();
        }

        /// <summary> Initializes a new instance of <see cref="SensitivitySettingsProperties"/>. </summary>
        /// <param name="sensitiveInfoTypesIds"> List of selected sensitive info types' IDs. </param>
        /// <param name="sensitivityThresholdLabelOrder"> The order of the sensitivity threshold label. Any label at or above this order will be considered sensitive. If set to -1, sensitivity by labels is turned off. </param>
        /// <param name="sensitivityThresholdLabelId"> The id of the sensitivity threshold label. Any label at or above this rank will be considered sensitive. </param>
        /// <param name="mipInformation"> Microsoft information protection built-in and custom information types, labels, and integration status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SensitivitySettingsProperties(IReadOnlyList<Guid> sensitiveInfoTypesIds, float? sensitivityThresholdLabelOrder, Guid? sensitivityThresholdLabelId, GetSensitivitySettingsResponsePropertiesMipInformation mipInformation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SensitiveInfoTypesIds = sensitiveInfoTypesIds;
            SensitivityThresholdLabelOrder = sensitivityThresholdLabelOrder;
            SensitivityThresholdLabelId = sensitivityThresholdLabelId;
            MipInformation = mipInformation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of selected sensitive info types' IDs. </summary>
        public IReadOnlyList<Guid> SensitiveInfoTypesIds { get; }
        /// <summary> The order of the sensitivity threshold label. Any label at or above this order will be considered sensitive. If set to -1, sensitivity by labels is turned off. </summary>
        public float? SensitivityThresholdLabelOrder { get; }
        /// <summary> The id of the sensitivity threshold label. Any label at or above this rank will be considered sensitive. </summary>
        public Guid? SensitivityThresholdLabelId { get; }
        /// <summary> Microsoft information protection built-in and custom information types, labels, and integration status. </summary>
        public GetSensitivitySettingsResponsePropertiesMipInformation MipInformation { get; }
    }
}
