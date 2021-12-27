// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class BackupRequest : IUtf8JsonSerializable
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
            if (Optional.IsDefined(BackupName))
            {
                writer.WritePropertyName("backupName");
                writer.WriteStringValue(BackupName);
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(StorageAccountUrl))
            {
                writer.WritePropertyName("storageAccountUrl");
                writer.WriteStringValue(StorageAccountUrl);
            }
            if (Optional.IsDefined(BackupSchedule))
            {
                writer.WritePropertyName("backupSchedule");
                writer.WriteObjectValue(BackupSchedule);
            }
            if (Optional.IsCollectionDefined(Databases))
            {
                writer.WritePropertyName("databases");
                writer.WriteStartArray();
                foreach (var item in Databases)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BackupRequest DeserializeBackupRequest(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> backupName = default;
            Optional<bool> enabled = default;
            Optional<string> storageAccountUrl = default;
            Optional<BackupSchedule> backupSchedule = default;
            Optional<IList<DatabaseBackupSetting>> databases = default;
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
                        if (property0.NameEquals("backupName"))
                        {
                            backupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountUrl"))
                        {
                            storageAccountUrl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("backupSchedule"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            backupSchedule = BackupSchedule.DeserializeBackupSchedule(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("databases"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DatabaseBackupSetting> array = new List<DatabaseBackupSetting>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DatabaseBackupSetting.DeserializeDatabaseBackupSetting(item));
                            }
                            databases = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BackupRequest(id, name, type, kind.Value, backupName.Value, Optional.ToNullable(enabled), storageAccountUrl.Value, backupSchedule.Value, Optional.ToList(databases));
        }
    }
}
