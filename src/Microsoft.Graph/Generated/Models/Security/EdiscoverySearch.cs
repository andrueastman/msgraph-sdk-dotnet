// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class EdiscoverySearch : global::Microsoft.Graph.Models.Security.Search, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Adds an additional source to the eDiscovery search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.DataSource>? AdditionalSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.DataSource>?>("additionalSources"); }
            set { BackingStore?.Set("additionalSources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.DataSource> AdditionalSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.DataSource>>("additionalSources"); }
            set { BackingStore?.Set("additionalSources", value); }
        }
#endif
        /// <summary>Adds the results of the eDiscovery search to the specified reviewSet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.EdiscoveryAddToReviewSetOperation? AddToReviewSetOperation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.EdiscoveryAddToReviewSetOperation?>("addToReviewSetOperation"); }
            set { BackingStore?.Set("addToReviewSetOperation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.EdiscoveryAddToReviewSetOperation AddToReviewSetOperation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.EdiscoveryAddToReviewSetOperation>("addToReviewSetOperation"); }
            set { BackingStore?.Set("addToReviewSetOperation", value); }
        }
#endif
        /// <summary>Custodian sources that are included in the eDiscovery search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.DataSource>? CustodianSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.DataSource>?>("custodianSources"); }
            set { BackingStore?.Set("custodianSources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.DataSource> CustodianSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.DataSource>>("custodianSources"); }
            set { BackingStore?.Set("custodianSources", value); }
        }
#endif
        /// <summary>When specified, the collection will span across a service for an entire workload. Possible values are: none, allTenantMailboxes, allTenantSites, allCaseCustodians, allCaseNoncustodialDataSources.</summary>
        public global::Microsoft.Graph.Models.Security.DataSourceScopes? DataSourceScopes
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.DataSourceScopes?>("dataSourceScopes"); }
            set { BackingStore?.Set("dataSourceScopes", value); }
        }
        /// <summary>The last estimate operation associated with the eDiscovery search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.EdiscoveryEstimateOperation? LastEstimateStatisticsOperation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.EdiscoveryEstimateOperation?>("lastEstimateStatisticsOperation"); }
            set { BackingStore?.Set("lastEstimateStatisticsOperation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.EdiscoveryEstimateOperation LastEstimateStatisticsOperation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.EdiscoveryEstimateOperation>("lastEstimateStatisticsOperation"); }
            set { BackingStore?.Set("lastEstimateStatisticsOperation", value); }
        }
#endif
        /// <summary>noncustodialDataSource sources that are included in the eDiscovery search</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource>? NoncustodialSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource>?>("noncustodialSources"); }
            set { BackingStore?.Set("noncustodialSources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource> NoncustodialSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource>>("noncustodialSources"); }
            set { BackingStore?.Set("noncustodialSources", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Security.EdiscoverySearch"/> and sets the default values.
        /// </summary>
        public EdiscoverySearch() : base()
        {
            OdataType = "#microsoft.graph.security.ediscoverySearch";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.EdiscoverySearch"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.EdiscoverySearch CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.EdiscoverySearch();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "addToReviewSetOperation", n => { AddToReviewSetOperation = n.GetObjectValue<global::Microsoft.Graph.Models.Security.EdiscoveryAddToReviewSetOperation>(global::Microsoft.Graph.Models.Security.EdiscoveryAddToReviewSetOperation.CreateFromDiscriminatorValue); } },
                { "additionalSources", n => { AdditionalSources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.DataSource>(global::Microsoft.Graph.Models.Security.DataSource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "custodianSources", n => { CustodianSources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.DataSource>(global::Microsoft.Graph.Models.Security.DataSource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "dataSourceScopes", n => { DataSourceScopes = n.GetEnumValue<global::Microsoft.Graph.Models.Security.DataSourceScopes>(); } },
                { "lastEstimateStatisticsOperation", n => { LastEstimateStatisticsOperation = n.GetObjectValue<global::Microsoft.Graph.Models.Security.EdiscoveryEstimateOperation>(global::Microsoft.Graph.Models.Security.EdiscoveryEstimateOperation.CreateFromDiscriminatorValue); } },
                { "noncustodialSources", n => { NoncustodialSources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource>(global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.DataSource>("additionalSources", AdditionalSources);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.EdiscoveryAddToReviewSetOperation>("addToReviewSetOperation", AddToReviewSetOperation);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.DataSource>("custodianSources", CustodianSources);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.DataSourceScopes>("dataSourceScopes", DataSourceScopes);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.EdiscoveryEstimateOperation>("lastEstimateStatisticsOperation", LastEstimateStatisticsOperation);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource>("noncustodialSources", NoncustodialSources);
        }
    }
}
