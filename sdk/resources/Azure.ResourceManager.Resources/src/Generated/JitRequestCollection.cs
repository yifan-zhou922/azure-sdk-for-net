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

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of JitRequest and their operations over its parent. </summary>
    public partial class JitRequestCollection : ArmCollection, IEnumerable<JitRequest>, IAsyncEnumerable<JitRequest>
    {
        private readonly ClientDiagnostics _jitRequestClientDiagnostics;
        private readonly JitRequestsRestOperations _jitRequestRestClient;

        /// <summary> Initializes a new instance of the <see cref="JitRequestCollection"/> class for mocking. </summary>
        protected JitRequestCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="JitRequestCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal JitRequestCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _jitRequestClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", JitRequest.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(JitRequest.ResourceType, out string jitRequestApiVersion);
            _jitRequestRestClient = new JitRequestsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, jitRequestApiVersion);
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
        /// Creates or updates the JIT request.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}
        /// Operation Id: JitRequests_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="parameters"> Parameters supplied to the update JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<JitRequest>> CreateOrUpdateAsync(WaitUntil waitUntil, string jitRequestName, JitRequestData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jitRequestName, nameof(jitRequestName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _jitRequestRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<JitRequest>(new JitRequestOperationSource(Client), _jitRequestClientDiagnostics, Pipeline, _jitRequestRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates the JIT request.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}
        /// Operation Id: JitRequests_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="parameters"> Parameters supplied to the update JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<JitRequest> CreateOrUpdate(WaitUntil waitUntil, string jitRequestName, JitRequestData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jitRequestName, nameof(jitRequestName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _jitRequestRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, parameters, cancellationToken);
                var operation = new ResourcesArmOperation<JitRequest>(new JitRequestOperationSource(Client), _jitRequestClientDiagnostics, Pipeline, _jitRequestRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the JIT request.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}
        /// Operation Id: JitRequests_Get
        /// </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> is null. </exception>
        public virtual async Task<Response<JitRequest>> GetAsync(string jitRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jitRequestName, nameof(jitRequestName));

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.Get");
            scope.Start();
            try
            {
                var response = await _jitRequestRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JitRequest(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the JIT request.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}
        /// Operation Id: JitRequests_Get
        /// </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> is null. </exception>
        public virtual Response<JitRequest> Get(string jitRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jitRequestName, nameof(jitRequestName));

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.Get");
            scope.Start();
            try
            {
                var response = _jitRequestRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JitRequest(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves all JIT requests within the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests
        /// Operation Id: JitRequests_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JitRequest" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JitRequest> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<JitRequest>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jitRequestRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JitRequest(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Retrieves all JIT requests within the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests
        /// Operation Id: JitRequests_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JitRequest" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JitRequest> GetAll(CancellationToken cancellationToken = default)
        {
            Page<JitRequest> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jitRequestRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JitRequest(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}
        /// Operation Id: JitRequests_Get
        /// </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string jitRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jitRequestName, nameof(jitRequestName));

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(jitRequestName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}
        /// Operation Id: JitRequests_Get
        /// </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> is null. </exception>
        public virtual Response<bool> Exists(string jitRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jitRequestName, nameof(jitRequestName));

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(jitRequestName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}
        /// Operation Id: JitRequests_Get
        /// </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> is null. </exception>
        public virtual async Task<Response<JitRequest>> GetIfExistsAsync(string jitRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jitRequestName, nameof(jitRequestName));

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _jitRequestRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<JitRequest>(null, response.GetRawResponse());
                return Response.FromValue(new JitRequest(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}
        /// Operation Id: JitRequests_Get
        /// </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> is null. </exception>
        public virtual Response<JitRequest> GetIfExists(string jitRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jitRequestName, nameof(jitRequestName));

            using var scope = _jitRequestClientDiagnostics.CreateScope("JitRequestCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _jitRequestRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, jitRequestName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<JitRequest>(null, response.GetRawResponse());
                return Response.FromValue(new JitRequest(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<JitRequest> IEnumerable<JitRequest>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<JitRequest> IAsyncEnumerable<JitRequest>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
