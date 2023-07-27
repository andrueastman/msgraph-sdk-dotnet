using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ConnectedOrganization : Entity, IParsable {
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description of the connected organization.</summary>
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
        /// <summary>The display name of the connected organization. Supports $filter (eq).</summary>
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
        /// <summary>The externalSponsors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? ExternalSponsors {
            get { return BackingStore?.Get<List<DirectoryObject>?>("externalSponsors"); }
            set { BackingStore?.Set("externalSponsors", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> ExternalSponsors {
            get { return BackingStore?.Get<List<DirectoryObject>>("externalSponsors"); }
            set { BackingStore?.Set("externalSponsors", value); }
        }
#endif
        /// <summary>The identity sources in this connected organization, one of azureActiveDirectoryTenant, domainIdentitySource, externalDomainFederation or crossCloudAzureActiveDirectoryTenant. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentitySource>? IdentitySources {
            get { return BackingStore?.Get<List<IdentitySource>?>("identitySources"); }
            set { BackingStore?.Set("identitySources", value); }
        }
#nullable restore
#else
        public List<IdentitySource> IdentitySources {
            get { return BackingStore?.Get<List<IdentitySource>>("identitySources"); }
            set { BackingStore?.Set("identitySources", value); }
        }
#endif
        /// <summary>The internalSponsors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? InternalSponsors {
            get { return BackingStore?.Get<List<DirectoryObject>?>("internalSponsors"); }
            set { BackingStore?.Set("internalSponsors", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> InternalSponsors {
            get { return BackingStore?.Get<List<DirectoryObject>>("internalSponsors"); }
            set { BackingStore?.Set("internalSponsors", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("modifiedDateTime"); }
            set { BackingStore?.Set("modifiedDateTime", value); }
        }
        /// <summary>The state of a connected organization defines whether assignment policies with requestor scope type AllConfiguredConnectedOrganizationSubjects are applicable or not.  The possible values are: configured, proposed, unknownFutureValue.</summary>
        public ConnectedOrganizationState? State {
            get { return BackingStore?.Get<ConnectedOrganizationState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConnectedOrganization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConnectedOrganization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalSponsors", n => { ExternalSponsors = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"identitySources", n => { IdentitySources = n.GetCollectionOfObjectValues<IdentitySource>(IdentitySource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"internalSponsors", n => { InternalSponsors = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", n => { State = n.GetEnumValue<ConnectedOrganizationState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("externalSponsors", ExternalSponsors);
            writer.WriteCollectionOfObjectValues<IdentitySource>("identitySources", IdentitySources);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("internalSponsors", InternalSponsors);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteEnumValue<ConnectedOrganizationState>("state", State);
        }
    }
}