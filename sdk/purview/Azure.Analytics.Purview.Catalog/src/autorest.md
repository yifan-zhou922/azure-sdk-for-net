Run `dotnet build /t:GenerateCode` to generate code.

```yaml
tag: package-purview-catalog
input-file:
- https://github.com/Azure/azure-rest-api-specs/blob/ccbe894f6b012ca2000184307ed453fd68797b86/specification/purview/data-plane/Azure.Analytics.Purview.Catalog/preview/2022-03-01-preview/purviewcatalog.json
namespace: Azure.Analytics.Purview.Catalog
generation1-convenience-client: true
public-clients: true
security: AADToken
security-scopes:  https://purview.azure.net/.default
modelerfour:
  lenient-model-deduplication: true
  seal-single-value-enum-by-default: true
```

# Model endpoint parameter as a url, not a string.

```yaml
directive:
  from: swagger-document
  where: $.parameters.Endpoint
  transform: >
    if ($.format === undefined) {
      $.format = "url";
    }
```

# Rename operation names in Collection
```yaml
directive:
  - rename-operation:
      from: Collection_CreateOrUpdate
      to: Collection_CreateOrUpdateEntity
  - rename-operation:
      from: Collection_CreateOrUpdateBulk
      to: Collection_CreateOrUpdateEntityInBulk
```

# Promote Discovery members to PurviewCatalogClient

```yaml
directive:
  - from: swagger-document
    where: $..[?(@.operationId !== undefined)]
    transform: >
      if ($.operationId.startsWith("Discovery_")) {
        $.operationId = $.operationId.replace("Discovery_", "");
      }
```

# Rename Query to Search (to follow .NET Naming Conventions)

```yaml
directive:
  - from: swagger-document
    where: $..[?(@.operationId === "Query")]
    transform: >
        $.operationId = "Search";
```


# Add `Purview` To Sub Clients

```yaml
directive:
  from: swagger-document
  where: $..[?(@.operationId !== undefined)]
  transform: >
    if ($.operationId.includes("_")) {
      $.operationId = "Purview" + $.operationId;
    }
```

# Change List -> Get in operation names

```yaml
directive:
  from: swagger-document
  where: $..[?(@.operationId !== undefined)]
  transform: >
     $.operationId = $.operationId.replace("_List", "_Get");
```

### Expose serialization and deserialization methods and internal models

``` yaml
directive:
- from: swagger-document
  where: $.definitions
  transform: >
    for (var path in $)
    {
      if (path.endsWith("AtlasAttributeDef") ||
          path.endsWith("AtlasBaseModelObject") ||
          path.endsWith("AtlasBaseTypeDef") ||
          path.endsWith("AtlasBusinessMetadataDef") ||  
          path.endsWith("AtlasClassification") ||
          path.endsWith("AtlasClassificationDef") ||
          path.endsWith("AtlasClassifications") ||
          path.endsWith("AtlasConstraintDef") ||
          path.endsWith("AtlasEntitiesWithExtInfo") ||
          path.endsWith("AtlasEntity") ||
          path.endsWith("TermTemplateDef") ||
          path.endsWith("AtlasEntityDef") ||
          path.endsWith("AtlasEntityExtInfo") ||
          path.endsWith("AtlasEntityHeader") ||
          path.endsWith("AtlasEntityHeaders") ||
          path.endsWith("AtlasEntityWithExtInfo") ||
          path.endsWith("AtlasEnumDef") ||
          path.endsWith("AtlasEnumElementDef") ||
          path.endsWith("AtlasGlossary") ||
          path.endsWith("AtlasGlossaryBaseObject") ||
          path.endsWith("AtlasGlossaryCategory") ||
          path.endsWith("AtlasGlossaryExtInfo") ||
          path.endsWith("AtlasGlossaryHeader") ||
          path.endsWith("AtlasGlossaryTerm") ||
          path.endsWith("ResourceLink") ||
          path.endsWith("ContactBasic") ||
          path.endsWith("TermStatus") ||
          path.endsWith("TermCustomAttributes") ||
          path.endsWith("TermCustomAttributesExtraProperties") ||
          path.endsWith("AtlasLineageInfo") ||
          path.endsWith("AtlasLineageInfoExtraProperties") ||
          path.endsWith("AtlasObjectId") ||
          path.endsWith("AtlasRelatedCategoryHeader") ||
          path.endsWith("AtlasRelatedObjectId") ||
          path.endsWith("AtlasRelatedTermHeader") ||
          path.endsWith("AtlasRelationship") ||
          path.endsWith("AtlasRelationshipDef") ||
          path.endsWith("AtlasRelationshipEndDef") ||
          path.endsWith("AtlasRelationshipAttributeDef") ||
          path.endsWith("AtlasRelationshipWithExtInfo") ||
          path.endsWith("AtlasStruct") ||
          path.endsWith("AtlasStructDef") ||
          path.endsWith("AtlasTermAssignmentHeader") ||
          path.endsWith("AtlasTermAssignmentStatus") ||
          path.endsWith("AtlasTermCategorizationHeader") ||
          path.endsWith("AtlasTermRelationshipStatus") ||
          path.endsWith("AtlasTypeDefHeader") ||
          path.endsWith("AtlasTypesDef") ||
          path.endsWith("AtlasExtraTypeDef") ||
          path.endsWith("AtlasTypeDef") ||
          path.endsWith("ImportInfo") ||
          path.endsWith("ImportStatus") ||
          path.endsWith("BulkImportResponse") ||
          path.endsWith("Cardinality") ||
          path.endsWith("ClassificationAssociateRequest") ||
          path.endsWith("MoveEntitiesRequest") ||
          path.endsWith("DateFormat") ||
          path.endsWith("EntityMutationResponse") ||
          path.endsWith("LineageDirection") ||
          path.endsWith("LineageRelation") ||
          path.endsWith("ParentRelation") ||
          path.endsWith("NumberFormat") ||
          path.endsWith("TermGuid") ||
          path.endsWith("PList") ||
          path.endsWith("RelationshipCategory") ||
          path.endsWith("RoundingMode") ||
          path.endsWith("SortType") ||
          path.endsWith("Status") ||
          path.endsWith("Status_AtlasRelationship") ||
          path.endsWith("TimeBoundary") ||
          path.endsWith("TimeZone") ||
          path.endsWith("TypeCategory") ||
          path.endsWith("SuggestResult") ||
          path.endsWith("BrowseResult") ||
          path.endsWith("SuggestResultValue") ||
          path.endsWith("BrowseResultValue") ||
          path.endsWith("BrowseResultOwner") ||
          path.endsWith("SearchResult") ||
          path.endsWith("SearchFacetResultValue") ||
          path.endsWith("SearchFacetItemValue") ||
          path.endsWith("SearchFacetItem") ||
          path.endsWith("SearchResultValue") ||
          path.endsWith("SearchHighlights") ||
          path.endsWith("TermSearchResultValue") ||
          path.endsWith("ContactSearchResultValue") ||
          path.endsWith("AutoCompleteRequest") ||
          path.endsWith("AutoCompleteResult") ||
          path.endsWith("AutoCompleteResultValue") ||
          path.endsWith("SearchRequest") ||
          path.endsWith("BrowseRequest") ||
          path.endsWith("SuggestRequest") ||
          path.endsWith("ImportCSVOperation") ||
          path.endsWith("ImportCSVOperationProperties") ||
          path.endsWith("ImportCSVOperationError") ||
          path.endsWith("ImportCSVOperationStatus") ||
          path.endsWith("LastModifiedTS") ||
          path.endsWith("ErrorResponse"))
      {
        $[path]["x-csharp-usage"] = "model,input,output,converter";
        $[path]["x-csharp-formats"] = "json";
      }
      else
      {
        $[path]["x-csharp-usage"] = "converter";
      }
    }
```

