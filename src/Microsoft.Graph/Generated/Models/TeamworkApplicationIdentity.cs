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
    public partial class TeamworkApplicationIdentity : global::Microsoft.Graph.Models.Identity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Type of application that is referenced. Possible values are: aadApplication, bot, tenantBot, office365Connector, outgoingWebhook, and unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.TeamworkApplicationIdentityType? ApplicationIdentityType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamworkApplicationIdentityType?>("applicationIdentityType"); }
            set { BackingStore?.Set("applicationIdentityType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.TeamworkApplicationIdentity"/> and sets the default values.
        /// </summary>
        public TeamworkApplicationIdentity() : base()
        {
            OdataType = "#microsoft.graph.teamworkApplicationIdentity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TeamworkApplicationIdentity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.TeamworkApplicationIdentity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.TeamworkApplicationIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "applicationIdentityType", n => { ApplicationIdentityType = n.GetEnumValue<global::Microsoft.Graph.Models.TeamworkApplicationIdentityType>(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.TeamworkApplicationIdentityType>("applicationIdentityType", ApplicationIdentityType);
        }
    }
}
