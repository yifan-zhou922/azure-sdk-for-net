// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of ResourceLink and their operations over its parent. </summary>
    public partial class ResourceLinkCollection : ArmCollection
    {
        private readonly ClientDiagnostics _resourceLinkClientDiagnostics;
        private readonly ResourceLinksRestOperations _resourceLinkRestClient;
        private readonly string _scope;

        /// <summary> Initializes a new instance of the <see cref="ResourceLinkCollection"/> class for mocking. </summary>
        protected ResourceLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceLinkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="scope"> The fully qualified ID of the scope for getting the resource links. For example, to list resource links at and under a resource group, set the scope to /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        internal ResourceLinkCollection(ArmClient client, ResourceIdentifier id, string scope) : base(client, id)
        {
            _scope = scope;
            _resourceLinkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceLink.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceLink.ResourceType, out string resourceLinkApiVersion);
            _resourceLinkRestClient = new ResourceLinksRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, resourceLinkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Tenant.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Tenant.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a resource link between the specified resources.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> Parameters for creating or updating a resource link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ResourceLink>> CreateOrUpdateAsync(bool waitForCompletion, ResourceLinkData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope0 = _resourceLinkClientDiagnostics.CreateScope("ResourceLinkCollection.CreateOrUpdate");
            scope0.Start();
            try
            {
                var response = await _resourceLinkRestClient.CreateOrUpdateAsync(_scope, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<ResourceLink>(Response.FromValue(new ResourceLink(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a resource link between the specified resources.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> Parameters for creating or updating a resource link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ResourceLink> CreateOrUpdate(bool waitForCompletion, ResourceLinkData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope0 = _resourceLinkClientDiagnostics.CreateScope("ResourceLinkCollection.CreateOrUpdate");
            scope0.Start();
            try
            {
                var response = _resourceLinkRestClient.CreateOrUpdate(_scope, parameters, cancellationToken);
                var operation = new ResourcesArmOperation<ResourceLink>(Response.FromValue(new ResourceLink(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a resource link with the specified ID.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceLink>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope0 = _resourceLinkClientDiagnostics.CreateScope("ResourceLinkCollection.Get");
            scope0.Start();
            try
            {
                var response = await _resourceLinkRestClient.GetAsync(_scope, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a resource link with the specified ID.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceLink> Get(CancellationToken cancellationToken = default)
        {
            using var scope0 = _resourceLinkClientDiagnostics.CreateScope("ResourceLinkCollection.Get");
            scope0.Start();
            try
            {
                var response = _resourceLinkRestClient.Get(_scope, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of resource links at and below the specified source scope.
        /// Request Path: /{scope}/providers/Microsoft.Resources/links
        /// Operation Id: ResourceLinks_ListAtSourceScope
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceLink> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope0 = _resourceLinkClientDiagnostics.CreateScope("ResourceLinkCollection.GetAll");
                scope0.Start();
                try
                {
                    var response = await _resourceLinkRestClient.ListAtSourceScopeAsync(_scope, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceLink>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope0 = _resourceLinkClientDiagnostics.CreateScope("ResourceLinkCollection.GetAll");
                scope0.Start();
                try
                {
                    var response = await _resourceLinkRestClient.ListAtSourceScopeNextPageAsync(nextLink, _scope, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of resource links at and below the specified source scope.
        /// Request Path: /{scope}/providers/Microsoft.Resources/links
        /// Operation Id: ResourceLinks_ListAtSourceScope
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceLink> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ResourceLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope0 = _resourceLinkClientDiagnostics.CreateScope("ResourceLinkCollection.GetAll");
                scope0.Start();
                try
                {
                    var response = _resourceLinkRestClient.ListAtSourceScope(_scope, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            Page<ResourceLink> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope0 = _resourceLinkClientDiagnostics.CreateScope("ResourceLinkCollection.GetAll");
                scope0.Start();
                try
                {
                    var response = _resourceLinkRestClient.ListAtSourceScopeNextPage(nextLink, _scope, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(CancellationToken cancellationToken = default)
        {
            using var scope0 = _resourceLinkClientDiagnostics.CreateScope("ResourceLinkCollection.Exists");
            scope0.Start();
            try
            {
                var response = await GetIfExistsAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(CancellationToken cancellationToken = default)
        {
            using var scope0 = _resourceLinkClientDiagnostics.CreateScope("ResourceLinkCollection.Exists");
            scope0.Start();
            try
            {
                var response = GetIfExists(cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceLink>> GetIfExistsAsync(CancellationToken cancellationToken = default)
        {
            using var scope0 = _resourceLinkClientDiagnostics.CreateScope("ResourceLinkCollection.GetIfExists");
            scope0.Start();
            try
            {
                var response = await _resourceLinkRestClient.GetAsync(_scope, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ResourceLink>(null, response.GetRawResponse());
                return Response.FromValue(new ResourceLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceLink> GetIfExists(CancellationToken cancellationToken = default)
        {
            using var scope0 = _resourceLinkClientDiagnostics.CreateScope("ResourceLinkCollection.GetIfExists");
            scope0.Start();
            try
            {
                var response = _resourceLinkRestClient.Get(_scope, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ResourceLink>(null, response.GetRawResponse());
                return Response.FromValue(new ResourceLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }
    }
}
