// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Db
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class DbPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The cost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Cost
        {
            get { return BackingStore?.Get<UntypedNode?>("cost"); }
            set { BackingStore?.Set("cost", value); }
        }
#nullable restore
#else
        public UntypedNode Cost
        {
            get { return BackingStore?.Get<UntypedNode>("cost"); }
            set { BackingStore?.Set("cost", value); }
        }
#endif
        /// <summary>The life property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Life
        {
            get { return BackingStore?.Get<UntypedNode?>("life"); }
            set { BackingStore?.Set("life", value); }
        }
#nullable restore
#else
        public UntypedNode Life
        {
            get { return BackingStore?.Get<UntypedNode>("life"); }
            set { BackingStore?.Set("life", value); }
        }
#endif
        /// <summary>The month property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Month
        {
            get { return BackingStore?.Get<UntypedNode?>("month"); }
            set { BackingStore?.Set("month", value); }
        }
#nullable restore
#else
        public UntypedNode Month
        {
            get { return BackingStore?.Get<UntypedNode>("month"); }
            set { BackingStore?.Set("month", value); }
        }
#endif
        /// <summary>The period property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Period
        {
            get { return BackingStore?.Get<UntypedNode?>("period"); }
            set { BackingStore?.Set("period", value); }
        }
#nullable restore
#else
        public UntypedNode Period
        {
            get { return BackingStore?.Get<UntypedNode>("period"); }
            set { BackingStore?.Set("period", value); }
        }
#endif
        /// <summary>The salvage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Salvage
        {
            get { return BackingStore?.Get<UntypedNode?>("salvage"); }
            set { BackingStore?.Set("salvage", value); }
        }
#nullable restore
#else
        public UntypedNode Salvage
        {
            get { return BackingStore?.Get<UntypedNode>("salvage"); }
            set { BackingStore?.Set("salvage", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Db.DbPostRequestBody"/> and sets the default values.
        /// </summary>
        public DbPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Db.DbPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Db.DbPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Db.DbPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cost", n => { Cost = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "life", n => { Life = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "month", n => { Month = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "period", n => { Period = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "salvage", n => { Salvage = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("cost", Cost);
            writer.WriteObjectValue<UntypedNode>("life", Life);
            writer.WriteObjectValue<UntypedNode>("month", Month);
            writer.WriteObjectValue<UntypedNode>("period", Period);
            writer.WriteObjectValue<UntypedNode>("salvage", Salvage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
