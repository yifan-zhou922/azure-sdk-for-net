// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Data.SchemaRegistry.Models;

namespace Azure.Data.SchemaRegistry
{
    internal partial class SchemaGroupsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of SchemaGroupsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The Schema Registry service endpoint, for example my-namespace.servicebus.windows.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public SchemaGroupsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2021-10")
        {
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/$schemaGroups", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the list of schema groups user is authorized to access. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SchemaGroups>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SchemaGroups value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SchemaGroups.DeserializeSchemaGroups(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the list of schema groups user is authorized to access. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SchemaGroups> List(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SchemaGroups value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SchemaGroups.DeserializeSchemaGroups(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
