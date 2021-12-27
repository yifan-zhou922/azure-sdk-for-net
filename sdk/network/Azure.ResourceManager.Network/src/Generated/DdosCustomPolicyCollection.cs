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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of DdosCustomPolicy and their operations over its parent. </summary>
    public partial class DdosCustomPolicyCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DdosCustomPoliciesRestOperations _ddosCustomPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DdosCustomPolicyCollection"/> class for mocking. </summary>
        protected DdosCustomPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of DdosCustomPolicyCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DdosCustomPolicyCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _ddosCustomPoliciesRestClient = new DdosCustomPoliciesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a DDoS custom policy. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual DdosCustomPolicyCreateOrUpdateOperation CreateOrUpdate(string ddosCustomPolicyName, DdosCustomPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ddosCustomPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, parameters, cancellationToken);
                var operation = new DdosCustomPolicyCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _ddosCustomPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, parameters).Request, response);
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

        /// <summary> Creates or updates a DDoS custom policy. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<DdosCustomPolicyCreateOrUpdateOperation> CreateOrUpdateAsync(string ddosCustomPolicyName, DdosCustomPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ddosCustomPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new DdosCustomPolicyCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _ddosCustomPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, parameters).Request, response);
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

        /// <summary> Gets information about the specified DDoS custom policy. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public virtual Response<DdosCustomPolicy> Get(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _ddosCustomPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DdosCustomPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about the specified DDoS custom policy. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public async virtual Task<Response<DdosCustomPolicy>> GetAsync(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _ddosCustomPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DdosCustomPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public virtual Response<DdosCustomPolicy> GetIfExists(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _ddosCustomPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DdosCustomPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new DdosCustomPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public async virtual Task<Response<DdosCustomPolicy>> GetIfExistsAsync(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _ddosCustomPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DdosCustomPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new DdosCustomPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(ddosCustomPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(ddosCustomPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DdosCustomPolicy" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DdosCustomPolicy.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DdosCustomPolicy" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DdosCustomPolicy.ResourceType);
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
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, DdosCustomPolicy, DdosCustomPolicyData> Construct() { }
    }
}
