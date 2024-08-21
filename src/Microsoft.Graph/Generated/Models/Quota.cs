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
    public partial class Quota : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Total space consumed by files in the recycle bin, in bytes. Read-only.</summary>
        public long? Deleted
        {
            get { return BackingStore?.Get<long?>("deleted"); }
            set { BackingStore?.Set("deleted", value); }
        }
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
        /// <summary>Total space remaining before reaching the quota limit, in bytes. Read-only.</summary>
        public long? Remaining
        {
            get { return BackingStore?.Get<long?>("remaining"); }
            set { BackingStore?.Set("remaining", value); }
        }
        /// <summary>Enumeration value that indicates the state of the storage space. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State
        {
            get { return BackingStore?.Get<string?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#nullable restore
#else
        public string State
        {
            get { return BackingStore?.Get<string>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#endif
        /// <summary>Information about the drive&apos;s storage quota plans. Only in Personal OneDrive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.StoragePlanInformation? StoragePlanInformation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.StoragePlanInformation?>("storagePlanInformation"); }
            set { BackingStore?.Set("storagePlanInformation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.StoragePlanInformation StoragePlanInformation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.StoragePlanInformation>("storagePlanInformation"); }
            set { BackingStore?.Set("storagePlanInformation", value); }
        }
#endif
        /// <summary>Total allowed storage space, in bytes. Read-only.</summary>
        public long? Total
        {
            get { return BackingStore?.Get<long?>("total"); }
            set { BackingStore?.Set("total", value); }
        }
        /// <summary>Total space used, in bytes. Read-only.</summary>
        public long? Used
        {
            get { return BackingStore?.Get<long?>("used"); }
            set { BackingStore?.Set("used", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Quota"/> and sets the default values.
        /// </summary>
        public Quota()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Quota"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.Quota CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Quota();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "deleted", n => { Deleted = n.GetLongValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "remaining", n => { Remaining = n.GetLongValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "storagePlanInformation", n => { StoragePlanInformation = n.GetObjectValue<global::Microsoft.Graph.Models.StoragePlanInformation>(global::Microsoft.Graph.Models.StoragePlanInformation.CreateFromDiscriminatorValue); } },
                { "total", n => { Total = n.GetLongValue(); } },
                { "used", n => { Used = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("deleted", Deleted);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("remaining", Remaining);
            writer.WriteStringValue("state", State);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.StoragePlanInformation>("storagePlanInformation", StoragePlanInformation);
            writer.WriteLongValue("total", Total);
            writer.WriteLongValue("used", Used);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
