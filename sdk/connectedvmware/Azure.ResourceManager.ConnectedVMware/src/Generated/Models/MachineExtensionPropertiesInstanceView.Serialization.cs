// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMware.Models
{
    public partial class MachineExtensionPropertiesInstanceView : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteObjectValue(Status);
            }
            writer.WriteEndObject();
        }

        internal static MachineExtensionPropertiesInstanceView DeserializeMachineExtensionPropertiesInstanceView(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> typeHandlerVersion = default;
            Optional<MachineExtensionInstanceViewStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeHandlerVersion"))
                {
                    typeHandlerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = MachineExtensionInstanceViewStatus.DeserializeMachineExtensionInstanceViewStatus(property.Value);
                    continue;
                }
            }
            return new MachineExtensionPropertiesInstanceView(name.Value, type.Value, typeHandlerVersion.Value, status.Value);
        }
    }
}
