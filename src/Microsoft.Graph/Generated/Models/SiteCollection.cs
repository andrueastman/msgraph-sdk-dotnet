// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class SiteCollection : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Represents whether the site collection is recently archived, fully archived, or reactivating. Possible values are: recentlyArchived, fullyArchived, reactivating, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SiteArchivalDetails? ArchivalDetails
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SiteArchivalDetails?>("archivalDetails"); }
            set { BackingStore?.Set("archivalDetails", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SiteArchivalDetails ArchivalDetails
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SiteArchivalDetails>("archivalDetails"); }
            set { BackingStore?.Set("archivalDetails", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The geographic region code for where this site collection resides. Only present for multi-geo tenants. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DataLocationCode
        {
            get { return BackingStore?.Get<string?>("dataLocationCode"); }
            set { BackingStore?.Set("dataLocationCode", value); }
        }
#nullable restore
#else
        public string DataLocationCode
        {
            get { return BackingStore?.Get<string>("dataLocationCode"); }
            set { BackingStore?.Set("dataLocationCode", value); }
        }
#endif
        /// <summary>The hostname for the site collection. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Hostname
        {
            get { return BackingStore?.Get<string?>("hostname"); }
            set { BackingStore?.Set("hostname", value); }
        }
#nullable restore
#else
        public string Hostname
        {
            get { return BackingStore?.Get<string>("hostname"); }
            set { BackingStore?.Set("hostname", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>If present, indicates that this is a root site collection in SharePoint. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Root? Root
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Root?>("root"); }
            set { BackingStore?.Set("root", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Root Root
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Root>("root"); }
            set { BackingStore?.Set("root", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.SiteCollection"/> and sets the default values.
        /// </summary>
        public SiteCollection()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SiteCollection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.SiteCollection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.SiteCollection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "archivalDetails", n => { ArchivalDetails = n.GetObjectValue<global::Microsoft.Graph.Models.SiteArchivalDetails>(global::Microsoft.Graph.Models.SiteArchivalDetails.CreateFromDiscriminatorValue); } },
                { "dataLocationCode", n => { DataLocationCode = n.GetStringValue(); } },
                { "hostname", n => { Hostname = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "root", n => { Root = n.GetObjectValue<global::Microsoft.Graph.Models.Root>(global::Microsoft.Graph.Models.Root.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SiteArchivalDetails>("archivalDetails", ArchivalDetails);
            writer.WriteStringValue("dataLocationCode", DataLocationCode);
            writer.WriteStringValue("hostname", Hostname);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Root>("root", Root);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
