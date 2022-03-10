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
    /// <summary> A Class representing a ResourceGroupLongTermRetentionManagedInstanceBackup along with the instance operations that can be performed on it. </summary>
    public partial class ResourceGroupLongTermRetentionManagedInstanceBackup : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceGroupLongTermRetentionManagedInstanceBackup"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string locationName, string managedInstanceName, string databaseName, string backupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics;
        private readonly LongTermRetentionManagedInstanceBackupsRestOperations _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient;
        private readonly ManagedInstanceLongTermRetentionBackupData _data;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLongTermRetentionManagedInstanceBackup"/> class for mocking. </summary>
        protected ResourceGroupLongTermRetentionManagedInstanceBackup()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResourceGroupLongTermRetentionManagedInstanceBackup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceGroupLongTermRetentionManagedInstanceBackup(ArmClient client, ManagedInstanceLongTermRetentionBackupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLongTermRetentionManagedInstanceBackup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupLongTermRetentionManagedInstanceBackup(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsApiVersion);
            _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient = new LongTermRetentionManagedInstanceBackupsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/locations/longTermRetentionManagedInstances/longTermRetentionDatabases/longTermRetentionManagedInstanceBackups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedInstanceLongTermRetentionBackupData Data
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
        /// Gets a long term retention backup for a managed database.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// Operation Id: LongTermRetentionManagedInstanceBackups_GetByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceGroupLongTermRetentionManagedInstanceBackup>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackup.Get");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupLongTermRetentionManagedInstanceBackup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a long term retention backup for a managed database.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// Operation Id: LongTermRetentionManagedInstanceBackups_GetByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceGroupLongTermRetentionManagedInstanceBackup> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackup.Get");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupLongTermRetentionManagedInstanceBackup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// Operation Id: LongTermRetentionManagedInstanceBackups_DeleteByResourceGroup
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackup.Delete");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.DeleteByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.CreateDeleteByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes a long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// Operation Id: LongTermRetentionManagedInstanceBackups_DeleteByResourceGroup
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackup.Delete");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.DeleteByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.CreateDeleteByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
