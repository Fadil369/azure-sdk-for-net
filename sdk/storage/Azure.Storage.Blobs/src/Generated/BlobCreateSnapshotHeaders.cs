// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Storage.Blobs
{
    internal partial class BlobCreateSnapshotHeaders
    {
        private readonly Response _response;
        public BlobCreateSnapshotHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Uniquely identifies the snapshot and indicates the snapshot version. It may be used in subsequent requests to access the snapshot. </summary>
        public string Snapshot => _response.Headers.TryGetValue("x-ms-snapshot", out string value) ? value : null;
        /// <summary> Returns the date and time the container was last modified. Any operation that modifies the blob, including an update of the blob&apos;s metadata or properties, changes the last-modified time of the blob. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> Indicates the version of the Blob service used to execute the request. This header is returned for requests made against version 2009-09-19 and above. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> A DateTime value returned by the service that uniquely identifies the blob. The value of this header indicates the blob version, and may be used in subsequent requests to access this version of the blob. </summary>
        public string VersionId => _response.Headers.TryGetValue("x-ms-version-id", out string value) ? value : null;
        /// <summary> True if the contents of the request are successfully encrypted using the specified algorithm, and false otherwise. For a snapshot request, this header is set to true when metadata was provided in the request and encrypted with a customer-provided key. </summary>
        public bool? IsServerEncrypted => _response.Headers.TryGetValue("x-ms-request-server-encrypted", out bool? value) ? value : null;
    }
}
