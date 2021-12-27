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
    /// <summary> A class representing collection of BackendAddressPool and their operations over its parent. </summary>
    public partial class BackendAddressPoolCollection : ArmCollection, IEnumerable<BackendAddressPool>, IAsyncEnumerable<BackendAddressPool>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly LoadBalancerBackendAddressPoolsRestOperations _loadBalancerBackendAddressPoolsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BackendAddressPoolCollection"/> class for mocking. </summary>
        protected BackendAddressPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of BackendAddressPoolCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal BackendAddressPoolCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _loadBalancerBackendAddressPoolsRestClient = new LoadBalancerBackendAddressPoolsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => LoadBalancer.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a load balancer backend address pool. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="parameters"> Parameters supplied to the create or update load balancer backend address pool operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual LoadBalancerBackendAddressPoolCreateOrUpdateOperation CreateOrUpdate(string backendAddressPoolName, BackendAddressPoolData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (backendAddressPoolName == null)
            {
                throw new ArgumentNullException(nameof(backendAddressPoolName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _loadBalancerBackendAddressPoolsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, parameters, cancellationToken);
                var operation = new LoadBalancerBackendAddressPoolCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _loadBalancerBackendAddressPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, parameters).Request, response);
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

        /// <summary> Creates or updates a load balancer backend address pool. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="parameters"> Parameters supplied to the create or update load balancer backend address pool operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<LoadBalancerBackendAddressPoolCreateOrUpdateOperation> CreateOrUpdateAsync(string backendAddressPoolName, BackendAddressPoolData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (backendAddressPoolName == null)
            {
                throw new ArgumentNullException(nameof(backendAddressPoolName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _loadBalancerBackendAddressPoolsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new LoadBalancerBackendAddressPoolCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _loadBalancerBackendAddressPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, parameters).Request, response);
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

        /// <summary> Gets load balancer backend address pool. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public virtual Response<BackendAddressPool> Get(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            if (backendAddressPoolName == null)
            {
                throw new ArgumentNullException(nameof(backendAddressPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _loadBalancerBackendAddressPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackendAddressPool(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets load balancer backend address pool. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public async virtual Task<Response<BackendAddressPool>> GetAsync(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            if (backendAddressPoolName == null)
            {
                throw new ArgumentNullException(nameof(backendAddressPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _loadBalancerBackendAddressPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new BackendAddressPool(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public virtual Response<BackendAddressPool> GetIfExists(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            if (backendAddressPoolName == null)
            {
                throw new ArgumentNullException(nameof(backendAddressPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _loadBalancerBackendAddressPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<BackendAddressPool>(null, response.GetRawResponse())
                    : Response.FromValue(new BackendAddressPool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public async virtual Task<Response<BackendAddressPool>> GetIfExistsAsync(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            if (backendAddressPoolName == null)
            {
                throw new ArgumentNullException(nameof(backendAddressPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _loadBalancerBackendAddressPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<BackendAddressPool>(null, response.GetRawResponse())
                    : Response.FromValue(new BackendAddressPool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            if (backendAddressPoolName == null)
            {
                throw new ArgumentNullException(nameof(backendAddressPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(backendAddressPoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            if (backendAddressPoolName == null)
            {
                throw new ArgumentNullException(nameof(backendAddressPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(backendAddressPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the load balancer backed address pools. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BackendAddressPool" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BackendAddressPool> GetAll(CancellationToken cancellationToken = default)
        {
            Page<BackendAddressPool> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _loadBalancerBackendAddressPoolsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BackendAddressPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BackendAddressPool> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _loadBalancerBackendAddressPoolsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BackendAddressPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the load balancer backed address pools. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BackendAddressPool" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BackendAddressPool> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<BackendAddressPool>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _loadBalancerBackendAddressPoolsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BackendAddressPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BackendAddressPool>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BackendAddressPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _loadBalancerBackendAddressPoolsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BackendAddressPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<BackendAddressPool> IEnumerable<BackendAddressPool>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BackendAddressPool> IAsyncEnumerable<BackendAddressPool>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, BackendAddressPool, BackendAddressPoolData> Construct() { }
    }
}
