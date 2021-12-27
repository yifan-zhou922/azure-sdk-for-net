// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    /// <summary> A class representing collection of ManagedServerSecurityAlertPolicy and their operations over its parent. </summary>
    public partial class ManagedServerSecurityAlertPolicyCollection : ArmCollection, IEnumerable<ManagedServerSecurityAlertPolicy>, IAsyncEnumerable<ManagedServerSecurityAlertPolicy>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagedServerSecurityAlertPoliciesRestOperations _managedServerSecurityAlertPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedServerSecurityAlertPolicyCollection"/> class for mocking. </summary>
        protected ManagedServerSecurityAlertPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of ManagedServerSecurityAlertPolicyCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagedServerSecurityAlertPolicyCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedServerSecurityAlertPoliciesRestClient = new ManagedServerSecurityAlertPoliciesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ManagedInstance.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/securityAlertPolicies/{securityAlertPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedServerSecurityAlertPolicies_CreateOrUpdate
        /// <summary> Creates or updates a threat detection policy. </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="parameters"> The managed server security alert policy. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ManagedServerSecurityAlertPolicyCreateOrUpdateOperation CreateOrUpdate(SecurityAlertPolicyName securityAlertPolicyName, ManagedServerSecurityAlertPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedServerSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedServerSecurityAlertPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, parameters, cancellationToken);
                var operation = new ManagedServerSecurityAlertPolicyCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _managedServerSecurityAlertPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/securityAlertPolicies/{securityAlertPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedServerSecurityAlertPolicies_CreateOrUpdate
        /// <summary> Creates or updates a threat detection policy. </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="parameters"> The managed server security alert policy. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ManagedServerSecurityAlertPolicyCreateOrUpdateOperation> CreateOrUpdateAsync(SecurityAlertPolicyName securityAlertPolicyName, ManagedServerSecurityAlertPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedServerSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedServerSecurityAlertPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedServerSecurityAlertPolicyCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _managedServerSecurityAlertPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/securityAlertPolicies/{securityAlertPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedServerSecurityAlertPolicies_Get
        /// <summary> Get a managed server&apos;s threat detection policy. </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedServerSecurityAlertPolicy> Get(SecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedServerSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _managedServerSecurityAlertPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedServerSecurityAlertPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/securityAlertPolicies/{securityAlertPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedServerSecurityAlertPolicies_Get
        /// <summary> Get a managed server&apos;s threat detection policy. </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedServerSecurityAlertPolicy>> GetAsync(SecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedServerSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedServerSecurityAlertPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedServerSecurityAlertPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedServerSecurityAlertPolicy> GetIfExists(SecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedServerSecurityAlertPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedServerSecurityAlertPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ManagedServerSecurityAlertPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagedServerSecurityAlertPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedServerSecurityAlertPolicy>> GetIfExistsAsync(SecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedServerSecurityAlertPolicyCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _managedServerSecurityAlertPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ManagedServerSecurityAlertPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagedServerSecurityAlertPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedServerSecurityAlertPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(securityAlertPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> ExistsAsync(SecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedServerSecurityAlertPolicyCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(securityAlertPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/securityAlertPolicies
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedServerSecurityAlertPolicies_ListByInstance
        /// <summary> Get the managed server&apos;s threat detection policies. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedServerSecurityAlertPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedServerSecurityAlertPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ManagedServerSecurityAlertPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedServerSecurityAlertPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedServerSecurityAlertPoliciesRestClient.ListByInstance(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedServerSecurityAlertPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedServerSecurityAlertPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedServerSecurityAlertPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedServerSecurityAlertPoliciesRestClient.ListByInstanceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedServerSecurityAlertPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/securityAlertPolicies
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: ManagedServerSecurityAlertPolicies_ListByInstance
        /// <summary> Get the managed server&apos;s threat detection policies. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedServerSecurityAlertPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedServerSecurityAlertPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedServerSecurityAlertPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedServerSecurityAlertPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedServerSecurityAlertPoliciesRestClient.ListByInstanceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedServerSecurityAlertPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedServerSecurityAlertPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedServerSecurityAlertPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedServerSecurityAlertPoliciesRestClient.ListByInstanceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedServerSecurityAlertPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ManagedServerSecurityAlertPolicy> IEnumerable<ManagedServerSecurityAlertPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedServerSecurityAlertPolicy> IAsyncEnumerable<ManagedServerSecurityAlertPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ManagedServerSecurityAlertPolicy, ManagedServerSecurityAlertPolicyData> Construct() { }
    }
}
