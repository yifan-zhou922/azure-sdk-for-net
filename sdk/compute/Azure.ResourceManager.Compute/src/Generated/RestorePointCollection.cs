// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of RestorePoint and their operations over its parent. </summary>
    public partial class RestorePointCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RestorePointsRestOperations _restorePointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RestorePointCollection"/> class for mocking. </summary>
        protected RestorePointCollection()
        {
        }

        /// <summary> Initializes a new instance of RestorePointCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RestorePointCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restorePointsRestClient = new RestorePointsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => RestorePointGroup.ResourceType;

        // Collection level operations.

        /// <summary> The operation to create the restore point. Updating properties of an existing restore point is not allowed. </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="parameters"> Parameters supplied to the Create restore point operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual RestorePointCreateOperation CreateOrUpdate(string restorePointName, RestorePointData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (restorePointName == null)
            {
                throw new ArgumentNullException(nameof(restorePointName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restorePointsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, parameters, cancellationToken);
                var operation = new RestorePointCreateOperation(Parent, _clientDiagnostics, Pipeline, _restorePointsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, parameters).Request, response);
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

        /// <summary> The operation to create the restore point. Updating properties of an existing restore point is not allowed. </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="parameters"> Parameters supplied to the Create restore point operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<RestorePointCreateOperation> CreateOrUpdateAsync(string restorePointName, RestorePointData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (restorePointName == null)
            {
                throw new ArgumentNullException(nameof(restorePointName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restorePointsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new RestorePointCreateOperation(Parent, _clientDiagnostics, Pipeline, _restorePointsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, parameters).Request, response);
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

        /// <summary> The operation to get the restore point. </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<RestorePoint> Get(string restorePointName, CancellationToken cancellationToken = default)
        {
            if (restorePointName == null)
            {
                throw new ArgumentNullException(nameof(restorePointName));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.Get");
            scope.Start();
            try
            {
                var response = _restorePointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorePoint(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to get the restore point. </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public async virtual Task<Response<RestorePoint>> GetAsync(string restorePointName, CancellationToken cancellationToken = default)
        {
            if (restorePointName == null)
            {
                throw new ArgumentNullException(nameof(restorePointName));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.Get");
            scope.Start();
            try
            {
                var response = await _restorePointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RestorePoint(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<RestorePoint> GetIfExists(string restorePointName, CancellationToken cancellationToken = default)
        {
            if (restorePointName == null)
            {
                throw new ArgumentNullException(nameof(restorePointName));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restorePointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<RestorePoint>(null, response.GetRawResponse())
                    : Response.FromValue(new RestorePoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public async virtual Task<Response<RestorePoint>> GetIfExistsAsync(string restorePointName, CancellationToken cancellationToken = default)
        {
            if (restorePointName == null)
            {
                throw new ArgumentNullException(nameof(restorePointName));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _restorePointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<RestorePoint>(null, response.GetRawResponse())
                    : Response.FromValue(new RestorePoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<bool> Exists(string restorePointName, CancellationToken cancellationToken = default)
        {
            if (restorePointName == null)
            {
                throw new ArgumentNullException(nameof(restorePointName));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(restorePointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string restorePointName, CancellationToken cancellationToken = default)
        {
            if (restorePointName == null)
            {
                throw new ArgumentNullException(nameof(restorePointName));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(restorePointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, RestorePoint, RestorePointData> Construct() { }
    }
}
