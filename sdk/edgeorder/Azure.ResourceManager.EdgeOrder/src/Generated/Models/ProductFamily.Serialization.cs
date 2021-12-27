// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ProductFamily
    {
        internal static ProductFamily DeserializeProductFamily(JsonElement element)
        {
            Optional<string> displayName = default;
            Optional<ProductDescription> description = default;
            Optional<IReadOnlyList<ImageInformation>> imageInformation = default;
            Optional<CostInformation> costInformation = default;
            Optional<AvailabilityInformation> availabilityInformation = default;
            Optional<HierarchyInformation> hierarchyInformation = default;
            Optional<IReadOnlyList<FilterableProperty>> filterableProperties = default;
            Optional<IReadOnlyList<ProductLine>> productLines = default;
            Optional<IReadOnlyList<ResourceProviderDetails>> resourceProviderDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            description = ProductDescription.DeserializeProductDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("imageInformation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ImageInformation> array = new List<ImageInformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.ImageInformation.DeserializeImageInformation(item));
                            }
                            imageInformation = array;
                            continue;
                        }
                        if (property0.NameEquals("costInformation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            costInformation = CostInformation.DeserializeCostInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("availabilityInformation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            availabilityInformation = AvailabilityInformation.DeserializeAvailabilityInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hierarchyInformation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hierarchyInformation = HierarchyInformation.DeserializeHierarchyInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("filterableProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FilterableProperty> array = new List<FilterableProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FilterableProperty.DeserializeFilterableProperty(item));
                            }
                            filterableProperties = array;
                            continue;
                        }
                        if (property0.NameEquals("productLines"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ProductLine> array = new List<ProductLine>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ProductLine.DeserializeProductLine(item));
                            }
                            productLines = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceProviderDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ResourceProviderDetails> array = new List<ResourceProviderDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.ResourceProviderDetails.DeserializeResourceProviderDetails(item));
                            }
                            resourceProviderDetails = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ProductFamily(displayName.Value, description.Value, Optional.ToList(imageInformation), costInformation.Value, availabilityInformation.Value, hierarchyInformation.Value, Optional.ToList(filterableProperties), Optional.ToList(productLines), Optional.ToList(resourceProviderDetails));
        }
    }
}
