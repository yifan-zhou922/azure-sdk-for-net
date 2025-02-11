// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.NetApp
{
    internal class NetAppBackupVaultOperationSource : IOperationSource<NetAppBackupVaultResource>
    {
        private readonly ArmClient _client;

        internal NetAppBackupVaultOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetAppBackupVaultResource IOperationSource<NetAppBackupVaultResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetAppBackupVaultData.DeserializeNetAppBackupVaultData(document.RootElement);
            return new NetAppBackupVaultResource(_client, data);
        }

        async ValueTask<NetAppBackupVaultResource> IOperationSource<NetAppBackupVaultResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetAppBackupVaultData.DeserializeNetAppBackupVaultData(document.RootElement);
            return new NetAppBackupVaultResource(_client, data);
        }
    }
}
