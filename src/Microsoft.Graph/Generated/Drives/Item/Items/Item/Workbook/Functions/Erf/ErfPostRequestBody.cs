// <auto-generated/>
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Erf {
    public class ErfPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The lowerLimit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? LowerLimit {
            get { return BackingStore?.Get<Json?>("lowerLimit"); }
            set { BackingStore?.Set("lowerLimit", value); }
        }
#nullable restore
#else
        public Json LowerLimit {
            get { return BackingStore?.Get<Json>("lowerLimit"); }
            set { BackingStore?.Set("lowerLimit", value); }
        }
#endif
        /// <summary>The upperLimit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? UpperLimit {
            get { return BackingStore?.Get<Json?>("upperLimit"); }
            set { BackingStore?.Set("upperLimit", value); }
        }
#nullable restore
#else
        public Json UpperLimit {
            get { return BackingStore?.Get<Json>("upperLimit"); }
            set { BackingStore?.Set("upperLimit", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ErfPostRequestBody"/> and sets the default values.
        /// </summary>
        public ErfPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ErfPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ErfPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ErfPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"lowerLimit", n => { LowerLimit = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"upperLimit", n => { UpperLimit = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("lowerLimit", LowerLimit);
            writer.WriteObjectValue<Json>("upperLimit", UpperLimit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
