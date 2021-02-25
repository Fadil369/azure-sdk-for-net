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
using Azure.ResourceManager.MachineLearningServices.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    internal partial class DataVersionsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of DataVersionsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Azure subscription identifier. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public DataVersionsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-09-01-preview")
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string name, string version, string resourceGroupName, string workspaceName, DataVersionResource body)
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
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/data/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(version, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (body != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Create or update version. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="version"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public async Task<Response<DataVersionResource>> CreateOrUpdateAsync(string name, string version, string resourceGroupName, string workspaceName, DataVersionResource body = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateCreateOrUpdateRequest(name, version, resourceGroupName, workspaceName, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        DataVersionResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataVersionResource.DeserializeDataVersionResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create or update version. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="version"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public Response<DataVersionResource> CreateOrUpdate(string name, string version, string resourceGroupName, string workspaceName, DataVersionResource body = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateCreateOrUpdateRequest(name, version, resourceGroupName, workspaceName, body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        DataVersionResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataVersionResource.DeserializeDataVersionResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string name, string version, string resourceGroupName, string workspaceName)
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
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/data/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(version, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get version. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="version"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public async Task<Response<DataVersionResource>> GetAsync(string name, string version, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateGetRequest(name, version, resourceGroupName, workspaceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataVersionResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataVersionResource.DeserializeDataVersionResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get version. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="version"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public Response<DataVersionResource> Get(string name, string version, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateGetRequest(name, version, resourceGroupName, workspaceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataVersionResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataVersionResource.DeserializeDataVersionResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string name, string version, string resourceGroupName, string workspaceName)
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
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/data/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(version, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Delete version. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="version"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string name, string version, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateDeleteRequest(name, version, resourceGroupName, workspaceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete version. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="version"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public Response Delete(string name, string version, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateDeleteRequest(name, version, resourceGroupName, workspaceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string name, string resourceGroupName, string workspaceName, string skiptoken)
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
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/data/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (skiptoken != null)
            {
                uri.AppendQuery("$skiptoken", skiptoken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> List versions. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public async Task<Response<DataVersionResourceArmPaginatedResult>> ListAsync(string name, string resourceGroupName, string workspaceName, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateListRequest(name, resourceGroupName, workspaceName, skiptoken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataVersionResourceArmPaginatedResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataVersionResourceArmPaginatedResult.DeserializeDataVersionResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List versions. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public Response<DataVersionResourceArmPaginatedResult> List(string name, string resourceGroupName, string workspaceName, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateListRequest(name, resourceGroupName, workspaceName, skiptoken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataVersionResourceArmPaginatedResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataVersionResourceArmPaginatedResult.DeserializeDataVersionResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string name, string resourceGroupName, string workspaceName, string skiptoken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> List versions. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="name"> Container name. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="name"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public async Task<Response<DataVersionResourceArmPaginatedResult>> ListNextPageAsync(string nextLink, string name, string resourceGroupName, string workspaceName, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateListNextPageRequest(nextLink, name, resourceGroupName, workspaceName, skiptoken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataVersionResourceArmPaginatedResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataVersionResourceArmPaginatedResult.DeserializeDataVersionResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List versions. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="name"> Container name. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="name"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public Response<DataVersionResourceArmPaginatedResult> ListNextPage(string nextLink, string name, string resourceGroupName, string workspaceName, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var message = CreateListNextPageRequest(nextLink, name, resourceGroupName, workspaceName, skiptoken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataVersionResourceArmPaginatedResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataVersionResourceArmPaginatedResult.DeserializeDataVersionResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
