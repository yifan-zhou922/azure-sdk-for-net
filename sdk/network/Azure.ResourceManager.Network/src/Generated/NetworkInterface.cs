// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a NetworkInterface along with the instance operations that can be performed on it. </summary>
    public partial class NetworkInterface : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NetworkInterface"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string networkInterfaceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _networkInterfaceClientDiagnostics;
        private readonly NetworkInterfacesRestOperations _networkInterfaceRestClient;
        private readonly ClientDiagnostics _networkInterfaceLoadBalancersClientDiagnostics;
        private readonly NetworkInterfaceLoadBalancersRestOperations _networkInterfaceLoadBalancersRestClient;
        private readonly NetworkInterfaceData _data;

        /// <summary> Initializes a new instance of the <see cref="NetworkInterface"/> class for mocking. </summary>
        protected NetworkInterface()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NetworkInterface"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NetworkInterface(ArmClient client, NetworkInterfaceData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkInterface"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NetworkInterface(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkInterfaceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string networkInterfaceApiVersion);
            _networkInterfaceRestClient = new NetworkInterfacesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, networkInterfaceApiVersion);
            _networkInterfaceLoadBalancersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
            _networkInterfaceLoadBalancersRestClient = new NetworkInterfaceLoadBalancersRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/networkInterfaces";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NetworkInterfaceData Data
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

        /// <summary> Gets a collection of NetworkInterfaceIPConfigurations in the NetworkInterfaceIPConfiguration. </summary>
        /// <returns> An object representing collection of NetworkInterfaceIPConfigurations and their operations over a NetworkInterfaceIPConfiguration. </returns>
        public virtual NetworkInterfaceIPConfigurationCollection GetNetworkInterfaceIPConfigurations()
        {
            return new NetworkInterfaceIPConfigurationCollection(Client, Id);
        }

        /// <summary> Gets a collection of NetworkInterfaceTapConfigurations in the NetworkInterfaceTapConfiguration. </summary>
        /// <returns> An object representing collection of NetworkInterfaceTapConfigurations and their operations over a NetworkInterfaceTapConfiguration. </returns>
        public virtual NetworkInterfaceTapConfigurationCollection GetNetworkInterfaceTapConfigurations()
        {
            return new NetworkInterfaceTapConfigurationCollection(Client, Id);
        }

        /// <summary>
        /// Gets information about the specified network interface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}
        /// Operation Id: NetworkInterfaces_Get
        /// </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkInterface>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterface.Get");
            scope.Start();
            try
            {
                var response = await _networkInterfaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkInterface(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified network interface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}
        /// Operation Id: NetworkInterfaces_Get
        /// </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkInterface> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterface.Get");
            scope.Start();
            try
            {
                var response = _networkInterfaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkInterface(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified network interface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}
        /// Operation Id: NetworkInterfaces_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterface.Delete");
            scope.Start();
            try
            {
                var response = await _networkInterfaceRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_networkInterfaceClientDiagnostics, Pipeline, _networkInterfaceRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes the specified network interface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}
        /// Operation Id: NetworkInterfaces_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterface.Delete");
            scope.Start();
            try
            {
                var response = _networkInterfaceRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_networkInterfaceClientDiagnostics, Pipeline, _networkInterfaceRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Gets all route tables applied to a network interface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/effectiveRouteTable
        /// Operation Id: NetworkInterfaces_GetEffectiveRouteTable
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<EffectiveRouteListResult>> GetEffectiveRouteTableAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterface.GetEffectiveRouteTable");
            scope.Start();
            try
            {
                var response = await _networkInterfaceRestClient.GetEffectiveRouteTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<EffectiveRouteListResult>(new EffectiveRouteListResultOperationSource(), _networkInterfaceClientDiagnostics, Pipeline, _networkInterfaceRestClient.CreateGetEffectiveRouteTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Gets all route tables applied to a network interface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/effectiveRouteTable
        /// Operation Id: NetworkInterfaces_GetEffectiveRouteTable
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<EffectiveRouteListResult> GetEffectiveRouteTable(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterface.GetEffectiveRouteTable");
            scope.Start();
            try
            {
                var response = _networkInterfaceRestClient.GetEffectiveRouteTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation<EffectiveRouteListResult>(new EffectiveRouteListResultOperationSource(), _networkInterfaceClientDiagnostics, Pipeline, _networkInterfaceRestClient.CreateGetEffectiveRouteTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Gets all network security groups applied to a network interface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/effectiveNetworkSecurityGroups
        /// Operation Id: NetworkInterfaces_ListEffectiveNetworkSecurityGroups
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<EffectiveNetworkSecurityGroupListResult>> GetEffectiveNetworkSecurityGroupsAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterface.GetEffectiveNetworkSecurityGroups");
            scope.Start();
            try
            {
                var response = await _networkInterfaceRestClient.ListEffectiveNetworkSecurityGroupsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<EffectiveNetworkSecurityGroupListResult>(new EffectiveNetworkSecurityGroupListResultOperationSource(), _networkInterfaceClientDiagnostics, Pipeline, _networkInterfaceRestClient.CreateListEffectiveNetworkSecurityGroupsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Gets all network security groups applied to a network interface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/effectiveNetworkSecurityGroups
        /// Operation Id: NetworkInterfaces_ListEffectiveNetworkSecurityGroups
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<EffectiveNetworkSecurityGroupListResult> GetEffectiveNetworkSecurityGroups(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterface.GetEffectiveNetworkSecurityGroups");
            scope.Start();
            try
            {
                var response = _networkInterfaceRestClient.ListEffectiveNetworkSecurityGroups(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation<EffectiveNetworkSecurityGroupListResult>(new EffectiveNetworkSecurityGroupListResultOperationSource(), _networkInterfaceClientDiagnostics, Pipeline, _networkInterfaceRestClient.CreateListEffectiveNetworkSecurityGroupsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// List all load balancers in a network interface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/loadBalancers
        /// Operation Id: NetworkInterfaceLoadBalancers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LoadBalancer" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LoadBalancer> GetNetworkInterfaceLoadBalancersAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<LoadBalancer>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkInterfaceLoadBalancersClientDiagnostics.CreateScope("NetworkInterface.GetNetworkInterfaceLoadBalancers");
                scope.Start();
                try
                {
                    var response = await _networkInterfaceLoadBalancersRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancer(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LoadBalancer>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _networkInterfaceLoadBalancersClientDiagnostics.CreateScope("NetworkInterface.GetNetworkInterfaceLoadBalancers");
                scope.Start();
                try
                {
                    var response = await _networkInterfaceLoadBalancersRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancer(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List all load balancers in a network interface.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}/loadBalancers
        /// Operation Id: NetworkInterfaceLoadBalancers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LoadBalancer" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LoadBalancer> GetNetworkInterfaceLoadBalancers(CancellationToken cancellationToken = default)
        {
            Page<LoadBalancer> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkInterfaceLoadBalancersClientDiagnostics.CreateScope("NetworkInterface.GetNetworkInterfaceLoadBalancers");
                scope.Start();
                try
                {
                    var response = _networkInterfaceLoadBalancersRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancer(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LoadBalancer> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _networkInterfaceLoadBalancersClientDiagnostics.CreateScope("NetworkInterface.GetNetworkInterfaceLoadBalancers");
                scope.Start();
                try
                {
                    var response = _networkInterfaceLoadBalancersRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancer(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}
        /// Operation Id: NetworkInterfaces_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<NetworkInterface>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterface.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _networkInterfaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new NetworkInterface(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}
        /// Operation Id: NetworkInterfaces_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<NetworkInterface> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterface.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _networkInterfaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new NetworkInterface(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}
        /// Operation Id: NetworkInterfaces_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<NetworkInterface>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterface.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _networkInterfaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new NetworkInterface(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}
        /// Operation Id: NetworkInterfaces_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<NetworkInterface> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterface.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _networkInterfaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new NetworkInterface(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}
        /// Operation Id: NetworkInterfaces_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<NetworkInterface>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterface.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _networkInterfaceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new NetworkInterface(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}
        /// Operation Id: NetworkInterfaces_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<NetworkInterface> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _networkInterfaceClientDiagnostics.CreateScope("NetworkInterface.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _networkInterfaceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new NetworkInterface(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
