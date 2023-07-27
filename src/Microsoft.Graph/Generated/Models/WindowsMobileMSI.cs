using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Contains properties and inherited properties for Windows Mobile MSI Line Of Business apps.
    /// </summary>
    public class WindowsMobileMSI : MobileLobApp, IParsable {
        /// <summary>The command line.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommandLine {
            get { return BackingStore?.Get<string?>("commandLine"); }
            set { BackingStore?.Set("commandLine", value); }
        }
#nullable restore
#else
        public string CommandLine {
            get { return BackingStore?.Get<string>("commandLine"); }
            set { BackingStore?.Set("commandLine", value); }
        }
#endif
        /// <summary>A boolean to control whether the app&apos;s version will be used to detect the app after it is installed on a device. Set this to true for Windows Mobile MSI Line of Business (LoB) apps that use a self update feature.</summary>
        public bool? IgnoreVersionDetection {
            get { return BackingStore?.Get<bool?>("ignoreVersionDetection"); }
            set { BackingStore?.Set("ignoreVersionDetection", value); }
        }
        /// <summary>The product code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductCode {
            get { return BackingStore?.Get<string?>("productCode"); }
            set { BackingStore?.Set("productCode", value); }
        }
#nullable restore
#else
        public string ProductCode {
            get { return BackingStore?.Get<string>("productCode"); }
            set { BackingStore?.Set("productCode", value); }
        }
#endif
        /// <summary>The product version of Windows Mobile MSI Line of Business (LoB) app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductVersion {
            get { return BackingStore?.Get<string?>("productVersion"); }
            set { BackingStore?.Set("productVersion", value); }
        }
#nullable restore
#else
        public string ProductVersion {
            get { return BackingStore?.Get<string>("productVersion"); }
            set { BackingStore?.Set("productVersion", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new windowsMobileMSI and sets the default values.
        /// </summary>
        public WindowsMobileMSI() : base() {
            OdataType = "#microsoft.graph.windowsMobileMSI";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsMobileMSI CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsMobileMSI();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"commandLine", n => { CommandLine = n.GetStringValue(); } },
                {"ignoreVersionDetection", n => { IgnoreVersionDetection = n.GetBoolValue(); } },
                {"productCode", n => { ProductCode = n.GetStringValue(); } },
                {"productVersion", n => { ProductVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("commandLine", CommandLine);
            writer.WriteBoolValue("ignoreVersionDetection", IgnoreVersionDetection);
            writer.WriteStringValue("productCode", ProductCode);
            writer.WriteStringValue("productVersion", ProductVersion);
        }
    }
}