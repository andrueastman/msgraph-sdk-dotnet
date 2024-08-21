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
    public partial class DelegatedAdminServiceManagementDetail : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The URL of the management portal for the managed service. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceManagementUrl
        {
            get { return BackingStore?.Get<string?>("serviceManagementUrl"); }
            set { BackingStore?.Set("serviceManagementUrl", value); }
        }
#nullable restore
#else
        public string ServiceManagementUrl
        {
            get { return BackingStore?.Get<string>("serviceManagementUrl"); }
            set { BackingStore?.Set("serviceManagementUrl", value); }
        }
#endif
        /// <summary>The name of a managed service. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceName
        {
            get { return BackingStore?.Get<string?>("serviceName"); }
            set { BackingStore?.Set("serviceName", value); }
        }
#nullable restore
#else
        public string ServiceName
        {
            get { return BackingStore?.Get<string>("serviceName"); }
            set { BackingStore?.Set("serviceName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DelegatedAdminServiceManagementDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.DelegatedAdminServiceManagementDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.DelegatedAdminServiceManagementDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "serviceManagementUrl", n => { ServiceManagementUrl = n.GetStringValue(); } },
                { "serviceName", n => { ServiceName = n.GetStringValue(); } },
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
            writer.WriteStringValue("serviceManagementUrl", ServiceManagementUrl);
            writer.WriteStringValue("serviceName", ServiceName);
        }
    }
}
