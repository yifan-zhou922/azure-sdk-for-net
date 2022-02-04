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
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A Class representing a VMwareDatastore along with the instance operations that can be performed on it. </summary>
    public partial class VMwareDatastore : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VMwareDatastore"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string datastoreName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _vMwareDatastoreDatastoresClientDiagnostics;
        private readonly DatastoresRestOperations _vMwareDatastoreDatastoresRestClient;
        private readonly VMwareDatastoreData _data;

        /// <summary> Initializes a new instance of the <see cref="VMwareDatastore"/> class for mocking. </summary>
        protected VMwareDatastore()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VMwareDatastore"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal VMwareDatastore(ArmClient client, VMwareDatastoreData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="VMwareDatastore"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VMwareDatastore(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vMwareDatastoreDatastoresClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string vMwareDatastoreDatastoresApiVersion);
            _vMwareDatastoreDatastoresRestClient = new DatastoresRestOperations(_vMwareDatastoreDatastoresClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, vMwareDatastoreDatastoresApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ConnectedVMwarevSphere/datastores";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VMwareDatastoreData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// OperationId: Datastores_Get
        /// <summary> Implements datastore GET method. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VMwareDatastore>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastore.Get");
            scope.Start();
            try
            {
                var response = await _vMwareDatastoreDatastoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _vMwareDatastoreDatastoresClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VMwareDatastore(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// OperationId: Datastores_Get
        /// <summary> Implements datastore GET method. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VMwareDatastore> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastore.Get");
            scope.Start();
            try
            {
                var response = _vMwareDatastoreDatastoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _vMwareDatastoreDatastoresClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareDatastore(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// OperationId: Datastores_Delete
        /// <summary> Implements datastore DELETE method. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="force"> Whether force delete was specified. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VMwareDatastoreDeleteOperation> DeleteAsync(bool waitForCompletion, bool? force = null, CancellationToken cancellationToken = default)
        {
            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastore.Delete");
            scope.Start();
            try
            {
                var response = await _vMwareDatastoreDatastoresRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, force, cancellationToken).ConfigureAwait(false);
                var operation = new VMwareDatastoreDeleteOperation(_vMwareDatastoreDatastoresClientDiagnostics, Pipeline, _vMwareDatastoreDatastoresRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, force).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// OperationId: Datastores_Delete
        /// <summary> Implements datastore DELETE method. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="force"> Whether force delete was specified. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VMwareDatastoreDeleteOperation Delete(bool waitForCompletion, bool? force = null, CancellationToken cancellationToken = default)
        {
            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastore.Delete");
            scope.Start();
            try
            {
                var response = _vMwareDatastoreDatastoresRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, force, cancellationToken);
                var operation = new VMwareDatastoreDeleteOperation(_vMwareDatastoreDatastoresClientDiagnostics, Pipeline, _vMwareDatastoreDatastoresRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, force).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// OperationId: Datastores_Update
        /// <summary> API to update certain properties of the datastore resource. </summary>
        /// <param name="body"> Resource properties to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VMwareDatastore>> UpdateAsync(ResourcePatch body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastore.Update");
            scope.Start();
            try
            {
                var response = await _vMwareDatastoreDatastoresRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, body, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VMwareDatastore(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// OperationId: Datastores_Update
        /// <summary> API to update certain properties of the datastore resource. </summary>
        /// <param name="body"> Resource properties to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VMwareDatastore> Update(ResourcePatch body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastore.Update");
            scope.Start();
            try
            {
                var response = _vMwareDatastoreDatastoresRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, body, cancellationToken);
                return Response.FromValue(new VMwareDatastore(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// OperationId: Datastores_Get
        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<VMwareDatastore>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastore.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _vMwareDatastoreDatastoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VMwareDatastore(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// OperationId: Datastores_Get
        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<VMwareDatastore> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastore.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _vMwareDatastoreDatastoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new VMwareDatastore(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// OperationId: Datastores_Get
        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<VMwareDatastore>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastore.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _vMwareDatastoreDatastoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VMwareDatastore(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// OperationId: Datastores_Get
        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<VMwareDatastore> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastore.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _vMwareDatastoreDatastoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new VMwareDatastore(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// OperationId: Datastores_Get
        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<VMwareDatastore>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastore.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _vMwareDatastoreDatastoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VMwareDatastore(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// OperationId: Datastores_Get
        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<VMwareDatastore> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastore.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _vMwareDatastoreDatastoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new VMwareDatastore(Client, originalResponse.Value), originalResponse.GetRawResponse());
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
            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastore.GetAvailableLocations");
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
            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastore.GetAvailableLocations");
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
