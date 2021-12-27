// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A Class representing a ServiceBusNamespace along with the instance operations that can be performed on it. </summary>
    public partial class ServiceBusNamespace : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServiceBusNamespace"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly NamespacesRestOperations _namespacesRestClient;
        private readonly PrivateLinkResourcesRestOperations _privateLinkResourcesRestClient;
        private readonly DisasterRecoveryConfigsRestOperations _disasterRecoveryConfigsRestClient;
        private readonly ServiceBusNamespaceData _data;

        /// <summary> Initializes a new instance of the <see cref="ServiceBusNamespace"/> class for mocking. </summary>
        protected ServiceBusNamespace()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServiceBusNamespace"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ServiceBusNamespace(ArmResource options, ServiceBusNamespaceData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _namespacesRestClient = new NamespacesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _privateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _disasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusNamespace"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceBusNamespace(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _namespacesRestClient = new NamespacesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _privateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _disasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusNamespace"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceBusNamespace(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _namespacesRestClient = new NamespacesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _privateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _disasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceBus/namespaces";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServiceBusNamespaceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets a description for the specified namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServiceBusNamespace>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.Get");
            scope.Start();
            try
            {
                var response = await _namespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServiceBusNamespace(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a description for the specified namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceBusNamespace> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.Get");
            scope.Start();
            try
            {
                var response = _namespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusNamespace(this, response.Value), response.GetRawResponse());
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
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes an existing namespace. This operation also removes all associated resources under the namespace. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<NamespaceDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.Delete");
            scope.Start();
            try
            {
                var response = await _namespacesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NamespaceDeleteOperation(_clientDiagnostics, Pipeline, _namespacesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Deletes an existing namespace. This operation also removes all associated resources under the namespace. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NamespaceDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.Delete");
            scope.Start();
            try
            {
                var response = _namespacesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new NamespaceDeleteOperation(_clientDiagnostics, Pipeline, _namespacesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public async virtual Task<Response<ServiceBusNamespace>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _namespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ServiceBusNamespace(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public virtual Response<ServiceBusNamespace> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _namespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ServiceBusNamespace(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public async virtual Task<Response<ServiceBusNamespace>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _namespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ServiceBusNamespace(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public virtual Response<ServiceBusNamespace> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _namespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ServiceBusNamespace(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public async virtual Task<Response<ServiceBusNamespace>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _namespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ServiceBusNamespace(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public virtual Response<ServiceBusNamespace> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _namespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ServiceBusNamespace(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a service namespace. Once created, this namespace&apos;s resource manifest is immutable. This operation is idempotent. </summary>
        /// <param name="parameters"> Parameters supplied to update a namespace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<ServiceBusNamespace>> UpdateAsync(ServiceBusNamespaceUpdateOptions parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.Update");
            scope.Start();
            try
            {
                var response = await _namespacesRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ServiceBusNamespace(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a service namespace. Once created, this namespace&apos;s resource manifest is immutable. This operation is idempotent. </summary>
        /// <param name="parameters"> Parameters supplied to update a namespace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<ServiceBusNamespace> Update(ServiceBusNamespaceUpdateOptions parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.Update");
            scope.Start();
            try
            {
                var response = _namespacesRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                return Response.FromValue(new ServiceBusNamespace(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets lists of resources that supports Privatelinks. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<IReadOnlyList<PrivateLinkResource>>> GetPrivateLinkResourcesAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.GetPrivateLinkResources");
            scope.Start();
            try
            {
                var response = await _privateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets lists of resources that supports Privatelinks. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<PrivateLinkResource>> GetPrivateLinkResources(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.GetPrivateLinkResources");
            scope.Start();
            try
            {
                var response = _privateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(response.Value.Value, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Check the give namespace name availability. </summary>
        /// <param name="parameters"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<CheckNameAvailabilityResult>> CheckNameAvailabilityDisasterRecoveryConfigAsync(CheckNameAvailability parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.CheckNameAvailabilityDisasterRecoveryConfig");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryConfigsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Check the give namespace name availability. </summary>
        /// <param name="parameters"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<CheckNameAvailabilityResult> CheckNameAvailabilityDisasterRecoveryConfig(CheckNameAvailability parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceBusNamespace.CheckNameAvailabilityDisasterRecoveryConfig");
            scope.Start();
            try
            {
                var response = _disasterRecoveryConfigsRestClient.CheckNameAvailability(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        #region NetworkRuleSet

        /// <summary> Gets an object representing a NetworkRuleSet along with the instance operations that can be performed on it in the ServiceBusNamespace. </summary>
        /// <returns> Returns a <see cref="NetworkRuleSet" /> object. </returns>
        public NetworkRuleSet GetNetworkRuleSet()
        {
            return new NetworkRuleSet(this, new ResourceIdentifier(Id.ToString() + "/networkRuleSets/default"));
        }
        #endregion

        #region PrivateEndpointConnection

        /// <summary> Gets a collection of PrivateEndpointConnections in the ServiceBusNamespace. </summary>
        /// <returns> An object representing collection of PrivateEndpointConnections and their operations over a ServiceBusNamespace. </returns>
        public PrivateEndpointConnectionCollection GetPrivateEndpointConnections()
        {
            return new PrivateEndpointConnectionCollection(this);
        }
        #endregion

        #region DisasterRecovery

        /// <summary> Gets a collection of DisasterRecoveries in the ServiceBusNamespace. </summary>
        /// <returns> An object representing collection of DisasterRecoveries and their operations over a ServiceBusNamespace. </returns>
        public DisasterRecoveryCollection GetDisasterRecoveries()
        {
            return new DisasterRecoveryCollection(this);
        }
        #endregion

        #region NamespaceAuthorizationRule

        /// <summary> Gets a collection of NamespaceAuthorizationRules in the ServiceBusNamespace. </summary>
        /// <returns> An object representing collection of NamespaceAuthorizationRules and their operations over a ServiceBusNamespace. </returns>
        public NamespaceAuthorizationRuleCollection GetNamespaceAuthorizationRules()
        {
            return new NamespaceAuthorizationRuleCollection(this);
        }
        #endregion

        #region MigrationConfigProperties

        /// <summary> Gets a collection of MigrationConfigProperties in the ServiceBusNamespace. </summary>
        /// <returns> An object representing collection of MigrationConfigProperties and their operations over a ServiceBusNamespace. </returns>
        public MigrationConfigPropertiesCollection GetMigrationConfigProperties()
        {
            return new MigrationConfigPropertiesCollection(this);
        }
        #endregion

        #region ServiceBusQueue

        /// <summary> Gets a collection of ServiceBusQueues in the ServiceBusNamespace. </summary>
        /// <returns> An object representing collection of ServiceBusQueues and their operations over a ServiceBusNamespace. </returns>
        public ServiceBusQueueCollection GetServiceBusQueues()
        {
            return new ServiceBusQueueCollection(this);
        }
        #endregion

        #region ServiceBusTopic

        /// <summary> Gets a collection of ServiceBusTopics in the ServiceBusNamespace. </summary>
        /// <returns> An object representing collection of ServiceBusTopics and their operations over a ServiceBusNamespace. </returns>
        public ServiceBusTopicCollection GetServiceBusTopics()
        {
            return new ServiceBusTopicCollection(this);
        }
        #endregion
    }
}
