// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of DeploymentScript and their operations over its parent. </summary>
    public partial class DeploymentScriptCollection : ArmCollection, IEnumerable<DeploymentScript>, IAsyncEnumerable<DeploymentScript>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DeploymentScriptsRestOperations _deploymentScriptsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeploymentScriptCollection"/> class for mocking. </summary>
        protected DeploymentScriptCollection()
        {
        }

        /// <summary> Initializes a new instance of DeploymentScriptCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DeploymentScriptCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _deploymentScriptsRestClient = new DeploymentScriptsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <summary> Creates a deployment script. </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="deploymentScript"> Deployment script supplied to the operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> or <paramref name="deploymentScript"/> is null. </exception>
        public virtual DeploymentScriptCreateOperation CreateOrUpdate(string scriptName, DeploymentScriptData deploymentScript, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }
            if (deploymentScript == null)
            {
                throw new ArgumentNullException(nameof(deploymentScript));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _deploymentScriptsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, scriptName, deploymentScript, cancellationToken);
                var operation = new DeploymentScriptCreateOperation(Parent, _clientDiagnostics, Pipeline, _deploymentScriptsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, scriptName, deploymentScript).Request, response);
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

        /// <summary> Creates a deployment script. </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="deploymentScript"> Deployment script supplied to the operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> or <paramref name="deploymentScript"/> is null. </exception>
        public async virtual Task<DeploymentScriptCreateOperation> CreateOrUpdateAsync(string scriptName, DeploymentScriptData deploymentScript, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }
            if (deploymentScript == null)
            {
                throw new ArgumentNullException(nameof(deploymentScript));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _deploymentScriptsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, scriptName, deploymentScript, cancellationToken).ConfigureAwait(false);
                var operation = new DeploymentScriptCreateOperation(Parent, _clientDiagnostics, Pipeline, _deploymentScriptsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, scriptName, deploymentScript).Request, response);
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

        /// <summary> Gets a deployment script with a given name. </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual Response<DeploymentScript> Get(string scriptName, CancellationToken cancellationToken = default)
        {
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptCollection.Get");
            scope.Start();
            try
            {
                var response = _deploymentScriptsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, scriptName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeploymentScript(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a deployment script with a given name. </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public async virtual Task<Response<DeploymentScript>> GetAsync(string scriptName, CancellationToken cancellationToken = default)
        {
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptCollection.Get");
            scope.Start();
            try
            {
                var response = await _deploymentScriptsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, scriptName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DeploymentScript(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual Response<DeploymentScript> GetIfExists(string scriptName, CancellationToken cancellationToken = default)
        {
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deploymentScriptsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, scriptName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DeploymentScript>(null, response.GetRawResponse())
                    : Response.FromValue(new DeploymentScript(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public async virtual Task<Response<DeploymentScript>> GetIfExistsAsync(string scriptName, CancellationToken cancellationToken = default)
        {
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _deploymentScriptsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, scriptName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DeploymentScript>(null, response.GetRawResponse())
                    : Response.FromValue(new DeploymentScript(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public virtual Response<bool> Exists(string scriptName, CancellationToken cancellationToken = default)
        {
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(scriptName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string scriptName, CancellationToken cancellationToken = default)
        {
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(scriptName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists deployments scripts. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeploymentScript" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeploymentScript> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DeploymentScript> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentScriptCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deploymentScriptsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeploymentScript> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentScriptCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deploymentScriptsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists deployments scripts. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeploymentScript" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeploymentScript> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeploymentScript>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentScriptCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deploymentScriptsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeploymentScript>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentScriptCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deploymentScriptsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="DeploymentScript" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DeploymentScript.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DeploymentScript" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentScriptCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DeploymentScript.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeploymentScript> IEnumerable<DeploymentScript>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeploymentScript> IAsyncEnumerable<DeploymentScript>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, DeploymentScript, DeploymentScriptData> Construct() { }
    }
}
