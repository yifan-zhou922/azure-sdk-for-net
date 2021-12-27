// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary> A class representing collection of OrderResource and their operations over its parent. </summary>
    public partial class OrderResourceCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly EdgeOrderManagementRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="OrderResourceCollection"/> class for mocking. </summary>
        protected OrderResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of OrderResourceCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal OrderResourceCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new EdgeOrderManagementRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: GetOrderByName
        /// <summary> Gets an order. </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public virtual Response<OrderResource> Get(string location, string orderName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (orderName == null)
            {
                throw new ArgumentNullException(nameof(orderName));
            }

            using var scope = _clientDiagnostics.CreateScope("OrderResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _restClient.GetOrderByName(Id.SubscriptionId, Id.ResourceGroupName, location, orderName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OrderResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: GetOrderByName
        /// <summary> Gets an order. </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public async virtual Task<Response<OrderResource>> GetAsync(string location, string orderName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (orderName == null)
            {
                throw new ArgumentNullException(nameof(orderName));
            }

            using var scope = _clientDiagnostics.CreateScope("OrderResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetOrderByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, location, orderName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new OrderResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public virtual Response<OrderResource> GetIfExists(string location, string orderName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (orderName == null)
            {
                throw new ArgumentNullException(nameof(orderName));
            }

            using var scope = _clientDiagnostics.CreateScope("OrderResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restClient.GetOrderByName(Id.SubscriptionId, Id.ResourceGroupName, location, orderName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<OrderResource>(null, response.GetRawResponse())
                    : Response.FromValue(new OrderResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public async virtual Task<Response<OrderResource>> GetIfExistsAsync(string location, string orderName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (orderName == null)
            {
                throw new ArgumentNullException(nameof(orderName));
            }

            using var scope = _clientDiagnostics.CreateScope("OrderResourceCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _restClient.GetOrderByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, location, orderName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<OrderResource>(null, response.GetRawResponse())
                    : Response.FromValue(new OrderResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public virtual Response<bool> Exists(string location, string orderName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (orderName == null)
            {
                throw new ArgumentNullException(nameof(orderName));
            }

            using var scope = _clientDiagnostics.CreateScope("OrderResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(location, orderName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string location, string orderName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (orderName == null)
            {
                throw new ArgumentNullException(nameof(orderName));
            }

            using var scope = _clientDiagnostics.CreateScope("OrderResourceCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(location, orderName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="OrderResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OrderResourceCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(OrderResource.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="OrderResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OrderResourceCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(OrderResource.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, OrderResource, OrderResourceData> Construct() { }
    }
}
