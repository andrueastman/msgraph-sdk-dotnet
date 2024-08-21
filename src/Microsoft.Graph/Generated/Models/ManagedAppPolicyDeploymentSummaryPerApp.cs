// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Represents policy deployment summary per app.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ManagedAppPolicyDeploymentSummaryPerApp : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Number of users the policy is applied.</summary>
        public int? ConfigurationAppliedUserCount
        {
            get { return BackingStore?.Get<int?>("configurationAppliedUserCount"); }
            set { BackingStore?.Set("configurationAppliedUserCount", value); }
        }
        /// <summary>Deployment of an app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.MobileAppIdentifier? MobileAppIdentifier
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.MobileAppIdentifier?>("mobileAppIdentifier"); }
            set { BackingStore?.Set("mobileAppIdentifier", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.MobileAppIdentifier MobileAppIdentifier
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.MobileAppIdentifier>("mobileAppIdentifier"); }
            set { BackingStore?.Set("mobileAppIdentifier", value); }
        }
#endif
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
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.ManagedAppPolicyDeploymentSummaryPerApp"/> and sets the default values.
        /// </summary>
        public ManagedAppPolicyDeploymentSummaryPerApp()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ManagedAppPolicyDeploymentSummaryPerApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.ManagedAppPolicyDeploymentSummaryPerApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ManagedAppPolicyDeploymentSummaryPerApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "configurationAppliedUserCount", n => { ConfigurationAppliedUserCount = n.GetIntValue(); } },
                { "mobileAppIdentifier", n => { MobileAppIdentifier = n.GetObjectValue<global::Microsoft.Graph.Models.MobileAppIdentifier>(global::Microsoft.Graph.Models.MobileAppIdentifier.CreateFromDiscriminatorValue); } },
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
            writer.WriteIntValue("configurationAppliedUserCount", ConfigurationAppliedUserCount);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.MobileAppIdentifier>("mobileAppIdentifier", MobileAppIdentifier);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
