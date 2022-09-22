// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class MachineExtensionInstanceViewStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code");
                writer.WriteStringValue(Code);
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level");
                writer.WriteStringValue(Level.Value.ToString());
            }
            if (Optional.IsDefined(DisplayStatus))
            {
                writer.WritePropertyName("displayStatus");
                writer.WriteStringValue(DisplayStatus);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message");
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(Time))
            {
                writer.WritePropertyName("time");
                writer.WriteStringValue(Time.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static MachineExtensionInstanceViewStatus DeserializeMachineExtensionInstanceViewStatus(JsonElement element)
        {
            Optional<string> code = default;
            Optional<StatusLevelType> level = default;
            Optional<string> displayStatus = default;
            Optional<string> message = default;
            Optional<DateTimeOffset> time = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("level"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    level = new StatusLevelType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayStatus"))
                {
                    displayStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("time"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    time = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new MachineExtensionInstanceViewStatus(code.Value, Optional.ToNullable(level), displayStatus.Value, message.Value, Optional.ToNullable(time));
        }
    }
}
