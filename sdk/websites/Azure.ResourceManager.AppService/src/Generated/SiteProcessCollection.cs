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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of ProcessInfo and their operations over its parent. </summary>
    public partial class SiteProcessCollection : ArmCollection, IEnumerable<SiteProcess>, IAsyncEnumerable<SiteProcess>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteProcessCollection"/> class for mocking. </summary>
        protected SiteProcessCollection()
        {
        }

        /// <summary> Initializes a new instance of SiteProcessCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteProcessCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => WebSite.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetProcess
        /// <summary> Description for Get process information by its ID for a specific scaled-out instance in a web site. </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<SiteProcess> Get(string processId, CancellationToken cancellationToken = default)
        {
            if (processId == null)
            {
                throw new ArgumentNullException(nameof(processId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteProcessCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetProcess(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, processId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteProcess(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetProcess
        /// <summary> Description for Get process information by its ID for a specific scaled-out instance in a web site. </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public async virtual Task<Response<SiteProcess>> GetAsync(string processId, CancellationToken cancellationToken = default)
        {
            if (processId == null)
            {
                throw new ArgumentNullException(nameof(processId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteProcessCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetProcessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, processId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteProcess(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<SiteProcess> GetIfExists(string processId, CancellationToken cancellationToken = default)
        {
            if (processId == null)
            {
                throw new ArgumentNullException(nameof(processId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteProcessCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetProcess(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, processId, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SiteProcess>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteProcess(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public async virtual Task<Response<SiteProcess>> GetIfExistsAsync(string processId, CancellationToken cancellationToken = default)
        {
            if (processId == null)
            {
                throw new ArgumentNullException(nameof(processId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteProcessCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetProcessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, processId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SiteProcess>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteProcess(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public virtual Response<bool> Exists(string processId, CancellationToken cancellationToken = default)
        {
            if (processId == null)
            {
                throw new ArgumentNullException(nameof(processId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteProcessCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(processId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string processId, CancellationToken cancellationToken = default)
        {
            if (processId == null)
            {
                throw new ArgumentNullException(nameof(processId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteProcessCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(processId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListProcesses
        /// <summary> Description for Get list of processes for a web site, or a deployment slot, or for a specific scaled-out instance in a web site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteProcess" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteProcess> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteProcess> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListProcesses(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteProcess(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteProcess> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListProcessesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteProcess(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListProcesses
        /// <summary> Description for Get list of processes for a web site, or a deployment slot, or for a specific scaled-out instance in a web site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteProcess" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteProcess> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteProcess>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListProcessesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteProcess(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteProcess>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteProcessCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListProcessesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteProcess(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteProcess> IEnumerable<SiteProcess>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteProcess> IAsyncEnumerable<SiteProcess>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SiteProcess, ProcessInfoData> Construct() { }
    }
}
