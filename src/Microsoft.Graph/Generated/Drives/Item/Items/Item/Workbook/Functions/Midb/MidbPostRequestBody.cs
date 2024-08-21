// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Midb
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class MidbPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The numBytes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? NumBytes
        {
            get { return BackingStore?.Get<UntypedNode?>("numBytes"); }
            set { BackingStore?.Set("numBytes", value); }
        }
#nullable restore
#else
        public UntypedNode NumBytes
        {
            get { return BackingStore?.Get<UntypedNode>("numBytes"); }
            set { BackingStore?.Set("numBytes", value); }
        }
#endif
        /// <summary>The startNum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? StartNum
        {
            get { return BackingStore?.Get<UntypedNode?>("startNum"); }
            set { BackingStore?.Set("startNum", value); }
        }
#nullable restore
#else
        public UntypedNode StartNum
        {
            get { return BackingStore?.Get<UntypedNode>("startNum"); }
            set { BackingStore?.Set("startNum", value); }
        }
#endif
        /// <summary>The text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Text
        {
            get { return BackingStore?.Get<UntypedNode?>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#nullable restore
#else
        public UntypedNode Text
        {
            get { return BackingStore?.Get<UntypedNode>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Midb.MidbPostRequestBody"/> and sets the default values.
        /// </summary>
        public MidbPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Midb.MidbPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Midb.MidbPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Midb.MidbPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "numBytes", n => { NumBytes = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "startNum", n => { StartNum = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "text", n => { Text = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("numBytes", NumBytes);
            writer.WriteObjectValue<UntypedNode>("startNum", StartNum);
            writer.WriteObjectValue<UntypedNode>("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
