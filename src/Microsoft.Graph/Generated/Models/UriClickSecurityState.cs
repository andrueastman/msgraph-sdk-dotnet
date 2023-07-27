using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class UriClickSecurityState : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The clickAction property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClickAction {
            get { return BackingStore?.Get<string?>("clickAction"); }
            set { BackingStore?.Set("clickAction", value); }
        }
#nullable restore
#else
        public string ClickAction {
            get { return BackingStore?.Get<string>("clickAction"); }
            set { BackingStore?.Set("clickAction", value); }
        }
#endif
        /// <summary>The clickDateTime property</summary>
        public DateTimeOffset? ClickDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("clickDateTime"); }
            set { BackingStore?.Set("clickDateTime", value); }
        }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id {
            get { return BackingStore?.Get<string?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#nullable restore
#else
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
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
        /// <summary>The sourceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceId {
            get { return BackingStore?.Get<string?>("sourceId"); }
            set { BackingStore?.Set("sourceId", value); }
        }
#nullable restore
#else
        public string SourceId {
            get { return BackingStore?.Get<string>("sourceId"); }
            set { BackingStore?.Set("sourceId", value); }
        }
#endif
        /// <summary>The uriDomain property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UriDomain {
            get { return BackingStore?.Get<string?>("uriDomain"); }
            set { BackingStore?.Set("uriDomain", value); }
        }
#nullable restore
#else
        public string UriDomain {
            get { return BackingStore?.Get<string>("uriDomain"); }
            set { BackingStore?.Set("uriDomain", value); }
        }
#endif
        /// <summary>The verdict property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Verdict {
            get { return BackingStore?.Get<string?>("verdict"); }
            set { BackingStore?.Set("verdict", value); }
        }
#nullable restore
#else
        public string Verdict {
            get { return BackingStore?.Get<string>("verdict"); }
            set { BackingStore?.Set("verdict", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new uriClickSecurityState and sets the default values.
        /// </summary>
        public UriClickSecurityState() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UriClickSecurityState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UriClickSecurityState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"clickAction", n => { ClickAction = n.GetStringValue(); } },
                {"clickDateTime", n => { ClickDateTime = n.GetDateTimeOffsetValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sourceId", n => { SourceId = n.GetStringValue(); } },
                {"uriDomain", n => { UriDomain = n.GetStringValue(); } },
                {"verdict", n => { Verdict = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clickAction", ClickAction);
            writer.WriteDateTimeOffsetValue("clickDateTime", ClickDateTime);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sourceId", SourceId);
            writer.WriteStringValue("uriDomain", UriDomain);
            writer.WriteStringValue("verdict", Verdict);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}