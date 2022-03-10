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

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing collection of EventHubCluster and their operations over its parent. </summary>
    public partial class EventHubClusterCollection : ArmCollection, IEnumerable<EventHubCluster>, IAsyncEnumerable<EventHubCluster>
    {
        private readonly ClientDiagnostics _eventHubClusterClientDiagnostics;
        private readonly EventHubClustersRestOperations _eventHubClusterRestClient;
        private readonly ClientDiagnostics _eventHubClusterClustersClientDiagnostics;
        private readonly ClustersRestOperations _eventHubClusterClustersRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventHubClusterCollection"/> class for mocking. </summary>
        protected EventHubClusterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubClusterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventHubClusterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubClusterClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubCluster.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(EventHubCluster.ResourceType, out string eventHubClusterApiVersion);
            _eventHubClusterRestClient = new EventHubClustersRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, eventHubClusterApiVersion);
            _eventHubClusterClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubCluster.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(EventHubCluster.ResourceType, out string eventHubClusterClustersApiVersion);
            _eventHubClusterClustersRestClient = new ClustersRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, eventHubClusterClustersApiVersion);
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
        /// Creates or updates an instance of an Event Hubs Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}
        /// Operation Id: EventHubClusters_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="parameters"> Parameters for creating a eventhub cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<EventHubCluster>> CreateOrUpdateAsync(bool waitForCompletion, string clusterName, EventHubClusterData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _eventHubClusterClientDiagnostics.CreateScope("EventHubClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventHubClusterRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubsArmOperation<EventHubCluster>(new EventHubClusterOperationSource(Client), _eventHubClusterClientDiagnostics, Pipeline, _eventHubClusterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterName, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Creates or updates an instance of an Event Hubs Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}
        /// Operation Id: EventHubClusters_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="parameters"> Parameters for creating a eventhub cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<EventHubCluster> CreateOrUpdate(bool waitForCompletion, string clusterName, EventHubClusterData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _eventHubClusterClientDiagnostics.CreateScope("EventHubClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventHubClusterRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, clusterName, parameters, cancellationToken);
                var operation = new EventHubsArmOperation<EventHubCluster>(new EventHubClusterOperationSource(Client), _eventHubClusterClientDiagnostics, Pipeline, _eventHubClusterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterName, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Gets the resource description of the specified Event Hubs Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual async Task<Response<EventHubCluster>> GetAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _eventHubClusterClustersClientDiagnostics.CreateScope("EventHubClusterCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventHubClusterClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubCluster(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the resource description of the specified Event Hubs Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<EventHubCluster> Get(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _eventHubClusterClustersClientDiagnostics.CreateScope("EventHubClusterCollection.Get");
            scope.Start();
            try
            {
                var response = _eventHubClusterClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubCluster(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the available Event Hubs Clusters within an ARM resource group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters
        /// Operation Id: Clusters_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubCluster" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubCluster> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<EventHubCluster>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _eventHubClusterClustersClientDiagnostics.CreateScope("EventHubClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _eventHubClusterClustersRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubCluster(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EventHubCluster>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _eventHubClusterClustersClientDiagnostics.CreateScope("EventHubClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _eventHubClusterClustersRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubCluster(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists the available Event Hubs Clusters within an ARM resource group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters
        /// Operation Id: Clusters_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubCluster" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubCluster> GetAll(CancellationToken cancellationToken = default)
        {
            Page<EventHubCluster> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _eventHubClusterClustersClientDiagnostics.CreateScope("EventHubClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _eventHubClusterClustersRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubCluster(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EventHubCluster> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _eventHubClusterClustersClientDiagnostics.CreateScope("EventHubClusterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _eventHubClusterClustersRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubCluster(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _eventHubClusterClustersClientDiagnostics.CreateScope("EventHubClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<bool> Exists(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _eventHubClusterClustersClientDiagnostics.CreateScope("EventHubClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(clusterName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual async Task<Response<EventHubCluster>> GetIfExistsAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _eventHubClusterClustersClientDiagnostics.CreateScope("EventHubClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _eventHubClusterClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<EventHubCluster>(null, response.GetRawResponse());
                return Response.FromValue(new EventHubCluster(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<EventHubCluster> GetIfExists(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _eventHubClusterClustersClientDiagnostics.CreateScope("EventHubClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _eventHubClusterClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<EventHubCluster>(null, response.GetRawResponse());
                return Response.FromValue(new EventHubCluster(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventHubCluster> IEnumerable<EventHubCluster>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventHubCluster> IAsyncEnumerable<EventHubCluster>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
