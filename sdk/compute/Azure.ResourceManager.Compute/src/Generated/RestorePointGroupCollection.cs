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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of RestorePointGroup and their operations over its parent. </summary>
    public partial class RestorePointGroupCollection : ArmCollection, IEnumerable<RestorePointGroup>, IAsyncEnumerable<RestorePointGroup>
    {
        private readonly ClientDiagnostics _restorePointGroupRestorePointCollectionsClientDiagnostics;
        private readonly RestorePointCollectionsRestOperations _restorePointGroupRestorePointCollectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RestorePointGroupCollection"/> class for mocking. </summary>
        protected RestorePointGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RestorePointGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RestorePointGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorePointGroupRestorePointCollectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", RestorePointGroup.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(RestorePointGroup.ResourceType, out string restorePointGroupRestorePointCollectionsApiVersion);
            _restorePointGroupRestorePointCollectionsRestClient = new RestorePointCollectionsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, restorePointGroupRestorePointCollectionsApiVersion);
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
        /// The operation to create or update the restore point collection. Please refer to https://aka.ms/RestorePoints for more details. When updating a restore point collection, only tags may be modified.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="parameters"> Parameters supplied to the Create or Update restore point collection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointCollectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<RestorePointGroup>> CreateOrUpdateAsync(bool waitForCompletion, string restorePointCollectionName, RestorePointGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointCollectionName, nameof(restorePointCollectionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restorePointGroupRestorePointCollectionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, restorePointCollectionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<RestorePointGroup>(Response.FromValue(new RestorePointGroup(Client, response), response.GetRawResponse()));
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
        /// The operation to create or update the restore point collection. Please refer to https://aka.ms/RestorePoints for more details. When updating a restore point collection, only tags may be modified.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="parameters"> Parameters supplied to the Create or Update restore point collection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointCollectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<RestorePointGroup> CreateOrUpdate(bool waitForCompletion, string restorePointCollectionName, RestorePointGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointCollectionName, nameof(restorePointCollectionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restorePointGroupRestorePointCollectionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, restorePointCollectionName, parameters, cancellationToken);
                var operation = new ComputeArmOperation<RestorePointGroup>(Response.FromValue(new RestorePointGroup(Client, response), response.GetRawResponse()));
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
        /// The operation to get the restore point collection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Get
        /// </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointCollectionName"/> is null. </exception>
        public virtual async Task<Response<RestorePointGroup>> GetAsync(string restorePointCollectionName, RestorePointCollectionExpandOptions? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointCollectionName, nameof(restorePointCollectionName));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _restorePointGroupRestorePointCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, restorePointCollectionName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorePointGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the restore point collection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Get
        /// </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointCollectionName"/> is null. </exception>
        public virtual Response<RestorePointGroup> Get(string restorePointCollectionName, RestorePointCollectionExpandOptions? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointCollectionName, nameof(restorePointCollectionName));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _restorePointGroupRestorePointCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, restorePointCollectionName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorePointGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of restore point collections in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections
        /// Operation Id: RestorePointCollections_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorePointGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorePointGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorePointGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restorePointGroupRestorePointCollectionsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePointGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RestorePointGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restorePointGroupRestorePointCollectionsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePointGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets the list of restore point collections in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections
        /// Operation Id: RestorePointCollections_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorePointGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorePointGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RestorePointGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restorePointGroupRestorePointCollectionsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePointGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RestorePointGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restorePointGroupRestorePointCollectionsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePointGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Get
        /// </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointCollectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string restorePointCollectionName, RestorePointCollectionExpandOptions? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointCollectionName, nameof(restorePointCollectionName));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(restorePointCollectionName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Get
        /// </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointCollectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string restorePointCollectionName, RestorePointCollectionExpandOptions? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointCollectionName, nameof(restorePointCollectionName));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(restorePointCollectionName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Get
        /// </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointCollectionName"/> is null. </exception>
        public virtual async Task<Response<RestorePointGroup>> GetIfExistsAsync(string restorePointCollectionName, RestorePointCollectionExpandOptions? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointCollectionName, nameof(restorePointCollectionName));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _restorePointGroupRestorePointCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, restorePointCollectionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<RestorePointGroup>(null, response.GetRawResponse());
                return Response.FromValue(new RestorePointGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Get
        /// </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointCollectionName"/> is null. </exception>
        public virtual Response<RestorePointGroup> GetIfExists(string restorePointCollectionName, RestorePointCollectionExpandOptions? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointCollectionName, nameof(restorePointCollectionName));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restorePointGroupRestorePointCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, restorePointCollectionName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<RestorePointGroup>(null, response.GetRawResponse());
                return Response.FromValue(new RestorePointGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RestorePointGroup> IEnumerable<RestorePointGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RestorePointGroup> IAsyncEnumerable<RestorePointGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
