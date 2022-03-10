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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VpnSite and their operations over its parent. </summary>
    public partial class VpnSiteCollection : ArmCollection, IEnumerable<VpnSite>, IAsyncEnumerable<VpnSite>
    {
        private readonly ClientDiagnostics _vpnSiteClientDiagnostics;
        private readonly VpnSitesRestOperations _vpnSiteRestClient;

        /// <summary> Initializes a new instance of the <see cref="VpnSiteCollection"/> class for mocking. </summary>
        protected VpnSiteCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VpnSiteCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VpnSiteCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vpnSiteClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VpnSite.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(VpnSite.ResourceType, out string vpnSiteApiVersion);
            _vpnSiteRestClient = new VpnSitesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, vpnSiteApiVersion);
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
        /// Creates a VpnSite resource if it doesn&apos;t exist else updates the existing VpnSite.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnSites/{vpnSiteName}
        /// Operation Id: VpnSites_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite being created or updated. </param>
        /// <param name="vpnSiteParameters"> Parameters supplied to create or update VpnSite. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteName"/> or <paramref name="vpnSiteParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<VpnSite>> CreateOrUpdateAsync(WaitUntil waitUntil, string vpnSiteName, VpnSiteData vpnSiteParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnSiteName, nameof(vpnSiteName));
            Argument.AssertNotNull(vpnSiteParameters, nameof(vpnSiteParameters));

            using var scope = _vpnSiteClientDiagnostics.CreateScope("VpnSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vpnSiteRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, vpnSiteName, vpnSiteParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VpnSite>(new VpnSiteOperationSource(Client), _vpnSiteClientDiagnostics, Pipeline, _vpnSiteRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vpnSiteName, vpnSiteParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a VpnSite resource if it doesn&apos;t exist else updates the existing VpnSite.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnSites/{vpnSiteName}
        /// Operation Id: VpnSites_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite being created or updated. </param>
        /// <param name="vpnSiteParameters"> Parameters supplied to create or update VpnSite. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteName"/> or <paramref name="vpnSiteParameters"/> is null. </exception>
        public virtual ArmOperation<VpnSite> CreateOrUpdate(WaitUntil waitUntil, string vpnSiteName, VpnSiteData vpnSiteParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnSiteName, nameof(vpnSiteName));
            Argument.AssertNotNull(vpnSiteParameters, nameof(vpnSiteParameters));

            using var scope = _vpnSiteClientDiagnostics.CreateScope("VpnSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vpnSiteRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, vpnSiteName, vpnSiteParameters, cancellationToken);
                var operation = new NetworkArmOperation<VpnSite>(new VpnSiteOperationSource(Client), _vpnSiteClientDiagnostics, Pipeline, _vpnSiteRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vpnSiteName, vpnSiteParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a VPN site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnSites/{vpnSiteName}
        /// Operation Id: VpnSites_Get
        /// </summary>
        /// <param name="vpnSiteName"> The name of the VpnSite being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteName"/> is null. </exception>
        public virtual async Task<Response<VpnSite>> GetAsync(string vpnSiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnSiteName, nameof(vpnSiteName));

            using var scope = _vpnSiteClientDiagnostics.CreateScope("VpnSiteCollection.Get");
            scope.Start();
            try
            {
                var response = await _vpnSiteRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vpnSiteName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnSite(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a VPN site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnSites/{vpnSiteName}
        /// Operation Id: VpnSites_Get
        /// </summary>
        /// <param name="vpnSiteName"> The name of the VpnSite being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteName"/> is null. </exception>
        public virtual Response<VpnSite> Get(string vpnSiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnSiteName, nameof(vpnSiteName));

            using var scope = _vpnSiteClientDiagnostics.CreateScope("VpnSiteCollection.Get");
            scope.Start();
            try
            {
                var response = _vpnSiteRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vpnSiteName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnSite(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the vpnSites in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnSites
        /// Operation Id: VpnSites_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnSite" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VpnSite> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnSite>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vpnSiteClientDiagnostics.CreateScope("VpnSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnSiteRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnSite(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnSite>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vpnSiteClientDiagnostics.CreateScope("VpnSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnSiteRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnSite(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all the vpnSites in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnSites
        /// Operation Id: VpnSites_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnSite" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VpnSite> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VpnSite> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vpnSiteClientDiagnostics.CreateScope("VpnSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnSiteRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnSite(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnSite> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vpnSiteClientDiagnostics.CreateScope("VpnSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnSiteRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnSite(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnSites/{vpnSiteName}
        /// Operation Id: VpnSites_Get
        /// </summary>
        /// <param name="vpnSiteName"> The name of the VpnSite being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vpnSiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnSiteName, nameof(vpnSiteName));

            using var scope = _vpnSiteClientDiagnostics.CreateScope("VpnSiteCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vpnSiteName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnSites/{vpnSiteName}
        /// Operation Id: VpnSites_Get
        /// </summary>
        /// <param name="vpnSiteName"> The name of the VpnSite being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteName"/> is null. </exception>
        public virtual Response<bool> Exists(string vpnSiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnSiteName, nameof(vpnSiteName));

            using var scope = _vpnSiteClientDiagnostics.CreateScope("VpnSiteCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(vpnSiteName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnSites/{vpnSiteName}
        /// Operation Id: VpnSites_Get
        /// </summary>
        /// <param name="vpnSiteName"> The name of the VpnSite being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteName"/> is null. </exception>
        public virtual async Task<Response<VpnSite>> GetIfExistsAsync(string vpnSiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnSiteName, nameof(vpnSiteName));

            using var scope = _vpnSiteClientDiagnostics.CreateScope("VpnSiteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vpnSiteRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vpnSiteName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VpnSite>(null, response.GetRawResponse());
                return Response.FromValue(new VpnSite(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnSites/{vpnSiteName}
        /// Operation Id: VpnSites_Get
        /// </summary>
        /// <param name="vpnSiteName"> The name of the VpnSite being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vpnSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteName"/> is null. </exception>
        public virtual Response<VpnSite> GetIfExists(string vpnSiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vpnSiteName, nameof(vpnSiteName));

            using var scope = _vpnSiteClientDiagnostics.CreateScope("VpnSiteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vpnSiteRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vpnSiteName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VpnSite>(null, response.GetRawResponse());
                return Response.FromValue(new VpnSite(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VpnSite> IEnumerable<VpnSite>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VpnSite> IAsyncEnumerable<VpnSite>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
