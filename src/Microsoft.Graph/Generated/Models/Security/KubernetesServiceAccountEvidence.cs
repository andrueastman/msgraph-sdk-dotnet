// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class KubernetesServiceAccountEvidence : global::Microsoft.Graph.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The service account name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The service account namespace.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.KubernetesNamespaceEvidence? Namespace
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.KubernetesNamespaceEvidence?>("namespace"); }
            set { BackingStore?.Set("namespace", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.KubernetesNamespaceEvidence Namespace
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.KubernetesNamespaceEvidence>("namespace"); }
            set { BackingStore?.Set("namespace", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Security.KubernetesServiceAccountEvidence"/> and sets the default values.
        /// </summary>
        public KubernetesServiceAccountEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.kubernetesServiceAccountEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.KubernetesServiceAccountEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.KubernetesServiceAccountEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.KubernetesServiceAccountEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "name", n => { Name = n.GetStringValue(); } },
                { "namespace", n => { Namespace = n.GetObjectValue<global::Microsoft.Graph.Models.Security.KubernetesNamespaceEvidence>(global::Microsoft.Graph.Models.Security.KubernetesNamespaceEvidence.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.KubernetesNamespaceEvidence>("namespace", Namespace);
        }
    }
}
#pragma warning restore CS0618
