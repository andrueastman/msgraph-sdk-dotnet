using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.NegBinom_Dist {
    public class NegBinom_DistPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The cumulative property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Cumulative {
            get { return BackingStore?.Get<Json?>("cumulative"); }
            set { BackingStore?.Set("cumulative", value); }
        }
#nullable restore
#else
        public Json Cumulative {
            get { return BackingStore?.Get<Json>("cumulative"); }
            set { BackingStore?.Set("cumulative", value); }
        }
#endif
        /// <summary>The numberF property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? NumberF {
            get { return BackingStore?.Get<Json?>("numberF"); }
            set { BackingStore?.Set("numberF", value); }
        }
#nullable restore
#else
        public Json NumberF {
            get { return BackingStore?.Get<Json>("numberF"); }
            set { BackingStore?.Set("numberF", value); }
        }
#endif
        /// <summary>The numberS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? NumberS {
            get { return BackingStore?.Get<Json?>("numberS"); }
            set { BackingStore?.Set("numberS", value); }
        }
#nullable restore
#else
        public Json NumberS {
            get { return BackingStore?.Get<Json>("numberS"); }
            set { BackingStore?.Set("numberS", value); }
        }
#endif
        /// <summary>The probabilityS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? ProbabilityS {
            get { return BackingStore?.Get<Json?>("probabilityS"); }
            set { BackingStore?.Set("probabilityS", value); }
        }
#nullable restore
#else
        public Json ProbabilityS {
            get { return BackingStore?.Get<Json>("probabilityS"); }
            set { BackingStore?.Set("probabilityS", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new negBinom_DistPostRequestBody and sets the default values.
        /// </summary>
        public NegBinom_DistPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static NegBinom_DistPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NegBinom_DistPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cumulative", n => { Cumulative = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"numberF", n => { NumberF = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"numberS", n => { NumberS = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"probabilityS", n => { ProbabilityS = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cumulative", Cumulative);
            writer.WriteObjectValue<Json>("numberF", NumberF);
            writer.WriteObjectValue<Json>("numberS", NumberS);
            writer.WriteObjectValue<Json>("probabilityS", ProbabilityS);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}