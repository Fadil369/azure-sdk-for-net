// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    internal partial class BinaryHardeningList
    {
        internal static BinaryHardeningList DeserializeBinaryHardeningList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<BinaryHardening>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryHardening> array = new List<BinaryHardening>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BinaryHardening.DeserializeBinaryHardening(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new BinaryHardeningList(Optional.ToList(value), nextLink.Value);
        }
    }
}
