// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The IntegrationRuntimes service client. </summary>
    public partial class IntegrationRuntimesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal IntegrationRuntimesRestClient RestClient { get; }

        /// <summary> Initializes a new instance of IntegrationRuntimesClient for mocking. </summary>
        protected IntegrationRuntimesClient()
        {
        }

        /// <summary> Initializes a new instance of IntegrationRuntimesClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public IntegrationRuntimesClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ArtifactsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://dev.azuresynapse.net/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new IntegrationRuntimesRestClient(_pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of IntegrationRuntimesClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        internal IntegrationRuntimesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            RestClient = new IntegrationRuntimesRestClient(pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> List Integration Runtimes. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IntegrationRuntimeListResponse>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IntegrationRuntimesClient.List");
            scope.Start();
            try
            {
                return await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List Integration Runtimes. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IntegrationRuntimeListResponse> List(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IntegrationRuntimesClient.List");
            scope.Start();
            try
            {
                return RestClient.List(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Integration Runtime. </summary>
        /// <param name="integrationRuntimeName"> The Integration Runtime name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IntegrationRuntimeResource>> GetAsync(string integrationRuntimeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IntegrationRuntimesClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(integrationRuntimeName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Integration Runtime. </summary>
        /// <param name="integrationRuntimeName"> The Integration Runtime name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IntegrationRuntimeResource> Get(string integrationRuntimeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IntegrationRuntimesClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(integrationRuntimeName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
