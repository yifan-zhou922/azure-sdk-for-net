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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of NetworkSecurityGroup and their operations over its parent. </summary>
    public partial class NetworkSecurityGroupCollection : ArmCollection, IEnumerable<NetworkSecurityGroup>, IAsyncEnumerable<NetworkSecurityGroup>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly NetworkSecurityGroupsRestOperations _networkSecurityGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityGroupCollection"/> class for mocking. </summary>
        protected NetworkSecurityGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of NetworkSecurityGroupCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal NetworkSecurityGroupCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _networkSecurityGroupsRestClient = new NetworkSecurityGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a network security group in the specified resource group. </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update network security group operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual NetworkSecurityGroupCreateOrUpdateOperation CreateOrUpdate(string networkSecurityGroupName, NetworkSecurityGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkSecurityGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkSecurityGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, parameters, cancellationToken);
                var operation = new NetworkSecurityGroupCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _networkSecurityGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, parameters).Request, response);
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

        /// <summary> Creates or updates a network security group in the specified resource group. </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update network security group operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<NetworkSecurityGroupCreateOrUpdateOperation> CreateOrUpdateAsync(string networkSecurityGroupName, NetworkSecurityGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkSecurityGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkSecurityGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkSecurityGroupCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _networkSecurityGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, parameters).Request, response);
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

        /// <summary> Gets the specified network security group. </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public virtual Response<NetworkSecurityGroup> Get(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkSecurityGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _networkSecurityGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified network security group. </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public async virtual Task<Response<NetworkSecurityGroup>> GetAsync(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkSecurityGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkSecurityGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NetworkSecurityGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public virtual Response<NetworkSecurityGroup> GetIfExists(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkSecurityGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<NetworkSecurityGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new NetworkSecurityGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public async virtual Task<Response<NetworkSecurityGroup>> GetIfExistsAsync(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _networkSecurityGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<NetworkSecurityGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new NetworkSecurityGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkSecurityGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(networkSecurityGroupName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkSecurityGroupCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(networkSecurityGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all network security groups in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkSecurityGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkSecurityGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NetworkSecurityGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkSecurityGroupsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkSecurityGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkSecurityGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkSecurityGroupsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkSecurityGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all network security groups in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkSecurityGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkSecurityGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkSecurityGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkSecurityGroupsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkSecurityGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkSecurityGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkSecurityGroupsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkSecurityGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="NetworkSecurityGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(NetworkSecurityGroup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="NetworkSecurityGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(NetworkSecurityGroup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkSecurityGroup> IEnumerable<NetworkSecurityGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkSecurityGroup> IAsyncEnumerable<NetworkSecurityGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, NetworkSecurityGroup, NetworkSecurityGroupData> Construct() { }
    }
}
