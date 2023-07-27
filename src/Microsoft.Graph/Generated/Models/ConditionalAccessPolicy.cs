using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ConditionalAccessPolicy : Entity, IParsable {
        /// <summary>The conditions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessConditionSet? Conditions {
            get { return BackingStore?.Get<ConditionalAccessConditionSet?>("conditions"); }
            set { BackingStore?.Set("conditions", value); }
        }
#nullable restore
#else
        public ConditionalAccessConditionSet Conditions {
            get { return BackingStore?.Get<ConditionalAccessConditionSet>("conditions"); }
            set { BackingStore?.Set("conditions", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Readonly.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Specifies a display name for the conditionalAccessPolicy object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Specifies the grant controls that must be fulfilled to pass the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessGrantControls? GrantControls {
            get { return BackingStore?.Get<ConditionalAccessGrantControls?>("grantControls"); }
            set { BackingStore?.Set("grantControls", value); }
        }
#nullable restore
#else
        public ConditionalAccessGrantControls GrantControls {
            get { return BackingStore?.Get<ConditionalAccessGrantControls>("grantControls"); }
            set { BackingStore?.Set("grantControls", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Readonly.</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("modifiedDateTime"); }
            set { BackingStore?.Set("modifiedDateTime", value); }
        }
        /// <summary>Specifies the session controls that are enforced after sign-in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessSessionControls? SessionControls {
            get { return BackingStore?.Get<ConditionalAccessSessionControls?>("sessionControls"); }
            set { BackingStore?.Set("sessionControls", value); }
        }
#nullable restore
#else
        public ConditionalAccessSessionControls SessionControls {
            get { return BackingStore?.Get<ConditionalAccessSessionControls>("sessionControls"); }
            set { BackingStore?.Set("sessionControls", value); }
        }
#endif
        /// <summary>The state property</summary>
        public ConditionalAccessPolicyState? State {
            get { return BackingStore?.Get<ConditionalAccessPolicyState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConditionalAccessPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"conditions", n => { Conditions = n.GetObjectValue<ConditionalAccessConditionSet>(ConditionalAccessConditionSet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"grantControls", n => { GrantControls = n.GetObjectValue<ConditionalAccessGrantControls>(ConditionalAccessGrantControls.CreateFromDiscriminatorValue); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"sessionControls", n => { SessionControls = n.GetObjectValue<ConditionalAccessSessionControls>(ConditionalAccessSessionControls.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetEnumValue<ConditionalAccessPolicyState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ConditionalAccessConditionSet>("conditions", Conditions);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<ConditionalAccessGrantControls>("grantControls", GrantControls);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteObjectValue<ConditionalAccessSessionControls>("sessionControls", SessionControls);
            writer.WriteEnumValue<ConditionalAccessPolicyState>("state", State);
        }
    }
}