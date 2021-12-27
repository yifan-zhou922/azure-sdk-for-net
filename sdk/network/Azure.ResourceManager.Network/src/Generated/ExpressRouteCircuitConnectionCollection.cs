// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ExpressRouteCircuitConnection and their operations over its parent. </summary>
    public partial class ExpressRouteCircuitConnectionCollection : ArmCollection, IEnumerable<ExpressRouteCircuitConnection>, IAsyncEnumerable<ExpressRouteCircuitConnection>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ExpressRouteCircuitConnectionsRestOperations _expressRouteCircuitConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitConnectionCollection"/> class for mocking. </summary>
        protected ExpressRouteCircuitConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteCircuitConnectionCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ExpressRouteCircuitConnectionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _expressRouteCircuitConnectionsRestClient = new ExpressRouteCircuitConnectionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ExpressRouteCircuitPeering.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a Express Route Circuit Connection in the specified express route circuits. </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="expressRouteCircuitConnectionParameters"> Parameters supplied to the create or update express route circuit connection operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="expressRouteCircuitConnectionParameters"/> is null. </exception>
        public virtual ExpressRouteCircuitConnectionCreateOrUpdateOperation CreateOrUpdate(string connectionName, ExpressRouteCircuitConnectionData expressRouteCircuitConnectionParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (expressRouteCircuitConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(expressRouteCircuitConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitConnectionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, expressRouteCircuitConnectionParameters, cancellationToken);
                var operation = new ExpressRouteCircuitConnectionCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _expressRouteCircuitConnectionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, expressRouteCircuitConnectionParameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a Express Route Circuit Connection in the specified express route circuits. </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="expressRouteCircuitConnectionParameters"> Parameters supplied to the create or update express route circuit connection operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="expressRouteCircuitConnectionParameters"/> is null. </exception>
        public async virtual Task<ExpressRouteCircuitConnectionCreateOrUpdateOperation> CreateOrUpdateAsync(string connectionName, ExpressRouteCircuitConnectionData expressRouteCircuitConnectionParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (expressRouteCircuitConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(expressRouteCircuitConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitConnectionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, expressRouteCircuitConnectionParameters, cancellationToken).ConfigureAwait(false);
                var operation = new ExpressRouteCircuitConnectionCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _expressRouteCircuitConnectionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, expressRouteCircuitConnectionParameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Express Route Circuit Connection from the specified express route circuit. </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuitConnection> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Express Route Circuit Connection from the specified express route circuit. </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteCircuitConnection>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteCircuitConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<ExpressRouteCircuitConnection> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ExpressRouteCircuitConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new ExpressRouteCircuitConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteCircuitConnection>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ExpressRouteCircuitConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new ExpressRouteCircuitConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(connectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all global reach connections associated with a private peering in an express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteCircuitConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteCircuitConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExpressRouteCircuitConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCircuitConnectionsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRouteCircuitConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCircuitConnectionsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all global reach connections associated with a private peering in an express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteCircuitConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteCircuitConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRouteCircuitConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCircuitConnectionsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRouteCircuitConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCircuitConnectionsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCircuitConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ExpressRouteCircuitConnection> IEnumerable<ExpressRouteCircuitConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteCircuitConnection> IAsyncEnumerable<ExpressRouteCircuitConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ExpressRouteCircuitConnection, ExpressRouteCircuitConnectionData> Construct() { }
    }
}
