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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of Certificate and their operations over its parent. </summary>
    public partial class CertificateCollection : ArmCollection, IEnumerable<Certificate>, IAsyncEnumerable<Certificate>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CertificatesRestOperations _certificatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CertificateCollection"/> class for mocking. </summary>
        protected CertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of CertificateCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CertificateCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _certificatesRestClient = new CertificatesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Certificates_CreateOrUpdate
        /// <summary> Description for Create or update a certificate. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="certificateEnvelope"> Details of certificate, if it exists already. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="certificateEnvelope"/> is null. </exception>
        public virtual CertificateCreateOrUpdateOperation CreateOrUpdate(string name, CertificateData certificateEnvelope, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (certificateEnvelope == null)
            {
                throw new ArgumentNullException(nameof(certificateEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("CertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _certificatesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, name, certificateEnvelope, cancellationToken);
                var operation = new CertificateCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Certificates_CreateOrUpdate
        /// <summary> Description for Create or update a certificate. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="certificateEnvelope"> Details of certificate, if it exists already. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="certificateEnvelope"/> is null. </exception>
        public async virtual Task<CertificateCreateOrUpdateOperation> CreateOrUpdateAsync(string name, CertificateData certificateEnvelope, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (certificateEnvelope == null)
            {
                throw new ArgumentNullException(nameof(certificateEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("CertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _certificatesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, name, certificateEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new CertificateCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Certificates_Get
        /// <summary> Description for Get a certificate. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<Certificate> Get(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("CertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _certificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Certificate(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Certificates_Get
        /// <summary> Description for Get a certificate. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<Certificate>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("CertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _certificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Certificate(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<Certificate> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("CertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _certificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Certificate>(null, response.GetRawResponse())
                    : Response.FromValue(new Certificate(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<Certificate>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("CertificateCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _certificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Certificate>(null, response.GetRawResponse())
                    : Response.FromValue(new Certificate(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("CertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("CertificateCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Certificates_ListByResourceGroup
        /// <summary> Description for Get all certificates in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Certificate" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Certificate> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Certificate> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _certificatesRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Certificate(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Certificate> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _certificatesRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Certificate(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/certificates
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Certificates_ListByResourceGroup
        /// <summary> Description for Get all certificates in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Certificate" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Certificate> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Certificate>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _certificatesRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Certificate(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Certificate>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CertificateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _certificatesRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Certificate(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="Certificate" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CertificateCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Certificate.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Certificate" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CertificateCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Certificate.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Certificate> IEnumerable<Certificate>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Certificate> IAsyncEnumerable<Certificate>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, Certificate, CertificateData> Construct() { }
    }
}
