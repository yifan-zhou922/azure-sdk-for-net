// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Parameters supplied to the Regenerate Authorization Rule operation, specifies which key needs to be reset. </summary>
    public partial class RegenerateAccessKeyOptions
    {
        /// <summary> Initializes a new instance of RegenerateAccessKeyOptions. </summary>
        /// <param name="keyType"> The access key to regenerate. </param>
        public RegenerateAccessKeyOptions(KeyType keyType)
        {
            KeyType = keyType;
        }

        /// <summary> The access key to regenerate. </summary>
        public KeyType KeyType { get; }
        /// <summary> Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType. </summary>
        public string Key { get; set; }
    }
}
