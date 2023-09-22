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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="SoftwareUpdateConfigurationResource" /> and their operations.
    /// Each <see cref="SoftwareUpdateConfigurationResource" /> in the collection will belong to the same instance of <see cref="AutomationAccountResource" />.
    /// To get a <see cref="SoftwareUpdateConfigurationCollection" /> instance call the GetSoftwareUpdateConfigurations method from an instance of <see cref="AutomationAccountResource" />.
    /// </summary>
    public partial class SoftwareUpdateConfigurationCollection : ArmCollection, IEnumerable<SoftwareUpdateConfigurationCollectionItem>, IAsyncEnumerable<SoftwareUpdateConfigurationCollectionItem>
    {
        private readonly ClientDiagnostics _softwareUpdateConfigurationClientDiagnostics;
        private readonly SoftwareUpdateConfigurationsRestOperations _softwareUpdateConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="SoftwareUpdateConfigurationCollection"/> class for mocking. </summary>
        protected SoftwareUpdateConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SoftwareUpdateConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SoftwareUpdateConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _softwareUpdateConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", SoftwareUpdateConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SoftwareUpdateConfigurationResource.ResourceType, out string softwareUpdateConfigurationApiVersion);
            _softwareUpdateConfigurationRestClient = new SoftwareUpdateConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, softwareUpdateConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new software update configuration with the name given in the URI.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/softwareUpdateConfigurations/{softwareUpdateConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SoftwareUpdateConfigurations_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="softwareUpdateConfigurationName"> The name of the software update configuration to be created. </param>
        /// <param name="data"> Request body. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="softwareUpdateConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="softwareUpdateConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SoftwareUpdateConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string softwareUpdateConfigurationName, SoftwareUpdateConfigurationData data, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(softwareUpdateConfigurationName, nameof(softwareUpdateConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _softwareUpdateConfigurationClientDiagnostics.CreateScope("SoftwareUpdateConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _softwareUpdateConfigurationRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, softwareUpdateConfigurationName, data, clientRequestId, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<SoftwareUpdateConfigurationResource>(Response.FromValue(new SoftwareUpdateConfigurationResource(Client, response), response.GetRawResponse()));
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
        /// Create a new software update configuration with the name given in the URI.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/softwareUpdateConfigurations/{softwareUpdateConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SoftwareUpdateConfigurations_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="softwareUpdateConfigurationName"> The name of the software update configuration to be created. </param>
        /// <param name="data"> Request body. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="softwareUpdateConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="softwareUpdateConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SoftwareUpdateConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string softwareUpdateConfigurationName, SoftwareUpdateConfigurationData data, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(softwareUpdateConfigurationName, nameof(softwareUpdateConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _softwareUpdateConfigurationClientDiagnostics.CreateScope("SoftwareUpdateConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _softwareUpdateConfigurationRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, softwareUpdateConfigurationName, data, clientRequestId, cancellationToken);
                var operation = new AutomationArmOperation<SoftwareUpdateConfigurationResource>(Response.FromValue(new SoftwareUpdateConfigurationResource(Client, response), response.GetRawResponse()));
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
        /// Get a single software update configuration by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/softwareUpdateConfigurations/{softwareUpdateConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SoftwareUpdateConfigurations_GetByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="softwareUpdateConfigurationName"> The name of the software update configuration to be created. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="softwareUpdateConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="softwareUpdateConfigurationName"/> is null. </exception>
        public virtual async Task<Response<SoftwareUpdateConfigurationResource>> GetAsync(string softwareUpdateConfigurationName, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(softwareUpdateConfigurationName, nameof(softwareUpdateConfigurationName));

            using var scope = _softwareUpdateConfigurationClientDiagnostics.CreateScope("SoftwareUpdateConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _softwareUpdateConfigurationRestClient.GetByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, softwareUpdateConfigurationName, clientRequestId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SoftwareUpdateConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a single software update configuration by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/softwareUpdateConfigurations/{softwareUpdateConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SoftwareUpdateConfigurations_GetByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="softwareUpdateConfigurationName"> The name of the software update configuration to be created. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="softwareUpdateConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="softwareUpdateConfigurationName"/> is null. </exception>
        public virtual Response<SoftwareUpdateConfigurationResource> Get(string softwareUpdateConfigurationName, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(softwareUpdateConfigurationName, nameof(softwareUpdateConfigurationName));

            using var scope = _softwareUpdateConfigurationClientDiagnostics.CreateScope("SoftwareUpdateConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _softwareUpdateConfigurationRestClient.GetByName(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, softwareUpdateConfigurationName, clientRequestId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SoftwareUpdateConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all software update configurations for the account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/softwareUpdateConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SoftwareUpdateConfigurations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SoftwareUpdateConfigurationCollectionItem" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SoftwareUpdateConfigurationCollectionItem> GetAllAsync(string clientRequestId = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _softwareUpdateConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientRequestId, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, SoftwareUpdateConfigurationCollectionItem.DeserializeSoftwareUpdateConfigurationCollectionItem, _softwareUpdateConfigurationClientDiagnostics, Pipeline, "SoftwareUpdateConfigurationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get all software update configurations for the account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/softwareUpdateConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SoftwareUpdateConfigurations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SoftwareUpdateConfigurationCollectionItem" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SoftwareUpdateConfigurationCollectionItem> GetAll(string clientRequestId = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _softwareUpdateConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, clientRequestId, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, SoftwareUpdateConfigurationCollectionItem.DeserializeSoftwareUpdateConfigurationCollectionItem, _softwareUpdateConfigurationClientDiagnostics, Pipeline, "SoftwareUpdateConfigurationCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/softwareUpdateConfigurations/{softwareUpdateConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SoftwareUpdateConfigurations_GetByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="softwareUpdateConfigurationName"> The name of the software update configuration to be created. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="softwareUpdateConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="softwareUpdateConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string softwareUpdateConfigurationName, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(softwareUpdateConfigurationName, nameof(softwareUpdateConfigurationName));

            using var scope = _softwareUpdateConfigurationClientDiagnostics.CreateScope("SoftwareUpdateConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _softwareUpdateConfigurationRestClient.GetByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, softwareUpdateConfigurationName, clientRequestId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/softwareUpdateConfigurations/{softwareUpdateConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SoftwareUpdateConfigurations_GetByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="softwareUpdateConfigurationName"> The name of the software update configuration to be created. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="softwareUpdateConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="softwareUpdateConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string softwareUpdateConfigurationName, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(softwareUpdateConfigurationName, nameof(softwareUpdateConfigurationName));

            using var scope = _softwareUpdateConfigurationClientDiagnostics.CreateScope("SoftwareUpdateConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _softwareUpdateConfigurationRestClient.GetByName(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, softwareUpdateConfigurationName, clientRequestId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/softwareUpdateConfigurations/{softwareUpdateConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SoftwareUpdateConfigurations_GetByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="softwareUpdateConfigurationName"> The name of the software update configuration to be created. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="softwareUpdateConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="softwareUpdateConfigurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<SoftwareUpdateConfigurationResource>> GetIfExistsAsync(string softwareUpdateConfigurationName, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(softwareUpdateConfigurationName, nameof(softwareUpdateConfigurationName));

            using var scope = _softwareUpdateConfigurationClientDiagnostics.CreateScope("SoftwareUpdateConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _softwareUpdateConfigurationRestClient.GetByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, softwareUpdateConfigurationName, clientRequestId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SoftwareUpdateConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new SoftwareUpdateConfigurationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/softwareUpdateConfigurations/{softwareUpdateConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SoftwareUpdateConfigurations_GetByName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="softwareUpdateConfigurationName"> The name of the software update configuration to be created. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="softwareUpdateConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="softwareUpdateConfigurationName"/> is null. </exception>
        public virtual NullableResponse<SoftwareUpdateConfigurationResource> GetIfExists(string softwareUpdateConfigurationName, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(softwareUpdateConfigurationName, nameof(softwareUpdateConfigurationName));

            using var scope = _softwareUpdateConfigurationClientDiagnostics.CreateScope("SoftwareUpdateConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _softwareUpdateConfigurationRestClient.GetByName(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, softwareUpdateConfigurationName, clientRequestId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SoftwareUpdateConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new SoftwareUpdateConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SoftwareUpdateConfigurationCollectionItem> IEnumerable<SoftwareUpdateConfigurationCollectionItem>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SoftwareUpdateConfigurationCollectionItem> IAsyncEnumerable<SoftwareUpdateConfigurationCollectionItem>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
