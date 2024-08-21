// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// An abstract base class containing properties for all managed mobile line of business apps.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ManagedMobileLobApp : global::Microsoft.Graph.Models.ManagedApp, IParsable
    {
        /// <summary>The internal committed content version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommittedContentVersion
        {
            get { return BackingStore?.Get<string?>("committedContentVersion"); }
            set { BackingStore?.Set("committedContentVersion", value); }
        }
#nullable restore
#else
        public string CommittedContentVersion
        {
            get { return BackingStore?.Get<string>("committedContentVersion"); }
            set { BackingStore?.Set("committedContentVersion", value); }
        }
#endif
        /// <summary>The list of content versions for this app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.MobileAppContent>? ContentVersions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MobileAppContent>?>("contentVersions"); }
            set { BackingStore?.Set("contentVersions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.MobileAppContent> ContentVersions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MobileAppContent>>("contentVersions"); }
            set { BackingStore?.Set("contentVersions", value); }
        }
#endif
        /// <summary>The name of the main Lob application file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName
        {
            get { return BackingStore?.Get<string?>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
#nullable restore
#else
        public string FileName
        {
            get { return BackingStore?.Get<string>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
#endif
        /// <summary>The total size, including all uploaded files.</summary>
        public long? Size
        {
            get { return BackingStore?.Get<long?>("size"); }
            set { BackingStore?.Set("size", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.ManagedMobileLobApp"/> and sets the default values.
        /// </summary>
        public ManagedMobileLobApp() : base()
        {
            OdataType = "#microsoft.graph.managedMobileLobApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ManagedMobileLobApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ManagedMobileLobApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.managedAndroidLobApp" => new global::Microsoft.Graph.Models.ManagedAndroidLobApp(),
                "#microsoft.graph.managedIOSLobApp" => new global::Microsoft.Graph.Models.ManagedIOSLobApp(),
                _ => new global::Microsoft.Graph.Models.ManagedMobileLobApp(),
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
                { "committedContentVersion", n => { CommittedContentVersion = n.GetStringValue(); } },
                { "contentVersions", n => { ContentVersions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.MobileAppContent>(global::Microsoft.Graph.Models.MobileAppContent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "fileName", n => { FileName = n.GetStringValue(); } },
                { "size", n => { Size = n.GetLongValue(); } },
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
            writer.WriteStringValue("committedContentVersion", CommittedContentVersion);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.MobileAppContent>("contentVersions", ContentVersions);
            writer.WriteStringValue("fileName", FileName);
        }
    }
}
