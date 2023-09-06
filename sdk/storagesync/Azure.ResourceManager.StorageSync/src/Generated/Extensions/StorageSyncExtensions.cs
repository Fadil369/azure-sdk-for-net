// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.StorageSync.Mocking;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.StorageSync. </summary>
    public static partial class StorageSyncExtensions
    {
        private static StorageSyncArmClientMockingExtension GetStorageSyncArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new StorageSyncArmClientMockingExtension(client);
            });
        }

        private static StorageSyncResourceGroupMockingExtension GetStorageSyncResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new StorageSyncResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static StorageSyncSubscriptionMockingExtension GetStorageSyncSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new StorageSyncSubscriptionMockingExtension(client, resource.Id);
            });
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageSyncServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageSyncServiceResource.CreateResourceIdentifier" /> to create a <see cref="StorageSyncServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageSyncServiceResource" /> object. </returns>
        public static StorageSyncServiceResource GetStorageSyncServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageSyncArmClientMockingExtension(client).GetStorageSyncServiceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageSyncPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageSyncPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="StorageSyncPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageSyncPrivateEndpointConnectionResource" /> object. </returns>
        public static StorageSyncPrivateEndpointConnectionResource GetStorageSyncPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageSyncArmClientMockingExtension(client).GetStorageSyncPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageSyncGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageSyncGroupResource.CreateResourceIdentifier" /> to create a <see cref="StorageSyncGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageSyncGroupResource" /> object. </returns>
        public static StorageSyncGroupResource GetStorageSyncGroupResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageSyncArmClientMockingExtension(client).GetStorageSyncGroupResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CloudEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CloudEndpointResource.CreateResourceIdentifier" /> to create a <see cref="CloudEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudEndpointResource" /> object. </returns>
        public static CloudEndpointResource GetCloudEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageSyncArmClientMockingExtension(client).GetCloudEndpointResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageSyncServerEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageSyncServerEndpointResource.CreateResourceIdentifier" /> to create a <see cref="StorageSyncServerEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageSyncServerEndpointResource" /> object. </returns>
        public static StorageSyncServerEndpointResource GetStorageSyncServerEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageSyncArmClientMockingExtension(client).GetStorageSyncServerEndpointResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageSyncRegisteredServerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageSyncRegisteredServerResource.CreateResourceIdentifier" /> to create a <see cref="StorageSyncRegisteredServerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageSyncRegisteredServerResource" /> object. </returns>
        public static StorageSyncRegisteredServerResource GetStorageSyncRegisteredServerResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageSyncArmClientMockingExtension(client).GetStorageSyncRegisteredServerResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageSyncWorkflowResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageSyncWorkflowResource.CreateResourceIdentifier" /> to create a <see cref="StorageSyncWorkflowResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageSyncWorkflowResource" /> object. </returns>
        public static StorageSyncWorkflowResource GetStorageSyncWorkflowResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageSyncArmClientMockingExtension(client).GetStorageSyncWorkflowResource(id);
        }

        /// <summary> Gets a collection of StorageSyncServiceResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of StorageSyncServiceResources and their operations over a StorageSyncServiceResource. </returns>
        public static StorageSyncServiceCollection GetStorageSyncServices(this ResourceGroupResource resourceGroupResource)
        {
            return GetStorageSyncResourceGroupMockingExtension(resourceGroupResource).GetStorageSyncServices();
        }

        /// <summary>
        /// Get a given StorageSyncService.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSyncServiceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<StorageSyncServiceResource>> GetStorageSyncServiceAsync(this ResourceGroupResource resourceGroupResource, string storageSyncServiceName, CancellationToken cancellationToken = default)
        {
            return await GetStorageSyncResourceGroupMockingExtension(resourceGroupResource).GetStorageSyncServiceAsync(storageSyncServiceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a given StorageSyncService.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSyncServiceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<StorageSyncServiceResource> GetStorageSyncService(this ResourceGroupResource resourceGroupResource, string storageSyncServiceName, CancellationToken cancellationToken = default)
        {
            return GetStorageSyncResourceGroupMockingExtension(resourceGroupResource).GetStorageSyncService(storageSyncServiceName, cancellationToken);
        }

        /// <summary>
        /// Check the give namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageSync/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The desired region for the name check. </param>
        /// <param name="content"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<StorageSyncNameAvailabilityResult>> CheckStorageSyncNameAvailabilityAsync(this SubscriptionResource subscriptionResource, string locationName, StorageSyncNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetStorageSyncSubscriptionMockingExtension(subscriptionResource).CheckStorageSyncNameAvailabilityAsync(locationName, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the give namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageSync/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The desired region for the name check. </param>
        /// <param name="content"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="content"/> is null. </exception>
        public static Response<StorageSyncNameAvailabilityResult> CheckStorageSyncNameAvailability(this SubscriptionResource subscriptionResource, string locationName, StorageSyncNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetStorageSyncSubscriptionMockingExtension(subscriptionResource).CheckStorageSyncNameAvailability(locationName, content, cancellationToken);
        }

        /// <summary>
        /// Get a StorageSyncService list by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageSync/storageSyncServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageSyncServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageSyncServiceResource> GetStorageSyncServicesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageSyncSubscriptionMockingExtension(subscriptionResource).GetStorageSyncServicesAsync(cancellationToken);
        }

        /// <summary>
        /// Get a StorageSyncService list by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageSync/storageSyncServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageSyncServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageSyncServiceResource> GetStorageSyncServices(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageSyncSubscriptionMockingExtension(subscriptionResource).GetStorageSyncServices(cancellationToken);
        }
    }
}
