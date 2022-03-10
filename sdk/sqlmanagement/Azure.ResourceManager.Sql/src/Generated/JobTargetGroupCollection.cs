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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of JobTargetGroup and their operations over its parent. </summary>
    public partial class JobTargetGroupCollection : ArmCollection, IEnumerable<JobTargetGroup>, IAsyncEnumerable<JobTargetGroup>
    {
        private readonly ClientDiagnostics _jobTargetGroupClientDiagnostics;
        private readonly JobTargetGroupsRestOperations _jobTargetGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="JobTargetGroupCollection"/> class for mocking. </summary>
        protected JobTargetGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="JobTargetGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal JobTargetGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _jobTargetGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", JobTargetGroup.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(JobTargetGroup.ResourceType, out string jobTargetGroupApiVersion);
            _jobTargetGroupRestClient = new JobTargetGroupsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, jobTargetGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != JobAgent.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, JobAgent.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a target group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups/{targetGroupName}
        /// Operation Id: JobTargetGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="parameters"> The requested state of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<JobTargetGroup>> CreateOrUpdateAsync(bool waitForCompletion, string targetGroupName, JobTargetGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _jobTargetGroupClientDiagnostics.CreateScope("JobTargetGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _jobTargetGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, targetGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<JobTargetGroup>(Response.FromValue(new JobTargetGroup(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a target group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups/{targetGroupName}
        /// Operation Id: JobTargetGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="parameters"> The requested state of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<JobTargetGroup> CreateOrUpdate(bool waitForCompletion, string targetGroupName, JobTargetGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _jobTargetGroupClientDiagnostics.CreateScope("JobTargetGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _jobTargetGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, targetGroupName, parameters, cancellationToken);
                var operation = new SqlArmOperation<JobTargetGroup>(Response.FromValue(new JobTargetGroup(Client, response), response.GetRawResponse()));
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
        /// Gets a target group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups/{targetGroupName}
        /// Operation Id: JobTargetGroups_Get
        /// </summary>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetGroupName"/> is null. </exception>
        public virtual async Task<Response<JobTargetGroup>> GetAsync(string targetGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));

            using var scope = _jobTargetGroupClientDiagnostics.CreateScope("JobTargetGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _jobTargetGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, targetGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobTargetGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a target group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups/{targetGroupName}
        /// Operation Id: JobTargetGroups_Get
        /// </summary>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetGroupName"/> is null. </exception>
        public virtual Response<JobTargetGroup> Get(string targetGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));

            using var scope = _jobTargetGroupClientDiagnostics.CreateScope("JobTargetGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _jobTargetGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, targetGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobTargetGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all target groups in an agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups
        /// Operation Id: JobTargetGroups_ListByAgent
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JobTargetGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JobTargetGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<JobTargetGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _jobTargetGroupClientDiagnostics.CreateScope("JobTargetGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobTargetGroupRestClient.ListByAgentAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobTargetGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobTargetGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _jobTargetGroupClientDiagnostics.CreateScope("JobTargetGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobTargetGroupRestClient.ListByAgentNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobTargetGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all target groups in an agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups
        /// Operation Id: JobTargetGroups_ListByAgent
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JobTargetGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JobTargetGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<JobTargetGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _jobTargetGroupClientDiagnostics.CreateScope("JobTargetGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobTargetGroupRestClient.ListByAgent(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobTargetGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobTargetGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _jobTargetGroupClientDiagnostics.CreateScope("JobTargetGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobTargetGroupRestClient.ListByAgentNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobTargetGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups/{targetGroupName}
        /// Operation Id: JobTargetGroups_Get
        /// </summary>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string targetGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));

            using var scope = _jobTargetGroupClientDiagnostics.CreateScope("JobTargetGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(targetGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups/{targetGroupName}
        /// Operation Id: JobTargetGroups_Get
        /// </summary>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string targetGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));

            using var scope = _jobTargetGroupClientDiagnostics.CreateScope("JobTargetGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(targetGroupName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups/{targetGroupName}
        /// Operation Id: JobTargetGroups_Get
        /// </summary>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetGroupName"/> is null. </exception>
        public virtual async Task<Response<JobTargetGroup>> GetIfExistsAsync(string targetGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));

            using var scope = _jobTargetGroupClientDiagnostics.CreateScope("JobTargetGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _jobTargetGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, targetGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<JobTargetGroup>(null, response.GetRawResponse());
                return Response.FromValue(new JobTargetGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/targetGroups/{targetGroupName}
        /// Operation Id: JobTargetGroups_Get
        /// </summary>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetGroupName"/> is null. </exception>
        public virtual Response<JobTargetGroup> GetIfExists(string targetGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetGroupName, nameof(targetGroupName));

            using var scope = _jobTargetGroupClientDiagnostics.CreateScope("JobTargetGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _jobTargetGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, targetGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<JobTargetGroup>(null, response.GetRawResponse());
                return Response.FromValue(new JobTargetGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<JobTargetGroup> IEnumerable<JobTargetGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<JobTargetGroup> IAsyncEnumerable<JobTargetGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
