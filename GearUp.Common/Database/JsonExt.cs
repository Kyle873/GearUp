using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace GearUp.Common.Database
{
    internal static class JsonExt
    {
        /// <summary>
        /// Populate an existing object with properties rather than create a new object. This custom implementation will be obsolete once
        /// System.Text.Json add support for this.
        /// Note : As this is a converter for derived type the expected inputs are either object or collection not value types.
        /// </summary>
        /// <remarks>
        /// Referenced from microsoftgraph sdk for dotnet core (MIT License): 
        /// https://github.com/microsoftgraph/msgraph-sdk-dotnet-core/blob/57861dc4aea6c33908838915c97fc02105b6e788/src/Microsoft.Graph.Core/Serialization/DerivedTypeConverter.cs#L119
        /// </remarks>
        /// <param name="target">The target object</param>
        /// <param name="json">The json element undergoing deserialization</param>
        /// <param name="options">The options to use for deserialization.</param>
        public static void PopulateObject(object target, JsonElement json, JsonSerializerOptions options)
        {
            // We use the target type information since it maybe be derived. We do not want to leave out extra properties in the child class and put them in the additional data unnecessarily
            Type objectType = target.GetType();
            switch (json.ValueKind)
            {
                case JsonValueKind.Object:
                    {
                        // iterate through the object properties
                        foreach (var property in json.EnumerateObject())
                        {
                            // look up the property in the object definition using the mapping provided in the model attribute
                            var propertyInfo = objectType.GetProperties().FirstOrDefault((mappedProperty) =>
                            {
                                var attribute = mappedProperty.GetCustomAttribute<JsonPropertyNameAttribute>();
                                return attribute?.Name == property.Name;
                            });
                            if (propertyInfo == null)
                            {
                                continue;
                            }

                            // Deserialize the property in and update the current object.
                            var parsedValue = JsonSerializer.Deserialize(property.Value.GetRawText(), propertyInfo.PropertyType, options);
                            propertyInfo.SetValue(target, parsedValue);
                        }

                        break;
                    }
                case JsonValueKind.Array:
                    throw new JsonException("Doesn't support JsonValueKind.Array");
            }
        }
    }
}
