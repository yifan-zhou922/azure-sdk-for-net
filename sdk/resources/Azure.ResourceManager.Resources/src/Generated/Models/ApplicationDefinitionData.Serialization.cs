// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    public partial class ApplicationDefinitionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedBy))
            {
                writer.WritePropertyName("managedBy");
                writer.WriteStringValue(ManagedBy);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("lockLevel");
            writer.WriteStringValue(LockLevel.ToSerialString());
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled");
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsCollectionDefined(Authorizations))
            {
                writer.WritePropertyName("authorizations");
                writer.WriteStartArray();
                foreach (var item in Authorizations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Artifacts))
            {
                writer.WritePropertyName("artifacts");
                writer.WriteStartArray();
                foreach (var item in Artifacts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(PackageFileUri))
            {
                writer.WritePropertyName("packageFileUri");
                writer.WriteStringValue(PackageFileUri);
            }
            if (Optional.IsDefined(MainTemplate))
            {
                writer.WritePropertyName("mainTemplate");
                writer.WriteObjectValue(MainTemplate);
            }
            if (Optional.IsDefined(CreateUiDefinition))
            {
                writer.WritePropertyName("createUiDefinition");
                writer.WriteObjectValue(CreateUiDefinition);
            }
            if (Optional.IsDefined(NotificationPolicy))
            {
                writer.WritePropertyName("notificationPolicy");
                writer.WriteObjectValue(NotificationPolicy);
            }
            if (Optional.IsDefined(LockingPolicy))
            {
                writer.WritePropertyName("lockingPolicy");
                writer.WriteObjectValue(LockingPolicy);
            }
            if (Optional.IsDefined(DeploymentPolicy))
            {
                writer.WritePropertyName("deploymentPolicy");
                writer.WriteObjectValue(DeploymentPolicy);
            }
            if (Optional.IsDefined(ManagementPolicy))
            {
                writer.WritePropertyName("managementPolicy");
                writer.WriteObjectValue(ManagementPolicy);
            }
            if (Optional.IsCollectionDefined(Policies))
            {
                writer.WritePropertyName("policies");
                writer.WriteStartArray();
                foreach (var item in Policies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationDefinitionData DeserializeApplicationDefinitionData(JsonElement element)
        {
            Optional<string> managedBy = default;
            Optional<SkuAutoGenerated> sku = default;
            IDictionary<string, string> tags = default;
            Location location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            ApplicationLockLevel lockLevel = default;
            Optional<string> displayName = default;
            Optional<bool> isEnabled = default;
            Optional<IList<ApplicationAuthorization>> authorizations = default;
            Optional<IList<ApplicationDefinitionArtifact>> artifacts = default;
            Optional<string> description = default;
            Optional<string> packageFileUri = default;
            Optional<object> mainTemplate = default;
            Optional<object> createUiDefinition = default;
            Optional<ApplicationNotificationPolicy> notificationPolicy = default;
            Optional<ApplicationPackageLockingPolicyDefinition> lockingPolicy = default;
            Optional<ApplicationDeploymentPolicy> deploymentPolicy = default;
            Optional<ApplicationManagementPolicy> managementPolicy = default;
            Optional<IList<ApplicationPolicy>> policies = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = SkuAutoGenerated.DeserializeSkuAutoGenerated(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
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
                        if (property0.NameEquals("lockLevel"))
                        {
                            lockLevel = property0.Value.GetString().ToApplicationLockLevel();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("authorizations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationAuthorization> array = new List<ApplicationAuthorization>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationAuthorization.DeserializeApplicationAuthorization(item));
                            }
                            authorizations = array;
                            continue;
                        }
                        if (property0.NameEquals("artifacts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationDefinitionArtifact> array = new List<ApplicationDefinitionArtifact>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationDefinitionArtifact.DeserializeApplicationDefinitionArtifact(item));
                            }
                            artifacts = array;
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageFileUri"))
                        {
                            packageFileUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("mainTemplate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            mainTemplate = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("createUiDefinition"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createUiDefinition = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("notificationPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            notificationPolicy = ApplicationNotificationPolicy.DeserializeApplicationNotificationPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("lockingPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lockingPolicy = ApplicationPackageLockingPolicyDefinition.DeserializeApplicationPackageLockingPolicyDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("deploymentPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deploymentPolicy = ApplicationDeploymentPolicy.DeserializeApplicationDeploymentPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("managementPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            managementPolicy = ApplicationManagementPolicy.DeserializeApplicationManagementPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("policies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationPolicy> array = new List<ApplicationPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationPolicy.DeserializeApplicationPolicy(item));
                            }
                            policies = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationDefinitionData(id, name, type, tags, location, managedBy.Value, sku.Value, lockLevel, displayName.Value, Optional.ToNullable(isEnabled), Optional.ToList(authorizations), Optional.ToList(artifacts), description.Value, packageFileUri.Value, mainTemplate.Value, createUiDefinition.Value, notificationPolicy.Value, lockingPolicy.Value, deploymentPolicy.Value, managementPolicy.Value, Optional.ToList(policies));
        }
    }
}
