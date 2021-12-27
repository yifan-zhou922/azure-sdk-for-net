// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class PrivateEndpointConnectionProxyProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RemotePrivateEndpoint))
            {
                writer.WritePropertyName("remotePrivateEndpoint");
                writer.WriteObjectValue(RemotePrivateEndpoint);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status);
            }
            writer.WriteEndObject();
        }

        internal static PrivateEndpointConnectionProxyProperties DeserializePrivateEndpointConnectionProxyProperties(JsonElement element)
        {
            Optional<string> eTag = default;
            Optional<RemotePrivateEndpoint> remotePrivateEndpoint = default;
            Optional<PrivateEndpointConnectionProxyProvisioningState> provisioningState = default;
            Optional<string> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"))
                {
                    eTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remotePrivateEndpoint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    remotePrivateEndpoint = RemotePrivateEndpoint.DeserializeRemotePrivateEndpoint(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new PrivateEndpointConnectionProxyProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
            }
            return new PrivateEndpointConnectionProxyProperties(eTag.Value, remotePrivateEndpoint.Value, Optional.ToNullable(provisioningState), status.Value);
        }
    }
}
