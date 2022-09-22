// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class ServiceStatuses : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ExtensionService))
            {
                writer.WritePropertyName("extensionService");
                writer.WriteObjectValue(ExtensionService);
            }
            if (Optional.IsDefined(GuestConfigurationService))
            {
                writer.WritePropertyName("guestConfigurationService");
                writer.WriteObjectValue(GuestConfigurationService);
            }
            writer.WriteEndObject();
        }

        internal static ServiceStatuses DeserializeServiceStatuses(JsonElement element)
        {
            Optional<ServiceStatus> extensionService = default;
            Optional<ServiceStatus> guestConfigurationService = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extensionService"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extensionService = ServiceStatus.DeserializeServiceStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("guestConfigurationService"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    guestConfigurationService = ServiceStatus.DeserializeServiceStatus(property.Value);
                    continue;
                }
            }
            return new ServiceStatuses(extensionService.Value, guestConfigurationService.Value);
        }
    }
}
