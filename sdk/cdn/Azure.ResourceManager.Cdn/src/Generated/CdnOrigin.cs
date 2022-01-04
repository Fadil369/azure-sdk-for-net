// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A Class representing a CdnOrigin along with the instance operations that can be performed on it. </summary>
    public partial class CdnOrigin : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CdnOrigin"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string originName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/origins/{originName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CdnOriginsRestOperations _cdnOriginsRestClient;
        private readonly CdnOriginData _data;

        /// <summary> Initializes a new instance of the <see cref="CdnOrigin"/> class for mocking. </summary>
        protected CdnOrigin()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CdnOrigin"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal CdnOrigin(ArmResource options, CdnOriginData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _cdnOriginsRestClient = new CdnOriginsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="CdnOrigin"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CdnOrigin(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _cdnOriginsRestClient = new CdnOriginsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="CdnOrigin"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CdnOrigin(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _cdnOriginsRestClient = new CdnOriginsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Cdn/profiles/endpoints/origins";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CdnOriginData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets an existing origin within an endpoint. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<CdnOrigin>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CdnOrigin.Get");
            scope.Start();
            try
            {
                var response = await _cdnOriginsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CdnOrigin(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing origin within an endpoint. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CdnOrigin> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CdnOrigin.Get");
            scope.Start();
            try
            {
                var response = _cdnOriginsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnOrigin(this, response.Value), response.GetRawResponse());
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
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes an existing origin within an endpoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<CdnOriginDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CdnOrigin.Delete");
            scope.Start();
            try
            {
                var response = await _cdnOriginsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CdnOriginDeleteOperation(_clientDiagnostics, Pipeline, _cdnOriginsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes an existing origin within an endpoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual CdnOriginDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CdnOrigin.Delete");
            scope.Start();
            try
            {
                var response = _cdnOriginsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CdnOriginDeleteOperation(_clientDiagnostics, Pipeline, _cdnOriginsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an existing origin within an endpoint. </summary>
        /// <param name="originUpdateProperties"> Origin properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originUpdateProperties"/> is null. </exception>
        public async virtual Task<CdnOriginUpdateOperation> UpdateAsync(OriginUpdateOptions originUpdateProperties, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (originUpdateProperties == null)
            {
                throw new ArgumentNullException(nameof(originUpdateProperties));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOrigin.Update");
            scope.Start();
            try
            {
                var response = await _cdnOriginsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, originUpdateProperties, cancellationToken).ConfigureAwait(false);
                var operation = new CdnOriginUpdateOperation(this, _clientDiagnostics, Pipeline, _cdnOriginsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, originUpdateProperties).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an existing origin within an endpoint. </summary>
        /// <param name="originUpdateProperties"> Origin properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originUpdateProperties"/> is null. </exception>
        public virtual CdnOriginUpdateOperation Update(OriginUpdateOptions originUpdateProperties, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (originUpdateProperties == null)
            {
                throw new ArgumentNullException(nameof(originUpdateProperties));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOrigin.Update");
            scope.Start();
            try
            {
                var response = _cdnOriginsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, originUpdateProperties, cancellationToken);
                var operation = new CdnOriginUpdateOperation(this, _clientDiagnostics, Pipeline, _cdnOriginsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, originUpdateProperties).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
