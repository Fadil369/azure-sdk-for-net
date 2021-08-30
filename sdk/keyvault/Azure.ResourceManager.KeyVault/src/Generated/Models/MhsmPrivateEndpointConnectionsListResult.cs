// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.KeyVault;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> List of private endpoint connections associated with a managed HSM Pools. </summary>
    internal partial class MhsmPrivateEndpointConnectionsListResult
    {
        /// <summary> Initializes a new instance of MhsmPrivateEndpointConnectionsListResult. </summary>
        internal MhsmPrivateEndpointConnectionsListResult()
        {
            Value = new ChangeTrackingList<MhsmPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of MhsmPrivateEndpointConnectionsListResult. </summary>
        /// <param name="value"> The private endpoint connection associated with a managed HSM Pools. </param>
        /// <param name="nextLink"> The URL to get the next set of managed HSM Pools. </param>
        internal MhsmPrivateEndpointConnectionsListResult(IReadOnlyList<MhsmPrivateEndpointConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The private endpoint connection associated with a managed HSM Pools. </summary>
        public IReadOnlyList<MhsmPrivateEndpointConnectionData> Value { get; }
        /// <summary> The URL to get the next set of managed HSM Pools. </summary>
        public string NextLink { get; }
    }
}
