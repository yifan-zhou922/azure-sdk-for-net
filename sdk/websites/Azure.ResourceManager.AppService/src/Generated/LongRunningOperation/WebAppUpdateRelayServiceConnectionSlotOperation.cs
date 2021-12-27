// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Creates a new hybrid connection configuration (PUT), or updates an existing one (PATCH). </summary>
    public partial class WebAppUpdateRelayServiceConnectionSlotOperation : Operation<SiteSlotHybridconnection>
    {
        private readonly OperationOrResponseInternals<SiteSlotHybridconnection> _operation;

        /// <summary> Initializes a new instance of WebAppUpdateRelayServiceConnectionSlotOperation for mocking. </summary>
        protected WebAppUpdateRelayServiceConnectionSlotOperation()
        {
        }

        internal WebAppUpdateRelayServiceConnectionSlotOperation(ArmResource operationsBase, Response<RelayServiceConnectionEntityData> response)
        {
            _operation = new OperationOrResponseInternals<SiteSlotHybridconnection>(Response.FromValue(new SiteSlotHybridconnection(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SiteSlotHybridconnection Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteSlotHybridconnection>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteSlotHybridconnection>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
