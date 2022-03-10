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
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    /// <summary> A class representing collection of DiskPool and their operations over its parent. </summary>
    public partial class DiskPoolCollection : ArmCollection, IEnumerable<DiskPool>, IAsyncEnumerable<DiskPool>
    {
        private readonly ClientDiagnostics _diskPoolClientDiagnostics;
        private readonly DiskPoolsRestOperations _diskPoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiskPoolCollection"/> class for mocking. </summary>
        protected DiskPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiskPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DiskPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diskPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StoragePool", DiskPool.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(DiskPool.ResourceType, out string diskPoolApiVersion);
            _diskPoolRestClient = new DiskPoolsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, diskPoolApiVersion);
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
        /// Create or Update Disk pool. This create or update operation can take 15 minutes to complete. This is expected service behavior.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}
        /// Operation Id: DiskPools_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="diskPoolCreatePayload"> Request payload for Disk Pool create operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> or <paramref name="diskPoolCreatePayload"/> is null. </exception>
        public virtual async Task<ArmOperation<DiskPool>> CreateOrUpdateAsync(bool waitForCompletion, string diskPoolName, DiskPoolCreate diskPoolCreatePayload, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskPoolName, nameof(diskPoolName));
            Argument.AssertNotNull(diskPoolCreatePayload, nameof(diskPoolCreatePayload));

            using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _diskPoolRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, diskPoolCreatePayload, cancellationToken).ConfigureAwait(false);
                var operation = new StoragePoolArmOperation<DiskPool>(new DiskPoolOperationSource(Client), _diskPoolClientDiagnostics, Pipeline, _diskPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, diskPoolCreatePayload).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or Update Disk pool. This create or update operation can take 15 minutes to complete. This is expected service behavior.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}
        /// Operation Id: DiskPools_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="diskPoolCreatePayload"> Request payload for Disk Pool create operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> or <paramref name="diskPoolCreatePayload"/> is null. </exception>
        public virtual ArmOperation<DiskPool> CreateOrUpdate(bool waitForCompletion, string diskPoolName, DiskPoolCreate diskPoolCreatePayload, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskPoolName, nameof(diskPoolName));
            Argument.AssertNotNull(diskPoolCreatePayload, nameof(diskPoolCreatePayload));

            using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _diskPoolRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, diskPoolCreatePayload, cancellationToken);
                var operation = new StoragePoolArmOperation<DiskPool>(new DiskPoolOperationSource(Client), _diskPoolClientDiagnostics, Pipeline, _diskPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, diskPoolCreatePayload).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a Disk pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}
        /// Operation Id: DiskPools_Get
        /// </summary>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        public virtual async Task<Response<DiskPool>> GetAsync(string diskPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskPoolName, nameof(diskPoolName));

            using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _diskPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskPool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Disk pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}
        /// Operation Id: DiskPools_Get
        /// </summary>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        public virtual Response<DiskPool> Get(string diskPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskPoolName, nameof(diskPoolName));

            using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _diskPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskPool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of DiskPools in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools
        /// Operation Id: DiskPools_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskPool" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiskPool> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DiskPool>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diskPoolRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DiskPool>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diskPoolRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of DiskPools in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools
        /// Operation Id: DiskPools_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskPool" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiskPool> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DiskPool> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diskPoolRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DiskPool> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diskPoolRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}
        /// Operation Id: DiskPools_Get
        /// </summary>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string diskPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskPoolName, nameof(diskPoolName));

            using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(diskPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}
        /// Operation Id: DiskPools_Get
        /// </summary>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string diskPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskPoolName, nameof(diskPoolName));

            using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(diskPoolName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}
        /// Operation Id: DiskPools_Get
        /// </summary>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        public virtual async Task<Response<DiskPool>> GetIfExistsAsync(string diskPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskPoolName, nameof(diskPoolName));

            using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _diskPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DiskPool>(null, response.GetRawResponse());
                return Response.FromValue(new DiskPool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}
        /// Operation Id: DiskPools_Get
        /// </summary>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        public virtual Response<DiskPool> GetIfExists(string diskPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskPoolName, nameof(diskPoolName));

            using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diskPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DiskPool>(null, response.GetRawResponse());
                return Response.FromValue(new DiskPool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DiskPool> IEnumerable<DiskPool>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DiskPool> IAsyncEnumerable<DiskPool>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
