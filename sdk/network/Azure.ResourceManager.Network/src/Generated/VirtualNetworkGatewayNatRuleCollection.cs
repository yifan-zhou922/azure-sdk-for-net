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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualNetworkGatewayNatRule and their operations over its parent. </summary>
    public partial class VirtualNetworkGatewayNatRuleCollection : ArmCollection, IEnumerable<VirtualNetworkGatewayNatRule>, IAsyncEnumerable<VirtualNetworkGatewayNatRule>
    {
        private readonly ClientDiagnostics _virtualNetworkGatewayNatRuleClientDiagnostics;
        private readonly VirtualNetworkGatewayNatRulesRestOperations _virtualNetworkGatewayNatRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayNatRuleCollection"/> class for mocking. </summary>
        protected VirtualNetworkGatewayNatRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayNatRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualNetworkGatewayNatRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualNetworkGatewayNatRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualNetworkGatewayNatRule.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(VirtualNetworkGatewayNatRule.ResourceType, out string virtualNetworkGatewayNatRuleApiVersion);
            _virtualNetworkGatewayNatRuleRestClient = new VirtualNetworkGatewayNatRulesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualNetworkGatewayNatRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualNetworkGateway.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualNetworkGateway.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a nat rule to a scalable virtual network gateway if it doesn&apos;t exist else updates the existing nat rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}/natRules/{natRuleName}
        /// Operation Id: VirtualNetworkGatewayNatRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="natRuleParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualNetworkGatewayNatRule>> CreateOrUpdateAsync(WaitUntil waitUntil, string natRuleName, VirtualNetworkGatewayNatRuleData natRuleParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));
            Argument.AssertNotNull(natRuleParameters, nameof(natRuleParameters));

            using var scope = _virtualNetworkGatewayNatRuleClientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayNatRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VirtualNetworkGatewayNatRule>(new VirtualNetworkGatewayNatRuleOperationSource(Client), _virtualNetworkGatewayNatRuleClientDiagnostics, Pipeline, _virtualNetworkGatewayNatRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a nat rule to a scalable virtual network gateway if it doesn&apos;t exist else updates the existing nat rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}/natRules/{natRuleName}
        /// Operation Id: VirtualNetworkGatewayNatRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="natRuleParameters"/> is null. </exception>
        public virtual ArmOperation<VirtualNetworkGatewayNatRule> CreateOrUpdate(WaitUntil waitUntil, string natRuleName, VirtualNetworkGatewayNatRuleData natRuleParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));
            Argument.AssertNotNull(natRuleParameters, nameof(natRuleParameters));

            using var scope = _virtualNetworkGatewayNatRuleClientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayNatRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters, cancellationToken);
                var operation = new NetworkArmOperation<VirtualNetworkGatewayNatRule>(new VirtualNetworkGatewayNatRuleOperationSource(Client), _virtualNetworkGatewayNatRuleClientDiagnostics, Pipeline, _virtualNetworkGatewayNatRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a nat rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}/natRules/{natRuleName}
        /// Operation Id: VirtualNetworkGatewayNatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual async Task<Response<VirtualNetworkGatewayNatRule>> GetAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _virtualNetworkGatewayNatRuleClientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayNatRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayNatRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a nat rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}/natRules/{natRuleName}
        /// Operation Id: VirtualNetworkGatewayNatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<VirtualNetworkGatewayNatRule> Get(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _virtualNetworkGatewayNatRuleClientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayNatRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayNatRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves all nat rules for a particular virtual network gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}/natRules
        /// Operation Id: VirtualNetworkGatewayNatRules_ListByVirtualNetworkGateway
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkGatewayNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkGatewayNatRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetworkGatewayNatRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualNetworkGatewayNatRuleClientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkGatewayNatRuleRestClient.ListByVirtualNetworkGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetworkGatewayNatRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualNetworkGatewayNatRuleClientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkGatewayNatRuleRestClient.ListByVirtualNetworkGatewayNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Retrieves all nat rules for a particular virtual network gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}/natRules
        /// Operation Id: VirtualNetworkGatewayNatRules_ListByVirtualNetworkGateway
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkGatewayNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkGatewayNatRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetworkGatewayNatRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualNetworkGatewayNatRuleClientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkGatewayNatRuleRestClient.ListByVirtualNetworkGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetworkGatewayNatRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualNetworkGatewayNatRuleClientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkGatewayNatRuleRestClient.ListByVirtualNetworkGatewayNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}/natRules/{natRuleName}
        /// Operation Id: VirtualNetworkGatewayNatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _virtualNetworkGatewayNatRuleClientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(natRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}/natRules/{natRuleName}
        /// Operation Id: VirtualNetworkGatewayNatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _virtualNetworkGatewayNatRuleClientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(natRuleName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}/natRules/{natRuleName}
        /// Operation Id: VirtualNetworkGatewayNatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual async Task<Response<VirtualNetworkGatewayNatRule>> GetIfExistsAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _virtualNetworkGatewayNatRuleClientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayNatRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualNetworkGatewayNatRule>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayNatRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}/natRules/{natRuleName}
        /// Operation Id: VirtualNetworkGatewayNatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<VirtualNetworkGatewayNatRule> GetIfExists(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _virtualNetworkGatewayNatRuleClientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayNatRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualNetworkGatewayNatRule>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayNatRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualNetworkGatewayNatRule> IEnumerable<VirtualNetworkGatewayNatRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetworkGatewayNatRule> IAsyncEnumerable<VirtualNetworkGatewayNatRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
