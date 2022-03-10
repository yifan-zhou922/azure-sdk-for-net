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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of SiteSlotDomainOwnershipIdentifier and their operations over its parent. </summary>
    public partial class SiteSlotDomainOwnershipIdentifierCollection : ArmCollection, IEnumerable<SiteSlotDomainOwnershipIdentifier>, IAsyncEnumerable<SiteSlotDomainOwnershipIdentifier>
    {
        private readonly ClientDiagnostics _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotDomainOwnershipIdentifierWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDomainOwnershipIdentifierCollection"/> class for mocking. </summary>
        protected SiteSlotDomainOwnershipIdentifierCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDomainOwnershipIdentifierCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotDomainOwnershipIdentifierCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotDomainOwnershipIdentifier.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SiteSlotDomainOwnershipIdentifier.ResourceType, out string siteSlotDomainOwnershipIdentifierWebAppsApiVersion);
            _siteSlotDomainOwnershipIdentifierWebAppsRestClient = new WebAppsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSlotDomainOwnershipIdentifierWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlot.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlot.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates a domain ownership identifier for web app, or updates an existing ownership identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_CreateOrUpdateDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="domainOwnershipIdentifier"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> or <paramref name="domainOwnershipIdentifier"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteSlotDomainOwnershipIdentifier>> CreateOrUpdateAsync(bool waitForCompletion, string domainOwnershipIdentifierName, IdentifierData domainOwnershipIdentifier, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));
            Argument.AssertNotNull(domainOwnershipIdentifier, nameof(domainOwnershipIdentifier));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotDomainOwnershipIdentifierWebAppsRestClient.CreateOrUpdateDomainOwnershipIdentifierSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, domainOwnershipIdentifier, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSlotDomainOwnershipIdentifier>(Response.FromValue(new SiteSlotDomainOwnershipIdentifier(Client, response), response.GetRawResponse()));
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
        /// Description for Creates a domain ownership identifier for web app, or updates an existing ownership identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_CreateOrUpdateDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="domainOwnershipIdentifier"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> or <paramref name="domainOwnershipIdentifier"/> is null. </exception>
        public virtual ArmOperation<SiteSlotDomainOwnershipIdentifier> CreateOrUpdate(bool waitForCompletion, string domainOwnershipIdentifierName, IdentifierData domainOwnershipIdentifier, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));
            Argument.AssertNotNull(domainOwnershipIdentifier, nameof(domainOwnershipIdentifier));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotDomainOwnershipIdentifierWebAppsRestClient.CreateOrUpdateDomainOwnershipIdentifierSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, domainOwnershipIdentifier, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSlotDomainOwnershipIdentifier>(Response.FromValue(new SiteSlotDomainOwnershipIdentifier(Client, response), response.GetRawResponse()));
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
        /// Description for Get domain ownership identifier for web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_GetDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotDomainOwnershipIdentifier>> GetAsync(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifierSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDomainOwnershipIdentifier(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get domain ownership identifier for web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_GetDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual Response<SiteSlotDomainOwnershipIdentifier> Get(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifierSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDomainOwnershipIdentifier(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Lists ownership identifiers for domain associated with web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers
        /// Operation Id: WebApps_ListDomainOwnershipIdentifiersSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotDomainOwnershipIdentifier" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotDomainOwnershipIdentifier> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotDomainOwnershipIdentifier>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotDomainOwnershipIdentifierWebAppsRestClient.ListDomainOwnershipIdentifiersSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDomainOwnershipIdentifier(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotDomainOwnershipIdentifier>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotDomainOwnershipIdentifierWebAppsRestClient.ListDomainOwnershipIdentifiersSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDomainOwnershipIdentifier(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Lists ownership identifiers for domain associated with web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers
        /// Operation Id: WebApps_ListDomainOwnershipIdentifiersSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotDomainOwnershipIdentifier" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotDomainOwnershipIdentifier> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotDomainOwnershipIdentifier> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotDomainOwnershipIdentifierWebAppsRestClient.ListDomainOwnershipIdentifiersSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDomainOwnershipIdentifier(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotDomainOwnershipIdentifier> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotDomainOwnershipIdentifierWebAppsRestClient.ListDomainOwnershipIdentifiersSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDomainOwnershipIdentifier(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_GetDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(domainOwnershipIdentifierName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_GetDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual Response<bool> Exists(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(domainOwnershipIdentifierName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_GetDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotDomainOwnershipIdentifier>> GetIfExistsAsync(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifierSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotDomainOwnershipIdentifier>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotDomainOwnershipIdentifier(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_GetDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual Response<SiteSlotDomainOwnershipIdentifier> GetIfExists(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifierSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifierName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotDomainOwnershipIdentifier>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotDomainOwnershipIdentifier(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotDomainOwnershipIdentifier> IEnumerable<SiteSlotDomainOwnershipIdentifier>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotDomainOwnershipIdentifier> IAsyncEnumerable<SiteSlotDomainOwnershipIdentifier>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
