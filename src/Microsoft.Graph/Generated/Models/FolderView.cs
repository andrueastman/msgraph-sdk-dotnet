using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class FolderView : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The method by which the folder should be sorted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SortBy {
            get { return BackingStore?.Get<string?>("sortBy"); }
            set { BackingStore?.Set("sortBy", value); }
        }
#nullable restore
#else
        public string SortBy {
            get { return BackingStore?.Get<string>("sortBy"); }
            set { BackingStore?.Set("sortBy", value); }
        }
#endif
        /// <summary>If true, indicates that items should be sorted in descending order. Otherwise, items should be sorted ascending.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SortOrder {
            get { return BackingStore?.Get<string?>("sortOrder"); }
            set { BackingStore?.Set("sortOrder", value); }
        }
#nullable restore
#else
        public string SortOrder {
            get { return BackingStore?.Get<string>("sortOrder"); }
            set { BackingStore?.Set("sortOrder", value); }
        }
#endif
        /// <summary>The type of view that should be used to represent the folder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ViewType {
            get { return BackingStore?.Get<string?>("viewType"); }
            set { BackingStore?.Set("viewType", value); }
        }
#nullable restore
#else
        public string ViewType {
            get { return BackingStore?.Get<string>("viewType"); }
            set { BackingStore?.Set("viewType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new folderView and sets the default values.
        /// </summary>
        public FolderView() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FolderView CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FolderView();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sortBy", n => { SortBy = n.GetStringValue(); } },
                {"sortOrder", n => { SortOrder = n.GetStringValue(); } },
                {"viewType", n => { ViewType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sortBy", SortBy);
            writer.WriteStringValue("sortOrder", SortOrder);
            writer.WriteStringValue("viewType", ViewType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}