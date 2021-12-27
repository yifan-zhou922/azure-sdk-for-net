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
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Migrate an Azure Cosmos DB MongoDB database from manual throughput to autoscale. </summary>
    public partial class MongoDBResourceMigrateMongoDBDatabaseToAutoscaleOperation : Operation<ThroughputSettingsData>, IOperationSource<ThroughputSettingsData>
    {
        private readonly OperationInternals<ThroughputSettingsData> _operation;

        /// <summary> Initializes a new instance of MongoDBResourceMigrateMongoDBDatabaseToAutoscaleOperation for mocking. </summary>
        protected MongoDBResourceMigrateMongoDBDatabaseToAutoscaleOperation()
        {
        }

        internal MongoDBResourceMigrateMongoDBDatabaseToAutoscaleOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ThroughputSettingsData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "MongoDBResourceMigrateMongoDBDatabaseToAutoscaleOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ThroughputSettingsData Value => _operation.Value;

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
        public override ValueTask<Response<ThroughputSettingsData>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ThroughputSettingsData>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ThroughputSettingsData IOperationSource<ThroughputSettingsData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ThroughputSettingsData.DeserializeThroughputSettingsData(document.RootElement);
        }

        async ValueTask<ThroughputSettingsData> IOperationSource<ThroughputSettingsData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ThroughputSettingsData.DeserializeThroughputSettingsData(document.RootElement);
        }
    }
}
