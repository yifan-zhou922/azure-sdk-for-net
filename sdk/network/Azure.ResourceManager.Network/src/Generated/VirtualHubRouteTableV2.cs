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
    /// <summary> A Class representing a VirtualHubRouteTableV2 along with the instance operations that can be performed on it. </summary>
    public partial class VirtualHubRouteTableV2 : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VirtualHubRouteTableV2"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualHubName, string routeTableName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeTables/{routeTableName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _virtualHubRouteTableV2ClientDiagnostics;
        private readonly VirtualHubRouteTableV2SRestOperations _virtualHubRouteTableV2RestClient;
        private readonly VirtualHubRouteTableV2Data _data;

        /// <summary> Initializes a new instance of the <see cref="VirtualHubRouteTableV2"/> class for mocking. </summary>
        protected VirtualHubRouteTableV2()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VirtualHubRouteTableV2"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal VirtualHubRouteTableV2(ArmClient client, VirtualHubRouteTableV2Data data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualHubRouteTableV2"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VirtualHubRouteTableV2(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualHubRouteTableV2ClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string virtualHubRouteTableV2ApiVersion);
            _virtualHubRouteTableV2RestClient = new VirtualHubRouteTableV2SRestOperations(_virtualHubRouteTableV2ClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualHubRouteTableV2ApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/virtualHubs/routeTables";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VirtualHubRouteTableV2Data Data
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
        /// Retrieves the details of a VirtualHubRouteTableV2.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeTables/{routeTableName}
        /// Operation Id: VirtualHubRouteTableV2s_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VirtualHubRouteTableV2>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2.Get");
            scope.Start();
            try
            {
                var response = await _virtualHubRouteTableV2RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _virtualHubRouteTableV2ClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualHubRouteTableV2(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a VirtualHubRouteTableV2.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeTables/{routeTableName}
        /// Operation Id: VirtualHubRouteTableV2s_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualHubRouteTableV2> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2.Get");
            scope.Start();
            try
            {
                var response = _virtualHubRouteTableV2RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _virtualHubRouteTableV2ClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualHubRouteTableV2(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a VirtualHubRouteTableV2.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeTables/{routeTableName}
        /// Operation Id: VirtualHubRouteTableV2s_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2.Delete");
            scope.Start();
            try
            {
                var response = await _virtualHubRouteTableV2RestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_virtualHubRouteTableV2ClientDiagnostics, Pipeline, _virtualHubRouteTableV2RestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes a VirtualHubRouteTableV2.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeTables/{routeTableName}
        /// Operation Id: VirtualHubRouteTableV2s_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualHubRouteTableV2ClientDiagnostics.CreateScope("VirtualHubRouteTableV2.Delete");
            scope.Start();
            try
            {
                var response = _virtualHubRouteTableV2RestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_virtualHubRouteTableV2ClientDiagnostics, Pipeline, _virtualHubRouteTableV2RestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
