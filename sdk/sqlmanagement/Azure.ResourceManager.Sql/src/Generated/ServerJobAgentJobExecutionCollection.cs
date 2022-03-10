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
    /// <summary> A class representing collection of ServerJobAgentJobExecution and their operations over its parent. </summary>
    public partial class ServerJobAgentJobExecutionCollection : ArmCollection, IEnumerable<ServerJobAgentJobExecution>, IAsyncEnumerable<ServerJobAgentJobExecution>
    {
        private readonly ClientDiagnostics _serverJobAgentJobExecutionJobExecutionsClientDiagnostics;
        private readonly JobExecutionsRestOperations _serverJobAgentJobExecutionJobExecutionsRestClient;
        private readonly ClientDiagnostics _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics;
        private readonly JobTargetExecutionsRestOperations _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerJobAgentJobExecutionCollection"/> class for mocking. </summary>
        protected ServerJobAgentJobExecutionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerJobAgentJobExecutionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerJobAgentJobExecutionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverJobAgentJobExecutionJobExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerJobAgentJobExecution.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ServerJobAgentJobExecution.ResourceType, out string serverJobAgentJobExecutionJobExecutionsApiVersion);
            _serverJobAgentJobExecutionJobExecutionsRestClient = new JobExecutionsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverJobAgentJobExecutionJobExecutionsApiVersion);
            _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerJobAgentJobExecutionStepTarget.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ServerJobAgentJobExecutionStepTarget.ResourceType, out string serverJobAgentJobExecutionStepTargetJobTargetExecutionsApiVersion);
            _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient = new JobTargetExecutionsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverJobAgentJobExecutionStepTargetJobTargetExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlJob.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlJob.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobExecutionId"> The job execution id to create the job execution under. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<ServerJobAgentJobExecution>> CreateOrUpdateAsync(WaitUntil waitUntil, Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverJobAgentJobExecutionJobExecutionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ServerJobAgentJobExecution>(new ServerJobAgentJobExecutionOperationSource(Client), _serverJobAgentJobExecutionJobExecutionsClientDiagnostics, Pipeline, _serverJobAgentJobExecutionJobExecutionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobExecutionId"> The job execution id to create the job execution under. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<ServerJobAgentJobExecution> CreateOrUpdate(WaitUntil waitUntil, Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverJobAgentJobExecutionJobExecutionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, cancellationToken);
                var operation = new SqlArmOperation<ServerJobAgentJobExecution>(new ServerJobAgentJobExecutionOperationSource(Client), _serverJobAgentJobExecutionJobExecutionsClientDiagnostics, Pipeline, _serverJobAgentJobExecutionJobExecutionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_Get
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerJobAgentJobExecution>> GetAsync(Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverJobAgentJobExecutionJobExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerJobAgentJobExecution(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_Get
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerJobAgentJobExecution> Get(Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.Get");
            scope.Start();
            try
            {
                var response = _serverJobAgentJobExecutionJobExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerJobAgentJobExecution(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a job&apos;s executions.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions
        /// Operation Id: JobExecutions_ListByJob
        /// </summary>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerJobAgentJobExecution" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerJobAgentJobExecution> GetAllAsync(DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerJobAgentJobExecution>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverJobAgentJobExecutionJobExecutionsRestClient.ListByJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecution(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerJobAgentJobExecution>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverJobAgentJobExecutionJobExecutionsRestClient.ListByJobNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecution(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists a job&apos;s executions.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions
        /// Operation Id: JobExecutions_ListByJob
        /// </summary>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerJobAgentJobExecution" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerJobAgentJobExecution> GetAll(DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ServerJobAgentJobExecution> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverJobAgentJobExecutionJobExecutionsRestClient.ListByJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecution(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerJobAgentJobExecution> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverJobAgentJobExecutionJobExecutionsRestClient.ListByJobNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecution(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists target executions for all steps of a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/targets
        /// Operation Id: JobTargetExecutions_ListByJobExecution
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerJobAgentJobExecutionStepTarget" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerJobAgentJobExecutionStepTarget> GetJobTargetExecutionsAsync(Guid jobExecutionId, DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerJobAgentJobExecutionStepTarget>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.GetJobTargetExecutions");
                scope.Start();
                try
                {
                    var response = await _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient.ListByJobExecutionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStepTarget(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerJobAgentJobExecutionStepTarget>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.GetJobTargetExecutions");
                scope.Start();
                try
                {
                    var response = await _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient.ListByJobExecutionNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStepTarget(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists target executions for all steps of a job execution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/targets
        /// Operation Id: JobTargetExecutions_ListByJobExecution
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerJobAgentJobExecutionStepTarget" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerJobAgentJobExecutionStepTarget> GetJobTargetExecutions(Guid jobExecutionId, DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ServerJobAgentJobExecutionStepTarget> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.GetJobTargetExecutions");
                scope.Start();
                try
                {
                    var response = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient.ListByJobExecution(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStepTarget(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerJobAgentJobExecutionStepTarget> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.GetJobTargetExecutions");
                scope.Start();
                try
                {
                    var response = _serverJobAgentJobExecutionStepTargetJobTargetExecutionsRestClient.ListByJobExecutionNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStepTarget(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_Get
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(jobExecutionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_Get
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(jobExecutionId, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_Get
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerJobAgentJobExecution>> GetIfExistsAsync(Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverJobAgentJobExecutionJobExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerJobAgentJobExecution>(null, response.GetRawResponse());
                return Response.FromValue(new ServerJobAgentJobExecution(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}
        /// Operation Id: JobExecutions_Get
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerJobAgentJobExecution> GetIfExists(Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _serverJobAgentJobExecutionJobExecutionsClientDiagnostics.CreateScope("ServerJobAgentJobExecutionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverJobAgentJobExecutionJobExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerJobAgentJobExecution>(null, response.GetRawResponse());
                return Response.FromValue(new ServerJobAgentJobExecution(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerJobAgentJobExecution> IEnumerable<ServerJobAgentJobExecution>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerJobAgentJobExecution> IAsyncEnumerable<ServerJobAgentJobExecution>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
