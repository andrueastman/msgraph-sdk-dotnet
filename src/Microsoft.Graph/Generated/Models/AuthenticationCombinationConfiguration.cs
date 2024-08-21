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
    public partial class AuthenticationCombinationConfiguration : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Which authentication method combinations this configuration applies to. Must be an allowedCombinations object, part of the authenticationStrengthPolicy. The only possible value for fido2combinationConfigurations is &apos;fido2&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AuthenticationMethodModes?>? AppliesToCombinations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AuthenticationMethodModes?>?>("appliesToCombinations"); }
            set { BackingStore?.Set("appliesToCombinations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AuthenticationMethodModes?> AppliesToCombinations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AuthenticationMethodModes?>>("appliesToCombinations"); }
            set { BackingStore?.Set("appliesToCombinations", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AuthenticationCombinationConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AuthenticationCombinationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.fido2CombinationConfiguration" => new global::Microsoft.Graph.Models.Fido2CombinationConfiguration(),
                "#microsoft.graph.x509CertificateCombinationConfiguration" => new global::Microsoft.Graph.Models.X509CertificateCombinationConfiguration(),
                _ => new global::Microsoft.Graph.Models.AuthenticationCombinationConfiguration(),
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
                { "appliesToCombinations", n => { AppliesToCombinations = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.AuthenticationMethodModes>()?.AsList(); } },
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
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.AuthenticationMethodModes>("appliesToCombinations", AppliesToCombinations);
        }
    }
}
