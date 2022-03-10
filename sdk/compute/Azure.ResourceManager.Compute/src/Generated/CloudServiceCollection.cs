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

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of CloudService and their operations over its parent. </summary>
    public partial class CloudServiceCollection : ArmCollection, IEnumerable<CloudService>, IAsyncEnumerable<CloudService>
    {
        private readonly ClientDiagnostics _cloudServiceClientDiagnostics;
        private readonly CloudServicesRestOperations _cloudServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="CloudServiceCollection"/> class for mocking. </summary>
        protected CloudServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CloudServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CloudServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cloudServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", CloudService.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(CloudService.ResourceType, out string cloudServiceApiVersion);
            _cloudServiceRestClient = new CloudServicesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, cloudServiceApiVersion);
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
        /// Create or update a cloud service. Please note some properties can be set only during cloud service creation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}
        /// Operation Id: CloudServices_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="parameters"> The cloud service object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual async Task<ArmOperation<CloudService>> CreateOrUpdateAsync(WaitUntil waitUntil, string cloudServiceName, CloudServiceData parameters = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServiceName, nameof(cloudServiceName));

            using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cloudServiceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<CloudService>(new CloudServiceOperationSource(Client), _cloudServiceClientDiagnostics, Pipeline, _cloudServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a cloud service. Please note some properties can be set only during cloud service creation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}
        /// Operation Id: CloudServices_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="parameters"> The cloud service object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual ArmOperation<CloudService> CreateOrUpdate(WaitUntil waitUntil, string cloudServiceName, CloudServiceData parameters = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServiceName, nameof(cloudServiceName));

            using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cloudServiceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, parameters, cancellationToken);
                var operation = new ComputeArmOperation<CloudService>(new CloudServiceOperationSource(Client), _cloudServiceClientDiagnostics, Pipeline, _cloudServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Display information about a cloud service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}
        /// Operation Id: CloudServices_Get
        /// </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual async Task<Response<CloudService>> GetAsync(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServiceName, nameof(cloudServiceName));

            using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudService(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Display information about a cloud service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}
        /// Operation Id: CloudServices_Get
        /// </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual Response<CloudService> Get(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServiceName, nameof(cloudServiceName));

            using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudService(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all cloud services under a resource group. Use nextLink property in the response to get the next page of Cloud Services. Do this till nextLink is null to fetch all the Cloud Services.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices
        /// Operation Id: CloudServices_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CloudService" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CloudService> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CloudService>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServiceRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudService(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CloudService>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServiceRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudService(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of all cloud services under a resource group. Use nextLink property in the response to get the next page of Cloud Services. Do this till nextLink is null to fetch all the Cloud Services.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices
        /// Operation Id: CloudServices_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CloudService" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CloudService> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CloudService> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServiceRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudService(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CloudService> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServiceRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudService(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}
        /// Operation Id: CloudServices_Get
        /// </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServiceName, nameof(cloudServiceName));

            using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(cloudServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}
        /// Operation Id: CloudServices_Get
        /// </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual Response<bool> Exists(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServiceName, nameof(cloudServiceName));

            using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(cloudServiceName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}
        /// Operation Id: CloudServices_Get
        /// </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual async Task<Response<CloudService>> GetIfExistsAsync(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServiceName, nameof(cloudServiceName));

            using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cloudServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CloudService>(null, response.GetRawResponse());
                return Response.FromValue(new CloudService(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}
        /// Operation Id: CloudServices_Get
        /// </summary>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudServiceName"/> is null. </exception>
        public virtual Response<CloudService> GetIfExists(string cloudServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudServiceName, nameof(cloudServiceName));

            using var scope = _cloudServiceClientDiagnostics.CreateScope("CloudServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cloudServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cloudServiceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CloudService>(null, response.GetRawResponse());
                return Response.FromValue(new CloudService(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CloudService> IEnumerable<CloudService>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CloudService> IAsyncEnumerable<CloudService>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
