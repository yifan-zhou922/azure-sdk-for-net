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
    /// <summary> A Class representing a SiteSourceControl along with the instance operations that can be performed on it. </summary>
    public partial class SiteSourceControl : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSourceControl"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSourceControlWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSourceControlWebAppsRestClient;
        private readonly SiteSourceControlData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSourceControl"/> class for mocking. </summary>
        protected SiteSourceControl()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSourceControl"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSourceControl(ArmClient client, SiteSourceControlData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSourceControl"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSourceControl(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSourceControlWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string siteSourceControlWebAppsApiVersion);
            _siteSourceControlWebAppsRestClient = new WebAppsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSourceControlWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/sourcecontrols";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SiteSourceControlData Data
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
        /// Description for Gets the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_GetSourceControl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteSourceControl>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSourceControlWebAppsClientDiagnostics.CreateScope("SiteSourceControl.Get");
            scope.Start();
            try
            {
                var response = await _siteSourceControlWebAppsRestClient.GetSourceControlAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSourceControl(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_GetSourceControl
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSourceControl> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSourceControlWebAppsClientDiagnostics.CreateScope("SiteSourceControl.Get");
            scope.Start();
            try
            {
                var response = _siteSourceControlWebAppsRestClient.GetSourceControl(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSourceControl(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deletes the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_DeleteSourceControl
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="additionalFlags"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(bool waitForCompletion, string additionalFlags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSourceControlWebAppsClientDiagnostics.CreateScope("SiteSourceControl.Delete");
            scope.Start();
            try
            {
                var response = await _siteSourceControlWebAppsRestClient.DeleteSourceControlAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, additionalFlags, cancellationToken).ConfigureAwait(false);
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
        /// Description for Deletes the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_DeleteSourceControl
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="additionalFlags"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, string additionalFlags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSourceControlWebAppsClientDiagnostics.CreateScope("SiteSourceControl.Delete");
            scope.Start();
            try
            {
                var response = _siteSourceControlWebAppsRestClient.DeleteSourceControl(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, additionalFlags, cancellationToken);
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
        /// Description for Updates the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_UpdateSourceControl
        /// </summary>
        /// <param name="siteSourceControl"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteSourceControl"/> is null. </exception>
        public virtual async Task<Response<SiteSourceControl>> UpdateAsync(SiteSourceControlData siteSourceControl, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(siteSourceControl, nameof(siteSourceControl));

            using var scope = _siteSourceControlWebAppsClientDiagnostics.CreateScope("SiteSourceControl.Update");
            scope.Start();
            try
            {
                var response = await _siteSourceControlWebAppsRestClient.UpdateSourceControlAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, siteSourceControl, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SiteSourceControl(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_UpdateSourceControl
        /// </summary>
        /// <param name="siteSourceControl"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteSourceControl"/> is null. </exception>
        public virtual Response<SiteSourceControl> Update(SiteSourceControlData siteSourceControl, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(siteSourceControl, nameof(siteSourceControl));

            using var scope = _siteSourceControlWebAppsClientDiagnostics.CreateScope("SiteSourceControl.Update");
            scope.Start();
            try
            {
                var response = _siteSourceControlWebAppsRestClient.UpdateSourceControl(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, siteSourceControl, cancellationToken);
                return Response.FromValue(new SiteSourceControl(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_CreateOrUpdateSourceControl
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="siteSourceControl"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteSourceControl"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteSourceControl>> CreateOrUpdateAsync(bool waitForCompletion, SiteSourceControlData siteSourceControl, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(siteSourceControl, nameof(siteSourceControl));

            using var scope = _siteSourceControlWebAppsClientDiagnostics.CreateScope("SiteSourceControl.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSourceControlWebAppsRestClient.CreateOrUpdateSourceControlAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, siteSourceControl, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSourceControl>(new SiteSourceControlOperationSource(Client), _siteSourceControlWebAppsClientDiagnostics, Pipeline, _siteSourceControlWebAppsRestClient.CreateCreateOrUpdateSourceControlRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, siteSourceControl).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Updates the source control configuration of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/sourcecontrols/web
        /// Operation Id: WebApps_CreateOrUpdateSourceControl
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="siteSourceControl"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteSourceControl"/> is null. </exception>
        public virtual ArmOperation<SiteSourceControl> CreateOrUpdate(bool waitForCompletion, SiteSourceControlData siteSourceControl, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(siteSourceControl, nameof(siteSourceControl));

            using var scope = _siteSourceControlWebAppsClientDiagnostics.CreateScope("SiteSourceControl.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSourceControlWebAppsRestClient.CreateOrUpdateSourceControl(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, siteSourceControl, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSourceControl>(new SiteSourceControlOperationSource(Client), _siteSourceControlWebAppsClientDiagnostics, Pipeline, _siteSourceControlWebAppsRestClient.CreateCreateOrUpdateSourceControlRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, siteSourceControl).Request, response, OperationFinalStateVia.Location);
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
    }
}
