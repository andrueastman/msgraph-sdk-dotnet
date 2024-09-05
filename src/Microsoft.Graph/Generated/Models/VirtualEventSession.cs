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
    public partial class VirtualEventSession : global::Microsoft.Graph.Models.OnlineMeetingBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The virtual event session end time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DateTimeTimeZone? EndDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DateTimeTimeZone EndDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
#endif
        /// <summary>The virtual event session start time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DateTimeTimeZone? StartDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DateTimeTimeZone StartDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.VirtualEventSession"/> and sets the default values.
        /// </summary>
        public VirtualEventSession() : base()
        {
            OdataType = "#microsoft.graph.virtualEventSession";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.VirtualEventSession"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.VirtualEventSession CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.VirtualEventSession();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "endDateTime", n => { EndDateTime = n.GetObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>(global::Microsoft.Graph.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "startDateTime", n => { StartDateTime = n.GetObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>(global::Microsoft.Graph.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>("endDateTime", EndDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>("startDateTime", StartDateTime);
        }
    }
}
#pragma warning restore CS0618
