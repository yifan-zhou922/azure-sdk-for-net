// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of RestorePoint and their operations over its parent. </summary>
    public partial class RestorePointCollection : ArmCollection, IEnumerable<RestorePoint>, IAsyncEnumerable<RestorePoint>
    {
        private readonly ClientDiagnostics _restorePointClientDiagnostics;
        private readonly RestorePointsRestOperations _restorePointRestClient;

        /// <summary> Initializes a new instance of the <see cref="RestorePointCollection"/> class for mocking. </summary>
        protected RestorePointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RestorePointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RestorePointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorePointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", RestorePoint.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(RestorePoint.ResourceType, out string restorePointApiVersion);
            _restorePointRestClient = new RestorePointsRestOperations(_restorePointClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, restorePointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabase.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabase.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a restore point.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints/{restorePointName}
        /// Operation Id: RestorePoints_Get
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public async virtual Task<Response<RestorePoint>> GetAsync(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.Get");
            scope.Start();
            try
            {
                var response = await _restorePointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, restorePointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _restorePointClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RestorePoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a restore point.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints/{restorePointName}
        /// Operation Id: RestorePoints_Get
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<RestorePoint> Get(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.Get");
            scope.Start();
            try
            {
                var response = _restorePointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, restorePointName, cancellationToken);
                if (response.Value == null)
                    throw _restorePointClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorePoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of database restore points.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints
        /// Operation Id: RestorePoints_ListByDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorePoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorePoint> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorePoint>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restorePointRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePoint(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RestorePoint>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restorePointRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePoint(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of database restore points.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints
        /// Operation Id: RestorePoints_ListByDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorePoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorePoint> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RestorePoint> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restorePointRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePoint(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RestorePoint> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restorePointRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePoint(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints/{restorePointName}
        /// Operation Id: RestorePoints_Get
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.Exists");
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

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints/{restorePointName}
        /// Operation Id: RestorePoints_Get
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<bool> Exists(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.Exists");
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

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints/{restorePointName}
        /// Operation Id: RestorePoints_Get
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public async virtual Task<Response<RestorePoint>> GetIfExistsAsync(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _restorePointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, restorePointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<RestorePoint>(null, response.GetRawResponse());
                return Response.FromValue(new RestorePoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints/{restorePointName}
        /// Operation Id: RestorePoints_Get
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<RestorePoint> GetIfExists(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restorePointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, restorePointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<RestorePoint>(null, response.GetRawResponse());
                return Response.FromValue(new RestorePoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RestorePoint> IEnumerable<RestorePoint>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RestorePoint> IAsyncEnumerable<RestorePoint>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
