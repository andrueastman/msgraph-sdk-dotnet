using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class PrintTaskTrigger : Entity, IParsable {
        /// <summary>The definition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrintTaskDefinition? Definition {
            get { return BackingStore?.Get<PrintTaskDefinition?>("definition"); }
            set { BackingStore?.Set("definition", value); }
        }
#nullable restore
#else
        public PrintTaskDefinition Definition {
            get { return BackingStore?.Get<PrintTaskDefinition>("definition"); }
            set { BackingStore?.Set("definition", value); }
        }
#endif
        /// <summary>The event property</summary>
        public PrintEvent? Event {
            get { return BackingStore?.Get<PrintEvent?>("event"); }
            set { BackingStore?.Set("event", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrintTaskTrigger CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintTaskTrigger();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"definition", n => { Definition = n.GetObjectValue<PrintTaskDefinition>(PrintTaskDefinition.CreateFromDiscriminatorValue); } },
                {"event", n => { Event = n.GetEnumValue<PrintEvent>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PrintTaskDefinition>("definition", Definition);
            writer.WriteEnumValue<PrintEvent>("event", Event);
        }
    }
}