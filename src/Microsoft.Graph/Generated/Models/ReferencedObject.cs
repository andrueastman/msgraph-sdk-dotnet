using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ReferencedObject : IAdditionalDataHolder, IBackedModel, IParsable {
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
        /// <summary>Name of the referenced object. Must match one of the objects in the directory definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReferencedObjectName {
            get { return BackingStore?.Get<string?>("referencedObjectName"); }
            set { BackingStore?.Set("referencedObjectName", value); }
        }
#nullable restore
#else
        public string ReferencedObjectName {
            get { return BackingStore?.Get<string>("referencedObjectName"); }
            set { BackingStore?.Set("referencedObjectName", value); }
        }
#endif
        /// <summary>Currently not supported. Name of the property in the referenced object, the value for which is used as the reference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReferencedProperty {
            get { return BackingStore?.Get<string?>("referencedProperty"); }
            set { BackingStore?.Set("referencedProperty", value); }
        }
#nullable restore
#else
        public string ReferencedProperty {
            get { return BackingStore?.Get<string>("referencedProperty"); }
            set { BackingStore?.Set("referencedProperty", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new referencedObject and sets the default values.
        /// </summary>
        public ReferencedObject() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ReferencedObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReferencedObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"referencedObjectName", n => { ReferencedObjectName = n.GetStringValue(); } },
                {"referencedProperty", n => { ReferencedProperty = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("referencedObjectName", ReferencedObjectName);
            writer.WriteStringValue("referencedProperty", ReferencedProperty);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}