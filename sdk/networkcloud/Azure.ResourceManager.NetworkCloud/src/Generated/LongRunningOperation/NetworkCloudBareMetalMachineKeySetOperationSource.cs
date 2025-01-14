// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.NetworkCloud
{
    internal class NetworkCloudBareMetalMachineKeySetOperationSource : IOperationSource<NetworkCloudBareMetalMachineKeySetResource>
    {
        private readonly ArmClient _client;

        internal NetworkCloudBareMetalMachineKeySetOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkCloudBareMetalMachineKeySetResource IOperationSource<NetworkCloudBareMetalMachineKeySetResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkCloudBareMetalMachineKeySetData.DeserializeNetworkCloudBareMetalMachineKeySetData(document.RootElement);
            return new NetworkCloudBareMetalMachineKeySetResource(_client, data);
        }

        async ValueTask<NetworkCloudBareMetalMachineKeySetResource> IOperationSource<NetworkCloudBareMetalMachineKeySetResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkCloudBareMetalMachineKeySetData.DeserializeNetworkCloudBareMetalMachineKeySetData(document.RootElement);
            return new NetworkCloudBareMetalMachineKeySetResource(_client, data);
        }
    }
}
