// <auto-generated/>
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Db {
    #pragma warning disable CS1591
    public class DbPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? throw new InvalidOperationException("AdditionalData can not be null"); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The cost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Cost {
            get { return BackingStore?.Get<Json?>("cost"); }
            set { BackingStore?.Set("cost", value); }
        }
#nullable restore
#else
        public Json Cost {
            get { return BackingStore?.Get<Json>("cost"); }
            set { BackingStore?.Set("cost", value); }
        }
#endif
        /// <summary>The life property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Life {
            get { return BackingStore?.Get<Json?>("life"); }
            set { BackingStore?.Set("life", value); }
        }
#nullable restore
#else
        public Json Life {
            get { return BackingStore?.Get<Json>("life"); }
            set { BackingStore?.Set("life", value); }
        }
#endif
        /// <summary>The month property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Month {
            get { return BackingStore?.Get<Json?>("month"); }
            set { BackingStore?.Set("month", value); }
        }
#nullable restore
#else
        public Json Month {
            get { return BackingStore?.Get<Json>("month"); }
            set { BackingStore?.Set("month", value); }
        }
#endif
        /// <summary>The period property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Period {
            get { return BackingStore?.Get<Json?>("period"); }
            set { BackingStore?.Set("period", value); }
        }
#nullable restore
#else
        public Json Period {
            get { return BackingStore?.Get<Json>("period"); }
            set { BackingStore?.Set("period", value); }
        }
#endif
        /// <summary>The salvage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Salvage {
            get { return BackingStore?.Get<Json?>("salvage"); }
            set { BackingStore?.Set("salvage", value); }
        }
#nullable restore
#else
        public Json Salvage {
            get { return BackingStore?.Get<Json>("salvage"); }
            set { BackingStore?.Set("salvage", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DbPostRequestBody"/> and sets the default values.
        /// </summary>
        public DbPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DbPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DbPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DbPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"cost", n => { Cost = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"life", n => { Life = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"month", n => { Month = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"period", n => { Period = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"salvage", n => { Salvage = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cost", Cost);
            writer.WriteObjectValue<Json>("life", Life);
            writer.WriteObjectValue<Json>("month", Month);
            writer.WriteObjectValue<Json>("period", Period);
            writer.WriteObjectValue<Json>("salvage", Salvage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
