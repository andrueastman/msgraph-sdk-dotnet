// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class UnifiedRoleManagementPolicyEnablementRule : global::Microsoft.Graph.Models.UnifiedRoleManagementPolicyRule, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The collection of rules that are enabled for this policy rule. For example, MultiFactorAuthentication, Ticketing, and Justification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnabledRules
        {
            get { return BackingStore?.Get<List<string>?>("enabledRules"); }
            set { BackingStore?.Set("enabledRules", value); }
        }
#nullable restore
#else
        public List<string> EnabledRules
        {
            get { return BackingStore?.Get<List<string>>("enabledRules"); }
            set { BackingStore?.Set("enabledRules", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.UnifiedRoleManagementPolicyEnablementRule"/> and sets the default values.
        /// </summary>
        public UnifiedRoleManagementPolicyEnablementRule() : base()
        {
            OdataType = "#microsoft.graph.unifiedRoleManagementPolicyEnablementRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.UnifiedRoleManagementPolicyEnablementRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.UnifiedRoleManagementPolicyEnablementRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.UnifiedRoleManagementPolicyEnablementRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "enabledRules", n => { EnabledRules = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("enabledRules", EnabledRules);
        }
    }
}
