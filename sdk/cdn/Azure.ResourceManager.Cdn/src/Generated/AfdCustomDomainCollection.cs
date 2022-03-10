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

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of AfdCustomDomain and their operations over its parent. </summary>
    public partial class AfdCustomDomainCollection : ArmCollection, IEnumerable<AfdCustomDomain>, IAsyncEnumerable<AfdCustomDomain>
    {
        private readonly ClientDiagnostics _afdCustomDomainClientDiagnostics;
        private readonly AfdCustomDomainsRestOperations _afdCustomDomainRestClient;

        /// <summary> Initializes a new instance of the <see cref="AfdCustomDomainCollection"/> class for mocking. </summary>
        protected AfdCustomDomainCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AfdCustomDomainCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AfdCustomDomainCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _afdCustomDomainClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", AfdCustomDomain.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(AfdCustomDomain.ResourceType, out string afdCustomDomainApiVersion);
            _afdCustomDomainRestClient = new AfdCustomDomainsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, afdCustomDomainApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Profile.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Profile.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new domain within the specified profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}
        /// Operation Id: AfdCustomDomains_Create
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="customDomain"> Domain properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> or <paramref name="customDomain"/> is null. </exception>
        public virtual async Task<ArmOperation<AfdCustomDomain>> CreateOrUpdateAsync(WaitUntil waitUntil, string customDomainName, AfdCustomDomainData customDomain, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));
            Argument.AssertNotNull(customDomain, nameof(customDomain));

            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _afdCustomDomainRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, customDomain, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<AfdCustomDomain>(new AfdCustomDomainOperationSource(Client), _afdCustomDomainClientDiagnostics, Pipeline, _afdCustomDomainRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, customDomain).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a new domain within the specified profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}
        /// Operation Id: AfdCustomDomains_Create
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="customDomain"> Domain properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> or <paramref name="customDomain"/> is null. </exception>
        public virtual ArmOperation<AfdCustomDomain> CreateOrUpdate(WaitUntil waitUntil, string customDomainName, AfdCustomDomainData customDomain, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));
            Argument.AssertNotNull(customDomain, nameof(customDomain));

            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _afdCustomDomainRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, customDomain, cancellationToken);
                var operation = new CdnArmOperation<AfdCustomDomain>(new AfdCustomDomainOperationSource(Client), _afdCustomDomainClientDiagnostics, Pipeline, _afdCustomDomainRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, customDomain).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}
        /// Operation Id: AfdCustomDomains_Get
        /// </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual async Task<Response<AfdCustomDomain>> GetAsync(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomainCollection.Get");
            scope.Start();
            try
            {
                var response = await _afdCustomDomainRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdCustomDomain(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}
        /// Operation Id: AfdCustomDomains_Get
        /// </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual Response<AfdCustomDomain> Get(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomainCollection.Get");
            scope.Start();
            try
            {
                var response = _afdCustomDomainRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdCustomDomain(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists existing AzureFrontDoor domains.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains
        /// Operation Id: AfdCustomDomains_ListByProfile
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AfdCustomDomain" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AfdCustomDomain> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AfdCustomDomain>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdCustomDomainRestClient.ListByProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdCustomDomain(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AfdCustomDomain>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdCustomDomainRestClient.ListByProfileNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdCustomDomain(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists existing AzureFrontDoor domains.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains
        /// Operation Id: AfdCustomDomains_ListByProfile
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AfdCustomDomain" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AfdCustomDomain> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AfdCustomDomain> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdCustomDomainRestClient.ListByProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdCustomDomain(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AfdCustomDomain> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdCustomDomainRestClient.ListByProfileNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdCustomDomain(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}
        /// Operation Id: AfdCustomDomains_Get
        /// </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(customDomainName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}
        /// Operation Id: AfdCustomDomains_Get
        /// </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual Response<bool> Exists(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(customDomainName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}
        /// Operation Id: AfdCustomDomains_Get
        /// </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual async Task<Response<AfdCustomDomain>> GetIfExistsAsync(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _afdCustomDomainRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AfdCustomDomain>(null, response.GetRawResponse());
                return Response.FromValue(new AfdCustomDomain(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}
        /// Operation Id: AfdCustomDomains_Get
        /// </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual Response<AfdCustomDomain> GetIfExists(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _afdCustomDomainClientDiagnostics.CreateScope("AfdCustomDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _afdCustomDomainRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AfdCustomDomain>(null, response.GetRawResponse());
                return Response.FromValue(new AfdCustomDomain(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AfdCustomDomain> IEnumerable<AfdCustomDomain>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AfdCustomDomain> IAsyncEnumerable<AfdCustomDomain>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
