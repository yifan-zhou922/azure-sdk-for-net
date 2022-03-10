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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ExpressRouteCircuit and their operations over its parent. </summary>
    public partial class ExpressRouteCircuitCollection : ArmCollection, IEnumerable<ExpressRouteCircuit>, IAsyncEnumerable<ExpressRouteCircuit>
    {
        private readonly ClientDiagnostics _expressRouteCircuitClientDiagnostics;
        private readonly ExpressRouteCircuitsRestOperations _expressRouteCircuitRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitCollection"/> class for mocking. </summary>
        protected ExpressRouteCircuitCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRouteCircuitCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteCircuitClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteCircuit.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ExpressRouteCircuit.ResourceType, out string expressRouteCircuitApiVersion);
            _expressRouteCircuitRestClient = new ExpressRouteCircuitsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, expressRouteCircuitApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}
        /// Operation Id: ExpressRouteCircuits_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="circuitName"> The name of the circuit. </param>
        /// <param name="parameters"> Parameters supplied to the create or update express route circuit operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRouteCircuit>> CreateOrUpdateAsync(WaitUntil waitUntil, string circuitName, ExpressRouteCircuitData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, circuitName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteCircuit>(new ExpressRouteCircuitOperationSource(Client), _expressRouteCircuitClientDiagnostics, Pipeline, _expressRouteCircuitRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, circuitName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}
        /// Operation Id: ExpressRouteCircuits_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="circuitName"> The name of the circuit. </param>
        /// <param name="parameters"> Parameters supplied to the create or update express route circuit operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteCircuit> CreateOrUpdate(WaitUntil waitUntil, string circuitName, ExpressRouteCircuitData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, circuitName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteCircuit>(new ExpressRouteCircuitOperationSource(Client), _expressRouteCircuitClientDiagnostics, Pipeline, _expressRouteCircuitRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, circuitName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}
        /// Operation Id: ExpressRouteCircuits_Get
        /// </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public virtual async Task<Response<ExpressRouteCircuit>> GetAsync(string circuitName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, circuitName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuit(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified express route circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}
        /// Operation Id: ExpressRouteCircuits_Get
        /// </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuit> Get(string circuitName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, circuitName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuit(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the express route circuits in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits
        /// Operation Id: ExpressRouteCircuits_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteCircuit" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteCircuit> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRouteCircuit>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCircuitRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuit(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRouteCircuit>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCircuitRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuit(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all the express route circuits in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits
        /// Operation Id: ExpressRouteCircuits_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteCircuit" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteCircuit> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExpressRouteCircuit> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCircuitRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuit(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRouteCircuit> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCircuitRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuit(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}
        /// Operation Id: ExpressRouteCircuits_Get
        /// </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string circuitName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(circuitName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}
        /// Operation Id: ExpressRouteCircuits_Get
        /// </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public virtual Response<bool> Exists(string circuitName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(circuitName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}
        /// Operation Id: ExpressRouteCircuits_Get
        /// </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public virtual async Task<Response<ExpressRouteCircuit>> GetIfExistsAsync(string circuitName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, circuitName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ExpressRouteCircuit>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuit(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}
        /// Operation Id: ExpressRouteCircuits_Get
        /// </summary>
        /// <param name="circuitName"> The name of express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="circuitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="circuitName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuit> GetIfExists(string circuitName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(circuitName, nameof(circuitName));

            using var scope = _expressRouteCircuitClientDiagnostics.CreateScope("ExpressRouteCircuitCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, circuitName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ExpressRouteCircuit>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuit(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteCircuit> IEnumerable<ExpressRouteCircuit>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteCircuit> IAsyncEnumerable<ExpressRouteCircuit>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
