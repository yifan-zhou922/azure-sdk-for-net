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

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A Class representing a GuestAgent along with the instance operations that can be performed on it. </summary>
    public partial class GuestAgent : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GuestAgent"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualMachineName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/guestAgents/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _guestAgentClientDiagnostics;
        private readonly GuestAgentsRestOperations _guestAgentRestClient;
        private readonly GuestAgentData _data;

        /// <summary> Initializes a new instance of the <see cref="GuestAgent"/> class for mocking. </summary>
        protected GuestAgent()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "GuestAgent"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GuestAgent(ArmClient client, GuestAgentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GuestAgent"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GuestAgent(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _guestAgentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string guestAgentApiVersion);
            _guestAgentRestClient = new GuestAgentsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, guestAgentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ConnectedVMwarevSphere/virtualMachines/guestAgents";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GuestAgentData Data
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
        /// Implements GuestAgent GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/guestAgents/{name}
        /// Operation Id: GuestAgents_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GuestAgent>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _guestAgentClientDiagnostics.CreateScope("GuestAgent.Get");
            scope.Start();
            try
            {
                var response = await _guestAgentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuestAgent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements GuestAgent GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/guestAgents/{name}
        /// Operation Id: GuestAgents_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GuestAgent> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _guestAgentClientDiagnostics.CreateScope("GuestAgent.Get");
            scope.Start();
            try
            {
                var response = _guestAgentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuestAgent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements GuestAgent DELETE method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/guestAgents/{name}
        /// Operation Id: GuestAgents_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _guestAgentClientDiagnostics.CreateScope("GuestAgent.Delete");
            scope.Start();
            try
            {
                var response = await _guestAgentRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation(_guestAgentClientDiagnostics, Pipeline, _guestAgentRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
        /// Implements GuestAgent DELETE method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/guestAgents/{name}
        /// Operation Id: GuestAgents_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _guestAgentClientDiagnostics.CreateScope("GuestAgent.Delete");
            scope.Start();
            try
            {
                var response = _guestAgentRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation(_guestAgentClientDiagnostics, Pipeline, _guestAgentRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
