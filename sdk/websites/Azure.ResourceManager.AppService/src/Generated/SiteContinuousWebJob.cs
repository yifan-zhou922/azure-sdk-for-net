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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteContinuousWebJob along with the instance operations that can be performed on it. </summary>
    public partial class SiteContinuousWebJob : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteContinuousWebJob"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string webJobName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteContinuousWebJobWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteContinuousWebJobWebAppsRestClient;
        private readonly ContinuousWebJobData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteContinuousWebJob"/> class for mocking. </summary>
        protected SiteContinuousWebJob()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteContinuousWebJob"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteContinuousWebJob(ArmClient client, ContinuousWebJobData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteContinuousWebJob"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteContinuousWebJob(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteContinuousWebJobWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string siteContinuousWebJobWebAppsApiVersion);
            _siteContinuousWebJobWebAppsRestClient = new WebAppsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteContinuousWebJobWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/continuouswebjobs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContinuousWebJobData Data
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
        /// Description for Gets a continuous web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}
        /// Operation Id: WebApps_GetContinuousWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteContinuousWebJob>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteContinuousWebJob.Get");
            scope.Start();
            try
            {
                var response = await _siteContinuousWebJobWebAppsRestClient.GetContinuousWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteContinuousWebJob(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a continuous web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}
        /// Operation Id: WebApps_GetContinuousWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteContinuousWebJob> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteContinuousWebJob.Get");
            scope.Start();
            try
            {
                var response = _siteContinuousWebJobWebAppsRestClient.GetContinuousWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteContinuousWebJob(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Delete a continuous web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}
        /// Operation Id: WebApps_DeleteContinuousWebJob
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _siteContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteContinuousWebJob.Delete");
            scope.Start();
            try
            {
                var response = await _siteContinuousWebJobWebAppsRestClient.DeleteContinuousWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(response);
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
        /// Description for Delete a continuous web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}
        /// Operation Id: WebApps_DeleteContinuousWebJob
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _siteContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteContinuousWebJob.Delete");
            scope.Start();
            try
            {
                var response = _siteContinuousWebJobWebAppsRestClient.DeleteContinuousWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(response);
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

        /// <summary>
        /// Description for Start a continuous web job for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}/start
        /// Operation Id: WebApps_StartContinuousWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StartContinuousWebJobAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteContinuousWebJob.StartContinuousWebJob");
            scope.Start();
            try
            {
                var response = await _siteContinuousWebJobWebAppsRestClient.StartContinuousWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Start a continuous web job for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}/start
        /// Operation Id: WebApps_StartContinuousWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response StartContinuousWebJob(CancellationToken cancellationToken = default)
        {
            using var scope = _siteContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteContinuousWebJob.StartContinuousWebJob");
            scope.Start();
            try
            {
                var response = _siteContinuousWebJobWebAppsRestClient.StartContinuousWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Stop a continuous web job for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}/stop
        /// Operation Id: WebApps_StopContinuousWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StopContinuousWebJobAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteContinuousWebJob.StopContinuousWebJob");
            scope.Start();
            try
            {
                var response = await _siteContinuousWebJobWebAppsRestClient.StopContinuousWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Stop a continuous web job for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/continuouswebjobs/{webJobName}/stop
        /// Operation Id: WebApps_StopContinuousWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response StopContinuousWebJob(CancellationToken cancellationToken = default)
        {
            using var scope = _siteContinuousWebJobWebAppsClientDiagnostics.CreateScope("SiteContinuousWebJob.StopContinuousWebJob");
            scope.Start();
            try
            {
                var response = _siteContinuousWebJobWebAppsRestClient.StopContinuousWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
