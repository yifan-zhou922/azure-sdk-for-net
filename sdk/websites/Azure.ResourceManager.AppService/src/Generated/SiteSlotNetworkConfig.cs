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
    /// <summary> A Class representing a SiteSlotNetworkConfig along with the instance operations that can be performed on it. </summary>
    public partial class SiteSlotNetworkConfig : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotNetworkConfig"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotNetworkConfigWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotNetworkConfigWebAppsRestClient;
        private readonly SwiftVirtualNetworkData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotNetworkConfig"/> class for mocking. </summary>
        protected SiteSlotNetworkConfig()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotNetworkConfig"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotNetworkConfig(ArmClient client, SwiftVirtualNetworkData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotNetworkConfig"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotNetworkConfig(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotNetworkConfigWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string siteSlotNetworkConfigWebAppsApiVersion);
            _siteSlotNetworkConfigWebAppsRestClient = new WebAppsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSlotNetworkConfigWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/networkConfig";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SwiftVirtualNetworkData Data
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
        /// Description for Gets a Swift Virtual Network connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_GetSwiftVirtualNetworkConnectionSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteSlotNetworkConfig>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfig.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotNetworkConfigWebAppsRestClient.GetSwiftVirtualNetworkConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotNetworkConfig(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a Swift Virtual Network connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_GetSwiftVirtualNetworkConnectionSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotNetworkConfig> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfig.Get");
            scope.Start();
            try
            {
                var response = _siteSlotNetworkConfigWebAppsRestClient.GetSwiftVirtualNetworkConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotNetworkConfig(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deletes a Swift Virtual Network connection from an app (or deployment slot).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_DeleteSwiftVirtualNetworkSlot
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfig.Delete");
            scope.Start();
            try
            {
                var response = await _siteSlotNetworkConfigWebAppsRestClient.DeleteSwiftVirtualNetworkSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Deletes a Swift Virtual Network connection from an app (or deployment slot).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_DeleteSwiftVirtualNetworkSlot
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfig.Delete");
            scope.Start();
            try
            {
                var response = _siteSlotNetworkConfigWebAppsRestClient.DeleteSwiftVirtualNetworkSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
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
        /// Description for Integrates this Web App with a Virtual Network. This requires that 1) &quot;swiftSupported&quot; is true when doing a GET against this resource, and 2) that the target Subnet has already been delegated, and is not
        /// in use by another App Service Plan other than the one this App is in.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_UpdateSwiftVirtualNetworkConnectionWithCheckSlot
        /// </summary>
        /// <param name="connectionEnvelope"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual async Task<Response<SiteSlotNetworkConfig>> UpdateAsync(SwiftVirtualNetworkData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(connectionEnvelope, nameof(connectionEnvelope));

            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfig.Update");
            scope.Start();
            try
            {
                var response = await _siteSlotNetworkConfigWebAppsRestClient.UpdateSwiftVirtualNetworkConnectionWithCheckSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, connectionEnvelope, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotNetworkConfig(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Integrates this Web App with a Virtual Network. This requires that 1) &quot;swiftSupported&quot; is true when doing a GET against this resource, and 2) that the target Subnet has already been delegated, and is not
        /// in use by another App Service Plan other than the one this App is in.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_UpdateSwiftVirtualNetworkConnectionWithCheckSlot
        /// </summary>
        /// <param name="connectionEnvelope"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual Response<SiteSlotNetworkConfig> Update(SwiftVirtualNetworkData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(connectionEnvelope, nameof(connectionEnvelope));

            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfig.Update");
            scope.Start();
            try
            {
                var response = _siteSlotNetworkConfigWebAppsRestClient.UpdateSwiftVirtualNetworkConnectionWithCheckSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, connectionEnvelope, cancellationToken);
                return Response.FromValue(new SiteSlotNetworkConfig(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Integrates this Web App with a Virtual Network. This requires that 1) &quot;swiftSupported&quot; is true when doing a GET against this resource, and 2) that the target Subnet has already been delegated, and is not
        /// in use by another App Service Plan other than the one this App is in.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_CreateOrUpdateSwiftVirtualNetworkConnectionWithCheckSlot
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="connectionEnvelope"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteSlotNetworkConfig>> CreateOrUpdateAsync(bool waitForCompletion, SwiftVirtualNetworkData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(connectionEnvelope, nameof(connectionEnvelope));

            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfig.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotNetworkConfigWebAppsRestClient.CreateOrUpdateSwiftVirtualNetworkConnectionWithCheckSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, connectionEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSlotNetworkConfig>(Response.FromValue(new SiteSlotNetworkConfig(Client, response), response.GetRawResponse()));
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
        /// Description for Integrates this Web App with a Virtual Network. This requires that 1) &quot;swiftSupported&quot; is true when doing a GET against this resource, and 2) that the target Subnet has already been delegated, and is not
        /// in use by another App Service Plan other than the one this App is in.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_CreateOrUpdateSwiftVirtualNetworkConnectionWithCheckSlot
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="connectionEnvelope"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual ArmOperation<SiteSlotNetworkConfig> CreateOrUpdate(bool waitForCompletion, SwiftVirtualNetworkData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(connectionEnvelope, nameof(connectionEnvelope));

            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfig.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotNetworkConfigWebAppsRestClient.CreateOrUpdateSwiftVirtualNetworkConnectionWithCheckSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, connectionEnvelope, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSlotNetworkConfig>(Response.FromValue(new SiteSlotNetworkConfig(Client, response), response.GetRawResponse()));
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
