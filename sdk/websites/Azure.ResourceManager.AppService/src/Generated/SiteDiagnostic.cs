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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteDiagnostic along with the instance operations that can be performed on it. </summary>
    public partial class SiteDiagnostic : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteDiagnostic"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string diagnosticCategory)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteDiagnosticDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteDiagnosticDiagnosticsRestClient;
        private readonly DiagnosticCategoryData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteDiagnostic"/> class for mocking. </summary>
        protected SiteDiagnostic()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteDiagnostic"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteDiagnostic(ArmClient client, DiagnosticCategoryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteDiagnostic"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteDiagnostic(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteDiagnosticDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string siteDiagnosticDiagnosticsApiVersion);
            _siteDiagnosticDiagnosticsRestClient = new DiagnosticsRestOperations(_siteDiagnosticDiagnosticsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteDiagnosticDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/diagnostics";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DiagnosticCategoryData Data
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

        /// <summary> Gets a collection of SiteDiagnosticAnalyses in the SiteDiagnosticAnalysis. </summary>
        /// <returns> An object representing collection of SiteDiagnosticAnalyses and their operations over a SiteDiagnosticAnalysis. </returns>
        public virtual SiteDiagnosticAnalysisCollection GetSiteDiagnosticAnalyses()
        {
            return new SiteDiagnosticAnalysisCollection(Client, Id);
        }

        /// <summary> Gets a collection of SiteDiagnosticDetectors in the SiteDiagnosticDetector. </summary>
        /// <returns> An object representing collection of SiteDiagnosticDetectors and their operations over a SiteDiagnosticDetector. </returns>
        public virtual SiteDiagnosticDetectorCollection GetSiteDiagnosticDetectors()
        {
            return new SiteDiagnosticDetectorCollection(Client, Id);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// OperationId: Diagnostics_GetSiteDiagnosticCategory
        /// <summary> Description for Get Diagnostics Category. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SiteDiagnostic>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnostic.Get");
            scope.Start();
            try
            {
                var response = await _siteDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteDiagnosticDiagnosticsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteDiagnostic(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// OperationId: Diagnostics_GetSiteDiagnosticCategory
        /// <summary> Description for Get Diagnostics Category. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteDiagnostic> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnostic.Get");
            scope.Start();
            try
            {
                var response = _siteDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategory(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _siteDiagnosticDiagnosticsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnostic(Client, response.Value), response.GetRawResponse());
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
            using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnostic.GetAvailableLocations");
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
            using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnostic.GetAvailableLocations");
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
