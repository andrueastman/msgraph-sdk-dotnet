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
    public partial class SiteProtectionRule : global::Microsoft.Graph.Models.ProtectionRuleBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Contains a site expression. For examples, see siteExpression example.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SiteExpression
        {
            get { return BackingStore?.Get<string?>("siteExpression"); }
            set { BackingStore?.Set("siteExpression", value); }
        }
#nullable restore
#else
        public string SiteExpression
        {
            get { return BackingStore?.Get<string>("siteExpression"); }
            set { BackingStore?.Set("siteExpression", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.SiteProtectionRule"/> and sets the default values.
        /// </summary>
        public SiteProtectionRule() : base()
        {
            OdataType = "#microsoft.graph.siteProtectionRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SiteProtectionRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.SiteProtectionRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.SiteProtectionRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "siteExpression", n => { SiteExpression = n.GetStringValue(); } },
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
            writer.WriteStringValue("siteExpression", SiteExpression);
        }
    }
}