using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ServiceHostedMediaConfig : MediaConfig, IParsable {
        /// <summary>The list of media to pre-fetch.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MediaInfo>? PreFetchMedia {
            get { return BackingStore?.Get<List<MediaInfo>?>("preFetchMedia"); }
            set { BackingStore?.Set("preFetchMedia", value); }
        }
#nullable restore
#else
        public List<MediaInfo> PreFetchMedia {
            get { return BackingStore?.Get<List<MediaInfo>>("preFetchMedia"); }
            set { BackingStore?.Set("preFetchMedia", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new serviceHostedMediaConfig and sets the default values.
        /// </summary>
        public ServiceHostedMediaConfig() : base() {
            OdataType = "#microsoft.graph.serviceHostedMediaConfig";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ServiceHostedMediaConfig CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServiceHostedMediaConfig();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"preFetchMedia", n => { PreFetchMedia = n.GetCollectionOfObjectValues<MediaInfo>(MediaInfo.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MediaInfo>("preFetchMedia", PreFetchMedia);
        }
    }
}