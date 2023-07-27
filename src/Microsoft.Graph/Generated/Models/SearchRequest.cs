using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class SearchRequest : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Contains one or more filters to obtain search results aggregated and filtered to a specific value of a field. Optional.Build this filter based on a prior search that aggregates by the same field. From the response of the prior search, identify the searchBucket that filters results to the specific value of the field, use the string in its aggregationFilterToken property, and build an aggregation filter string in the format &apos;{field}:/&apos;{aggregationFilterToken}/&apos;&apos;. If multiple values for the same field need to be provided, use the strings in its aggregationFilterToken property and build an aggregation filter string in the format &apos;{field}:or(/&apos;{aggregationFilterToken1}/&apos;,/&apos;{aggregationFilterToken2}/&apos;)&apos;. For example, searching and aggregating drive items by file type returns a searchBucket for the file type docx in the response. You can conveniently use the aggregationFilterToken returned for this searchBucket in a subsequent search query and filter matches down to drive items of the docx file type. Example 1 and example 2 show the actual requests and responses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AggregationFilters {
            get { return BackingStore?.Get<List<string>?>("aggregationFilters"); }
            set { BackingStore?.Set("aggregationFilters", value); }
        }
#nullable restore
#else
        public List<string> AggregationFilters {
            get { return BackingStore?.Get<List<string>>("aggregationFilters"); }
            set { BackingStore?.Set("aggregationFilters", value); }
        }
#endif
        /// <summary>Specifies aggregations (also known as refiners) to be returned alongside search results. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AggregationOption>? Aggregations {
            get { return BackingStore?.Get<List<AggregationOption>?>("aggregations"); }
            set { BackingStore?.Set("aggregations", value); }
        }
#nullable restore
#else
        public List<AggregationOption> Aggregations {
            get { return BackingStore?.Get<List<AggregationOption>>("aggregations"); }
            set { BackingStore?.Set("aggregations", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Contains the ordered collection of fields and limit to collapse results. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CollapseProperty>? CollapseProperties {
            get { return BackingStore?.Get<List<CollapseProperty>?>("collapseProperties"); }
            set { BackingStore?.Set("collapseProperties", value); }
        }
#nullable restore
#else
        public List<CollapseProperty> CollapseProperties {
            get { return BackingStore?.Get<List<CollapseProperty>>("collapseProperties"); }
            set { BackingStore?.Set("collapseProperties", value); }
        }
#endif
        /// <summary>Contains the connection to be targeted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ContentSources {
            get { return BackingStore?.Get<List<string>?>("contentSources"); }
            set { BackingStore?.Set("contentSources", value); }
        }
#nullable restore
#else
        public List<string> ContentSources {
            get { return BackingStore?.Get<List<string>>("contentSources"); }
            set { BackingStore?.Set("contentSources", value); }
        }
#endif
        /// <summary>This triggers hybrid sort for messages : the first 3 messages are the most relevant. This property is only applicable to entityType=message. Optional.</summary>
        public bool? EnableTopResults {
            get { return BackingStore?.Get<bool?>("enableTopResults"); }
            set { BackingStore?.Set("enableTopResults", value); }
        }
        /// <summary>One or more types of resources expected in the response. Possible values are: event, message, driveItem, externalItem, site, list, listItem, drive, chatMessage, person, acronym, bookmark.  Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum:chatMessage, person, acronym, bookmark. See known limitations for those combinations of two or more entity types that are supported in the same search request. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EntityType?>? EntityTypes {
            get { return BackingStore?.Get<List<EntityType?>?>("entityTypes"); }
            set { BackingStore?.Set("entityTypes", value); }
        }
#nullable restore
#else
        public List<EntityType?> EntityTypes {
            get { return BackingStore?.Get<List<EntityType?>>("entityTypes"); }
            set { BackingStore?.Set("entityTypes", value); }
        }
#endif
        /// <summary>Contains the fields to be returned for each resource object specified in entityTypes, allowing customization of the fields returned by default; otherwise, including additional fields such as custom managed properties from SharePoint and OneDrive, or custom fields in externalItem from the content that Microsoft Graph connectors bring in. The fields property can use the semantic labels applied to properties. For example, if a property is labeled as title, you can retrieve it using the following syntax: label_title. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Fields {
            get { return BackingStore?.Get<List<string>?>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#nullable restore
#else
        public List<string> Fields {
            get { return BackingStore?.Get<List<string>>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#endif
        /// <summary>Specifies the offset for the search results. Offset 0 returns the very first result. Optional.</summary>
        public int? From {
            get { return BackingStore?.Get<int?>("from"); }
            set { BackingStore?.Set("from", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The query property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SearchQuery? Query {
            get { return BackingStore?.Get<SearchQuery?>("query"); }
            set { BackingStore?.Set("query", value); }
        }
#nullable restore
#else
        public SearchQuery Query {
            get { return BackingStore?.Get<SearchQuery>("query"); }
            set { BackingStore?.Set("query", value); }
        }
#endif
        /// <summary>Query alteration options formatted in a JSON blob that contains two optional flags related to spelling correction. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SearchAlterationOptions? QueryAlterationOptions {
            get { return BackingStore?.Get<SearchAlterationOptions?>("queryAlterationOptions"); }
            set { BackingStore?.Set("queryAlterationOptions", value); }
        }
#nullable restore
#else
        public SearchAlterationOptions QueryAlterationOptions {
            get { return BackingStore?.Get<SearchAlterationOptions>("queryAlterationOptions"); }
            set { BackingStore?.Set("queryAlterationOptions", value); }
        }
#endif
        /// <summary>The geographic location for the search. Required for searches that use application permissions. For details, see Get the region value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region {
            get { return BackingStore?.Get<string?>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#nullable restore
#else
        public string Region {
            get { return BackingStore?.Get<string>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#endif
        /// <summary>Provides the search result template options to render search results from connectors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ResultTemplateOption? ResultTemplateOptions {
            get { return BackingStore?.Get<ResultTemplateOption?>("resultTemplateOptions"); }
            set { BackingStore?.Set("resultTemplateOptions", value); }
        }
#nullable restore
#else
        public ResultTemplateOption ResultTemplateOptions {
            get { return BackingStore?.Get<ResultTemplateOption>("resultTemplateOptions"); }
            set { BackingStore?.Set("resultTemplateOptions", value); }
        }
#endif
        /// <summary>Indicates the kind of contents to be searched when a search is performed using application permissions. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.SharePointOneDriveOptions? SharePointOneDriveOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SharePointOneDriveOptions?>("sharePointOneDriveOptions"); }
            set { BackingStore?.Set("sharePointOneDriveOptions", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.SharePointOneDriveOptions SharePointOneDriveOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SharePointOneDriveOptions>("sharePointOneDriveOptions"); }
            set { BackingStore?.Set("sharePointOneDriveOptions", value); }
        }
#endif
        /// <summary>The size of the page to be retrieved. The maximum value is 500. Optional.</summary>
        public int? Size {
            get { return BackingStore?.Get<int?>("size"); }
            set { BackingStore?.Set("size", value); }
        }
        /// <summary>Contains the ordered collection of fields and direction to sort results. There can be at most 5 sort properties in the collection. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SortProperty>? SortProperties {
            get { return BackingStore?.Get<List<SortProperty>?>("sortProperties"); }
            set { BackingStore?.Set("sortProperties", value); }
        }
#nullable restore
#else
        public List<SortProperty> SortProperties {
            get { return BackingStore?.Get<List<SortProperty>>("sortProperties"); }
            set { BackingStore?.Set("sortProperties", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new searchRequest and sets the default values.
        /// </summary>
        public SearchRequest() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SearchRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"aggregationFilters", n => { AggregationFilters = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"aggregations", n => { Aggregations = n.GetCollectionOfObjectValues<AggregationOption>(AggregationOption.CreateFromDiscriminatorValue)?.ToList(); } },
                {"collapseProperties", n => { CollapseProperties = n.GetCollectionOfObjectValues<CollapseProperty>(CollapseProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contentSources", n => { ContentSources = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"enableTopResults", n => { EnableTopResults = n.GetBoolValue(); } },
                {"entityTypes", n => { EntityTypes = n.GetCollectionOfEnumValues<EntityType>()?.ToList(); } },
                {"fields", n => { Fields = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"from", n => { From = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"query", n => { Query = n.GetObjectValue<SearchQuery>(SearchQuery.CreateFromDiscriminatorValue); } },
                {"queryAlterationOptions", n => { QueryAlterationOptions = n.GetObjectValue<SearchAlterationOptions>(SearchAlterationOptions.CreateFromDiscriminatorValue); } },
                {"region", n => { Region = n.GetStringValue(); } },
                {"resultTemplateOptions", n => { ResultTemplateOptions = n.GetObjectValue<ResultTemplateOption>(ResultTemplateOption.CreateFromDiscriminatorValue); } },
                {"sharePointOneDriveOptions", n => { SharePointOneDriveOptions = n.GetObjectValue<Microsoft.Graph.Models.SharePointOneDriveOptions>(Microsoft.Graph.Models.SharePointOneDriveOptions.CreateFromDiscriminatorValue); } },
                {"size", n => { Size = n.GetIntValue(); } },
                {"sortProperties", n => { SortProperties = n.GetCollectionOfObjectValues<SortProperty>(SortProperty.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("aggregationFilters", AggregationFilters);
            writer.WriteCollectionOfObjectValues<AggregationOption>("aggregations", Aggregations);
            writer.WriteCollectionOfObjectValues<CollapseProperty>("collapseProperties", CollapseProperties);
            writer.WriteCollectionOfPrimitiveValues<string>("contentSources", ContentSources);
            writer.WriteBoolValue("enableTopResults", EnableTopResults);
            writer.WriteCollectionOfEnumValues<EntityType>("entityTypes", EntityTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("fields", Fields);
            writer.WriteIntValue("from", From);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<SearchQuery>("query", Query);
            writer.WriteObjectValue<SearchAlterationOptions>("queryAlterationOptions", QueryAlterationOptions);
            writer.WriteStringValue("region", Region);
            writer.WriteObjectValue<ResultTemplateOption>("resultTemplateOptions", ResultTemplateOptions);
            writer.WriteObjectValue<Microsoft.Graph.Models.SharePointOneDriveOptions>("sharePointOneDriveOptions", SharePointOneDriveOptions);
            writer.WriteIntValue("size", Size);
            writer.WriteCollectionOfObjectValues<SortProperty>("sortProperties", SortProperties);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}