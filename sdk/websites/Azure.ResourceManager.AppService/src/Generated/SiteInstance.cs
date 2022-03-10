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
    /// <summary> A Class representing a SiteInstance along with the instance operations that can be performed on it. </summary>
    public partial class SiteInstance : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteInstance"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string instanceId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteInstanceWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteInstanceWebAppsRestClient;
        private readonly WebSiteInstanceStatusData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteInstance"/> class for mocking. </summary>
        protected SiteInstance()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteInstance"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteInstance(ArmClient client, WebSiteInstanceStatusData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteInstance"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteInstance(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteInstanceWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string siteInstanceWebAppsApiVersion);
            _siteInstanceWebAppsRestClient = new WebAppsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteInstanceWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/instances";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WebSiteInstanceStatusData Data
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

        /// <summary> Gets an object representing a SiteInstanceExtension along with the instance operations that can be performed on it in the SiteInstance. </summary>
        /// <returns> Returns a <see cref="SiteInstanceExtension" /> object. </returns>
        public virtual SiteInstanceExtension GetSiteInstanceExtension()
        {
            return new SiteInstanceExtension(Client, new ResourceIdentifier(Id.ToString() + "/extensions/MSDeploy"));
        }

        /// <summary> Gets a collection of SiteInstanceProcesses in the SiteInstanceProcess. </summary>
        /// <returns> An object representing collection of SiteInstanceProcesses and their operations over a SiteInstanceProcess. </returns>
        public virtual SiteInstanceProcessCollection GetSiteInstanceProcesses()
        {
            return new SiteInstanceProcessCollection(Client, Id);
        }

        /// <summary>
        /// Description for Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteInstance>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstance.Get");
            scope.Start();
            try
            {
                var response = await _siteInstanceWebAppsRestClient.GetInstanceInfoAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteInstance(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfo
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteInstance> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteInstanceWebAppsClientDiagnostics.CreateScope("SiteInstance.Get");
            scope.Start();
            try
            {
                var response = _siteInstanceWebAppsRestClient.GetInstanceInfo(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteInstance(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
