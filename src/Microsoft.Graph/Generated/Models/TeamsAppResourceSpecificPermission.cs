using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class TeamsAppResourceSpecificPermission : IAdditionalDataHolder, IBackedModel, IParsable {
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
        /// <summary>The permissionType property</summary>
        public TeamsAppResourceSpecificPermissionType? PermissionType {
            get { return BackingStore?.Get<TeamsAppResourceSpecificPermissionType?>("permissionType"); }
            set { BackingStore?.Set("permissionType", value); }
        }
        /// <summary>The permissionValue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PermissionValue {
            get { return BackingStore?.Get<string?>("permissionValue"); }
            set { BackingStore?.Set("permissionValue", value); }
        }
#nullable restore
#else
        public string PermissionValue {
            get { return BackingStore?.Get<string>("permissionValue"); }
            set { BackingStore?.Set("permissionValue", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new teamsAppResourceSpecificPermission and sets the default values.
        /// </summary>
        public TeamsAppResourceSpecificPermission() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamsAppResourceSpecificPermission CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsAppResourceSpecificPermission();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"permissionType", n => { PermissionType = n.GetEnumValue<TeamsAppResourceSpecificPermissionType>(); } },
                {"permissionValue", n => { PermissionValue = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<TeamsAppResourceSpecificPermissionType>("permissionType", PermissionType);
            writer.WriteStringValue("permissionValue", PermissionValue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
