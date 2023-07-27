using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class UnifiedRoleManagementPolicyRuleTarget : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The type of caller that&apos;s the target of the policy rule. Allowed values are: None, Admin, EndUser.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Caller {
            get { return BackingStore?.Get<string?>("caller"); }
            set { BackingStore?.Set("caller", value); }
        }
#nullable restore
#else
        public string Caller {
            get { return BackingStore?.Get<string>("caller"); }
            set { BackingStore?.Set("caller", value); }
        }
#endif
        /// <summary>The list of role settings that are enforced and cannot be overridden by child scopes. Use All for all settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnforcedSettings {
            get { return BackingStore?.Get<List<string>?>("enforcedSettings"); }
            set { BackingStore?.Set("enforcedSettings", value); }
        }
#nullable restore
#else
        public List<string> EnforcedSettings {
            get { return BackingStore?.Get<List<string>>("enforcedSettings"); }
            set { BackingStore?.Set("enforcedSettings", value); }
        }
#endif
        /// <summary>The list of role settings that can be inherited by child scopes. Use All for all settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? InheritableSettings {
            get { return BackingStore?.Get<List<string>?>("inheritableSettings"); }
            set { BackingStore?.Set("inheritableSettings", value); }
        }
#nullable restore
#else
        public List<string> InheritableSettings {
            get { return BackingStore?.Get<List<string>>("inheritableSettings"); }
            set { BackingStore?.Set("inheritableSettings", value); }
        }
#endif
        /// <summary>The role assignment type that&apos;s the target of policy rule. Allowed values are: Eligibility, Assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Level {
            get { return BackingStore?.Get<string?>("level"); }
            set { BackingStore?.Set("level", value); }
        }
#nullable restore
#else
        public string Level {
            get { return BackingStore?.Get<string>("level"); }
            set { BackingStore?.Set("level", value); }
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
        /// <summary>The role management operations that are the target of the policy rule. Allowed values are: All, Activate, Deactivate, Assign, Update, Remove, Extend, Renew.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleManagementPolicyRuleTargetOperations?>? Operations {
            get { return BackingStore?.Get<List<UnifiedRoleManagementPolicyRuleTargetOperations?>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleManagementPolicyRuleTargetOperations?> Operations {
            get { return BackingStore?.Get<List<UnifiedRoleManagementPolicyRuleTargetOperations?>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>The targetObjects property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? TargetObjects {
            get { return BackingStore?.Get<List<DirectoryObject>?>("targetObjects"); }
            set { BackingStore?.Set("targetObjects", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> TargetObjects {
            get { return BackingStore?.Get<List<DirectoryObject>>("targetObjects"); }
            set { BackingStore?.Set("targetObjects", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new unifiedRoleManagementPolicyRuleTarget and sets the default values.
        /// </summary>
        public UnifiedRoleManagementPolicyRuleTarget() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UnifiedRoleManagementPolicyRuleTarget CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementPolicyRuleTarget();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"caller", n => { Caller = n.GetStringValue(); } },
                {"enforcedSettings", n => { EnforcedSettings = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"inheritableSettings", n => { InheritableSettings = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"level", n => { Level = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfEnumValues<UnifiedRoleManagementPolicyRuleTargetOperations>()?.ToList(); } },
                {"targetObjects", n => { TargetObjects = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("caller", Caller);
            writer.WriteCollectionOfPrimitiveValues<string>("enforcedSettings", EnforcedSettings);
            writer.WriteCollectionOfPrimitiveValues<string>("inheritableSettings", InheritableSettings);
            writer.WriteStringValue("level", Level);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfEnumValues<UnifiedRoleManagementPolicyRuleTargetOperations>("operations", Operations);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("targetObjects", TargetObjects);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}