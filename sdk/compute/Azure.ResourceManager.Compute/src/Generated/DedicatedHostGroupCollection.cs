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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of DedicatedHostGroup and their operations over its parent. </summary>
    public partial class DedicatedHostGroupCollection : ArmCollection, IEnumerable<DedicatedHostGroup>, IAsyncEnumerable<DedicatedHostGroup>
    {
        private readonly ClientDiagnostics _dedicatedHostGroupClientDiagnostics;
        private readonly DedicatedHostGroupsRestOperations _dedicatedHostGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="DedicatedHostGroupCollection"/> class for mocking. </summary>
        protected DedicatedHostGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DedicatedHostGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DedicatedHostGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dedicatedHostGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", DedicatedHostGroup.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(DedicatedHostGroup.ResourceType, out string dedicatedHostGroupApiVersion);
            _dedicatedHostGroupRestClient = new DedicatedHostGroupsRestOperations(_dedicatedHostGroupClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, dedicatedHostGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary> Create or update a dedicated host group. For details of Dedicated Host and Dedicated Host Groups please see [Dedicated Host Documentation] (https://go.microsoft.com/fwlink/?linkid=2082596). </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<DedicatedHostGroupCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string hostGroupName, DedicatedHostGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostGroupName, nameof(hostGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _dedicatedHostGroupClientDiagnostics.CreateScope("DedicatedHostGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dedicatedHostGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, hostGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new DedicatedHostGroupCreateOrUpdateOperation(Client, response);
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

        /// <summary> Create or update a dedicated host group. For details of Dedicated Host and Dedicated Host Groups please see [Dedicated Host Documentation] (https://go.microsoft.com/fwlink/?linkid=2082596). </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual DedicatedHostGroupCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string hostGroupName, DedicatedHostGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostGroupName, nameof(hostGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _dedicatedHostGroupClientDiagnostics.CreateScope("DedicatedHostGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dedicatedHostGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, hostGroupName, parameters, cancellationToken);
                var operation = new DedicatedHostGroupCreateOrUpdateOperation(Client, response);
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

        /// <summary> Retrieves information about a dedicated host group. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated hosts under the dedicated host group. &apos;UserData&apos; is not supported for dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> is null. </exception>
        public async virtual Task<Response<DedicatedHostGroup>> GetAsync(string hostGroupName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostGroupName, nameof(hostGroupName));

            using var scope = _dedicatedHostGroupClientDiagnostics.CreateScope("DedicatedHostGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _dedicatedHostGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, hostGroupName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _dedicatedHostGroupClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DedicatedHostGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about a dedicated host group. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated hosts under the dedicated host group. &apos;UserData&apos; is not supported for dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> is null. </exception>
        public virtual Response<DedicatedHostGroup> Get(string hostGroupName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostGroupName, nameof(hostGroupName));

            using var scope = _dedicatedHostGroupClientDiagnostics.CreateScope("DedicatedHostGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _dedicatedHostGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, hostGroupName, expand, cancellationToken);
                if (response.Value == null)
                    throw _dedicatedHostGroupClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DedicatedHostGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the dedicated host groups in the specified resource group. Use the nextLink property in the response to get the next page of dedicated host groups. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DedicatedHostGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DedicatedHostGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DedicatedHostGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dedicatedHostGroupClientDiagnostics.CreateScope("DedicatedHostGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dedicatedHostGroupRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHostGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DedicatedHostGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dedicatedHostGroupClientDiagnostics.CreateScope("DedicatedHostGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dedicatedHostGroupRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHostGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the dedicated host groups in the specified resource group. Use the nextLink property in the response to get the next page of dedicated host groups. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DedicatedHostGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DedicatedHostGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DedicatedHostGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dedicatedHostGroupClientDiagnostics.CreateScope("DedicatedHostGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dedicatedHostGroupRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHostGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DedicatedHostGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dedicatedHostGroupClientDiagnostics.CreateScope("DedicatedHostGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dedicatedHostGroupRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHostGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated hosts under the dedicated host group. &apos;UserData&apos; is not supported for dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string hostGroupName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostGroupName, nameof(hostGroupName));

            using var scope = _dedicatedHostGroupClientDiagnostics.CreateScope("DedicatedHostGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(hostGroupName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated hosts under the dedicated host group. &apos;UserData&apos; is not supported for dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string hostGroupName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostGroupName, nameof(hostGroupName));

            using var scope = _dedicatedHostGroupClientDiagnostics.CreateScope("DedicatedHostGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(hostGroupName, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated hosts under the dedicated host group. &apos;UserData&apos; is not supported for dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> is null. </exception>
        public async virtual Task<Response<DedicatedHostGroup>> GetIfExistsAsync(string hostGroupName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostGroupName, nameof(hostGroupName));

            using var scope = _dedicatedHostGroupClientDiagnostics.CreateScope("DedicatedHostGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dedicatedHostGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, hostGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DedicatedHostGroup>(null, response.GetRawResponse());
                return Response.FromValue(new DedicatedHostGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated hosts under the dedicated host group. &apos;UserData&apos; is not supported for dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> is null. </exception>
        public virtual Response<DedicatedHostGroup> GetIfExists(string hostGroupName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostGroupName, nameof(hostGroupName));

            using var scope = _dedicatedHostGroupClientDiagnostics.CreateScope("DedicatedHostGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dedicatedHostGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, hostGroupName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DedicatedHostGroup>(null, response.GetRawResponse());
                return Response.FromValue(new DedicatedHostGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DedicatedHostGroup> IEnumerable<DedicatedHostGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DedicatedHostGroup> IAsyncEnumerable<DedicatedHostGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
