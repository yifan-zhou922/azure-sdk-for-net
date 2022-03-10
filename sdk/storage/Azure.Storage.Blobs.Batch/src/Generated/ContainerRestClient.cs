// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Storage.Blobs.Batch
{
    internal partial class ContainerRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _url;
        private readonly string _version;

        /// <summary> Initializes a new instance of ContainerRestClient. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> The URL of the service account, container, or blob that is the targe of the desired operation. </param>
        /// <param name="version"> Specifies the version of the operation to use for this request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/>, <paramref name="url"/> or <paramref name="version"/> is null. </exception>
        public ContainerRestClient(HttpPipeline pipeline, string url, string version = "2020-06-12")
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _url = url ?? throw new ArgumentNullException(nameof(url));
            _version = version ?? throw new ArgumentNullException(nameof(version));
        }

        /// <summary> The Batch operation allows multiple API calls to be embedded into a single HTTP request. </summary>
        /// <param name="containerName"> The container name. </param>
        /// <param name="contentLength"> The length of the request. </param>
        /// <param name="multipartContentType"> Required. The value of this header must be multipart/mixed with a batch boundary. Example header value: multipart/mixed; boundary=batch_&lt;GUID&gt;. </param>
        /// <param name="body"> Initial data. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations&quot;&gt;Setting Timeouts for Blob Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/>, <paramref name="multipartContentType"/> or <paramref name="body"/> is null. </exception>
        public async Task<ResponseWithHeaders<Stream, ContainerSubmitBatchHeaders>> SubmitBatchAsync(string containerName, long contentLength, string multipartContentType, Stream body, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (multipartContentType == null)
            {
                throw new ArgumentNullException(nameof(multipartContentType));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateSubmitBatchRequest(containerName, contentLength, multipartContentType, body, timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ContainerSubmitBatchHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        var value = message.ExtractResponseContent();
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> The Batch operation allows multiple API calls to be embedded into a single HTTP request. </summary>
        /// <param name="containerName"> The container name. </param>
        /// <param name="contentLength"> The length of the request. </param>
        /// <param name="multipartContentType"> Required. The value of this header must be multipart/mixed with a batch boundary. Example header value: multipart/mixed; boundary=batch_&lt;GUID&gt;. </param>
        /// <param name="body"> Initial data. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href=&quot;https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations&quot;&gt;Setting Timeouts for Blob Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/>, <paramref name="multipartContentType"/> or <paramref name="body"/> is null. </exception>
        public ResponseWithHeaders<Stream, ContainerSubmitBatchHeaders> SubmitBatch(string containerName, long contentLength, string multipartContentType, Stream body, int? timeout = null, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (multipartContentType == null)
            {
                throw new ArgumentNullException(nameof(multipartContentType));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateSubmitBatchRequest(containerName, contentLength, multipartContentType, body, timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new ContainerSubmitBatchHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        var value = message.ExtractResponseContent();
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
