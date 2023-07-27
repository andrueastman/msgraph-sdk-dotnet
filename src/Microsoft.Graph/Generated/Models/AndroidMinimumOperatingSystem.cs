using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Contains properties for the minimum operating system required for an Android mobile app.
    /// </summary>
    public class AndroidMinimumOperatingSystem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>When TRUE, only Version 10.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V100 {
            get { return BackingStore?.Get<bool?>("v10_0"); }
            set { BackingStore?.Set("v10_0", value); }
        }
        /// <summary>When TRUE, only Version 11.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V110 {
            get { return BackingStore?.Get<bool?>("v11_0"); }
            set { BackingStore?.Set("v11_0", value); }
        }
        /// <summary>When TRUE, only Version 4.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V40 {
            get { return BackingStore?.Get<bool?>("v4_0"); }
            set { BackingStore?.Set("v4_0", value); }
        }
        /// <summary>When TRUE, only Version 4.0.3 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V403 {
            get { return BackingStore?.Get<bool?>("v4_0_3"); }
            set { BackingStore?.Set("v4_0_3", value); }
        }
        /// <summary>When TRUE, only Version 4.1 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V41 {
            get { return BackingStore?.Get<bool?>("v4_1"); }
            set { BackingStore?.Set("v4_1", value); }
        }
        /// <summary>When TRUE, only Version 4.2 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V42 {
            get { return BackingStore?.Get<bool?>("v4_2"); }
            set { BackingStore?.Set("v4_2", value); }
        }
        /// <summary>When TRUE, only Version 4.3 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V43 {
            get { return BackingStore?.Get<bool?>("v4_3"); }
            set { BackingStore?.Set("v4_3", value); }
        }
        /// <summary>When TRUE, only Version 4.4 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V44 {
            get { return BackingStore?.Get<bool?>("v4_4"); }
            set { BackingStore?.Set("v4_4", value); }
        }
        /// <summary>When TRUE, only Version 5.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V50 {
            get { return BackingStore?.Get<bool?>("v5_0"); }
            set { BackingStore?.Set("v5_0", value); }
        }
        /// <summary>When TRUE, only Version 5.1 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V51 {
            get { return BackingStore?.Get<bool?>("v5_1"); }
            set { BackingStore?.Set("v5_1", value); }
        }
        /// <summary>When TRUE, only Version 6.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V60 {
            get { return BackingStore?.Get<bool?>("v6_0"); }
            set { BackingStore?.Set("v6_0", value); }
        }
        /// <summary>When TRUE, only Version 7.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V70 {
            get { return BackingStore?.Get<bool?>("v7_0"); }
            set { BackingStore?.Set("v7_0", value); }
        }
        /// <summary>When TRUE, only Version 7.1 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V71 {
            get { return BackingStore?.Get<bool?>("v7_1"); }
            set { BackingStore?.Set("v7_1", value); }
        }
        /// <summary>When TRUE, only Version 8.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V80 {
            get { return BackingStore?.Get<bool?>("v8_0"); }
            set { BackingStore?.Set("v8_0", value); }
        }
        /// <summary>When TRUE, only Version 8.1 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V81 {
            get { return BackingStore?.Get<bool?>("v8_1"); }
            set { BackingStore?.Set("v8_1", value); }
        }
        /// <summary>When TRUE, only Version 9.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V90 {
            get { return BackingStore?.Get<bool?>("v9_0"); }
            set { BackingStore?.Set("v9_0", value); }
        }
        /// <summary>
        /// Instantiates a new androidMinimumOperatingSystem and sets the default values.
        /// </summary>
        public AndroidMinimumOperatingSystem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AndroidMinimumOperatingSystem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidMinimumOperatingSystem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"v10_0", n => { V100 = n.GetBoolValue(); } },
                {"v11_0", n => { V110 = n.GetBoolValue(); } },
                {"v4_0", n => { V40 = n.GetBoolValue(); } },
                {"v4_0_3", n => { V403 = n.GetBoolValue(); } },
                {"v4_1", n => { V41 = n.GetBoolValue(); } },
                {"v4_2", n => { V42 = n.GetBoolValue(); } },
                {"v4_3", n => { V43 = n.GetBoolValue(); } },
                {"v4_4", n => { V44 = n.GetBoolValue(); } },
                {"v5_0", n => { V50 = n.GetBoolValue(); } },
                {"v5_1", n => { V51 = n.GetBoolValue(); } },
                {"v6_0", n => { V60 = n.GetBoolValue(); } },
                {"v7_0", n => { V70 = n.GetBoolValue(); } },
                {"v7_1", n => { V71 = n.GetBoolValue(); } },
                {"v8_0", n => { V80 = n.GetBoolValue(); } },
                {"v8_1", n => { V81 = n.GetBoolValue(); } },
                {"v9_0", n => { V90 = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("v10_0", V100);
            writer.WriteBoolValue("v11_0", V110);
            writer.WriteBoolValue("v4_0", V40);
            writer.WriteBoolValue("v4_0_3", V403);
            writer.WriteBoolValue("v4_1", V41);
            writer.WriteBoolValue("v4_2", V42);
            writer.WriteBoolValue("v4_3", V43);
            writer.WriteBoolValue("v4_4", V44);
            writer.WriteBoolValue("v5_0", V50);
            writer.WriteBoolValue("v5_1", V51);
            writer.WriteBoolValue("v6_0", V60);
            writer.WriteBoolValue("v7_0", V70);
            writer.WriteBoolValue("v7_1", V71);
            writer.WriteBoolValue("v8_0", V80);
            writer.WriteBoolValue("v8_1", V81);
            writer.WriteBoolValue("v9_0", V90);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}