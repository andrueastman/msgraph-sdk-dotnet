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
    public partial class TeamsAppRemovedEventMessageDetail : global::Microsoft.Graph.Models.EventMessageDetail, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Initiator of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentitySet? Initiator
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet?>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentitySet Initiator
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#endif
        /// <summary>Display name of the teamsApp.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamsAppDisplayName
        {
            get { return BackingStore?.Get<string?>("teamsAppDisplayName"); }
            set { BackingStore?.Set("teamsAppDisplayName", value); }
        }
#nullable restore
#else
        public string TeamsAppDisplayName
        {
            get { return BackingStore?.Get<string>("teamsAppDisplayName"); }
            set { BackingStore?.Set("teamsAppDisplayName", value); }
        }
#endif
        /// <summary>Unique identifier of the teamsApp.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamsAppId
        {
            get { return BackingStore?.Get<string?>("teamsAppId"); }
            set { BackingStore?.Set("teamsAppId", value); }
        }
#nullable restore
#else
        public string TeamsAppId
        {
            get { return BackingStore?.Get<string>("teamsAppId"); }
            set { BackingStore?.Set("teamsAppId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.TeamsAppRemovedEventMessageDetail"/> and sets the default values.
        /// </summary>
        public TeamsAppRemovedEventMessageDetail() : base()
        {
            OdataType = "#microsoft.graph.teamsAppRemovedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TeamsAppRemovedEventMessageDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.TeamsAppRemovedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.TeamsAppRemovedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "initiator", n => { Initiator = n.GetObjectValue<global::Microsoft.Graph.Models.IdentitySet>(global::Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "teamsAppDisplayName", n => { TeamsAppDisplayName = n.GetStringValue(); } },
                { "teamsAppId", n => { TeamsAppId = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IdentitySet>("initiator", Initiator);
            writer.WriteStringValue("teamsAppDisplayName", TeamsAppDisplayName);
            writer.WriteStringValue("teamsAppId", TeamsAppId);
        }
    }
}
