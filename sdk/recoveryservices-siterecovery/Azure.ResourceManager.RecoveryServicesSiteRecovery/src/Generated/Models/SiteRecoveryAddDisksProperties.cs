// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Add Disks input properties. </summary>
    internal partial class SiteRecoveryAddDisksProperties
    {
        /// <summary> Initializes a new instance of SiteRecoveryAddDisksProperties. </summary>
        /// <param name="providerSpecificDetails">
        /// The ReplicationProviderInput. For HyperVReplicaAzure provider, it will be AzureEnableProtectionInput object. For San provider, it will be SanEnableProtectionInput object. For HyperVReplicaAzure provider, it can be null.
        /// Please note <see cref="SiteRecoveryAddDisksProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AAddDisksContent"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerSpecificDetails"/> is null. </exception>
        public SiteRecoveryAddDisksProperties(SiteRecoveryAddDisksProviderSpecificContent providerSpecificDetails)
        {
            Argument.AssertNotNull(providerSpecificDetails, nameof(providerSpecificDetails));

            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary>
        /// The ReplicationProviderInput. For HyperVReplicaAzure provider, it will be AzureEnableProtectionInput object. For San provider, it will be SanEnableProtectionInput object. For HyperVReplicaAzure provider, it can be null.
        /// Please note <see cref="SiteRecoveryAddDisksProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AAddDisksContent"/>.
        /// </summary>
        public SiteRecoveryAddDisksProviderSpecificContent ProviderSpecificDetails { get; }
    }
}
