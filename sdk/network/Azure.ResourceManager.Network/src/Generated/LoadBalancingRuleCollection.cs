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
    /// <summary> A class representing collection of LoadBalancingRule and their operations over its parent. </summary>
    public partial class LoadBalancingRuleCollection : ArmCollection, IEnumerable<LoadBalancingRule>, IAsyncEnumerable<LoadBalancingRule>
    {
        private readonly ClientDiagnostics _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics;
        private readonly LoadBalancerLoadBalancingRulesRestOperations _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="LoadBalancingRuleCollection"/> class for mocking. </summary>
        protected LoadBalancingRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LoadBalancingRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LoadBalancingRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", LoadBalancingRule.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(LoadBalancingRule.ResourceType, out string loadBalancingRuleLoadBalancerLoadBalancingRulesApiVersion);
            _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient = new LoadBalancerLoadBalancingRulesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, loadBalancingRuleLoadBalancerLoadBalancingRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LoadBalancer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LoadBalancer.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified load balancer load balancing rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules/{loadBalancingRuleName}
        /// Operation Id: LoadBalancerLoadBalancingRules_Get
        /// </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public virtual async Task<Response<LoadBalancingRule>> GetAsync(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancingRuleName, nameof(loadBalancingRuleName));

            using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loadBalancingRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadBalancingRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified load balancer load balancing rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules/{loadBalancingRuleName}
        /// Operation Id: LoadBalancerLoadBalancingRules_Get
        /// </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public virtual Response<LoadBalancingRule> Get(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancingRuleName, nameof(loadBalancingRuleName));

            using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loadBalancingRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadBalancingRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the load balancing rules in a load balancer.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules
        /// Operation Id: LoadBalancerLoadBalancingRules_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LoadBalancingRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LoadBalancingRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<LoadBalancingRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancingRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LoadBalancingRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancingRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all the load balancing rules in a load balancer.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules
        /// Operation Id: LoadBalancerLoadBalancingRules_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LoadBalancingRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LoadBalancingRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<LoadBalancingRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancingRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LoadBalancingRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancingRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules/{loadBalancingRuleName}
        /// Operation Id: LoadBalancerLoadBalancingRules_Get
        /// </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancingRuleName, nameof(loadBalancingRuleName));

            using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(loadBalancingRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules/{loadBalancingRuleName}
        /// Operation Id: LoadBalancerLoadBalancingRules_Get
        /// </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancingRuleName, nameof(loadBalancingRuleName));

            using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(loadBalancingRuleName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules/{loadBalancingRuleName}
        /// Operation Id: LoadBalancerLoadBalancingRules_Get
        /// </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public virtual async Task<Response<LoadBalancingRule>> GetIfExistsAsync(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancingRuleName, nameof(loadBalancingRuleName));

            using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loadBalancingRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<LoadBalancingRule>(null, response.GetRawResponse());
                return Response.FromValue(new LoadBalancingRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules/{loadBalancingRuleName}
        /// Operation Id: LoadBalancerLoadBalancingRules_Get
        /// </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public virtual Response<LoadBalancingRule> GetIfExists(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancingRuleName, nameof(loadBalancingRuleName));

            using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loadBalancingRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<LoadBalancingRule>(null, response.GetRawResponse());
                return Response.FromValue(new LoadBalancingRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LoadBalancingRule> IEnumerable<LoadBalancingRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LoadBalancingRule> IAsyncEnumerable<LoadBalancingRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
