// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class VnetConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VnetName))
            {
                writer.WritePropertyName("vnetName");
                writer.WriteStringValue(VnetName);
            }
            if (Optional.IsDefined(SubnetName))
            {
                writer.WritePropertyName("subnetName");
                writer.WriteStringValue(SubnetName);
            }
            writer.WriteEndObject();
        }

        internal static VnetConfiguration DeserializeVnetConfiguration(JsonElement element)
        {
            Optional<string> vnetName = default;
            Optional<string> subnetName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vnetName"))
                {
                    vnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnetName"))
                {
                    subnetName = property.Value.GetString();
                    continue;
                }
            }
            return new VnetConfiguration(vnetName.Value, subnetName.Value);
        }
    }
}
