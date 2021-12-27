// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Stops an existing running CDN endpoint. </summary>
    public partial class CdnEndpointStopOperation : Operation<CdnEndpointData>, IOperationSource<CdnEndpointData>
    {
        private readonly OperationInternals<CdnEndpointData> _operation;

        /// <summary> Initializes a new instance of CdnEndpointStopOperation for mocking. </summary>
        protected CdnEndpointStopOperation()
        {
        }

        internal CdnEndpointStopOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<CdnEndpointData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "CdnEndpointStopOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override CdnEndpointData Value => _operation.Value;

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
        public override ValueTask<Response<CdnEndpointData>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<CdnEndpointData>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        CdnEndpointData IOperationSource<CdnEndpointData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return CdnEndpointData.DeserializeCdnEndpointData(document.RootElement);
        }

        async ValueTask<CdnEndpointData> IOperationSource<CdnEndpointData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return CdnEndpointData.DeserializeCdnEndpointData(document.RootElement);
        }
    }
}
