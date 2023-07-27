using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AccessPackageResource : Entity, IParsable {
        /// <summary>The createdDateTime property</summary>
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
        /// <summary>The displayName property</summary>
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
        /// <summary>The environment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageResourceEnvironment? Environment {
            get { return BackingStore?.Get<AccessPackageResourceEnvironment?>("environment"); }
            set { BackingStore?.Set("environment", value); }
        }
#nullable restore
#else
        public AccessPackageResourceEnvironment Environment {
            get { return BackingStore?.Get<AccessPackageResourceEnvironment>("environment"); }
            set { BackingStore?.Set("environment", value); }
        }
#endif
        /// <summary>The modifiedDateTime property</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("modifiedDateTime"); }
            set { BackingStore?.Set("modifiedDateTime", value); }
        }
        /// <summary>The originId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginId {
            get { return BackingStore?.Get<string?>("originId"); }
            set { BackingStore?.Set("originId", value); }
        }
#nullable restore
#else
        public string OriginId {
            get { return BackingStore?.Get<string>("originId"); }
            set { BackingStore?.Set("originId", value); }
        }
#endif
        /// <summary>The originSystem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginSystem {
            get { return BackingStore?.Get<string?>("originSystem"); }
            set { BackingStore?.Set("originSystem", value); }
        }
#nullable restore
#else
        public string OriginSystem {
            get { return BackingStore?.Get<string>("originSystem"); }
            set { BackingStore?.Set("originSystem", value); }
        }
#endif
        /// <summary>The roles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageResourceRole>? Roles {
            get { return BackingStore?.Get<List<AccessPackageResourceRole>?>("roles"); }
            set { BackingStore?.Set("roles", value); }
        }
#nullable restore
#else
        public List<AccessPackageResourceRole> Roles {
            get { return BackingStore?.Get<List<AccessPackageResourceRole>>("roles"); }
            set { BackingStore?.Set("roles", value); }
        }
#endif
        /// <summary>The scopes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageResourceScope>? Scopes {
            get { return BackingStore?.Get<List<AccessPackageResourceScope>?>("scopes"); }
            set { BackingStore?.Set("scopes", value); }
        }
#nullable restore
#else
        public List<AccessPackageResourceScope> Scopes {
            get { return BackingStore?.Get<List<AccessPackageResourceScope>>("scopes"); }
            set { BackingStore?.Set("scopes", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"environment", n => { Environment = n.GetObjectValue<AccessPackageResourceEnvironment>(AccessPackageResourceEnvironment.CreateFromDiscriminatorValue); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"originId", n => { OriginId = n.GetStringValue(); } },
                {"originSystem", n => { OriginSystem = n.GetStringValue(); } },
                {"roles", n => { Roles = n.GetCollectionOfObjectValues<AccessPackageResourceRole>(AccessPackageResourceRole.CreateFromDiscriminatorValue)?.ToList(); } },
                {"scopes", n => { Scopes = n.GetCollectionOfObjectValues<AccessPackageResourceScope>(AccessPackageResourceScope.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteObjectValue<AccessPackageResourceEnvironment>("environment", Environment);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteStringValue("originId", OriginId);
            writer.WriteStringValue("originSystem", OriginSystem);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceRole>("roles", Roles);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceScope>("scopes", Scopes);
        }
    }
}