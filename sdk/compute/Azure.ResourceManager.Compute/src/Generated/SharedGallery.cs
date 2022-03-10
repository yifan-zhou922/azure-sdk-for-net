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

namespace Azure.ResourceManager.Compute
{
    /// <summary> A Class representing a SharedGallery along with the instance operations that can be performed on it. </summary>
    public partial class SharedGallery : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SharedGallery"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string location, string galleryUniqueName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sharedGalleryClientDiagnostics;
        private readonly SharedGalleriesRestOperations _sharedGalleryRestClient;
        private readonly SharedGalleryData _data;

        /// <summary> Initializes a new instance of the <see cref="SharedGallery"/> class for mocking. </summary>
        protected SharedGallery()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SharedGallery"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SharedGallery(ArmClient client, SharedGalleryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SharedGallery"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SharedGallery(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sharedGalleryClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string sharedGalleryApiVersion);
            _sharedGalleryRestClient = new SharedGalleriesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sharedGalleryApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/locations/sharedGalleries";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SharedGalleryData Data
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

        /// <summary> Gets a collection of SharedGalleryImages in the SharedGalleryImage. </summary>
        /// <returns> An object representing collection of SharedGalleryImages and their operations over a SharedGalleryImage. </returns>
        public virtual SharedGalleryImageCollection GetSharedGalleryImages()
        {
            return new SharedGalleryImageCollection(Client, Id);
        }

        /// <summary>
        /// Get a shared gallery by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}
        /// Operation Id: SharedGalleries_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SharedGallery>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sharedGalleryClientDiagnostics.CreateScope("SharedGallery.Get");
            scope.Start();
            try
            {
                var response = await _sharedGalleryRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CreateResourceIdentifier(Id.SubscriptionId, Id.Parent.Name, Id.Name);
                return Response.FromValue(new SharedGallery(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a shared gallery by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}
        /// Operation Id: SharedGalleries_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SharedGallery> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sharedGalleryClientDiagnostics.CreateScope("SharedGallery.Get");
            scope.Start();
            try
            {
                var response = _sharedGalleryRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CreateResourceIdentifier(Id.SubscriptionId, Id.Parent.Name, Id.Name);
                return Response.FromValue(new SharedGallery(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
