using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class FileAssessmentRequest : ThreatAssessmentRequest, IParsable {
        /// <summary>Base64 encoded file content. The file content cannot fetch back because it isn&apos;t stored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentData {
            get { return BackingStore?.Get<string?>("contentData"); }
            set { BackingStore?.Set("contentData", value); }
        }
#nullable restore
#else
        public string ContentData {
            get { return BackingStore?.Get<string>("contentData"); }
            set { BackingStore?.Set("contentData", value); }
        }
#endif
        /// <summary>The file name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName {
            get { return BackingStore?.Get<string?>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
#nullable restore
#else
        public string FileName {
            get { return BackingStore?.Get<string>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new fileAssessmentRequest and sets the default values.
        /// </summary>
        public FileAssessmentRequest() : base() {
            OdataType = "#microsoft.graph.fileAssessmentRequest";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new FileAssessmentRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FileAssessmentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contentData", n => { ContentData = n.GetStringValue(); } },
                {"fileName", n => { FileName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("contentData", ContentData);
            writer.WriteStringValue("fileName", FileName);
        }
    }
}