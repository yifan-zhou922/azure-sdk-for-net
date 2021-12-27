// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    internal partial class SecretListResult
    {
        internal static SecretListResult DeserializeSecretListResult(JsonElement element)
        {
            Optional<IReadOnlyList<AfdSecretData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AfdSecretData> array = new List<AfdSecretData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AfdSecretData.DeserializeAfdSecretData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SecretListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
