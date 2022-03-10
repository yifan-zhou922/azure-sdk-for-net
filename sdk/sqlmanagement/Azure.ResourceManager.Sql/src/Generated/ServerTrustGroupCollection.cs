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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServerTrustGroup and their operations over its parent. </summary>
    public partial class ServerTrustGroupCollection : ArmCollection, IEnumerable<ServerTrustGroup>, IAsyncEnumerable<ServerTrustGroup>
    {
        private readonly ClientDiagnostics _serverTrustGroupClientDiagnostics;
        private readonly ServerTrustGroupsRestOperations _serverTrustGroupRestClient;
        private readonly string _locationName;

        /// <summary> Initializes a new instance of the <see cref="ServerTrustGroupCollection"/> class for mocking. </summary>
        protected ServerTrustGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerTrustGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        internal ServerTrustGroupCollection(ArmClient client, ResourceIdentifier id, string locationName) : base(client, id)
        {
            _locationName = locationName;
            _serverTrustGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerTrustGroup.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ServerTrustGroup.ResourceType, out string serverTrustGroupApiVersion);
            _serverTrustGroupRestClient = new ServerTrustGroupsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverTrustGroupApiVersion);
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
        /// Creates or updates a server trust group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// Operation Id: ServerTrustGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="parameters"> The server trust group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ServerTrustGroup>> CreateOrUpdateAsync(WaitUntil waitUntil, string serverTrustGroupName, ServerTrustGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _serverTrustGroupClientDiagnostics.CreateScope("ServerTrustGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverTrustGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ServerTrustGroup>(new ServerTrustGroupOperationSource(Client), _serverTrustGroupClientDiagnostics, Pipeline, _serverTrustGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a server trust group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// Operation Id: ServerTrustGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="parameters"> The server trust group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ServerTrustGroup> CreateOrUpdate(WaitUntil waitUntil, string serverTrustGroupName, ServerTrustGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _serverTrustGroupClientDiagnostics.CreateScope("ServerTrustGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverTrustGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, parameters, cancellationToken);
                var operation = new SqlArmOperation<ServerTrustGroup>(new ServerTrustGroupOperationSource(Client), _serverTrustGroupClientDiagnostics, Pipeline, _serverTrustGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a server trust group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// Operation Id: ServerTrustGroups_Get
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual async Task<Response<ServerTrustGroup>> GetAsync(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _serverTrustGroupClientDiagnostics.CreateScope("ServerTrustGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverTrustGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerTrustGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server trust group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// Operation Id: ServerTrustGroups_Get
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual Response<ServerTrustGroup> Get(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _serverTrustGroupClientDiagnostics.CreateScope("ServerTrustGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _serverTrustGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerTrustGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a server trust group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups
        /// Operation Id: ServerTrustGroups_ListByLocation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerTrustGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerTrustGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerTrustGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverTrustGroupClientDiagnostics.CreateScope("ServerTrustGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverTrustGroupRestClient.ListByLocationAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerTrustGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerTrustGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverTrustGroupClientDiagnostics.CreateScope("ServerTrustGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverTrustGroupRestClient.ListByLocationNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerTrustGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists a server trust group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups
        /// Operation Id: ServerTrustGroups_ListByLocation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerTrustGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerTrustGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerTrustGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverTrustGroupClientDiagnostics.CreateScope("ServerTrustGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverTrustGroupRestClient.ListByLocation(Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerTrustGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerTrustGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverTrustGroupClientDiagnostics.CreateScope("ServerTrustGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverTrustGroupRestClient.ListByLocationNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerTrustGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// Operation Id: ServerTrustGroups_Get
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _serverTrustGroupClientDiagnostics.CreateScope("ServerTrustGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(serverTrustGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// Operation Id: ServerTrustGroups_Get
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _serverTrustGroupClientDiagnostics.CreateScope("ServerTrustGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(serverTrustGroupName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// Operation Id: ServerTrustGroups_Get
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual async Task<Response<ServerTrustGroup>> GetIfExistsAsync(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _serverTrustGroupClientDiagnostics.CreateScope("ServerTrustGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverTrustGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerTrustGroup>(null, response.GetRawResponse());
                return Response.FromValue(new ServerTrustGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// Operation Id: ServerTrustGroups_Get
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual Response<ServerTrustGroup> GetIfExists(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _serverTrustGroupClientDiagnostics.CreateScope("ServerTrustGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverTrustGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerTrustGroup>(null, response.GetRawResponse());
                return Response.FromValue(new ServerTrustGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerTrustGroup> IEnumerable<ServerTrustGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerTrustGroup> IAsyncEnumerable<ServerTrustGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
