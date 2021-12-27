// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class FileSystemTokenStore : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Directory))
            {
                writer.WritePropertyName("directory");
                writer.WriteStringValue(Directory);
            }
            writer.WriteEndObject();
        }

        internal static FileSystemTokenStore DeserializeFileSystemTokenStore(JsonElement element)
        {
            Optional<string> directory = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("directory"))
                {
                    directory = property.Value.GetString();
                    continue;
                }
            }
            return new FileSystemTokenStore(directory.Value);
        }
    }
}
