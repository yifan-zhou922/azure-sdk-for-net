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

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of VirtualMachineRunCommand and their operations over its parent. </summary>
    public partial class VirtualMachineRunCommandCollection : ArmCollection, IEnumerable<VirtualMachineRunCommand>, IAsyncEnumerable<VirtualMachineRunCommand>
    {
        private readonly ClientDiagnostics _virtualMachineRunCommandClientDiagnostics;
        private readonly VirtualMachineRunCommandsRestOperations _virtualMachineRunCommandRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineRunCommandCollection"/> class for mocking. </summary>
        protected VirtualMachineRunCommandCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineRunCommandCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualMachineRunCommandCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualMachineRunCommandClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", VirtualMachineRunCommand.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(VirtualMachineRunCommand.ResourceType, out string virtualMachineRunCommandApiVersion);
            _virtualMachineRunCommandRestClient = new VirtualMachineRunCommandsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualMachineRunCommandApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualMachine.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualMachine.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update the run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineRunCommands_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="runCommand"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="runCommand"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualMachineRunCommand>> CreateOrUpdateAsync(WaitUntil waitUntil, string runCommandName, VirtualMachineRunCommandData runCommand, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));
            Argument.AssertNotNull(runCommand, nameof(runCommand));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineRunCommandRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, runCommand, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<VirtualMachineRunCommand>(new VirtualMachineRunCommandOperationSource(Client), _virtualMachineRunCommandClientDiagnostics, Pipeline, _virtualMachineRunCommandRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, runCommand).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create or update the run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineRunCommands_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="runCommand"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> or <paramref name="runCommand"/> is null. </exception>
        public virtual ArmOperation<VirtualMachineRunCommand> CreateOrUpdate(WaitUntil waitUntil, string runCommandName, VirtualMachineRunCommandData runCommand, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));
            Argument.AssertNotNull(runCommand, nameof(runCommand));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineRunCommandRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, runCommand, cancellationToken);
                var operation = new ComputeArmOperation<VirtualMachineRunCommand>(new VirtualMachineRunCommandOperationSource(Client), _virtualMachineRunCommandClientDiagnostics, Pipeline, _virtualMachineRunCommandRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, runCommand).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to get the run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineRunCommands_GetByVirtualMachine
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual async Task<Response<VirtualMachineRunCommand>> GetAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineRunCommandRestClient.GetByVirtualMachineAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineRunCommand(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the run command.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineRunCommands_GetByVirtualMachine
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<VirtualMachineRunCommand> Get(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineRunCommandRestClient.GetByVirtualMachine(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineRunCommand(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get all run commands of a Virtual Machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands
        /// Operation Id: VirtualMachineRunCommands_ListByVirtualMachine
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineRunCommand" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineRunCommand> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineRunCommand>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineRunCommandRestClient.ListByVirtualMachineAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineRunCommand(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachineRunCommand>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineRunCommandRestClient.ListByVirtualMachineNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineRunCommand(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// The operation to get all run commands of a Virtual Machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands
        /// Operation Id: VirtualMachineRunCommands_ListByVirtualMachine
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineRunCommand" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineRunCommand> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineRunCommand> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineRunCommandRestClient.ListByVirtualMachine(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineRunCommand(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachineRunCommand> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineRunCommandRestClient.ListByVirtualMachineNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineRunCommand(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineRunCommands_GetByVirtualMachine
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(runCommandName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineRunCommands_GetByVirtualMachine
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<bool> Exists(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(runCommandName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineRunCommands_GetByVirtualMachine
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual async Task<Response<VirtualMachineRunCommand>> GetIfExistsAsync(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineRunCommandRestClient.GetByVirtualMachineAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineRunCommand>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineRunCommand(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/runCommands/{runCommandName}
        /// Operation Id: VirtualMachineRunCommands_GetByVirtualMachine
        /// </summary>
        /// <param name="runCommandName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runCommandName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runCommandName"/> is null. </exception>
        public virtual Response<VirtualMachineRunCommand> GetIfExists(string runCommandName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runCommandName, nameof(runCommandName));

            using var scope = _virtualMachineRunCommandClientDiagnostics.CreateScope("VirtualMachineRunCommandCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineRunCommandRestClient.GetByVirtualMachine(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runCommandName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineRunCommand>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineRunCommand(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachineRunCommand> IEnumerable<VirtualMachineRunCommand>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineRunCommand> IAsyncEnumerable<VirtualMachineRunCommand>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
