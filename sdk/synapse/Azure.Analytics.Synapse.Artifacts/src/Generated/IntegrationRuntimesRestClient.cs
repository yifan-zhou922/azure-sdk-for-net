// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    internal partial class IntegrationRuntimesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> Initializes a new instance of IntegrationRuntimesRestClient. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        public IntegrationRuntimesRestClient(HttpPipeline pipeline, Uri endpoint)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
        }

        internal HttpMessage CreateListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/integrationRuntimes", false);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> List Integration Runtimes. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<IntegrationRuntimeListResponse>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationRuntimeListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IntegrationRuntimeListResponse.DeserializeIntegrationRuntimeListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List Integration Runtimes. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<IntegrationRuntimeListResponse> List(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationRuntimeListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IntegrationRuntimeListResponse.DeserializeIntegrationRuntimeListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string integrationRuntimeName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/integrationRuntimes/", false);
            uri.AppendPath(integrationRuntimeName, true);
            uri.AppendQuery("api-version", "2020-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get Integration Runtime. </summary>
        /// <param name="integrationRuntimeName"> The Integration Runtime name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationRuntimeName"/> is null. </exception>
        public async Task<Response<IntegrationRuntimeResource>> GetAsync(string integrationRuntimeName, CancellationToken cancellationToken = default)
        {
            if (integrationRuntimeName == null)
            {
                throw new ArgumentNullException(nameof(integrationRuntimeName));
            }

            using var message = CreateGetRequest(integrationRuntimeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationRuntimeResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IntegrationRuntimeResource.DeserializeIntegrationRuntimeResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get Integration Runtime. </summary>
        /// <param name="integrationRuntimeName"> The Integration Runtime name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationRuntimeName"/> is null. </exception>
        public Response<IntegrationRuntimeResource> Get(string integrationRuntimeName, CancellationToken cancellationToken = default)
        {
            if (integrationRuntimeName == null)
            {
                throw new ArgumentNullException(nameof(integrationRuntimeName));
            }

            using var message = CreateGetRequest(integrationRuntimeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationRuntimeResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IntegrationRuntimeResource.DeserializeIntegrationRuntimeResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
