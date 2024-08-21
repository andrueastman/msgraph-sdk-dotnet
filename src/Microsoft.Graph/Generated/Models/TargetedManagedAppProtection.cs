// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Policy used to configure detailed management settings targeted to specific security groups
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class TargetedManagedAppProtection : global::Microsoft.Graph.Models.ManagedAppProtection, IParsable
    {
        /// <summary>Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TargetedManagedAppPolicyAssignment>? Assignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TargetedManagedAppPolicyAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TargetedManagedAppPolicyAssignment> Assignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TargetedManagedAppPolicyAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>Indicates if the policy is deployed to any inclusion groups or not.</summary>
        public bool? IsAssigned
        {
            get { return BackingStore?.Get<bool?>("isAssigned"); }
            set { BackingStore?.Set("isAssigned", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.TargetedManagedAppProtection"/> and sets the default values.
        /// </summary>
        public TargetedManagedAppProtection() : base()
        {
            OdataType = "#microsoft.graph.targetedManagedAppProtection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TargetedManagedAppProtection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.TargetedManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.androidManagedAppProtection" => new global::Microsoft.Graph.Models.AndroidManagedAppProtection(),
                "#microsoft.graph.iosManagedAppProtection" => new global::Microsoft.Graph.Models.IosManagedAppProtection(),
                _ => new global::Microsoft.Graph.Models.TargetedManagedAppProtection(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TargetedManagedAppPolicyAssignment>(global::Microsoft.Graph.Models.TargetedManagedAppPolicyAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TargetedManagedAppPolicyAssignment>("assignments", Assignments);
            writer.WriteBoolValue("isAssigned", IsAssigned);
        }
    }
}
