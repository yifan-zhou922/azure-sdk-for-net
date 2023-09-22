// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A class representing a collection of <see cref="GlobalRulestackCertificateObjectResource" /> and their operations.
    /// Each <see cref="GlobalRulestackCertificateObjectResource" /> in the collection will belong to the same instance of <see cref="GlobalRulestackResource" />.
    /// To get a <see cref="GlobalRulestackCertificateObjectCollection" /> instance call the GetGlobalRulestackCertificateObjects method from an instance of <see cref="GlobalRulestackResource" />.
    /// </summary>
    public partial class GlobalRulestackCertificateObjectCollection : ArmCollection, IEnumerable<GlobalRulestackCertificateObjectResource>, IAsyncEnumerable<GlobalRulestackCertificateObjectResource>
    {
        private readonly ClientDiagnostics _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics;
        private readonly CertificateObjectGlobalRulestackRestOperations _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient;

        /// <summary> Initializes a new instance of the <see cref="GlobalRulestackCertificateObjectCollection"/> class for mocking. </summary>
        protected GlobalRulestackCertificateObjectCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GlobalRulestackCertificateObjectCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GlobalRulestackCertificateObjectCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", GlobalRulestackCertificateObjectResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GlobalRulestackCertificateObjectResource.ResourceType, out string globalRulestackCertificateObjectCertificateObjectGlobalRulestackApiVersion);
            _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient = new CertificateObjectGlobalRulestackRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, globalRulestackCertificateObjectCertificateObjectGlobalRulestackApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != GlobalRulestackResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, GlobalRulestackResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a CertificateObjectGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> certificate name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GlobalRulestackCertificateObjectResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, GlobalRulestackCertificateObjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackCertificateObjectCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.CreateOrUpdateAsync(Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<GlobalRulestackCertificateObjectResource>(new GlobalRulestackCertificateObjectOperationSource(Client), _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.CreateCreateOrUpdateRequest(Id.Name, name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a CertificateObjectGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> certificate name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GlobalRulestackCertificateObjectResource> CreateOrUpdate(WaitUntil waitUntil, string name, GlobalRulestackCertificateObjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackCertificateObjectCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.CreateOrUpdate(Id.Name, name, data, cancellationToken);
                var operation = new NgfwArmOperation<GlobalRulestackCertificateObjectResource>(new GlobalRulestackCertificateObjectOperationSource(Client), _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.CreateCreateOrUpdateRequest(Id.Name, name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a CertificateObjectGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<GlobalRulestackCertificateObjectResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackCertificateObjectCollection.Get");
            scope.Start();
            try
            {
                var response = await _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.GetAsync(Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackCertificateObjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a CertificateObjectGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<GlobalRulestackCertificateObjectResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackCertificateObjectCollection.Get");
            scope.Start();
            try
            {
                var response = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.Get(Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackCertificateObjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List CertificateObjectGlobalRulestackResource resources by Tenant
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GlobalRulestackCertificateObjectResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GlobalRulestackCertificateObjectResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.CreateListRequest(Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.CreateListNextPageRequest(nextLink, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new GlobalRulestackCertificateObjectResource(Client, GlobalRulestackCertificateObjectData.DeserializeGlobalRulestackCertificateObjectData(e)), _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics, Pipeline, "GlobalRulestackCertificateObjectCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List CertificateObjectGlobalRulestackResource resources by Tenant
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GlobalRulestackCertificateObjectResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GlobalRulestackCertificateObjectResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.CreateListRequest(Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.CreateListNextPageRequest(nextLink, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new GlobalRulestackCertificateObjectResource(Client, GlobalRulestackCertificateObjectData.DeserializeGlobalRulestackCertificateObjectData(e)), _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics, Pipeline, "GlobalRulestackCertificateObjectCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackCertificateObjectCollection.Exists");
            scope.Start();
            try
            {
                var response = await _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.GetAsync(Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackCertificateObjectCollection.Exists");
            scope.Start();
            try
            {
                var response = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.Get(Id.Name, name, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<GlobalRulestackCertificateObjectResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackCertificateObjectCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.GetAsync(Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<GlobalRulestackCertificateObjectResource>(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackCertificateObjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectGlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<GlobalRulestackCertificateObjectResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackCertificateObjectCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _globalRulestackCertificateObjectCertificateObjectGlobalRulestackRestClient.Get(Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<GlobalRulestackCertificateObjectResource>(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackCertificateObjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GlobalRulestackCertificateObjectResource> IEnumerable<GlobalRulestackCertificateObjectResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GlobalRulestackCertificateObjectResource> IAsyncEnumerable<GlobalRulestackCertificateObjectResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
