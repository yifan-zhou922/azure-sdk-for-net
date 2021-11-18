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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class VirtualNetworkGatewayNatRulesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of VirtualNetworkGatewayNatRulesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public VirtualNetworkGatewayNatRulesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-02-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string virtualNetworkGatewayName, string natRuleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualNetworkGateways/", false);
            uri.AppendPath(virtualNetworkGatewayName, true);
            uri.AppendPath("/natRules/", false);
            uri.AppendPath(natRuleName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Retrieves the details of a nat rule. </summary>
        /// <param name="resourceGroupName"> The resource group name of the Virtual Network Gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/>, or <paramref name="natRuleName"/> is null. </exception>
        public async Task<Response<VirtualNetworkGatewayNatRuleData>> GetAsync(string resourceGroupName, string virtualNetworkGatewayName, string natRuleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
            }
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var message = CreateGetRequest(resourceGroupName, virtualNetworkGatewayName, natRuleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualNetworkGatewayNatRuleData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualNetworkGatewayNatRuleData.DeserializeVirtualNetworkGatewayNatRuleData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VirtualNetworkGatewayNatRuleData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves the details of a nat rule. </summary>
        /// <param name="resourceGroupName"> The resource group name of the Virtual Network Gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/>, or <paramref name="natRuleName"/> is null. </exception>
        public Response<VirtualNetworkGatewayNatRuleData> Get(string resourceGroupName, string virtualNetworkGatewayName, string natRuleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
            }
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var message = CreateGetRequest(resourceGroupName, virtualNetworkGatewayName, natRuleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualNetworkGatewayNatRuleData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualNetworkGatewayNatRuleData.DeserializeVirtualNetworkGatewayNatRuleData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VirtualNetworkGatewayNatRuleData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string virtualNetworkGatewayName, string natRuleName, VirtualNetworkGatewayNatRuleData natRuleParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualNetworkGateways/", false);
            uri.AppendPath(virtualNetworkGatewayName, true);
            uri.AppendPath("/natRules/", false);
            uri.AppendPath(natRuleName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(natRuleParameters);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Creates a nat rule to a scalable virtual network gateway if it doesn&apos;t exist else updates the existing nat rules. </summary>
        /// <param name="resourceGroupName"> The resource group name of the Virtual Network Gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/>, <paramref name="natRuleName"/>, or <paramref name="natRuleParameters"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string virtualNetworkGatewayName, string natRuleName, VirtualNetworkGatewayNatRuleData natRuleParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
            }
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, virtualNetworkGatewayName, natRuleName, natRuleParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a nat rule to a scalable virtual network gateway if it doesn&apos;t exist else updates the existing nat rules. </summary>
        /// <param name="resourceGroupName"> The resource group name of the Virtual Network Gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/>, <paramref name="natRuleName"/>, or <paramref name="natRuleParameters"/> is null. </exception>
        public Response CreateOrUpdate(string resourceGroupName, string virtualNetworkGatewayName, string natRuleName, VirtualNetworkGatewayNatRuleData natRuleParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
            }
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, virtualNetworkGatewayName, natRuleName, natRuleParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string virtualNetworkGatewayName, string natRuleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualNetworkGateways/", false);
            uri.AppendPath(virtualNetworkGatewayName, true);
            uri.AppendPath("/natRules/", false);
            uri.AppendPath(natRuleName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Deletes a nat rule. </summary>
        /// <param name="resourceGroupName"> The resource group name of the Virtual Network Gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/>, or <paramref name="natRuleName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string virtualNetworkGatewayName, string natRuleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
            }
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, virtualNetworkGatewayName, natRuleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a nat rule. </summary>
        /// <param name="resourceGroupName"> The resource group name of the Virtual Network Gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/>, or <paramref name="natRuleName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string virtualNetworkGatewayName, string natRuleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
            }
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, virtualNetworkGatewayName, natRuleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVirtualNetworkGatewayRequest(string resourceGroupName, string virtualNetworkGatewayName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualNetworkGateways/", false);
            uri.AppendPath(virtualNetworkGatewayName, true);
            uri.AppendPath("/natRules", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Retrieves all nat rules for a particular virtual network gateway. </summary>
        /// <param name="resourceGroupName"> The resource group name of the virtual network gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public async Task<Response<ListVirtualNetworkGatewayNatRulesResult>> ListByVirtualNetworkGatewayAsync(string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
            }

            using var message = CreateListByVirtualNetworkGatewayRequest(resourceGroupName, virtualNetworkGatewayName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualNetworkGatewayNatRulesResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVirtualNetworkGatewayNatRulesResult.DeserializeListVirtualNetworkGatewayNatRulesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves all nat rules for a particular virtual network gateway. </summary>
        /// <param name="resourceGroupName"> The resource group name of the virtual network gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public Response<ListVirtualNetworkGatewayNatRulesResult> ListByVirtualNetworkGateway(string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
            }

            using var message = CreateListByVirtualNetworkGatewayRequest(resourceGroupName, virtualNetworkGatewayName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualNetworkGatewayNatRulesResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVirtualNetworkGatewayNatRulesResult.DeserializeListVirtualNetworkGatewayNatRulesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVirtualNetworkGatewayNextPageRequest(string nextLink, string resourceGroupName, string virtualNetworkGatewayName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Retrieves all nat rules for a particular virtual network gateway. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The resource group name of the virtual network gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public async Task<Response<ListVirtualNetworkGatewayNatRulesResult>> ListByVirtualNetworkGatewayNextPageAsync(string nextLink, string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
            }

            using var message = CreateListByVirtualNetworkGatewayNextPageRequest(nextLink, resourceGroupName, virtualNetworkGatewayName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualNetworkGatewayNatRulesResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVirtualNetworkGatewayNatRulesResult.DeserializeListVirtualNetworkGatewayNatRulesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves all nat rules for a particular virtual network gateway. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The resource group name of the virtual network gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public Response<ListVirtualNetworkGatewayNatRulesResult> ListByVirtualNetworkGatewayNextPage(string nextLink, string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayName));
            }

            using var message = CreateListByVirtualNetworkGatewayNextPageRequest(nextLink, resourceGroupName, virtualNetworkGatewayName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualNetworkGatewayNatRulesResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVirtualNetworkGatewayNatRulesResult.DeserializeListVirtualNetworkGatewayNatRulesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
