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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of AppServiceEnvironment and their operations over its parent. </summary>
    public partial class AppServiceEnvironmentCollection : ArmCollection, IEnumerable<AppServiceEnvironment>, IAsyncEnumerable<AppServiceEnvironment>
    {
        private readonly ClientDiagnostics _appServiceEnvironmentClientDiagnostics;
        private readonly AppServiceEnvironmentsRestOperations _appServiceEnvironmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppServiceEnvironmentCollection"/> class for mocking. </summary>
        protected AppServiceEnvironmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppServiceEnvironmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppServiceEnvironmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appServiceEnvironmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", AppServiceEnvironment.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(AppServiceEnvironment.ResourceType, out string appServiceEnvironmentApiVersion);
            _appServiceEnvironmentRestClient = new AppServiceEnvironmentsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, appServiceEnvironmentApiVersion);
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
        /// Description for Create or update an App Service Environment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// Operation Id: AppServiceEnvironments_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="hostingEnvironmentEnvelope"> Configuration details of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="hostingEnvironmentEnvelope"/> is null. </exception>
        public virtual async Task<ArmOperation<AppServiceEnvironment>> CreateOrUpdateAsync(bool waitForCompletion, string name, AppServiceEnvironmentData hostingEnvironmentEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(hostingEnvironmentEnvelope, nameof(hostingEnvironmentEnvelope));

            using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, name, hostingEnvironmentEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<AppServiceEnvironment>(new AppServiceEnvironmentOperationSource(Client), _appServiceEnvironmentClientDiagnostics, Pipeline, _appServiceEnvironmentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, hostingEnvironmentEnvelope).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Create or update an App Service Environment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// Operation Id: AppServiceEnvironments_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="hostingEnvironmentEnvelope"> Configuration details of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="hostingEnvironmentEnvelope"/> is null. </exception>
        public virtual ArmOperation<AppServiceEnvironment> CreateOrUpdate(bool waitForCompletion, string name, AppServiceEnvironmentData hostingEnvironmentEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(hostingEnvironmentEnvelope, nameof(hostingEnvironmentEnvelope));

            using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, name, hostingEnvironmentEnvelope, cancellationToken);
                var operation = new AppServiceArmOperation<AppServiceEnvironment>(new AppServiceEnvironmentOperationSource(Client), _appServiceEnvironmentClientDiagnostics, Pipeline, _appServiceEnvironmentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, hostingEnvironmentEnvelope).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get the properties of an App Service Environment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// Operation Id: AppServiceEnvironments_Get
        /// </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<AppServiceEnvironment>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceEnvironment(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the properties of an App Service Environment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// Operation Id: AppServiceEnvironments_Get
        /// </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<AppServiceEnvironment> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.Get");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceEnvironment(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get all App Service Environments in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments
        /// Operation Id: AppServiceEnvironments_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServiceEnvironment" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServiceEnvironment> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AppServiceEnvironment>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceEnvironment(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AppServiceEnvironment>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceEnvironment(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Get all App Service Environments in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments
        /// Operation Id: AppServiceEnvironments_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServiceEnvironment" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServiceEnvironment> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AppServiceEnvironment> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceEnvironment(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AppServiceEnvironment> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceEnvironment(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// Operation Id: AppServiceEnvironments_Get
        /// </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// Operation Id: AppServiceEnvironments_Get
        /// </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// Operation Id: AppServiceEnvironments_Get
        /// </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<AppServiceEnvironment>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AppServiceEnvironment>(null, response.GetRawResponse());
                return Response.FromValue(new AppServiceEnvironment(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// Operation Id: AppServiceEnvironments_Get
        /// </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<AppServiceEnvironment> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _appServiceEnvironmentClientDiagnostics.CreateScope("AppServiceEnvironmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AppServiceEnvironment>(null, response.GetRawResponse());
                return Response.FromValue(new AppServiceEnvironment(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppServiceEnvironment> IEnumerable<AppServiceEnvironment>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppServiceEnvironment> IAsyncEnumerable<AppServiceEnvironment>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
