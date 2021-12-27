// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of AppServiceDomain and their operations over its parent. </summary>
    public partial class AppServiceDomainCollection : ArmCollection, IEnumerable<AppServiceDomain>, IAsyncEnumerable<AppServiceDomain>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DomainsRestOperations _domainsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppServiceDomainCollection"/> class for mocking. </summary>
        protected AppServiceDomainCollection()
        {
        }

        /// <summary> Initializes a new instance of AppServiceDomainCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AppServiceDomainCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _domainsRestClient = new DomainsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_CreateOrUpdate
        /// <summary> Description for Creates or updates a domain. </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="domain"> Domain registration information. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="domain"/> is null. </exception>
        public virtual DomainCreateOrUpdateOperation CreateOrUpdate(string domainName, AppServiceDomainData domain, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (domainName == null)
            {
                throw new ArgumentNullException(nameof(domainName));
            }
            if (domain == null)
            {
                throw new ArgumentNullException(nameof(domain));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _domainsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, domainName, domain, cancellationToken);
                var operation = new DomainCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _domainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, domainName, domain).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_CreateOrUpdate
        /// <summary> Description for Creates or updates a domain. </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="domain"> Domain registration information. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="domain"/> is null. </exception>
        public async virtual Task<DomainCreateOrUpdateOperation> CreateOrUpdateAsync(string domainName, AppServiceDomainData domain, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (domainName == null)
            {
                throw new ArgumentNullException(nameof(domainName));
            }
            if (domain == null)
            {
                throw new ArgumentNullException(nameof(domain));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _domainsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, domainName, domain, cancellationToken).ConfigureAwait(false);
                var operation = new DomainCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _domainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, domainName, domain).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_Get
        /// <summary> Description for Get a domain. </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<AppServiceDomain> Get(string domainName, CancellationToken cancellationToken = default)
        {
            if (domainName == null)
            {
                throw new ArgumentNullException(nameof(domainName));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceDomainCollection.Get");
            scope.Start();
            try
            {
                var response = _domainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, domainName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceDomain(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_Get
        /// <summary> Description for Get a domain. </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public async virtual Task<Response<AppServiceDomain>> GetAsync(string domainName, CancellationToken cancellationToken = default)
        {
            if (domainName == null)
            {
                throw new ArgumentNullException(nameof(domainName));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceDomainCollection.Get");
            scope.Start();
            try
            {
                var response = await _domainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, domainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AppServiceDomain(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<AppServiceDomain> GetIfExists(string domainName, CancellationToken cancellationToken = default)
        {
            if (domainName == null)
            {
                throw new ArgumentNullException(nameof(domainName));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _domainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, domainName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<AppServiceDomain>(null, response.GetRawResponse())
                    : Response.FromValue(new AppServiceDomain(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public async virtual Task<Response<AppServiceDomain>> GetIfExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            if (domainName == null)
            {
                throw new ArgumentNullException(nameof(domainName));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceDomainCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _domainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<AppServiceDomain>(null, response.GetRawResponse())
                    : Response.FromValue(new AppServiceDomain(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<bool> Exists(string domainName, CancellationToken cancellationToken = default)
        {
            if (domainName == null)
            {
                throw new ArgumentNullException(nameof(domainName));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(domainName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="domainName"> Name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            if (domainName == null)
            {
                throw new ArgumentNullException(nameof(domainName));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceDomainCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_ListByResourceGroup
        /// <summary> Description for Get all domains in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServiceDomain" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServiceDomain> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AppServiceDomain> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _domainsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceDomain(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AppServiceDomain> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _domainsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceDomain(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Domains_ListByResourceGroup
        /// <summary> Description for Get all domains in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServiceDomain" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServiceDomain> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AppServiceDomain>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _domainsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceDomain(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AppServiceDomain>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceDomainCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _domainsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceDomain(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="AppServiceDomain" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppServiceDomainCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AppServiceDomain.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="AppServiceDomain" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppServiceDomainCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AppServiceDomain.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppServiceDomain> IEnumerable<AppServiceDomain>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppServiceDomain> IAsyncEnumerable<AppServiceDomain>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, AppServiceDomain, AppServiceDomainData> Construct() { }
    }
}
