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
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Invoke the MSDeploy web app extension. </summary>
    public partial class WebAppCreateMSDeployOperationSlotOperation : Operation<SiteSlotExtension>, IOperationSource<SiteSlotExtension>
    {
        private readonly OperationInternals<SiteSlotExtension> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of WebAppCreateMSDeployOperationSlotOperation for mocking. </summary>
        protected WebAppCreateMSDeployOperationSlotOperation()
        {
        }

        internal WebAppCreateMSDeployOperationSlotOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<SiteSlotExtension>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "WebAppCreateMSDeployOperationSlotOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SiteSlotExtension Value => _operation.Value;

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
        public override ValueTask<Response<SiteSlotExtension>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteSlotExtension>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SiteSlotExtension IOperationSource<SiteSlotExtension>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new SiteSlotExtension(_operationBase, MSDeployStatusData.DeserializeMSDeployStatusData(document.RootElement));
        }

        async ValueTask<SiteSlotExtension> IOperationSource<SiteSlotExtension>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new SiteSlotExtension(_operationBase, MSDeployStatusData.DeserializeMSDeployStatusData(document.RootElement));
        }
    }
}
