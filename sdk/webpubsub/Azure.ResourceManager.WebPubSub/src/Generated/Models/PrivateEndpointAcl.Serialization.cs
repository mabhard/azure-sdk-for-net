// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    public partial class PrivateEndpointAcl : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsCollectionDefined(Allow))
            {
                writer.WritePropertyName("allow"u8);
                writer.WriteStartArray();
                foreach (var item in Allow)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Deny))
            {
                writer.WritePropertyName("deny"u8);
                writer.WriteStartArray();
                foreach (var item in Deny)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static PrivateEndpointAcl DeserializePrivateEndpointAcl(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<IList<WebPubSubRequestType>> allow = default;
            Optional<IList<WebPubSubRequestType>> deny = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WebPubSubRequestType> array = new List<WebPubSubRequestType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new WebPubSubRequestType(item.GetString()));
                    }
                    allow = array;
                    continue;
                }
                if (property.NameEquals("deny"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WebPubSubRequestType> array = new List<WebPubSubRequestType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new WebPubSubRequestType(item.GetString()));
                    }
                    deny = array;
                    continue;
                }
            }
            return new PrivateEndpointAcl(Optional.ToList(allow), Optional.ToList(deny), name);
        }
    }
}
