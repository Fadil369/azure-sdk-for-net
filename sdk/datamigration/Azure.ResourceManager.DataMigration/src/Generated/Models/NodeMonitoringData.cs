// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The NodeMonitoringData. </summary>
    public partial class NodeMonitoringData
    {
        /// <summary> Initializes a new instance of NodeMonitoringData. </summary>
        internal NodeMonitoringData()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of NodeMonitoringData. </summary>
        /// <param name="additionalProperties"> Unmatched properties from the message are deserialized in this collection. </param>
        /// <param name="nodeName"> Name of the integration runtime node. </param>
        /// <param name="availableMemoryInMB"> Available memory (MB) on the integration runtime node. </param>
        /// <param name="cpuUtilization"> CPU percentage on the integration runtime node. </param>
        /// <param name="concurrentJobsLimit"> Maximum concurrent jobs on the integration runtime node. </param>
        /// <param name="concurrentJobsRunning"> The number of jobs currently running on the integration runtime node. </param>
        /// <param name="maxConcurrentJobs"> The maximum concurrent jobs in this integration runtime. </param>
        /// <param name="sentBytes"> Sent bytes on the integration runtime node. </param>
        /// <param name="receivedBytes"> Received bytes on the integration runtime node. </param>
        internal NodeMonitoringData(IReadOnlyDictionary<string, BinaryData> additionalProperties, string nodeName, int? availableMemoryInMB, int? cpuUtilization, int? concurrentJobsLimit, int? concurrentJobsRunning, int? maxConcurrentJobs, double? sentBytes, double? receivedBytes)
        {
            AdditionalProperties = additionalProperties;
            NodeName = nodeName;
            AvailableMemoryInMB = availableMemoryInMB;
            CpuUtilization = cpuUtilization;
            ConcurrentJobsLimit = concurrentJobsLimit;
            ConcurrentJobsRunning = concurrentJobsRunning;
            MaxConcurrentJobs = maxConcurrentJobs;
            SentBytes = sentBytes;
            ReceivedBytes = receivedBytes;
        }

        /// <summary> Unmatched properties from the message are deserialized in this collection. </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
        /// <summary> Name of the integration runtime node. </summary>
        public string NodeName { get; }
        /// <summary> Available memory (MB) on the integration runtime node. </summary>
        public int? AvailableMemoryInMB { get; }
        /// <summary> CPU percentage on the integration runtime node. </summary>
        public int? CpuUtilization { get; }
        /// <summary> Maximum concurrent jobs on the integration runtime node. </summary>
        public int? ConcurrentJobsLimit { get; }
        /// <summary> The number of jobs currently running on the integration runtime node. </summary>
        public int? ConcurrentJobsRunning { get; }
        /// <summary> The maximum concurrent jobs in this integration runtime. </summary>
        public int? MaxConcurrentJobs { get; }
        /// <summary> Sent bytes on the integration runtime node. </summary>
        public double? SentBytes { get; }
        /// <summary> Received bytes on the integration runtime node. </summary>
        public double? ReceivedBytes { get; }
    }
}
