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
    /// <summary> A class representing collection of Deployment and their operations over its parent. </summary>
    public partial class DeploymentCollection : ArmCollection, IEnumerable<Deployment>, IAsyncEnumerable<Deployment>
    {
        private readonly ClientDiagnostics _deploymentClientDiagnostics;
        private readonly DeploymentsRestOperations _deploymentRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeploymentCollection"/> class for mocking. </summary>
        protected DeploymentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeploymentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeploymentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deploymentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", Deployment.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(Deployment.ResourceType, out string deploymentApiVersion);
            _deploymentRestClient = new DeploymentsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, deploymentApiVersion);
        }

        /// <summary>
        /// You can provide the template and parameters directly in the request or link to JSON files.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_CreateOrUpdateAtScope
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="parameters"> Additional parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<Deployment>> CreateOrUpdateAsync(WaitUntil waitUntil, string deploymentName, DeploymentInput parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _deploymentClientDiagnostics.CreateScope("DeploymentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _deploymentRestClient.CreateOrUpdateAtScopeAsync(Id, deploymentName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<Deployment>(new DeploymentOperationSource(Client), _deploymentClientDiagnostics, Pipeline, _deploymentRestClient.CreateCreateOrUpdateAtScopeRequest(Id, deploymentName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
        /// You can provide the template and parameters directly in the request or link to JSON files.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_CreateOrUpdateAtScope
        /// </summary>
        /// <param name="waitUntil"> "F:WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="parameters"> Additional parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<Deployment> CreateOrUpdate(WaitUntil waitUntil, string deploymentName, DeploymentInput parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _deploymentClientDiagnostics.CreateScope("DeploymentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _deploymentRestClient.CreateOrUpdateAtScope(Id, deploymentName, parameters, cancellationToken);
                var operation = new ResourcesArmOperation<Deployment>(new DeploymentOperationSource(Client), _deploymentClientDiagnostics, Pipeline, _deploymentRestClient.CreateCreateOrUpdateAtScopeRequest(Id, deploymentName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
        /// Gets a deployment.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_GetAtScope
        /// </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual async Task<Response<Deployment>> GetAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _deploymentClientDiagnostics.CreateScope("DeploymentCollection.Get");
            scope.Start();
            try
            {
                var response = await _deploymentRestClient.GetAtScopeAsync(Id, deploymentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Deployment(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a deployment.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_GetAtScope
        /// </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual Response<Deployment> Get(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _deploymentClientDiagnostics.CreateScope("DeploymentCollection.Get");
            scope.Start();
            try
            {
                var response = _deploymentRestClient.GetAtScope(Id, deploymentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Deployment(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all the deployments at the given scope.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments
        /// Operation Id: Deployments_ListAtScope
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For example, you can use $filter=provisioningState eq &apos;{state}&apos;. </param>
        /// <param name="top"> The number of results to get. If null is passed, returns all deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Deployment" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Deployment> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Deployment>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _deploymentClientDiagnostics.CreateScope("DeploymentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deploymentRestClient.ListAtScopeAsync(Id, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Deployment(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Deployment>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _deploymentClientDiagnostics.CreateScope("DeploymentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deploymentRestClient.ListAtScopeNextPageAsync(nextLink, Id, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Deployment(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Get all the deployments at the given scope.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments
        /// Operation Id: Deployments_ListAtScope
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For example, you can use $filter=provisioningState eq &apos;{state}&apos;. </param>
        /// <param name="top"> The number of results to get. If null is passed, returns all deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Deployment" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Deployment> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<Deployment> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _deploymentClientDiagnostics.CreateScope("DeploymentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deploymentRestClient.ListAtScope(Id, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Deployment(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Deployment> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _deploymentClientDiagnostics.CreateScope("DeploymentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deploymentRestClient.ListAtScopeNextPage(nextLink, Id, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Deployment(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_GetAtScope
        /// </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _deploymentClientDiagnostics.CreateScope("DeploymentCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_GetAtScope
        /// </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual Response<bool> Exists(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _deploymentClientDiagnostics.CreateScope("DeploymentCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(deploymentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_GetAtScope
        /// </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual async Task<Response<Deployment>> GetIfExistsAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _deploymentClientDiagnostics.CreateScope("DeploymentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deploymentRestClient.GetAtScopeAsync(Id, deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Deployment>(null, response.GetRawResponse());
                return Response.FromValue(new Deployment(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_GetAtScope
        /// </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual Response<Deployment> GetIfExists(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _deploymentClientDiagnostics.CreateScope("DeploymentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deploymentRestClient.GetAtScope(Id, deploymentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Deployment>(null, response.GetRawResponse());
                return Response.FromValue(new Deployment(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Deployment> IEnumerable<Deployment>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Deployment> IAsyncEnumerable<Deployment>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
