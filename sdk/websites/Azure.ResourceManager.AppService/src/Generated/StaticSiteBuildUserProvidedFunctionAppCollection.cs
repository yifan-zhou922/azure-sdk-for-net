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
    /// <summary> A class representing collection of StaticSiteBuildUserProvidedFunctionApp and their operations over its parent. </summary>
    public partial class StaticSiteBuildUserProvidedFunctionAppCollection : ArmCollection, IEnumerable<StaticSiteBuildUserProvidedFunctionApp>, IAsyncEnumerable<StaticSiteBuildUserProvidedFunctionApp>
    {
        private readonly ClientDiagnostics _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildUserProvidedFunctionAppCollection"/> class for mocking. </summary>
        protected StaticSiteBuildUserProvidedFunctionAppCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildUserProvidedFunctionAppCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StaticSiteBuildUserProvidedFunctionAppCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", StaticSiteBuildUserProvidedFunctionApp.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(StaticSiteBuildUserProvidedFunctionApp.ResourceType, out string staticSiteBuildUserProvidedFunctionAppStaticSitesApiVersion);
            _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, staticSiteBuildUserProvidedFunctionAppStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StaticSiteBuildARMResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StaticSiteBuildARMResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Register a user provided function app with a static site build
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_RegisterUserProvidedFunctionAppWithStaticSiteBuild
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="functionAppName"> Name of the function app to register with the static site build. </param>
        /// <param name="staticSiteUserProvidedFunctionEnvelope"> A JSON representation of the user provided function app properties. See example. </param>
        /// <param name="isForced"> Specify &lt;code&gt;true&lt;/code&gt; to force the update of the auth configuration on the function app even if an AzureStaticWebApps provider is already configured on the function app. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> or <paramref name="staticSiteUserProvidedFunctionEnvelope"/> is null. </exception>
        public virtual async Task<ArmOperation<StaticSiteBuildUserProvidedFunctionApp>> CreateOrUpdateAsync(bool waitForCompletion, string functionAppName, StaticSiteUserProvidedFunctionAppARMResourceData staticSiteUserProvidedFunctionEnvelope, bool? isForced = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));
            Argument.AssertNotNull(staticSiteUserProvidedFunctionEnvelope, nameof(staticSiteUserProvidedFunctionEnvelope));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.RegisterUserProvidedFunctionAppWithStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, staticSiteUserProvidedFunctionEnvelope, isForced, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<StaticSiteBuildUserProvidedFunctionApp>(new StaticSiteBuildUserProvidedFunctionAppOperationSource(Client), _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.CreateRegisterUserProvidedFunctionAppWithStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, staticSiteUserProvidedFunctionEnvelope, isForced).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Register a user provided function app with a static site build
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_RegisterUserProvidedFunctionAppWithStaticSiteBuild
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="functionAppName"> Name of the function app to register with the static site build. </param>
        /// <param name="staticSiteUserProvidedFunctionEnvelope"> A JSON representation of the user provided function app properties. See example. </param>
        /// <param name="isForced"> Specify &lt;code&gt;true&lt;/code&gt; to force the update of the auth configuration on the function app even if an AzureStaticWebApps provider is already configured on the function app. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> or <paramref name="staticSiteUserProvidedFunctionEnvelope"/> is null. </exception>
        public virtual ArmOperation<StaticSiteBuildUserProvidedFunctionApp> CreateOrUpdate(bool waitForCompletion, string functionAppName, StaticSiteUserProvidedFunctionAppARMResourceData staticSiteUserProvidedFunctionEnvelope, bool? isForced = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));
            Argument.AssertNotNull(staticSiteUserProvidedFunctionEnvelope, nameof(staticSiteUserProvidedFunctionEnvelope));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.RegisterUserProvidedFunctionAppWithStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, staticSiteUserProvidedFunctionEnvelope, isForced, cancellationToken);
                var operation = new AppServiceArmOperation<StaticSiteBuildUserProvidedFunctionApp>(new StaticSiteBuildUserProvidedFunctionAppOperationSource(Client), _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.CreateRegisterUserProvidedFunctionAppWithStaticSiteBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, staticSiteUserProvidedFunctionEnvelope, isForced).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Gets the details of the user provided function app registered with a static site build
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual async Task<Response<StaticSiteBuildUserProvidedFunctionApp>> GetAsync(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildUserProvidedFunctionApp(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the details of the user provided function app registered with a static site build
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual Response<StaticSiteBuildUserProvidedFunctionApp> Get(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.Get");
            scope.Start();
            try
            {
                var response = _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildUserProvidedFunctionApp(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the details of the user provided function apps registered with a static site build
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppsForStaticSiteBuild
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteBuildUserProvidedFunctionApp" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteBuildUserProvidedFunctionApp> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StaticSiteBuildUserProvidedFunctionApp>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppsForStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteBuildUserProvidedFunctionApp(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StaticSiteBuildUserProvidedFunctionApp>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppsForStaticSiteBuildNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteBuildUserProvidedFunctionApp(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Gets the details of the user provided function apps registered with a static site build
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppsForStaticSiteBuild
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteBuildUserProvidedFunctionApp" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteBuildUserProvidedFunctionApp> GetAll(CancellationToken cancellationToken = default)
        {
            Page<StaticSiteBuildUserProvidedFunctionApp> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppsForStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteBuildUserProvidedFunctionApp(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StaticSiteBuildUserProvidedFunctionApp> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppsForStaticSiteBuildNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteBuildUserProvidedFunctionApp(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.Exists");
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

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual Response<bool> Exists(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.Exists");
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

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual async Task<Response<StaticSiteBuildUserProvidedFunctionApp>> GetIfExistsAsync(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<StaticSiteBuildUserProvidedFunctionApp>(null, response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildUserProvidedFunctionApp(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site build. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual Response<StaticSiteBuildUserProvidedFunctionApp> GetIfExists(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteBuildUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildUserProvidedFunctionAppCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _staticSiteBuildUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, functionAppName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<StaticSiteBuildUserProvidedFunctionApp>(null, response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildUserProvidedFunctionApp(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StaticSiteBuildUserProvidedFunctionApp> IEnumerable<StaticSiteBuildUserProvidedFunctionApp>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StaticSiteBuildUserProvidedFunctionApp> IAsyncEnumerable<StaticSiteBuildUserProvidedFunctionApp>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
