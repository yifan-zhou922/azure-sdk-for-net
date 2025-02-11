// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotFirmwareDefense;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Crypto key resource. </summary>
    public partial class CryptoKeyResult : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="CryptoKeyResult"/>. </summary>
        public CryptoKeyResult()
        {
            Usage = new ChangeTrackingList<string>();
            FilePaths = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CryptoKeyResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="cryptoKeyId"> ID for the key result. </param>
        /// <param name="keyType"> Type of the key (public or private). </param>
        /// <param name="keySize"> Size of the key in bits. </param>
        /// <param name="keyAlgorithm"> Key algorithm name. </param>
        /// <param name="usage"> Functions the key can fulfill. </param>
        /// <param name="filePaths"> List of files where this key was found. </param>
        /// <param name="pairedKey"> A matching paired key or certificate. </param>
        /// <param name="isShortKeySize"> Indicates the key size is considered too small to be secure for the algorithm. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CryptoKeyResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string cryptoKeyId, string keyType, long? keySize, string keyAlgorithm, IList<string> usage, IReadOnlyList<string> filePaths, CryptoPairedKey pairedKey, bool? isShortKeySize, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            CryptoKeyId = cryptoKeyId;
            KeyType = keyType;
            KeySize = keySize;
            KeyAlgorithm = keyAlgorithm;
            Usage = usage;
            FilePaths = filePaths;
            PairedKey = pairedKey;
            IsShortKeySize = isShortKeySize;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ID for the key result. </summary>
        public string CryptoKeyId { get; set; }
        /// <summary> Type of the key (public or private). </summary>
        public string KeyType { get; set; }
        /// <summary> Size of the key in bits. </summary>
        public long? KeySize { get; set; }
        /// <summary> Key algorithm name. </summary>
        public string KeyAlgorithm { get; set; }
        /// <summary> Functions the key can fulfill. </summary>
        public IList<string> Usage { get; set; }
        /// <summary> List of files where this key was found. </summary>
        public IReadOnlyList<string> FilePaths { get; }
        /// <summary> A matching paired key or certificate. </summary>
        public CryptoPairedKey PairedKey { get; set; }
        /// <summary> Indicates the key size is considered too small to be secure for the algorithm. </summary>
        public bool? IsShortKeySize { get; set; }
    }
}
