// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class InferenceClassificationOverride : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies how incoming messages from a specific sender should always be classified as. The possible values are: focused, other.</summary>
        public global::Microsoft.Graph.Models.InferenceClassificationType? ClassifyAs
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.InferenceClassificationType?>("classifyAs"); }
            set { BackingStore?.Set("classifyAs", value); }
        }
        /// <summary>The email address information of the sender for whom the override is created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EmailAddress? SenderEmailAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EmailAddress?>("senderEmailAddress"); }
            set { BackingStore?.Set("senderEmailAddress", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EmailAddress SenderEmailAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EmailAddress>("senderEmailAddress"); }
            set { BackingStore?.Set("senderEmailAddress", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.InferenceClassificationOverride"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.InferenceClassificationOverride CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.InferenceClassificationOverride();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "classifyAs", n => { ClassifyAs = n.GetEnumValue<global::Microsoft.Graph.Models.InferenceClassificationType>(); } },
                { "senderEmailAddress", n => { SenderEmailAddress = n.GetObjectValue<global::Microsoft.Graph.Models.EmailAddress>(global::Microsoft.Graph.Models.EmailAddress.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.InferenceClassificationType>("classifyAs", ClassifyAs);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EmailAddress>("senderEmailAddress", SenderEmailAddress);
        }
    }
}
#pragma warning restore CS0618
