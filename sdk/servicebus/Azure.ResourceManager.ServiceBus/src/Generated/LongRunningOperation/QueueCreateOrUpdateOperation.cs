// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Creates or updates a Service Bus queue. This operation is idempotent. </summary>
    public partial class QueueCreateOrUpdateOperation : Operation<ServiceBusQueue>
    {
        private readonly OperationOrResponseInternals<ServiceBusQueue> _operation;

        /// <summary> Initializes a new instance of QueueCreateOrUpdateOperation for mocking. </summary>
        protected QueueCreateOrUpdateOperation()
        {
        }

        internal QueueCreateOrUpdateOperation(ArmResource operationsBase, Response<ServiceBusQueueData> response)
        {
            _operation = new OperationOrResponseInternals<ServiceBusQueue>(Response.FromValue(new ServiceBusQueue(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ServiceBusQueue Value => _operation.Value;

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
        public override ValueTask<Response<ServiceBusQueue>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServiceBusQueue>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
