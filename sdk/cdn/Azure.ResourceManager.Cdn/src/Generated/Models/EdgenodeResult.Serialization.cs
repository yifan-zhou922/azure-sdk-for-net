// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    internal partial class EdgenodeResult
    {
        internal static EdgenodeResult DeserializeEdgenodeResult(JsonElement element)
        {
            Optional<IReadOnlyList<EdgeNode>> value = default;
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
                    List<EdgeNode> array = new List<EdgeNode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EdgeNode.DeserializeEdgeNode(item));
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
            return new EdgenodeResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
