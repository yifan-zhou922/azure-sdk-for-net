// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a VpnSite along with the instance operations that can be performed on it. </summary>
    public partial class VpnSite : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VpnSite"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vpnSiteName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnSites/{vpnSiteName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VpnSitesRestOperations _vpnSitesRestClient;
        private readonly VpnSiteData _data;

        /// <summary> Initializes a new instance of the <see cref="VpnSite"/> class for mocking. </summary>
        protected VpnSite()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VpnSite"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal VpnSite(ArmResource options, VpnSiteData resource) : base(options, new ResourceIdentifier(resource.Id))
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _vpnSitesRestClient = new VpnSitesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="VpnSite"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VpnSite(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _vpnSitesRestClient = new VpnSitesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="VpnSite"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VpnSite(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _vpnSitesRestClient = new VpnSitesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/vpnSites";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VpnSiteData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Retrieves the details of a VPN site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VpnSite>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSite.Get");
            scope.Start();
            try
            {
                var response = await _vpnSitesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VpnSite(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a VPN site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnSite> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSite.Get");
            scope.Start();
            try
            {
                var response = _vpnSitesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnSite(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes a VpnSite. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VpnSiteDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSite.Delete");
            scope.Start();
            try
            {
                var response = await _vpnSitesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new VpnSiteDeleteOperation(_clientDiagnostics, Pipeline, _vpnSitesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VpnSite. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnSiteDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSite.Delete");
            scope.Start();
            try
            {
                var response = _vpnSitesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new VpnSiteDeleteOperation(_clientDiagnostics, Pipeline, _vpnSitesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Updates VpnSite tags. </summary>
        /// <param name="vpnSiteParameters"> Parameters supplied to update VpnSite tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteParameters"/> is null. </exception>
        public async virtual Task<Response<VpnSite>> UpdateAsync(TagsObject vpnSiteParameters, CancellationToken cancellationToken = default)
        {
            if (vpnSiteParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSite.Update");
            scope.Start();
            try
            {
                var response = await _vpnSitesRestClient.UpdateTagsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vpnSiteParameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VpnSite(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates VpnSite tags. </summary>
        /// <param name="vpnSiteParameters"> Parameters supplied to update VpnSite tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnSiteParameters"/> is null. </exception>
        public virtual Response<VpnSite> Update(TagsObject vpnSiteParameters, CancellationToken cancellationToken = default)
        {
            if (vpnSiteParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSite.Update");
            scope.Start();
            try
            {
                var response = _vpnSitesRestClient.UpdateTags(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vpnSiteParameters, cancellationToken);
                return Response.FromValue(new VpnSite(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        #region VpnSiteLink

        /// <summary> Gets a collection of VpnSiteLinks in the VpnSite. </summary>
        /// <returns> An object representing collection of VpnSiteLinks and their operations over a VpnSite. </returns>
        public VpnSiteLinkCollection GetVpnSiteLinks()
        {
            return new VpnSiteLinkCollection(this);
        }
        #endregion
    }
}
