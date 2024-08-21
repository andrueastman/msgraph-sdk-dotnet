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
    public partial class PeopleAdminSettings : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents administrator settings that manage the support for item insights in an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.InsightsSettings? ItemInsights
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.InsightsSettings?>("itemInsights"); }
            set { BackingStore?.Set("itemInsights", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.InsightsSettings ItemInsights
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.InsightsSettings>("itemInsights"); }
            set { BackingStore?.Set("itemInsights", value); }
        }
#endif
        /// <summary>Contains a collection of the properties an administrator has defined as visible on the Microsoft 365 profile card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ProfileCardProperty>? ProfileCardProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ProfileCardProperty>?>("profileCardProperties"); }
            set { BackingStore?.Set("profileCardProperties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ProfileCardProperty> ProfileCardProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ProfileCardProperty>>("profileCardProperties"); }
            set { BackingStore?.Set("profileCardProperties", value); }
        }
#endif
        /// <summary>Represents administrator settings that manage the support of pronouns in an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.PronounsSettings? Pronouns
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PronounsSettings?>("pronouns"); }
            set { BackingStore?.Set("pronouns", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.PronounsSettings Pronouns
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PronounsSettings>("pronouns"); }
            set { BackingStore?.Set("pronouns", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.PeopleAdminSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.PeopleAdminSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.PeopleAdminSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "itemInsights", n => { ItemInsights = n.GetObjectValue<global::Microsoft.Graph.Models.InsightsSettings>(global::Microsoft.Graph.Models.InsightsSettings.CreateFromDiscriminatorValue); } },
                { "profileCardProperties", n => { ProfileCardProperties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ProfileCardProperty>(global::Microsoft.Graph.Models.ProfileCardProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pronouns", n => { Pronouns = n.GetObjectValue<global::Microsoft.Graph.Models.PronounsSettings>(global::Microsoft.Graph.Models.PronounsSettings.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.InsightsSettings>("itemInsights", ItemInsights);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ProfileCardProperty>("profileCardProperties", ProfileCardProperties);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.PronounsSettings>("pronouns", Pronouns);
        }
    }
}
