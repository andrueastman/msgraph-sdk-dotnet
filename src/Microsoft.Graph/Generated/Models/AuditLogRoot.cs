using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AuditLogRoot : Entity, IParsable {
        /// <summary>The directoryAudits property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryAudit>? DirectoryAudits {
            get { return BackingStore?.Get<List<DirectoryAudit>?>("directoryAudits"); }
            set { BackingStore?.Set("directoryAudits", value); }
        }
#nullable restore
#else
        public List<DirectoryAudit> DirectoryAudits {
            get { return BackingStore?.Get<List<DirectoryAudit>>("directoryAudits"); }
            set { BackingStore?.Set("directoryAudits", value); }
        }
#endif
        /// <summary>The provisioning property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProvisioningObjectSummary>? Provisioning {
            get { return BackingStore?.Get<List<ProvisioningObjectSummary>?>("provisioning"); }
            set { BackingStore?.Set("provisioning", value); }
        }
#nullable restore
#else
        public List<ProvisioningObjectSummary> Provisioning {
            get { return BackingStore?.Get<List<ProvisioningObjectSummary>>("provisioning"); }
            set { BackingStore?.Set("provisioning", value); }
        }
#endif
        /// <summary>The signIns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SignIn>? SignIns {
            get { return BackingStore?.Get<List<SignIn>?>("signIns"); }
            set { BackingStore?.Set("signIns", value); }
        }
#nullable restore
#else
        public List<SignIn> SignIns {
            get { return BackingStore?.Get<List<SignIn>>("signIns"); }
            set { BackingStore?.Set("signIns", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AuditLogRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditLogRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"directoryAudits", n => { DirectoryAudits = n.GetCollectionOfObjectValues<DirectoryAudit>(DirectoryAudit.CreateFromDiscriminatorValue)?.ToList(); } },
                {"provisioning", n => { Provisioning = n.GetCollectionOfObjectValues<ProvisioningObjectSummary>(ProvisioningObjectSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"signIns", n => { SignIns = n.GetCollectionOfObjectValues<SignIn>(SignIn.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DirectoryAudit>("directoryAudits", DirectoryAudits);
            writer.WriteCollectionOfObjectValues<ProvisioningObjectSummary>("provisioning", Provisioning);
            writer.WriteCollectionOfObjectValues<SignIn>("signIns", SignIns);
        }
    }
}