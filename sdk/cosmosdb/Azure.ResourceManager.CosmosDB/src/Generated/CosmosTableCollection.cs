// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of CosmosTable and their operations over its parent. </summary>
    public partial class CosmosTableCollection : ArmCollection, IEnumerable<CosmosTable>, IAsyncEnumerable<CosmosTable>
    {
        private readonly ClientDiagnostics _cosmosTableTableResourcesClientDiagnostics;
        private readonly TableResourcesRestOperations _cosmosTableTableResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosTableCollection"/> class for mocking. </summary>
        protected CosmosTableCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosTableCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosTableCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosTableTableResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosTable.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(CosmosTable.ResourceType, out string cosmosTableTableResourcesApiVersion);
            _cosmosTableTableResourcesRestClient = new TableResourcesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, cosmosTableTableResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DatabaseAccount.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DatabaseAccount.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an Azure Cosmos DB Table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}
        /// Operation Id: TableResources_CreateUpdateTable
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="createUpdateTableParameters"> The parameters to provide for the current Table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> or <paramref name="createUpdateTableParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosTable>> CreateOrUpdateAsync(WaitUntil waitUntil, string tableName, TableCreateUpdateData createUpdateTableParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));
            Argument.AssertNotNull(createUpdateTableParameters, nameof(createUpdateTableParameters));

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosTableTableResourcesRestClient.CreateUpdateTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, createUpdateTableParameters, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosTable>(new CosmosTableOperationSource(Client), _cosmosTableTableResourcesClientDiagnostics, Pipeline, _cosmosTableTableResourcesRestClient.CreateCreateUpdateTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, createUpdateTableParameters).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update an Azure Cosmos DB Table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}
        /// Operation Id: TableResources_CreateUpdateTable
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="createUpdateTableParameters"> The parameters to provide for the current Table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> or <paramref name="createUpdateTableParameters"/> is null. </exception>
        public virtual ArmOperation<CosmosTable> CreateOrUpdate(WaitUntil waitUntil, string tableName, TableCreateUpdateData createUpdateTableParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));
            Argument.AssertNotNull(createUpdateTableParameters, nameof(createUpdateTableParameters));

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosTableTableResourcesRestClient.CreateUpdateTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, createUpdateTableParameters, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosTable>(new CosmosTableOperationSource(Client), _cosmosTableTableResourcesClientDiagnostics, Pipeline, _cosmosTableTableResourcesRestClient.CreateCreateUpdateTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, createUpdateTableParameters).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Tables under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}
        /// Operation Id: TableResources_GetTable
        /// </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<CosmosTable>> GetAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosTableTableResourcesRestClient.GetTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Tables under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}
        /// Operation Id: TableResources_GetTable
        /// </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<CosmosTable> Get(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosTableTableResourcesRestClient.GetTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Tables under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables
        /// Operation Id: TableResources_ListTables
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosTable> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CosmosTable>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cosmosTableTableResourcesRestClient.ListTablesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CosmosTable(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists the Tables under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables
        /// Operation Id: TableResources_ListTables
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosTable> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CosmosTable> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cosmosTableTableResourcesRestClient.ListTables(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CosmosTable(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}
        /// Operation Id: TableResources_GetTable
        /// </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}
        /// Operation Id: TableResources_GetTable
        /// </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<bool> Exists(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(tableName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}
        /// Operation Id: TableResources_GetTable
        /// </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<CosmosTable>> GetIfExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosTableTableResourcesRestClient.GetTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CosmosTable>(null, response.GetRawResponse());
                return Response.FromValue(new CosmosTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/tables/{tableName}
        /// Operation Id: TableResources_GetTable
        /// </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<CosmosTable> GetIfExists(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosTableTableResourcesRestClient.GetTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CosmosTable>(null, response.GetRawResponse());
                return Response.FromValue(new CosmosTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosTable> IEnumerable<CosmosTable>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosTable> IAsyncEnumerable<CosmosTable>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
