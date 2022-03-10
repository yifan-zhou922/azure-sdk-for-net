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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ApplicationGatewayPrivateEndpointConnection and their operations over its parent. </summary>
    public partial class ApplicationGatewayPrivateEndpointConnectionCollection : ArmCollection, IEnumerable<ApplicationGatewayPrivateEndpointConnection>, IAsyncEnumerable<ApplicationGatewayPrivateEndpointConnection>
    {
        private readonly ClientDiagnostics _applicationGatewayPrivateEndpointConnectionClientDiagnostics;
        private readonly ApplicationGatewayPrivateEndpointConnectionsRestOperations _applicationGatewayPrivateEndpointConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayPrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected ApplicationGatewayPrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayPrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApplicationGatewayPrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _applicationGatewayPrivateEndpointConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ApplicationGatewayPrivateEndpointConnection.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ApplicationGatewayPrivateEndpointConnection.ResourceType, out string applicationGatewayPrivateEndpointConnectionApiVersion);
            _applicationGatewayPrivateEndpointConnectionRestClient = new ApplicationGatewayPrivateEndpointConnectionsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, applicationGatewayPrivateEndpointConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApplicationGateway.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApplicationGateway.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates the specified private endpoint connection on application gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/privateEndpointConnections/{connectionName}
        /// Operation Id: ApplicationGatewayPrivateEndpointConnections_Update
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the application gateway private endpoint connection. </param>
        /// <param name="parameters"> Parameters supplied to update application gateway private endpoint connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ApplicationGatewayPrivateEndpointConnection>> CreateOrUpdateAsync(WaitUntil waitUntil, string connectionName, ApplicationGatewayPrivateEndpointConnectionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _applicationGatewayPrivateEndpointConnectionRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ApplicationGatewayPrivateEndpointConnection>(new ApplicationGatewayPrivateEndpointConnectionOperationSource(Client), _applicationGatewayPrivateEndpointConnectionClientDiagnostics, Pipeline, _applicationGatewayPrivateEndpointConnectionRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Updates the specified private endpoint connection on application gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/privateEndpointConnections/{connectionName}
        /// Operation Id: ApplicationGatewayPrivateEndpointConnections_Update
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the application gateway private endpoint connection. </param>
        /// <param name="parameters"> Parameters supplied to update application gateway private endpoint connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ApplicationGatewayPrivateEndpointConnection> CreateOrUpdate(WaitUntil waitUntil, string connectionName, ApplicationGatewayPrivateEndpointConnectionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _applicationGatewayPrivateEndpointConnectionRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<ApplicationGatewayPrivateEndpointConnection>(new ApplicationGatewayPrivateEndpointConnectionOperationSource(Client), _applicationGatewayPrivateEndpointConnectionClientDiagnostics, Pipeline, _applicationGatewayPrivateEndpointConnectionRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified private endpoint connection on application gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/privateEndpointConnections/{connectionName}
        /// Operation Id: ApplicationGatewayPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the application gateway private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<ApplicationGatewayPrivateEndpointConnection>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _applicationGatewayPrivateEndpointConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayPrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified private endpoint connection on application gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/privateEndpointConnections/{connectionName}
        /// Operation Id: ApplicationGatewayPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the application gateway private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<ApplicationGatewayPrivateEndpointConnection> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _applicationGatewayPrivateEndpointConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayPrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all private endpoint connections on an application gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/privateEndpointConnections
        /// Operation Id: ApplicationGatewayPrivateEndpointConnections_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplicationGatewayPrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApplicationGatewayPrivateEndpointConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApplicationGatewayPrivateEndpointConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _applicationGatewayPrivateEndpointConnectionRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGatewayPrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApplicationGatewayPrivateEndpointConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _applicationGatewayPrivateEndpointConnectionRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGatewayPrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all private endpoint connections on an application gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/privateEndpointConnections
        /// Operation Id: ApplicationGatewayPrivateEndpointConnections_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplicationGatewayPrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApplicationGatewayPrivateEndpointConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ApplicationGatewayPrivateEndpointConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _applicationGatewayPrivateEndpointConnectionRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGatewayPrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApplicationGatewayPrivateEndpointConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _applicationGatewayPrivateEndpointConnectionRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGatewayPrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/privateEndpointConnections/{connectionName}
        /// Operation Id: ApplicationGatewayPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the application gateway private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnectionCollection.Exists");
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

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/privateEndpointConnections/{connectionName}
        /// Operation Id: ApplicationGatewayPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the application gateway private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnectionCollection.Exists");
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

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/privateEndpointConnections/{connectionName}
        /// Operation Id: ApplicationGatewayPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the application gateway private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<ApplicationGatewayPrivateEndpointConnection>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _applicationGatewayPrivateEndpointConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ApplicationGatewayPrivateEndpointConnection>(null, response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayPrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/privateEndpointConnections/{connectionName}
        /// Operation Id: ApplicationGatewayPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the application gateway private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<ApplicationGatewayPrivateEndpointConnection> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _applicationGatewayPrivateEndpointConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ApplicationGatewayPrivateEndpointConnection>(null, response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayPrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApplicationGatewayPrivateEndpointConnection> IEnumerable<ApplicationGatewayPrivateEndpointConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApplicationGatewayPrivateEndpointConnection> IAsyncEnumerable<ApplicationGatewayPrivateEndpointConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
