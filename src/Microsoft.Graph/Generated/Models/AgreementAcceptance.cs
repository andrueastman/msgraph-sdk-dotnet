using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AgreementAcceptance : Entity, IParsable {
        /// <summary>The identifier of the agreement file accepted by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AgreementFileId {
            get { return BackingStore?.Get<string?>("agreementFileId"); }
            set { BackingStore?.Set("agreementFileId", value); }
        }
#nullable restore
#else
        public string AgreementFileId {
            get { return BackingStore?.Get<string>("agreementFileId"); }
            set { BackingStore?.Set("agreementFileId", value); }
        }
#endif
        /// <summary>The identifier of the agreement.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AgreementId {
            get { return BackingStore?.Get<string?>("agreementId"); }
            set { BackingStore?.Set("agreementId", value); }
        }
#nullable restore
#else
        public string AgreementId {
            get { return BackingStore?.Get<string>("agreementId"); }
            set { BackingStore?.Set("agreementId", value); }
        }
#endif
        /// <summary>The display name of the device used for accepting the agreement.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceDisplayName {
            get { return BackingStore?.Get<string?>("deviceDisplayName"); }
            set { BackingStore?.Set("deviceDisplayName", value); }
        }
#nullable restore
#else
        public string DeviceDisplayName {
            get { return BackingStore?.Get<string>("deviceDisplayName"); }
            set { BackingStore?.Set("deviceDisplayName", value); }
        }
#endif
        /// <summary>The unique identifier of the device used for accepting the agreement. Supports $filter (eq) and eq for null values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>The operating system used to accept the agreement.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceOSType {
            get { return BackingStore?.Get<string?>("deviceOSType"); }
            set { BackingStore?.Set("deviceOSType", value); }
        }
#nullable restore
#else
        public string DeviceOSType {
            get { return BackingStore?.Get<string>("deviceOSType"); }
            set { BackingStore?.Set("deviceOSType", value); }
        }
#endif
        /// <summary>The operating system version of the device used to accept the agreement.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceOSVersion {
            get { return BackingStore?.Get<string?>("deviceOSVersion"); }
            set { BackingStore?.Set("deviceOSVersion", value); }
        }
#nullable restore
#else
        public string DeviceOSVersion {
            get { return BackingStore?.Get<string>("deviceOSVersion"); }
            set { BackingStore?.Set("deviceOSVersion", value); }
        }
#endif
        /// <summary>The expiration date time of the acceptance. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $filter (eq, ge, le) and eq for null values.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? RecordedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("recordedDateTime"); }
            set { BackingStore?.Set("recordedDateTime", value); }
        }
        /// <summary>The state of the agreement acceptance. Possible values are: accepted, declined. Supports $filter (eq).</summary>
        public AgreementAcceptanceState? State {
            get { return BackingStore?.Get<AgreementAcceptanceState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>Display name of the user when the acceptance was recorded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName {
            get { return BackingStore?.Get<string?>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#nullable restore
#else
        public string UserDisplayName {
            get { return BackingStore?.Get<string>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#endif
        /// <summary>Email of the user when the acceptance was recorded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserEmail {
            get { return BackingStore?.Get<string?>("userEmail"); }
            set { BackingStore?.Set("userEmail", value); }
        }
#nullable restore
#else
        public string UserEmail {
            get { return BackingStore?.Get<string>("userEmail"); }
            set { BackingStore?.Set("userEmail", value); }
        }
#endif
        /// <summary>The identifier of the user who accepted the agreement. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>UPN of the user when the acceptance was recorded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AgreementAcceptance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AgreementAcceptance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"agreementFileId", n => { AgreementFileId = n.GetStringValue(); } },
                {"agreementId", n => { AgreementId = n.GetStringValue(); } },
                {"deviceDisplayName", n => { DeviceDisplayName = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceOSType", n => { DeviceOSType = n.GetStringValue(); } },
                {"deviceOSVersion", n => { DeviceOSVersion = n.GetStringValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"recordedDateTime", n => { RecordedDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", n => { State = n.GetEnumValue<AgreementAcceptanceState>(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userEmail", n => { UserEmail = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("agreementFileId", AgreementFileId);
            writer.WriteStringValue("agreementId", AgreementId);
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceOSType", DeviceOSType);
            writer.WriteStringValue("deviceOSVersion", DeviceOSVersion);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("recordedDateTime", RecordedDateTime);
            writer.WriteEnumValue<AgreementAcceptanceState>("state", State);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userEmail", UserEmail);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}