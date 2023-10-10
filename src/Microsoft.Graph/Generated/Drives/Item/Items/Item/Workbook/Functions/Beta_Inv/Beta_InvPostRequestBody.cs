// <auto-generated/>
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Beta_Inv {
    public class Beta_InvPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The A property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? A {
            get { return BackingStore?.Get<Json?>("A"); }
            set { BackingStore?.Set("A", value); }
        }
#nullable restore
#else
        public Json A {
            get { return BackingStore?.Get<Json>("A"); }
            set { BackingStore?.Set("A", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>The alpha property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Alpha {
            get { return BackingStore?.Get<Json?>("alpha"); }
            set { BackingStore?.Set("alpha", value); }
        }
#nullable restore
#else
        public Json Alpha {
            get { return BackingStore?.Get<Json>("alpha"); }
            set { BackingStore?.Set("alpha", value); }
        }
#endif
        /// <summary>The B property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? B {
            get { return BackingStore?.Get<Json?>("B"); }
            set { BackingStore?.Set("B", value); }
        }
#nullable restore
#else
        public Json B {
            get { return BackingStore?.Get<Json>("B"); }
            set { BackingStore?.Set("B", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The beta property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Beta {
            get { return BackingStore?.Get<Json?>("beta"); }
            set { BackingStore?.Set("beta", value); }
        }
#nullable restore
#else
        public Json Beta {
            get { return BackingStore?.Get<Json>("beta"); }
            set { BackingStore?.Set("beta", value); }
        }
#endif
        /// <summary>The probability property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Probability {
            get { return BackingStore?.Get<Json?>("probability"); }
            set { BackingStore?.Set("probability", value); }
        }
#nullable restore
#else
        public Json Probability {
            get { return BackingStore?.Get<Json>("probability"); }
            set { BackingStore?.Set("probability", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new beta_InvPostRequestBody and sets the default values.
        /// </summary>
        public Beta_InvPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Beta_InvPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Beta_InvPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"A", n => { A = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"alpha", n => { Alpha = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"B", n => { B = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"beta", n => { Beta = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"probability", n => { Probability = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("A", A);
            writer.WriteObjectValue<Json>("alpha", Alpha);
            writer.WriteObjectValue<Json>("B", B);
            writer.WriteObjectValue<Json>("beta", Beta);
            writer.WriteObjectValue<Json>("probability", Probability);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
