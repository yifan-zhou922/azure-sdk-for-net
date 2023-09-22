// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceEndpointPolicyResource" /> and their operations.
    /// Each <see cref="ServiceEndpointPolicyResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ServiceEndpointPolicyCollection" /> instance call the GetServiceEndpointPolicies method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ServiceEndpointPolicyCollection : ArmCollection, IEnumerable<ServiceEndpointPolicyResource>, IAsyncEnumerable<ServiceEndpointPolicyResource>
    {
        private readonly ClientDiagnostics _serviceEndpointPolicyClientDiagnostics;
        private readonly ServiceEndpointPoliciesRestOperations _serviceEndpointPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceEndpointPolicyCollection"/> class for mocking. </summary>
        protected ServiceEndpointPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceEndpointPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceEndpointPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceEndpointPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ServiceEndpointPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceEndpointPolicyResource.ResourceType, out string serviceEndpointPolicyApiVersion);
            _serviceEndpointPolicyRestClient = new ServiceEndpointPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceEndpointPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a service Endpoint Policies.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="data"> Parameters supplied to the create or update service endpoint policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceEndpointPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serviceEndpointPolicyName, ServiceEndpointPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyName, nameof(serviceEndpointPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceEndpointPolicyClientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceEndpointPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ServiceEndpointPolicyResource>(new ServiceEndpointPolicyOperationSource(Client), _serviceEndpointPolicyClientDiagnostics, Pipeline, _serviceEndpointPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a service Endpoint Policies.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="data"> Parameters supplied to the create or update service endpoint policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceEndpointPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string serviceEndpointPolicyName, ServiceEndpointPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyName, nameof(serviceEndpointPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceEndpointPolicyClientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceEndpointPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, data, cancellationToken);
                var operation = new NetworkArmOperation<ServiceEndpointPolicyResource>(new ServiceEndpointPolicyOperationSource(Client), _serviceEndpointPolicyClientDiagnostics, Pipeline, _serviceEndpointPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified service Endpoint Policies in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public virtual async Task<Response<ServiceEndpointPolicyResource>> GetAsync(string serviceEndpointPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyName, nameof(serviceEndpointPolicyName));

            using var scope = _serviceEndpointPolicyClientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceEndpointPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceEndpointPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified service Endpoint Policies in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public virtual Response<ServiceEndpointPolicyResource> Get(string serviceEndpointPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyName, nameof(serviceEndpointPolicyName));

            using var scope = _serviceEndpointPolicyClientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceEndpointPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceEndpointPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all service endpoint Policies in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicies_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceEndpointPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceEndpointPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceEndpointPolicyRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceEndpointPolicyRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceEndpointPolicyResource(Client, ServiceEndpointPolicyData.DeserializeServiceEndpointPolicyData(e)), _serviceEndpointPolicyClientDiagnostics, Pipeline, "ServiceEndpointPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all service endpoint Policies in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicies_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceEndpointPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceEndpointPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceEndpointPolicyRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceEndpointPolicyRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceEndpointPolicyResource(Client, ServiceEndpointPolicyData.DeserializeServiceEndpointPolicyData(e)), _serviceEndpointPolicyClientDiagnostics, Pipeline, "ServiceEndpointPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serviceEndpointPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyName, nameof(serviceEndpointPolicyName));

            using var scope = _serviceEndpointPolicyClientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceEndpointPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string serviceEndpointPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyName, nameof(serviceEndpointPolicyName));

            using var scope = _serviceEndpointPolicyClientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceEndpointPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, expand, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceEndpointPolicyResource>> GetIfExistsAsync(string serviceEndpointPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyName, nameof(serviceEndpointPolicyName));

            using var scope = _serviceEndpointPolicyClientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceEndpointPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceEndpointPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceEndpointPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/serviceEndpointPolicies/{serviceEndpointPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceEndpointPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceEndpointPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public virtual NullableResponse<ServiceEndpointPolicyResource> GetIfExists(string serviceEndpointPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceEndpointPolicyName, nameof(serviceEndpointPolicyName));

            using var scope = _serviceEndpointPolicyClientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceEndpointPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceEndpointPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceEndpointPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceEndpointPolicyResource> IEnumerable<ServiceEndpointPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceEndpointPolicyResource> IAsyncEnumerable<ServiceEndpointPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
