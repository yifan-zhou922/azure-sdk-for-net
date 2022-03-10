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
using Azure.IoT.Hub.Service.Models;

namespace Azure.IoT.Hub.Service
{
    internal partial class CloudToDeviceMessagesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of CloudToDeviceMessagesRestClient. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public CloudToDeviceMessagesRestClient(HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2020-03-13")
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://fully-qualified-iothubname.azure-devices.net");
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreatePurgeCloudToDeviceMessageQueueRequest(string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/devices/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/commands", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes all the pending commands for a device in the IoT Hub. </summary>
        /// <param name="id"> The unique identifier of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async Task<Response<PurgeMessageQueueResult>> PurgeCloudToDeviceMessageQueueAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreatePurgeCloudToDeviceMessageQueueRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PurgeMessageQueueResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PurgeMessageQueueResult.DeserializePurgeMessageQueueResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes all the pending commands for a device in the IoT Hub. </summary>
        /// <param name="id"> The unique identifier of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public Response<PurgeMessageQueueResult> PurgeCloudToDeviceMessageQueue(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var message = CreatePurgeCloudToDeviceMessageQueueRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PurgeMessageQueueResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PurgeMessageQueueResult.DeserializePurgeMessageQueueResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateReceiveFeedbackNotificationRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/messages/serviceBound/feedback", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets the feedback for cloud-to-device messages. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging for more information. This capability is only available in the standard tier IoT Hub. For more information, see [Choose the right IoT Hub tier](https://aka.ms/scaleyouriotsolution). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> ReceiveFeedbackNotificationAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateReceiveFeedbackNotificationRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the feedback for cloud-to-device messages. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging for more information. This capability is only available in the standard tier IoT Hub. For more information, see [Choose the right IoT Hub tier](https://aka.ms/scaleyouriotsolution). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response ReceiveFeedbackNotification(CancellationToken cancellationToken = default)
        {
            using var message = CreateReceiveFeedbackNotificationRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCompleteFeedbackNotificationRequest(string lockToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/messages/serviceBound/feedback/", false);
            uri.AppendPath(lockToken, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Completes the cloud-to-device feedback message. A completed message is deleted from the feedback queue of the service. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging for more information. </summary>
        /// <param name="lockToken"> The lock token obtained when the cloud-to-device message is received. This is used to resolve race conditions when completing a feedback message. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lockToken"/> is null. </exception>
        public async Task<Response> CompleteFeedbackNotificationAsync(string lockToken, CancellationToken cancellationToken = default)
        {
            if (lockToken == null)
            {
                throw new ArgumentNullException(nameof(lockToken));
            }

            using var message = CreateCompleteFeedbackNotificationRequest(lockToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Completes the cloud-to-device feedback message. A completed message is deleted from the feedback queue of the service. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging for more information. </summary>
        /// <param name="lockToken"> The lock token obtained when the cloud-to-device message is received. This is used to resolve race conditions when completing a feedback message. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lockToken"/> is null. </exception>
        public Response CompleteFeedbackNotification(string lockToken, CancellationToken cancellationToken = default)
        {
            if (lockToken == null)
            {
                throw new ArgumentNullException(nameof(lockToken));
            }

            using var message = CreateCompleteFeedbackNotificationRequest(lockToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAbandonFeedbackNotificationRequest(string lockToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/messages/serviceBound/feedback/", false);
            uri.AppendPath(lockToken, true);
            uri.AppendPath("/abandon", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Abandons the lock on a cloud-to-device feedback message. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging for more information. </summary>
        /// <param name="lockToken"> The lock token obtained when the cloud-to-device message is received. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lockToken"/> is null. </exception>
        public async Task<Response> AbandonFeedbackNotificationAsync(string lockToken, CancellationToken cancellationToken = default)
        {
            if (lockToken == null)
            {
                throw new ArgumentNullException(nameof(lockToken));
            }

            using var message = CreateAbandonFeedbackNotificationRequest(lockToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Abandons the lock on a cloud-to-device feedback message. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging for more information. </summary>
        /// <param name="lockToken"> The lock token obtained when the cloud-to-device message is received. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lockToken"/> is null. </exception>
        public Response AbandonFeedbackNotification(string lockToken, CancellationToken cancellationToken = default)
        {
            if (lockToken == null)
            {
                throw new ArgumentNullException(nameof(lockToken));
            }

            using var message = CreateAbandonFeedbackNotificationRequest(lockToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
