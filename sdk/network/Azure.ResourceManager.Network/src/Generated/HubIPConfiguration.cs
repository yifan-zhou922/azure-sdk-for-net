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

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a HubIPConfiguration along with the instance operations that can be performed on it. </summary>
    public partial class HubIPConfiguration : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HubIPConfiguration"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualHubName, string ipConfigName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics;
        private readonly VirtualHubIpConfigurationRestOperations _hubIPConfigurationVirtualHubIpConfigurationRestClient;
        private readonly HubIPConfigurationData _data;

        /// <summary> Initializes a new instance of the <see cref="HubIPConfiguration"/> class for mocking. </summary>
        protected HubIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "HubIPConfiguration"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HubIPConfiguration(ArmClient client, HubIPConfigurationData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HubIPConfiguration"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HubIPConfiguration(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string hubIPConfigurationVirtualHubIpConfigurationApiVersion);
            _hubIPConfigurationVirtualHubIpConfigurationRestClient = new VirtualHubIpConfigurationRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, hubIPConfigurationVirtualHubIpConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/virtualHubs/ipConfigurations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HubIPConfigurationData Data
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
        /// Retrieves the details of a Virtual Hub Ip configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}
        /// Operation Id: VirtualHubIpConfiguration_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HubIPConfiguration>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfiguration.Get");
            scope.Start();
            try
            {
                var response = await _hubIPConfigurationVirtualHubIpConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HubIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a Virtual Hub Ip configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}
        /// Operation Id: VirtualHubIpConfiguration_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HubIPConfiguration> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfiguration.Get");
            scope.Start();
            try
            {
                var response = _hubIPConfigurationVirtualHubIpConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HubIPConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a VirtualHubIpConfiguration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}
        /// Operation Id: VirtualHubIpConfiguration_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfiguration.Delete");
            scope.Start();
            try
            {
                var response = await _hubIPConfigurationVirtualHubIpConfigurationRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics, Pipeline, _hubIPConfigurationVirtualHubIpConfigurationRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes a VirtualHubIpConfiguration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigName}
        /// Operation Id: VirtualHubIpConfiguration_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics.CreateScope("HubIPConfiguration.Delete");
            scope.Start();
            try
            {
                var response = _hubIPConfigurationVirtualHubIpConfigurationRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_hubIPConfigurationVirtualHubIpConfigurationClientDiagnostics, Pipeline, _hubIPConfigurationVirtualHubIpConfigurationRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
