// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    /// <summary> The Scenes service client. </summary>
    public partial class ScenesClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ScenesClient for mocking. </summary>
        protected ScenesClient()
        {
        }

        /// <summary> Initializes a new instance of ScenesClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ScenesClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options = null)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new FarmBeatsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Get a satellite data ingestion job. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   boundaryId: string,
        ///   startDateTime: string (ISO 8601 Format),
        ///   endDateTime: string (ISO 8601 Format),
        ///   provider: &quot;Microsoft&quot;,
        ///   source: &quot;Sentinel_2_L2A&quot;,
        ///   data: {
        ///     imageNames: [string],
        ///     imageFormats: [string],
        ///     imageResolutions: [number]
        ///   },
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetSatelliteDataIngestionJobDetailsAsync(string jobId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("ScenesClient.GetSatelliteDataIngestionJobDetails");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSatelliteDataIngestionJobDetailsRequest(jobId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a satellite data ingestion job. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   boundaryId: string,
        ///   startDateTime: string (ISO 8601 Format),
        ///   endDateTime: string (ISO 8601 Format),
        ///   provider: &quot;Microsoft&quot;,
        ///   source: &quot;Sentinel_2_L2A&quot;,
        ///   data: {
        ///     imageNames: [string],
        ///     imageFormats: [string],
        ///     imageResolutions: [number]
        ///   },
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetSatelliteDataIngestionJobDetails(string jobId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("ScenesClient.GetSatelliteDataIngestionJobDetails");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSatelliteDataIngestionJobDetailsRequest(jobId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Downloads and returns file stream as response for the given input filePath. </summary>
        /// <param name="filePath"> cloud storage path of scene file. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filePath"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> DownloadAsync(string filePath, RequestContext context = null)
        {
            Argument.AssertNotNull(filePath, nameof(filePath));

            using var scope = ClientDiagnostics.CreateScope("ScenesClient.Download");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDownloadRequest(filePath, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Downloads and returns file stream as response for the given input filePath. </summary>
        /// <param name="filePath"> cloud storage path of scene file. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filePath"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response Download(string filePath, RequestContext context = null)
        {
            Argument.AssertNotNull(filePath, nameof(filePath));

            using var scope = ClientDiagnostics.CreateScope("ScenesClient.Download");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDownloadRequest(filePath, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a paginated list of scene resources. </summary>
        /// <param name="provider"> Provider name of scene data. </param>
        /// <param name="farmerId"> FarmerId. </param>
        /// <param name="boundaryId"> BoundaryId. </param>
        /// <param name="source"> Source name of scene data, default value Sentinel_2_L2A (Sentinel 2 L2A). </param>
        /// <param name="startDateTime"> Scene start UTC datetime (inclusive), sample format: yyyy-MM-ddThh:mm:ssZ. </param>
        /// <param name="endDateTime"> Scene end UTC datetime (inclusive), sample format: yyyy-MM-dThh:mm:ssZ. </param>
        /// <param name="maxCloudCoveragePercentage"> Filter scenes with cloud coverage percentage less than max value. Range [0 to 100.0]. </param>
        /// <param name="maxDarkPixelCoveragePercentage"> Filter scenes with dark pixel coverage percentage less than max value. Range [0 to 100.0]. </param>
        /// <param name="imageNames"> List of image names to be filtered. </param>
        /// <param name="imageResolutions"> List of image resolutions in meters to be filtered. </param>
        /// <param name="imageFormats"> List of image formats to be filtered. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="provider"/>, <paramref name="farmerId"/> or <paramref name="boundaryId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       sceneDateTime: string (ISO 8601 Format),
        ///       provider: string,
        ///       source: string,
        ///       imageFiles: [
        ///         {
        ///           fileLink: string,
        ///           name: string,
        ///           imageFormat: &quot;TIF&quot;,
        ///           resolution: number
        ///         }
        ///       ],
        ///       imageFormat: &quot;TIF&quot;,
        ///       cloudCoverPercentage: number,
        ///       darkPixelPercentage: number,
        ///       ndviMedianValue: number,
        ///       boundaryId: string,
        ///       farmerId: string,
        ///       id: string,
        ///       eTag: string
        ///     }
        ///   ],
        ///   $skipToken: string,
        ///   nextLink: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual AsyncPageable<BinaryData> GetScenesAsync(string provider, string farmerId, string boundaryId, string source = null, DateTimeOffset? startDateTime = null, DateTimeOffset? endDateTime = null, double? maxCloudCoveragePercentage = null, double? maxDarkPixelCoveragePercentage = null, IEnumerable<string> imageNames = null, IEnumerable<double> imageResolutions = null, IEnumerable<string> imageFormats = null, int? maxPageSize = null, string skipToken = null, RequestContext context = null)
        {
            Argument.AssertNotNull(provider, nameof(provider));
            Argument.AssertNotNull(farmerId, nameof(farmerId));
            Argument.AssertNotNull(boundaryId, nameof(boundaryId));

            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, "ScenesClient.GetScenes");
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetScenesRequest(provider, farmerId, boundaryId, source, startDateTime, endDateTime, maxCloudCoveragePercentage, maxDarkPixelCoveragePercentage, imageNames, imageResolutions, imageFormats, maxPageSize, skipToken, context)
                        : CreateGetScenesNextPageRequest(nextLink, provider, farmerId, boundaryId, source, startDateTime, endDateTime, maxCloudCoveragePercentage, maxDarkPixelCoveragePercentage, imageNames, imageResolutions, imageFormats, maxPageSize, skipToken, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Returns a paginated list of scene resources. </summary>
        /// <param name="provider"> Provider name of scene data. </param>
        /// <param name="farmerId"> FarmerId. </param>
        /// <param name="boundaryId"> BoundaryId. </param>
        /// <param name="source"> Source name of scene data, default value Sentinel_2_L2A (Sentinel 2 L2A). </param>
        /// <param name="startDateTime"> Scene start UTC datetime (inclusive), sample format: yyyy-MM-ddThh:mm:ssZ. </param>
        /// <param name="endDateTime"> Scene end UTC datetime (inclusive), sample format: yyyy-MM-dThh:mm:ssZ. </param>
        /// <param name="maxCloudCoveragePercentage"> Filter scenes with cloud coverage percentage less than max value. Range [0 to 100.0]. </param>
        /// <param name="maxDarkPixelCoveragePercentage"> Filter scenes with dark pixel coverage percentage less than max value. Range [0 to 100.0]. </param>
        /// <param name="imageNames"> List of image names to be filtered. </param>
        /// <param name="imageResolutions"> List of image resolutions in meters to be filtered. </param>
        /// <param name="imageFormats"> List of image formats to be filtered. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="provider"/>, <paramref name="farmerId"/> or <paramref name="boundaryId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       sceneDateTime: string (ISO 8601 Format),
        ///       provider: string,
        ///       source: string,
        ///       imageFiles: [
        ///         {
        ///           fileLink: string,
        ///           name: string,
        ///           imageFormat: &quot;TIF&quot;,
        ///           resolution: number
        ///         }
        ///       ],
        ///       imageFormat: &quot;TIF&quot;,
        ///       cloudCoverPercentage: number,
        ///       darkPixelPercentage: number,
        ///       ndviMedianValue: number,
        ///       boundaryId: string,
        ///       farmerId: string,
        ///       id: string,
        ///       eTag: string
        ///     }
        ///   ],
        ///   $skipToken: string,
        ///   nextLink: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Pageable<BinaryData> GetScenes(string provider, string farmerId, string boundaryId, string source = null, DateTimeOffset? startDateTime = null, DateTimeOffset? endDateTime = null, double? maxCloudCoveragePercentage = null, double? maxDarkPixelCoveragePercentage = null, IEnumerable<string> imageNames = null, IEnumerable<double> imageResolutions = null, IEnumerable<string> imageFormats = null, int? maxPageSize = null, string skipToken = null, RequestContext context = null)
        {
            Argument.AssertNotNull(provider, nameof(provider));
            Argument.AssertNotNull(farmerId, nameof(farmerId));
            Argument.AssertNotNull(boundaryId, nameof(boundaryId));

            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, "ScenesClient.GetScenes");
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetScenesRequest(provider, farmerId, boundaryId, source, startDateTime, endDateTime, maxCloudCoveragePercentage, maxDarkPixelCoveragePercentage, imageNames, imageResolutions, imageFormats, maxPageSize, skipToken, context)
                        : CreateGetScenesNextPageRequest(nextLink, provider, farmerId, boundaryId, source, startDateTime, endDateTime, maxCloudCoveragePercentage, maxDarkPixelCoveragePercentage, imageNames, imageResolutions, imageFormats, maxPageSize, skipToken, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Create a satellite data ingestion job. </summary>
        /// <param name="waitUntil"> Indicates whether this method should return once it has started the long-running operation or wait for the operation to fully complete before returning. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobId"> JobId provided by user. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   farmerId: string (required),
        ///   boundaryId: string (required),
        ///   startDateTime: string (ISO 8601 Format) (required),
        ///   endDateTime: string (ISO 8601 Format) (required),
        ///   provider: &quot;Microsoft&quot;,
        ///   source: &quot;Sentinel_2_L2A&quot;,
        ///   data: {
        ///     imageNames: [string],
        ///     imageFormats: [string],
        ///     imageResolutions: [number]
        ///   },
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   boundaryId: string,
        ///   startDateTime: string (ISO 8601 Format),
        ///   endDateTime: string (ISO 8601 Format),
        ///   provider: &quot;Microsoft&quot;,
        ///   source: &quot;Sentinel_2_L2A&quot;,
        ///   data: {
        ///     imageNames: [string],
        ///     imageFormats: [string],
        ///     imageResolutions: [number]
        ///   },
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Operation<BinaryData>> CreateSatelliteDataIngestionJobAsync(WaitUntil waitUntil, string jobId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("ScenesClient.CreateSatelliteDataIngestionJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateSatelliteDataIngestionJobRequest(jobId, content, context);
                return await LowLevelOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "ScenesClient.CreateSatelliteDataIngestionJob", OperationFinalStateVia.Location, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a satellite data ingestion job. </summary>
        /// <param name="waitUntil"> Indicates whether this method should return once it has started the long-running operation or wait for the operation to fully complete before returning. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobId"> JobId provided by user. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   farmerId: string (required),
        ///   boundaryId: string (required),
        ///   startDateTime: string (ISO 8601 Format) (required),
        ///   endDateTime: string (ISO 8601 Format) (required),
        ///   provider: &quot;Microsoft&quot;,
        ///   source: &quot;Sentinel_2_L2A&quot;,
        ///   data: {
        ///     imageNames: [string],
        ///     imageFormats: [string],
        ///     imageResolutions: [number]
        ///   },
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   boundaryId: string,
        ///   startDateTime: string (ISO 8601 Format),
        ///   endDateTime: string (ISO 8601 Format),
        ///   provider: &quot;Microsoft&quot;,
        ///   source: &quot;Sentinel_2_L2A&quot;,
        ///   data: {
        ///     imageNames: [string],
        ///     imageFormats: [string],
        ///     imageResolutions: [number]
        ///   },
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Operation<BinaryData> CreateSatelliteDataIngestionJob(WaitUntil waitUntil, string jobId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("ScenesClient.CreateSatelliteDataIngestionJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateSatelliteDataIngestionJobRequest(jobId, content, context);
                return LowLevelOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "ScenesClient.CreateSatelliteDataIngestionJob", OperationFinalStateVia.Location, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetScenesRequest(string provider, string farmerId, string boundaryId, string source, DateTimeOffset? startDateTime, DateTimeOffset? endDateTime, double? maxCloudCoveragePercentage, double? maxDarkPixelCoveragePercentage, IEnumerable<string> imageNames, IEnumerable<double> imageResolutions, IEnumerable<string> imageFormats, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/scenes", false);
            uri.AppendQuery("provider", provider, true);
            uri.AppendQuery("farmerId", farmerId, true);
            uri.AppendQuery("boundaryId", boundaryId, true);
            if (source != null)
            {
                uri.AppendQuery("source", source, true);
            }
            if (startDateTime != null)
            {
                uri.AppendQuery("startDateTime", startDateTime.Value, "O", true);
            }
            if (endDateTime != null)
            {
                uri.AppendQuery("endDateTime", endDateTime.Value, "O", true);
            }
            if (maxCloudCoveragePercentage != null)
            {
                uri.AppendQuery("maxCloudCoveragePercentage", maxCloudCoveragePercentage.Value, true);
            }
            if (maxDarkPixelCoveragePercentage != null)
            {
                uri.AppendQuery("maxDarkPixelCoveragePercentage", maxDarkPixelCoveragePercentage.Value, true);
            }
            if (imageNames != null)
            {
                foreach (var param in imageNames)
                {
                    uri.AppendQuery("imageNames", param, true);
                }
            }
            if (imageResolutions != null)
            {
                foreach (var param in imageResolutions)
                {
                    uri.AppendQuery("imageResolutions", param, true);
                }
            }
            if (imageFormats != null)
            {
                foreach (var param in imageFormats)
                {
                    uri.AppendQuery("imageFormats", param, true);
                }
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("$maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCreateSatelliteDataIngestionJobRequest(string jobId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier202);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/scenes/satellite/ingest-data/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetSatelliteDataIngestionJobDetailsRequest(string jobId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/scenes/satellite/ingest-data/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateDownloadRequest(string filePath, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/scenes/downloadFiles", false);
            uri.AppendQuery("filePath", filePath, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/octet-stream, application/json");
            return message;
        }

        internal HttpMessage CreateGetScenesNextPageRequest(string nextLink, string provider, string farmerId, string boundaryId, string source, DateTimeOffset? startDateTime, DateTimeOffset? endDateTime, double? maxCloudCoveragePercentage, double? maxDarkPixelCoveragePercentage, IEnumerable<string> imageNames, IEnumerable<double> imageResolutions, IEnumerable<string> imageFormats, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier202;
        private static ResponseClassifier ResponseClassifier202 => _responseClassifier202 ??= new StatusCodeClassifier(stackalloc ushort[] { 202 });
    }
}
