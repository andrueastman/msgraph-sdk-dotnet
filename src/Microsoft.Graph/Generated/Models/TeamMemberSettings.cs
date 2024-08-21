// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class TeamMemberSettings : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>If set to true, members can add and remove apps.</summary>
        public bool? AllowAddRemoveApps
        {
            get { return BackingStore?.Get<bool?>("allowAddRemoveApps"); }
            set { BackingStore?.Set("allowAddRemoveApps", value); }
        }
        /// <summary>If set to true, members can add and update private channels.</summary>
        public bool? AllowCreatePrivateChannels
        {
            get { return BackingStore?.Get<bool?>("allowCreatePrivateChannels"); }
            set { BackingStore?.Set("allowCreatePrivateChannels", value); }
        }
        /// <summary>If set to true, members can add and update channels.</summary>
        public bool? AllowCreateUpdateChannels
        {
            get { return BackingStore?.Get<bool?>("allowCreateUpdateChannels"); }
            set { BackingStore?.Set("allowCreateUpdateChannels", value); }
        }
        /// <summary>If set to true, members can add, update, and remove connectors.</summary>
        public bool? AllowCreateUpdateRemoveConnectors
        {
            get { return BackingStore?.Get<bool?>("allowCreateUpdateRemoveConnectors"); }
            set { BackingStore?.Set("allowCreateUpdateRemoveConnectors", value); }
        }
        /// <summary>If set to true, members can add, update, and remove tabs.</summary>
        public bool? AllowCreateUpdateRemoveTabs
        {
            get { return BackingStore?.Get<bool?>("allowCreateUpdateRemoveTabs"); }
            set { BackingStore?.Set("allowCreateUpdateRemoveTabs", value); }
        }
        /// <summary>If set to true, members can delete channels.</summary>
        public bool? AllowDeleteChannels
        {
            get { return BackingStore?.Get<bool?>("allowDeleteChannels"); }
            set { BackingStore?.Set("allowDeleteChannels", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.TeamMemberSettings"/> and sets the default values.
        /// </summary>
        public TeamMemberSettings()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TeamMemberSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.TeamMemberSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.TeamMemberSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowAddRemoveApps", n => { AllowAddRemoveApps = n.GetBoolValue(); } },
                { "allowCreatePrivateChannels", n => { AllowCreatePrivateChannels = n.GetBoolValue(); } },
                { "allowCreateUpdateChannels", n => { AllowCreateUpdateChannels = n.GetBoolValue(); } },
                { "allowCreateUpdateRemoveConnectors", n => { AllowCreateUpdateRemoveConnectors = n.GetBoolValue(); } },
                { "allowCreateUpdateRemoveTabs", n => { AllowCreateUpdateRemoveTabs = n.GetBoolValue(); } },
                { "allowDeleteChannels", n => { AllowDeleteChannels = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowAddRemoveApps", AllowAddRemoveApps);
            writer.WriteBoolValue("allowCreatePrivateChannels", AllowCreatePrivateChannels);
            writer.WriteBoolValue("allowCreateUpdateChannels", AllowCreateUpdateChannels);
            writer.WriteBoolValue("allowCreateUpdateRemoveConnectors", AllowCreateUpdateRemoveConnectors);
            writer.WriteBoolValue("allowCreateUpdateRemoveTabs", AllowCreateUpdateRemoveTabs);
            writer.WriteBoolValue("allowDeleteChannels", AllowDeleteChannels);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
