// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.IdentityGovernance
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class MembershipChangeTrigger : global::Microsoft.Graph.Models.IdentityGovernance.WorkflowExecutionTrigger, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The changeType property</summary>
        public global::Microsoft.Graph.Models.IdentityGovernance.MembershipChangeType? ChangeType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.MembershipChangeType?>("changeType"); }
            set { BackingStore?.Set("changeType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.IdentityGovernance.MembershipChangeTrigger"/> and sets the default values.
        /// </summary>
        public MembershipChangeTrigger() : base()
        {
            OdataType = "#microsoft.graph.identityGovernance.membershipChangeTrigger";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityGovernance.MembershipChangeTrigger"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.IdentityGovernance.MembershipChangeTrigger CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.IdentityGovernance.MembershipChangeTrigger();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "changeType", n => { ChangeType = n.GetEnumValue<global::Microsoft.Graph.Models.IdentityGovernance.MembershipChangeType>(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.IdentityGovernance.MembershipChangeType>("changeType", ChangeType);
        }
    }
}
#pragma warning restore CS0618