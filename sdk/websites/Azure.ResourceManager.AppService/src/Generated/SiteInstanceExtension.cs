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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteInstanceExtension along with the instance operations that can be performed on it. </summary>
    public partial class SiteInstanceExtension : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteInstanceExtension"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string instanceId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/extensions/MSDeploy";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteInstanceExtensionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteInstanceExtensionWebAppsRestClient;
        private readonly MSDeployStatusData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceExtension"/> class for mocking. </summary>
        protected SiteInstanceExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteInstanceExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteInstanceExtension(ArmClient client, MSDeployStatusData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteInstanceExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteInstanceExtensionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string siteInstanceExtensionWebAppsApiVersion);
            _siteInstanceExtensionWebAppsRestClient = new WebAppsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteInstanceExtensionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/instances/extensions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MSDeployStatusData Data
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
        /// Description for Get the status of the last MSDeploy operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/extensions/MSDeploy
        /// Operation Id: WebApps_GetInstanceMsDeployStatus
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteInstanceExtension>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteInstanceExtension.Get");
            scope.Start();
            try
            {
                var response = await _siteInstanceExtensionWebAppsRestClient.GetInstanceMsDeployStatusAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteInstanceExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the status of the last MSDeploy operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/extensions/MSDeploy
        /// Operation Id: WebApps_GetInstanceMsDeployStatus
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteInstanceExtension> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteInstanceExtension.Get");
            scope.Start();
            try
            {
                var response = _siteInstanceExtensionWebAppsRestClient.GetInstanceMsDeployStatus(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteInstanceExtension(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Invoke the MSDeploy web app extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/extensions/MSDeploy
        /// Operation Id: WebApps_CreateInstanceMSDeployOperation
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="msDeploy"> Details of MSDeploy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="msDeploy"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteInstanceExtension>> CreateOrUpdateAsync(bool waitForCompletion, MsDeploy msDeploy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(msDeploy, nameof(msDeploy));

            using var scope = _siteInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteInstanceExtension.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteInstanceExtensionWebAppsRestClient.CreateInstanceMSDeployOperationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteInstanceExtension>(new SiteInstanceExtensionOperationSource(Client), _siteInstanceExtensionWebAppsClientDiagnostics, Pipeline, _siteInstanceExtensionWebAppsRestClient.CreateCreateInstanceMSDeployOperationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Invoke the MSDeploy web app extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/extensions/MSDeploy
        /// Operation Id: WebApps_CreateInstanceMSDeployOperation
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="msDeploy"> Details of MSDeploy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="msDeploy"/> is null. </exception>
        public virtual ArmOperation<SiteInstanceExtension> CreateOrUpdate(bool waitForCompletion, MsDeploy msDeploy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(msDeploy, nameof(msDeploy));

            using var scope = _siteInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteInstanceExtension.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteInstanceExtensionWebAppsRestClient.CreateInstanceMSDeployOperation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy, cancellationToken);
                var operation = new AppServiceArmOperation<SiteInstanceExtension>(new SiteInstanceExtensionOperationSource(Client), _siteInstanceExtensionWebAppsClientDiagnostics, Pipeline, _siteInstanceExtensionWebAppsRestClient.CreateCreateInstanceMSDeployOperationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get the MSDeploy Log for the last MSDeploy operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/extensions/MSDeploy/log
        /// Operation Id: WebApps_GetInstanceMSDeployLog
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MsDeployLog>> GetInstanceMSDeployLogAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteInstanceExtension.GetInstanceMSDeployLog");
            scope.Start();
            try
            {
                var response = await _siteInstanceExtensionWebAppsRestClient.GetInstanceMSDeployLogAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the MSDeploy Log for the last MSDeploy operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/extensions/MSDeploy/log
        /// Operation Id: WebApps_GetInstanceMSDeployLog
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MsDeployLog> GetInstanceMSDeployLog(CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceExtensionWebAppsClientDiagnostics.CreateScope("SiteInstanceExtension.GetInstanceMSDeployLog");
            scope.Start();
            try
            {
                var response = _siteInstanceExtensionWebAppsRestClient.GetInstanceMSDeployLog(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
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
