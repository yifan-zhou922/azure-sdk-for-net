// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.AppPlatform;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Buildpack group properties of the Builder. </summary>
    public partial class BuildpacksGroupProperties
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

        /// <summary> Initializes a new instance of <see cref="BuildpacksGroupProperties"/>. </summary>
        public BuildpacksGroupProperties()
        {
            Buildpacks = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="BuildpacksGroupProperties"/>. </summary>
        /// <param name="name"> Buildpack group name. </param>
        /// <param name="buildpacks"> Buildpacks in the buildpack group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BuildpacksGroupProperties(string name, IList<WritableSubResource> buildpacks, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Buildpacks = buildpacks;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Buildpack group name. </summary>
        public string Name { get; set; }
        /// <summary> Buildpacks in the buildpack group. </summary>
        public IList<WritableSubResource> Buildpacks { get; }
    }
}
