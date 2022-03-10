// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
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
    /// <summary> A Class representing a ServerfarmHybridConnectionNamespaceRelay along with the instance operations that can be performed on it. </summary>
    public partial class ServerfarmHybridConnectionNamespaceRelay : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServerfarmHybridConnectionNamespaceRelay"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string namespaceName, string relayName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serverfarmHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics;
        private readonly AppServicePlansRestOperations _serverfarmHybridConnectionNamespaceRelayAppServicePlansRestClient;
        private readonly HybridConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="ServerfarmHybridConnectionNamespaceRelay"/> class for mocking. </summary>
        protected ServerfarmHybridConnectionNamespaceRelay()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServerfarmHybridConnectionNamespaceRelay"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServerfarmHybridConnectionNamespaceRelay(ArmClient client, HybridConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServerfarmHybridConnectionNamespaceRelay"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServerfarmHybridConnectionNamespaceRelay(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverfarmHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string serverfarmHybridConnectionNamespaceRelayAppServicePlansApiVersion);
            _serverfarmHybridConnectionNamespaceRelayAppServicePlansRestClient = new AppServicePlansRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverfarmHybridConnectionNamespaceRelayAppServicePlansApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/serverfarms/hybridConnectionNamespaces/relays";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HybridConnectionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Retrieve a Hybrid Connection in use in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// Operation Id: AppServicePlans_GetHybridConnection
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerfarmHybridConnectionNamespaceRelay>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serverfarmHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("ServerfarmHybridConnectionNamespaceRelay.Get");
            scope.Start();
            try
            {
                var response = await _serverfarmHybridConnectionNamespaceRelayAppServicePlansRestClient.GetHybridConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerfarmHybridConnectionNamespaceRelay(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Retrieve a Hybrid Connection in use in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// Operation Id: AppServicePlans_GetHybridConnection
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerfarmHybridConnectionNamespaceRelay> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serverfarmHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("ServerfarmHybridConnectionNamespaceRelay.Get");
            scope.Start();
            try
            {
                var response = _serverfarmHybridConnectionNamespaceRelayAppServicePlansRestClient.GetHybridConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerfarmHybridConnectionNamespaceRelay(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Delete a Hybrid Connection in use in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// Operation Id: AppServicePlans_DeleteHybridConnection
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _serverfarmHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("ServerfarmHybridConnectionNamespaceRelay.Delete");
            scope.Start();
            try
            {
                var response = await _serverfarmHybridConnectionNamespaceRelayAppServicePlansRestClient.DeleteHybridConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(response);
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

        /// <summary>
        /// Description for Delete a Hybrid Connection in use in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// Operation Id: AppServicePlans_DeleteHybridConnection
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _serverfarmHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("ServerfarmHybridConnectionNamespaceRelay.Delete");
            scope.Start();
            try
            {
                var response = _serverfarmHybridConnectionNamespaceRelayAppServicePlansRestClient.DeleteHybridConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(response);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the send key name and value of a Hybrid Connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}/listKeys
        /// Operation Id: AppServicePlans_ListHybridConnectionKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HybridConnectionKey>> GetHybridConnectionKeysAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serverfarmHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("ServerfarmHybridConnectionNamespaceRelay.GetHybridConnectionKeys");
            scope.Start();
            try
            {
                var response = await _serverfarmHybridConnectionNamespaceRelayAppServicePlansRestClient.ListHybridConnectionKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the send key name and value of a Hybrid Connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}/listKeys
        /// Operation Id: AppServicePlans_ListHybridConnectionKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HybridConnectionKey> GetHybridConnectionKeys(CancellationToken cancellationToken = default)
        {
            using var scope = _serverfarmHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("ServerfarmHybridConnectionNamespaceRelay.GetHybridConnectionKeys");
            scope.Start();
            try
            {
                var response = _serverfarmHybridConnectionNamespaceRelayAppServicePlansRestClient.ListHybridConnectionKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get all apps that use a Hybrid Connection in an App Service Plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}/sites
        /// Operation Id: AppServicePlans_ListWebAppsByHybridConnection
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="string" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<string> GetWebAppsByHybridConnectionAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<string>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverfarmHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("ServerfarmHybridConnectionNamespaceRelay.GetWebAppsByHybridConnection");
                scope.Start();
                try
                {
                    var response = await _serverfarmHybridConnectionNamespaceRelayAppServicePlansRestClient.ListWebAppsByHybridConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<string>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverfarmHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("ServerfarmHybridConnectionNamespaceRelay.GetWebAppsByHybridConnection");
                scope.Start();
                try
                {
                    var response = await _serverfarmHybridConnectionNamespaceRelayAppServicePlansRestClient.ListWebAppsByHybridConnectionNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Get all apps that use a Hybrid Connection in an App Service Plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}/sites
        /// Operation Id: AppServicePlans_ListWebAppsByHybridConnection
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="string" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<string> GetWebAppsByHybridConnection(CancellationToken cancellationToken = default)
        {
            Page<string> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverfarmHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("ServerfarmHybridConnectionNamespaceRelay.GetWebAppsByHybridConnection");
                scope.Start();
                try
                {
                    var response = _serverfarmHybridConnectionNamespaceRelayAppServicePlansRestClient.ListWebAppsByHybridConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<string> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverfarmHybridConnectionNamespaceRelayAppServicePlansClientDiagnostics.CreateScope("ServerfarmHybridConnectionNamespaceRelay.GetWebAppsByHybridConnection");
                scope.Start();
                try
                {
                    var response = _serverfarmHybridConnectionNamespaceRelayAppServicePlansRestClient.ListWebAppsByHybridConnectionNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
