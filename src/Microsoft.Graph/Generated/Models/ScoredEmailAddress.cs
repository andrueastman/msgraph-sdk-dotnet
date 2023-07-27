using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ScoredEmailAddress : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The email address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address {
            get { return BackingStore?.Get<string?>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#nullable restore
#else
        public string Address {
            get { return BackingStore?.Get<string>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The itemId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ItemId {
            get { return BackingStore?.Get<string?>("itemId"); }
            set { BackingStore?.Set("itemId", value); }
        }
#nullable restore
#else
        public string ItemId {
            get { return BackingStore?.Get<string>("itemId"); }
            set { BackingStore?.Set("itemId", value); }
        }
#endif
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
        /// <summary>The relevance score of the email address. A relevance score is used as a sort key, in relation to the other returned results. A higher relevance score value corresponds to a more relevant result. Relevance is determined by the user’s communication and collaboration patterns and business relationships.</summary>
        public double? RelevanceScore {
            get { return BackingStore?.Get<double?>("relevanceScore"); }
            set { BackingStore?.Set("relevanceScore", value); }
        }
        /// <summary>The selectionLikelihood property</summary>
        public SelectionLikelihoodInfo? SelectionLikelihood {
            get { return BackingStore?.Get<SelectionLikelihoodInfo?>("selectionLikelihood"); }
            set { BackingStore?.Set("selectionLikelihood", value); }
        }
        /// <summary>
        /// Instantiates a new scoredEmailAddress and sets the default values.
        /// </summary>
        public ScoredEmailAddress() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ScoredEmailAddress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScoredEmailAddress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"address", n => { Address = n.GetStringValue(); } },
                {"itemId", n => { ItemId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"relevanceScore", n => { RelevanceScore = n.GetDoubleValue(); } },
                {"selectionLikelihood", n => { SelectionLikelihood = n.GetEnumValue<SelectionLikelihoodInfo>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("address", Address);
            writer.WriteStringValue("itemId", ItemId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDoubleValue("relevanceScore", RelevanceScore);
            writer.WriteEnumValue<SelectionLikelihoodInfo>("selectionLikelihood", SelectionLikelihood);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}