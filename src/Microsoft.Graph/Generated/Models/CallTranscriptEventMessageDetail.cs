using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class CallTranscriptEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Unique identifier of the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallId {
            get { return BackingStore?.Get<string?>("callId"); }
            set { BackingStore?.Set("callId", value); }
        }
#nullable restore
#else
        public string CallId {
            get { return BackingStore?.Get<string>("callId"); }
            set { BackingStore?.Set("callId", value); }
        }
#endif
        /// <summary>Unique identifier for a call transcript.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallTranscriptICalUid {
            get { return BackingStore?.Get<string?>("callTranscriptICalUid"); }
            set { BackingStore?.Set("callTranscriptICalUid", value); }
        }
#nullable restore
#else
        public string CallTranscriptICalUid {
            get { return BackingStore?.Get<string>("callTranscriptICalUid"); }
            set { BackingStore?.Set("callTranscriptICalUid", value); }
        }
#endif
        /// <summary>The organizer of the meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? MeetingOrganizer {
            get { return BackingStore?.Get<IdentitySet?>("meetingOrganizer"); }
            set { BackingStore?.Set("meetingOrganizer", value); }
        }
#nullable restore
#else
        public IdentitySet MeetingOrganizer {
            get { return BackingStore?.Get<IdentitySet>("meetingOrganizer"); }
            set { BackingStore?.Set("meetingOrganizer", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new callTranscriptEventMessageDetail and sets the default values.
        /// </summary>
        public CallTranscriptEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.callTranscriptEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CallTranscriptEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CallTranscriptEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"callId", n => { CallId = n.GetStringValue(); } },
                {"callTranscriptICalUid", n => { CallTranscriptICalUid = n.GetStringValue(); } },
                {"meetingOrganizer", n => { MeetingOrganizer = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("callId", CallId);
            writer.WriteStringValue("callTranscriptICalUid", CallTranscriptICalUid);
            writer.WriteObjectValue<IdentitySet>("meetingOrganizer", MeetingOrganizer);
        }
    }
}