// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A Class representing a OSVersion along with the instance operations that can be performed on it. </summary>
    public partial class OSVersion : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="OSVersion"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string location, string osVersionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions/{osVersionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _oSVersionCloudServiceOperatingSystemsClientDiagnostics;
        private readonly CloudServiceOperatingSystemsRestOperations _oSVersionCloudServiceOperatingSystemsRestClient;
        private readonly OSVersionData _data;

        /// <summary> Initializes a new instance of the <see cref="OSVersion"/> class for mocking. </summary>
        protected OSVersion()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "OSVersion"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal OSVersion(ArmClient client, OSVersionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="OSVersion"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal OSVersion(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _oSVersionCloudServiceOperatingSystemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string oSVersionCloudServiceOperatingSystemsApiVersion);
            _oSVersionCloudServiceOperatingSystemsRestClient = new CloudServiceOperatingSystemsRestOperations(_oSVersionCloudServiceOperatingSystemsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, oSVersionCloudServiceOperatingSystemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/locations/cloudServiceOsVersions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual OSVersionData Data
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

        /// <summary> Gets properties of a guest operating system version that can be specified in the XML service configuration (.cscfg) for a cloud service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<OSVersion>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _oSVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersion.Get");
            scope.Start();
            try
            {
                var response = await _oSVersionCloudServiceOperatingSystemsRestClient.GetOSVersionAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _oSVersionCloudServiceOperatingSystemsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new OSVersion(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets properties of a guest operating system version that can be specified in the XML service configuration (.cscfg) for a cloud service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OSVersion> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _oSVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersion.Get");
            scope.Start();
            try
            {
                var response = _oSVersionCloudServiceOperatingSystemsRestClient.GetOSVersion(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _oSVersionCloudServiceOperatingSystemsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OSVersion(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _oSVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersion.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _oSVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersion.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
