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

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing collection of DisasterRecovery and their operations over its parent. </summary>
    public partial class DisasterRecoveryCollection : ArmCollection, IEnumerable<DisasterRecovery>, IAsyncEnumerable<DisasterRecovery>
    {
        private readonly ClientDiagnostics _disasterRecoveryClientDiagnostics;
        private readonly DisasterRecoveriesRestOperations _disasterRecoveryRestClient;
        private readonly ClientDiagnostics _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics;
        private readonly DisasterRecoveryConfigsRestOperations _disasterRecoveryDisasterRecoveryConfigsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DisasterRecoveryCollection"/> class for mocking. </summary>
        protected DisasterRecoveryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DisasterRecoveryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DisasterRecoveryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _disasterRecoveryClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", DisasterRecovery.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(DisasterRecovery.ResourceType, out string disasterRecoveryApiVersion);
            _disasterRecoveryRestClient = new DisasterRecoveriesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, disasterRecoveryApiVersion);
            _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", DisasterRecovery.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(DisasterRecovery.ResourceType, out string disasterRecoveryDisasterRecoveryConfigsApiVersion);
            _disasterRecoveryDisasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, disasterRecoveryDisasterRecoveryConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventHubNamespace.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventHubNamespace.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a new Alias(Disaster Recovery configuration)
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// Operation Id: DisasterRecoveries_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="parameters"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<DisasterRecovery>> CreateOrUpdateAsync(WaitUntil waitUntil, string @alias, DisasterRecoveryData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(@alias, nameof(@alias));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _disasterRecoveryClientDiagnostics.CreateScope("DisasterRecoveryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubsArmOperation<DisasterRecovery>(Response.FromValue(new DisasterRecovery(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a new Alias(Disaster Recovery configuration)
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// Operation Id: DisasterRecoveries_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="parameters"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<DisasterRecovery> CreateOrUpdate(WaitUntil waitUntil, string @alias, DisasterRecoveryData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(@alias, nameof(@alias));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _disasterRecoveryClientDiagnostics.CreateScope("DisasterRecoveryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _disasterRecoveryRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, parameters, cancellationToken);
                var operation = new EventHubsArmOperation<DisasterRecovery>(Response.FromValue(new DisasterRecovery(Client, response), response.GetRawResponse()));
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
        /// Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// Operation Id: DisasterRecoveryConfigs_Get
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual async Task<Response<DisasterRecovery>> GetAsync(string @alias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(@alias, nameof(@alias));

            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryCollection.Get");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryDisasterRecoveryConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DisasterRecovery(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// Operation Id: DisasterRecoveryConfigs_Get
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual Response<DisasterRecovery> Get(string @alias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(@alias, nameof(@alias));

            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryCollection.Get");
            scope.Start();
            try
            {
                var response = _disasterRecoveryDisasterRecoveryConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DisasterRecovery(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all Alias(Disaster Recovery configurations)
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs
        /// Operation Id: DisasterRecoveryConfigs_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DisasterRecovery" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DisasterRecovery> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DisasterRecovery>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _disasterRecoveryDisasterRecoveryConfigsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecovery(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DisasterRecovery>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _disasterRecoveryDisasterRecoveryConfigsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecovery(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all Alias(Disaster Recovery configurations)
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs
        /// Operation Id: DisasterRecoveryConfigs_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DisasterRecovery" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DisasterRecovery> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DisasterRecovery> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _disasterRecoveryDisasterRecoveryConfigsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecovery(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DisasterRecovery> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _disasterRecoveryDisasterRecoveryConfigsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecovery(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// Operation Id: DisasterRecoveryConfigs_Get
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string @alias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(@alias, nameof(@alias));

            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(alias, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// Operation Id: DisasterRecoveryConfigs_Get
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual Response<bool> Exists(string @alias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(@alias, nameof(@alias));

            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(alias, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// Operation Id: DisasterRecoveryConfigs_Get
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual async Task<Response<DisasterRecovery>> GetIfExistsAsync(string @alias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(@alias, nameof(@alias));

            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryDisasterRecoveryConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DisasterRecovery>(null, response.GetRawResponse());
                return Response.FromValue(new DisasterRecovery(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// Operation Id: DisasterRecoveryConfigs_Get
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual Response<DisasterRecovery> GetIfExists(string @alias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(@alias, nameof(@alias));

            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("DisasterRecoveryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _disasterRecoveryDisasterRecoveryConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DisasterRecovery>(null, response.GetRawResponse());
                return Response.FromValue(new DisasterRecovery(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DisasterRecovery> IEnumerable<DisasterRecovery>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DisasterRecovery> IAsyncEnumerable<DisasterRecovery>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
