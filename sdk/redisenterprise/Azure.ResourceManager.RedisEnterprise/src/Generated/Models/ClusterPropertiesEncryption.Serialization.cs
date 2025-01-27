// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    internal partial class ClusterPropertiesEncryption : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CustomerManagedKeyEncryption))
            {
                writer.WritePropertyName("customerManagedKeyEncryption"u8);
                writer.WriteObjectValue(CustomerManagedKeyEncryption);
            }
            writer.WriteEndObject();
        }

        internal static ClusterPropertiesEncryption DeserializeClusterPropertiesEncryption(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RedisEnterpriseCustomerManagedKeyEncryption> customerManagedKeyEncryption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customerManagedKeyEncryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    customerManagedKeyEncryption = RedisEnterpriseCustomerManagedKeyEncryption.DeserializeRedisEnterpriseCustomerManagedKeyEncryption(property.Value);
                    continue;
                }
            }
            return new ClusterPropertiesEncryption(customerManagedKeyEncryption.Value);
        }
    }
}
