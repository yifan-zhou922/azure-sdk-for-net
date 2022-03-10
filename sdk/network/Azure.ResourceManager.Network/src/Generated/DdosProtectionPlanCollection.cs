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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of DdosProtectionPlan and their operations over its parent. </summary>
    public partial class DdosProtectionPlanCollection : ArmCollection, IEnumerable<DdosProtectionPlan>, IAsyncEnumerable<DdosProtectionPlan>
    {
        private readonly ClientDiagnostics _ddosProtectionPlanClientDiagnostics;
        private readonly DdosProtectionPlansRestOperations _ddosProtectionPlanRestClient;

        /// <summary> Initializes a new instance of the <see cref="DdosProtectionPlanCollection"/> class for mocking. </summary>
        protected DdosProtectionPlanCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DdosProtectionPlanCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DdosProtectionPlanCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _ddosProtectionPlanClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", DdosProtectionPlan.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(DdosProtectionPlan.ResourceType, out string ddosProtectionPlanApiVersion);
            _ddosProtectionPlanRestClient = new DdosProtectionPlansRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, ddosProtectionPlanApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a DDoS protection plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans/{ddosProtectionPlanName}
        /// Operation Id: DdosProtectionPlans_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosProtectionPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<DdosProtectionPlan>> CreateOrUpdateAsync(bool waitForCompletion, string ddosProtectionPlanName, DdosProtectionPlanData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosProtectionPlanName, nameof(ddosProtectionPlanName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ddosProtectionPlanRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<DdosProtectionPlan>(new DdosProtectionPlanOperationSource(Client), _ddosProtectionPlanClientDiagnostics, Pipeline, _ddosProtectionPlanRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a DDoS protection plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans/{ddosProtectionPlanName}
        /// Operation Id: DdosProtectionPlans_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosProtectionPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<DdosProtectionPlan> CreateOrUpdate(bool waitForCompletion, string ddosProtectionPlanName, DdosProtectionPlanData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosProtectionPlanName, nameof(ddosProtectionPlanName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ddosProtectionPlanRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<DdosProtectionPlan>(new DdosProtectionPlanOperationSource(Client), _ddosProtectionPlanClientDiagnostics, Pipeline, _ddosProtectionPlanRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified DDoS protection plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans/{ddosProtectionPlanName}
        /// Operation Id: DdosProtectionPlans_Get
        /// </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosProtectionPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public virtual async Task<Response<DdosProtectionPlan>> GetAsync(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosProtectionPlanName, nameof(ddosProtectionPlanName));

            using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.Get");
            scope.Start();
            try
            {
                var response = await _ddosProtectionPlanRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DdosProtectionPlan(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified DDoS protection plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans/{ddosProtectionPlanName}
        /// Operation Id: DdosProtectionPlans_Get
        /// </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosProtectionPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public virtual Response<DdosProtectionPlan> Get(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosProtectionPlanName, nameof(ddosProtectionPlanName));

            using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.Get");
            scope.Start();
            try
            {
                var response = _ddosProtectionPlanRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DdosProtectionPlan(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the DDoS protection plans in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans
        /// Operation Id: DdosProtectionPlans_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DdosProtectionPlan" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DdosProtectionPlan> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DdosProtectionPlan>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _ddosProtectionPlanRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DdosProtectionPlan(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DdosProtectionPlan>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _ddosProtectionPlanRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DdosProtectionPlan(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all the DDoS protection plans in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans
        /// Operation Id: DdosProtectionPlans_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DdosProtectionPlan" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DdosProtectionPlan> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DdosProtectionPlan> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _ddosProtectionPlanRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DdosProtectionPlan(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DdosProtectionPlan> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _ddosProtectionPlanRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DdosProtectionPlan(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans/{ddosProtectionPlanName}
        /// Operation Id: DdosProtectionPlans_Get
        /// </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosProtectionPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosProtectionPlanName, nameof(ddosProtectionPlanName));

            using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(ddosProtectionPlanName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans/{ddosProtectionPlanName}
        /// Operation Id: DdosProtectionPlans_Get
        /// </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosProtectionPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public virtual Response<bool> Exists(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosProtectionPlanName, nameof(ddosProtectionPlanName));

            using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(ddosProtectionPlanName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans/{ddosProtectionPlanName}
        /// Operation Id: DdosProtectionPlans_Get
        /// </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosProtectionPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public virtual async Task<Response<DdosProtectionPlan>> GetIfExistsAsync(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosProtectionPlanName, nameof(ddosProtectionPlanName));

            using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _ddosProtectionPlanRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DdosProtectionPlan>(null, response.GetRawResponse());
                return Response.FromValue(new DdosProtectionPlan(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosProtectionPlans/{ddosProtectionPlanName}
        /// Operation Id: DdosProtectionPlans_Get
        /// </summary>
        /// <param name="ddosProtectionPlanName"> The name of the DDoS protection plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosProtectionPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosProtectionPlanName"/> is null. </exception>
        public virtual Response<DdosProtectionPlan> GetIfExists(string ddosProtectionPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosProtectionPlanName, nameof(ddosProtectionPlanName));

            using var scope = _ddosProtectionPlanClientDiagnostics.CreateScope("DdosProtectionPlanCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _ddosProtectionPlanRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ddosProtectionPlanName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DdosProtectionPlan>(null, response.GetRawResponse());
                return Response.FromValue(new DdosProtectionPlan(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DdosProtectionPlan> IEnumerable<DdosProtectionPlan>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DdosProtectionPlan> IAsyncEnumerable<DdosProtectionPlan>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
