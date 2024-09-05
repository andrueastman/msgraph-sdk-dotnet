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
    public partial class PrinterCreateOperation : global::Microsoft.Graph.Models.PrintOperation, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The signed certificate created during the registration process. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Certificate
        {
            get { return BackingStore?.Get<string?>("certificate"); }
            set { BackingStore?.Set("certificate", value); }
        }
#nullable restore
#else
        public string Certificate
        {
            get { return BackingStore?.Get<string>("certificate"); }
            set { BackingStore?.Set("certificate", value); }
        }
#endif
        /// <summary>The created printer entity. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Printer? Printer
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Printer?>("printer"); }
            set { BackingStore?.Set("printer", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Printer Printer
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Printer>("printer"); }
            set { BackingStore?.Set("printer", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.PrinterCreateOperation"/> and sets the default values.
        /// </summary>
        public PrinterCreateOperation() : base()
        {
            OdataType = "#microsoft.graph.printerCreateOperation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.PrinterCreateOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.PrinterCreateOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.PrinterCreateOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "certificate", n => { Certificate = n.GetStringValue(); } },
                { "printer", n => { Printer = n.GetObjectValue<global::Microsoft.Graph.Models.Printer>(global::Microsoft.Graph.Models.Printer.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("certificate", Certificate);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Printer>("printer", Printer);
        }
    }
}
#pragma warning restore CS0618
