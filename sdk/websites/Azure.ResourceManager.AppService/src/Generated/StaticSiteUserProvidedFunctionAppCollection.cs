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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of StaticSiteUserProvidedFunctionAppARMResource and their operations over its parent. </summary>
    public partial class StaticSiteUserProvidedFunctionAppCollection : ArmCollection, IEnumerable<StaticSiteUserProvidedFunctionApp>, IAsyncEnumerable<StaticSiteUserProvidedFunctionApp>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly StaticSitesRestOperations _staticSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteUserProvidedFunctionAppCollection"/> class for mocking. </summary>
        protected StaticSiteUserProvidedFunctionAppCollection()
        {
        }

        /// <summary> Initializes a new instance of StaticSiteUserProvidedFunctionAppCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal StaticSiteUserProvidedFunctionAppCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _staticSitesRestClient = new StaticSitesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => StaticSiteARMResource.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// OperationId: StaticSites_RegisterUserProvidedFunctionAppWithStaticSite
        /// <summary> Description for Register a user provided function app with a static site. </summary>
        /// <param name="functionAppName"> Name of the function app to register with the static site. </param>
        /// <param name="staticSiteUserProvidedFunctionEnvelope"> A JSON representation of the user provided function app properties. See example. </param>
        /// <param name="isForced"> Specify &lt;code&gt;true&lt;/code&gt; to force the update of the auth configuration on the function app even if an AzureStaticWebApps provider is already configured on the function app. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> or <paramref name="staticSiteUserProvidedFunctionEnvelope"/> is null. </exception>
        public virtual StaticSiteRegisterUserProvidedFunctionAppWithStaticSiteOperation CreateOrUpdate(string functionAppName, StaticSiteUserProvidedFunctionAppARMResourceData staticSiteUserProvidedFunctionEnvelope, bool? isForced = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (functionAppName == null)
            {
                throw new ArgumentNullException(nameof(functionAppName));
            }
            if (staticSiteUserProvidedFunctionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(staticSiteUserProvidedFunctionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _staticSitesRestClient.RegisterUserProvidedFunctionAppWithStaticSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, staticSiteUserProvidedFunctionEnvelope, isForced, cancellationToken);
                var operation = new StaticSiteRegisterUserProvidedFunctionAppWithStaticSiteOperation(Parent, _clientDiagnostics, Pipeline, _staticSitesRestClient.CreateRegisterUserProvidedFunctionAppWithStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, staticSiteUserProvidedFunctionEnvelope, isForced).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// OperationId: StaticSites_RegisterUserProvidedFunctionAppWithStaticSite
        /// <summary> Description for Register a user provided function app with a static site. </summary>
        /// <param name="functionAppName"> Name of the function app to register with the static site. </param>
        /// <param name="staticSiteUserProvidedFunctionEnvelope"> A JSON representation of the user provided function app properties. See example. </param>
        /// <param name="isForced"> Specify &lt;code&gt;true&lt;/code&gt; to force the update of the auth configuration on the function app even if an AzureStaticWebApps provider is already configured on the function app. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> or <paramref name="staticSiteUserProvidedFunctionEnvelope"/> is null. </exception>
        public async virtual Task<StaticSiteRegisterUserProvidedFunctionAppWithStaticSiteOperation> CreateOrUpdateAsync(string functionAppName, StaticSiteUserProvidedFunctionAppARMResourceData staticSiteUserProvidedFunctionEnvelope, bool? isForced = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (functionAppName == null)
            {
                throw new ArgumentNullException(nameof(functionAppName));
            }
            if (staticSiteUserProvidedFunctionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(staticSiteUserProvidedFunctionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _staticSitesRestClient.RegisterUserProvidedFunctionAppWithStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, staticSiteUserProvidedFunctionEnvelope, isForced, cancellationToken).ConfigureAwait(false);
                var operation = new StaticSiteRegisterUserProvidedFunctionAppWithStaticSiteOperation(Parent, _clientDiagnostics, Pipeline, _staticSitesRestClient.CreateRegisterUserProvidedFunctionAppWithStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, staticSiteUserProvidedFunctionEnvelope, isForced).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// OperationId: StaticSites_GetUserProvidedFunctionAppForStaticSite
        /// <summary> Description for Gets the details of the user provided function app registered with a static site. </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual Response<StaticSiteUserProvidedFunctionApp> Get(string functionAppName, CancellationToken cancellationToken = default)
        {
            if (functionAppName == null)
            {
                throw new ArgumentNullException(nameof(functionAppName));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.Get");
            scope.Start();
            try
            {
                var response = _staticSitesRestClient.GetUserProvidedFunctionAppForStaticSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteUserProvidedFunctionApp(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// OperationId: StaticSites_GetUserProvidedFunctionAppForStaticSite
        /// <summary> Description for Gets the details of the user provided function app registered with a static site. </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public async virtual Task<Response<StaticSiteUserProvidedFunctionApp>> GetAsync(string functionAppName, CancellationToken cancellationToken = default)
        {
            if (functionAppName == null)
            {
                throw new ArgumentNullException(nameof(functionAppName));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.Get");
            scope.Start();
            try
            {
                var response = await _staticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new StaticSiteUserProvidedFunctionApp(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual Response<StaticSiteUserProvidedFunctionApp> GetIfExists(string functionAppName, CancellationToken cancellationToken = default)
        {
            if (functionAppName == null)
            {
                throw new ArgumentNullException(nameof(functionAppName));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _staticSitesRestClient.GetUserProvidedFunctionAppForStaticSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<StaticSiteUserProvidedFunctionApp>(null, response.GetRawResponse())
                    : Response.FromValue(new StaticSiteUserProvidedFunctionApp(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public async virtual Task<Response<StaticSiteUserProvidedFunctionApp>> GetIfExistsAsync(string functionAppName, CancellationToken cancellationToken = default)
        {
            if (functionAppName == null)
            {
                throw new ArgumentNullException(nameof(functionAppName));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _staticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<StaticSiteUserProvidedFunctionApp>(null, response.GetRawResponse())
                    : Response.FromValue(new StaticSiteUserProvidedFunctionApp(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual Response<bool> Exists(string functionAppName, CancellationToken cancellationToken = default)
        {
            if (functionAppName == null)
            {
                throw new ArgumentNullException(nameof(functionAppName));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(functionAppName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string functionAppName, CancellationToken cancellationToken = default)
        {
            if (functionAppName == null)
            {
                throw new ArgumentNullException(nameof(functionAppName));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(functionAppName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// OperationId: StaticSites_GetUserProvidedFunctionAppsForStaticSite
        /// <summary> Description for Gets the details of the user provided function apps registered with a static site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteUserProvidedFunctionApp" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteUserProvidedFunctionApp> GetAll(CancellationToken cancellationToken = default)
        {
            Page<StaticSiteUserProvidedFunctionApp> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSitesRestClient.GetUserProvidedFunctionAppsForStaticSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteUserProvidedFunctionApp(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StaticSiteUserProvidedFunctionApp> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSitesRestClient.GetUserProvidedFunctionAppsForStaticSiteNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteUserProvidedFunctionApp(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}
        /// OperationId: StaticSites_GetUserProvidedFunctionAppsForStaticSite
        /// <summary> Description for Gets the details of the user provided function apps registered with a static site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteUserProvidedFunctionApp" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteUserProvidedFunctionApp> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StaticSiteUserProvidedFunctionApp>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSitesRestClient.GetUserProvidedFunctionAppsForStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteUserProvidedFunctionApp(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StaticSiteUserProvidedFunctionApp>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSitesRestClient.GetUserProvidedFunctionAppsForStaticSiteNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteUserProvidedFunctionApp(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<StaticSiteUserProvidedFunctionApp> IEnumerable<StaticSiteUserProvidedFunctionApp>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StaticSiteUserProvidedFunctionApp> IAsyncEnumerable<StaticSiteUserProvidedFunctionApp>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, StaticSiteUserProvidedFunctionApp, StaticSiteUserProvidedFunctionAppARMResourceData> Construct() { }
    }
}
