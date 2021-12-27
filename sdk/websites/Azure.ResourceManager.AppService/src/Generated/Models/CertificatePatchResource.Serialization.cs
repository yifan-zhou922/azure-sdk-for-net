// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class CertificatePatchResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteStringValue(Password);
            }
            if (Optional.IsCollectionDefined(HostNames))
            {
                writer.WritePropertyName("hostNames");
                writer.WriteStartArray();
                foreach (var item in HostNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PfxBlob))
            {
                writer.WritePropertyName("pfxBlob");
                writer.WriteBase64StringValue(PfxBlob, "D");
            }
            if (Optional.IsDefined(KeyVaultId))
            {
                writer.WritePropertyName("keyVaultId");
                writer.WriteStringValue(KeyVaultId);
            }
            if (Optional.IsDefined(KeyVaultSecretName))
            {
                writer.WritePropertyName("keyVaultSecretName");
                writer.WriteStringValue(KeyVaultSecretName);
            }
            if (Optional.IsDefined(ServerFarmId))
            {
                writer.WritePropertyName("serverFarmId");
                writer.WriteStringValue(ServerFarmId);
            }
            if (Optional.IsDefined(CanonicalName))
            {
                writer.WritePropertyName("canonicalName");
                writer.WriteStringValue(CanonicalName);
            }
            if (Optional.IsDefined(DomainValidationMethod))
            {
                writer.WritePropertyName("domainValidationMethod");
                writer.WriteStringValue(DomainValidationMethod);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CertificatePatchResource DeserializeCertificatePatchResource(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> password = default;
            Optional<string> friendlyName = default;
            Optional<string> subjectName = default;
            Optional<IList<string>> hostNames = default;
            Optional<byte[]> pfxBlob = default;
            Optional<string> siteName = default;
            Optional<string> selfLink = default;
            Optional<string> issuer = default;
            Optional<DateTimeOffset> issueDate = default;
            Optional<DateTimeOffset> expirationDate = default;
            Optional<string> thumbprint = default;
            Optional<bool> valid = default;
            Optional<byte[]> cerBlob = default;
            Optional<string> publicKeyHash = default;
            Optional<HostingEnvironmentProfile> hostingEnvironmentProfile = default;
            Optional<string> keyVaultId = default;
            Optional<string> keyVaultSecretName = default;
            Optional<KeyVaultSecretStatus> keyVaultSecretStatus = default;
            Optional<string> serverFarmId = default;
            Optional<string> canonicalName = default;
            Optional<string> domainValidationMethod = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("password"))
                        {
                            password = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subjectName"))
                        {
                            subjectName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostNames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            hostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("pfxBlob"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            pfxBlob = property0.Value.GetBytesFromBase64("D");
                            continue;
                        }
                        if (property0.NameEquals("siteName"))
                        {
                            siteName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("selfLink"))
                        {
                            selfLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("issuer"))
                        {
                            issuer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("issueDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            issueDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expirationDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            expirationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"))
                        {
                            thumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("valid"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            valid = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("cerBlob"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            cerBlob = property0.Value.GetBytesFromBase64("D");
                            continue;
                        }
                        if (property0.NameEquals("publicKeyHash"))
                        {
                            publicKeyHash = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostingEnvironmentProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hostingEnvironmentProfile = HostingEnvironmentProfile.DeserializeHostingEnvironmentProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("keyVaultId"))
                        {
                            keyVaultId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultSecretName"))
                        {
                            keyVaultSecretName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultSecretStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            keyVaultSecretStatus = property0.Value.GetString().ToKeyVaultSecretStatus();
                            continue;
                        }
                        if (property0.NameEquals("serverFarmId"))
                        {
                            serverFarmId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("canonicalName"))
                        {
                            canonicalName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainValidationMethod"))
                        {
                            domainValidationMethod = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CertificatePatchResource(id, name, type, kind.Value, password.Value, friendlyName.Value, subjectName.Value, Optional.ToList(hostNames), pfxBlob.Value, siteName.Value, selfLink.Value, issuer.Value, Optional.ToNullable(issueDate), Optional.ToNullable(expirationDate), thumbprint.Value, Optional.ToNullable(valid), cerBlob.Value, publicKeyHash.Value, hostingEnvironmentProfile.Value, keyVaultId.Value, keyVaultSecretName.Value, Optional.ToNullable(keyVaultSecretStatus), serverFarmId.Value, canonicalName.Value, domainValidationMethod.Value);
        }
    }
}
