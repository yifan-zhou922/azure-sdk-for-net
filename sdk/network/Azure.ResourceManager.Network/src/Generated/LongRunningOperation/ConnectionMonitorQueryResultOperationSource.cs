// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal class ConnectionMonitorQueryResultOperationSource : IOperationSource<ConnectionMonitorQueryResult>
    {
        ConnectionMonitorQueryResult IOperationSource<ConnectionMonitorQueryResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ConnectionMonitorQueryResult.DeserializeConnectionMonitorQueryResult(document.RootElement);
        }

        async ValueTask<ConnectionMonitorQueryResult> IOperationSource<ConnectionMonitorQueryResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ConnectionMonitorQueryResult.DeserializeConnectionMonitorQueryResult(document.RootElement);
        }
    }
}
