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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a ManagedRestorableDroppedDbBackupShortTermRetentionPolicy along with the instance operations that can be performed on it. </summary>
    public partial class ManagedRestorableDroppedDbBackupShortTermRetentionPolicy : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicy"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId, string policyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics;
        private readonly ManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestOperations _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient;
        private readonly ManagedBackupShortTermRetentionPolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicy"/> class for mocking. </summary>
        protected ManagedRestorableDroppedDbBackupShortTermRetentionPolicy()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedRestorableDroppedDbBackupShortTermRetentionPolicy"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedRestorableDroppedDbBackupShortTermRetentionPolicy(ArmClient client, ManagedBackupShortTermRetentionPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicy"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedRestorableDroppedDbBackupShortTermRetentionPolicy(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesApiVersion);
            _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient = new ManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/restorableDroppedDatabases/backupShortTermRetentionPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedBackupShortTermRetentionPolicyData Data
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
        /// Gets a dropped database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedRestorableDroppedDbBackupShortTermRetentionPolicy>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicy.Get");
            scope.Start();
            try
            {
                var response = await _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a dropped database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedRestorableDroppedDbBackupShortTermRetentionPolicy> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicy.Get");
            scope.Start();
            try
            {
                var response = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Sets a database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Update
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="parameters"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicy>> UpdateAsync(WaitUntil waitUntil, ManagedBackupShortTermRetentionPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicy.Update");
            scope.Start();
            try
            {
                var response = await _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicy>(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyOperationSource(Client), _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Sets a database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Update
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="parameters"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicy> Update(WaitUntil waitUntil, ManagedBackupShortTermRetentionPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicy.Update");
            scope.Start();
            try
            {
                var response = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken);
                var operation = new SqlArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicy>(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyOperationSource(Client), _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters).Request, response, OperationFinalStateVia.Location);
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
    }
}
