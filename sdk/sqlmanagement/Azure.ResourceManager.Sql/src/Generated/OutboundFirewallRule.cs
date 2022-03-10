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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a OutboundFirewallRule along with the instance operations that can be performed on it. </summary>
    public partial class OutboundFirewallRule : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="OutboundFirewallRule"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string outboundRuleFqdn)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _outboundFirewallRuleClientDiagnostics;
        private readonly OutboundFirewallRulesRestOperations _outboundFirewallRuleRestClient;
        private readonly OutboundFirewallRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="OutboundFirewallRule"/> class for mocking. </summary>
        protected OutboundFirewallRule()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "OutboundFirewallRule"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal OutboundFirewallRule(ArmClient client, OutboundFirewallRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="OutboundFirewallRule"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal OutboundFirewallRule(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _outboundFirewallRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string outboundFirewallRuleApiVersion);
            _outboundFirewallRuleRestClient = new OutboundFirewallRulesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, outboundFirewallRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/outboundFirewallRules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual OutboundFirewallRuleData Data
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
        /// Gets an outbound firewall rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// Operation Id: OutboundFirewallRules_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<OutboundFirewallRule>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRule.Get");
            scope.Start();
            try
            {
                var response = await _outboundFirewallRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OutboundFirewallRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an outbound firewall rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// Operation Id: OutboundFirewallRules_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OutboundFirewallRule> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRule.Get");
            scope.Start();
            try
            {
                var response = _outboundFirewallRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OutboundFirewallRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a outbound firewall rule with a given name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// Operation Id: OutboundFirewallRules_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRule.Delete");
            scope.Start();
            try
            {
                var response = await _outboundFirewallRuleRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_outboundFirewallRuleClientDiagnostics, Pipeline, _outboundFirewallRuleRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes a outbound firewall rule with a given name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// Operation Id: OutboundFirewallRules_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRule.Delete");
            scope.Start();
            try
            {
                var response = _outboundFirewallRuleRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_outboundFirewallRuleClientDiagnostics, Pipeline, _outboundFirewallRuleRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
    }
}
