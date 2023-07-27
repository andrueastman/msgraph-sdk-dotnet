using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// An item describing notification setting.
    /// </summary>
    public class IosNotificationSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Notification Settings Alert Type.</summary>
        public IosNotificationAlertType? AlertType {
            get { return BackingStore?.Get<IosNotificationAlertType?>("alertType"); }
            set { BackingStore?.Set("alertType", value); }
        }
        /// <summary>Application name to be associated with the bundleID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppName {
            get { return BackingStore?.Get<string?>("appName"); }
            set { BackingStore?.Set("appName", value); }
        }
#nullable restore
#else
        public string AppName {
            get { return BackingStore?.Get<string>("appName"); }
            set { BackingStore?.Set("appName", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether badges are allowed for this app.</summary>
        public bool? BadgesEnabled {
            get { return BackingStore?.Get<bool?>("badgesEnabled"); }
            set { BackingStore?.Set("badgesEnabled", value); }
        }
        /// <summary>Bundle id of app to which to apply these notification settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BundleID {
            get { return BackingStore?.Get<string?>("bundleID"); }
            set { BackingStore?.Set("bundleID", value); }
        }
#nullable restore
#else
        public string BundleID {
            get { return BackingStore?.Get<string>("bundleID"); }
            set { BackingStore?.Set("bundleID", value); }
        }
#endif
        /// <summary>Indicates whether notifications are allowed for this app.</summary>
        public bool? Enabled {
            get { return BackingStore?.Get<bool?>("enabled"); }
            set { BackingStore?.Set("enabled", value); }
        }
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
        /// <summary>Publisher to be associated with the bundleID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher {
            get { return BackingStore?.Get<string?>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#nullable restore
#else
        public string Publisher {
            get { return BackingStore?.Get<string>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#endif
        /// <summary>Indicates whether notifications can be shown in notification center.</summary>
        public bool? ShowInNotificationCenter {
            get { return BackingStore?.Get<bool?>("showInNotificationCenter"); }
            set { BackingStore?.Set("showInNotificationCenter", value); }
        }
        /// <summary>Indicates whether notifications can be shown on the lock screen.</summary>
        public bool? ShowOnLockScreen {
            get { return BackingStore?.Get<bool?>("showOnLockScreen"); }
            set { BackingStore?.Set("showOnLockScreen", value); }
        }
        /// <summary>Indicates whether sounds are allowed for this app.</summary>
        public bool? SoundsEnabled {
            get { return BackingStore?.Get<bool?>("soundsEnabled"); }
            set { BackingStore?.Set("soundsEnabled", value); }
        }
        /// <summary>
        /// Instantiates a new iosNotificationSettings and sets the default values.
        /// </summary>
        public IosNotificationSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IosNotificationSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosNotificationSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alertType", n => { AlertType = n.GetEnumValue<IosNotificationAlertType>(); } },
                {"appName", n => { AppName = n.GetStringValue(); } },
                {"badgesEnabled", n => { BadgesEnabled = n.GetBoolValue(); } },
                {"bundleID", n => { BundleID = n.GetStringValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"showInNotificationCenter", n => { ShowInNotificationCenter = n.GetBoolValue(); } },
                {"showOnLockScreen", n => { ShowOnLockScreen = n.GetBoolValue(); } },
                {"soundsEnabled", n => { SoundsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<IosNotificationAlertType>("alertType", AlertType);
            writer.WriteStringValue("appName", AppName);
            writer.WriteBoolValue("badgesEnabled", BadgesEnabled);
            writer.WriteStringValue("bundleID", BundleID);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteBoolValue("showInNotificationCenter", ShowInNotificationCenter);
            writer.WriteBoolValue("showOnLockScreen", ShowOnLockScreen);
            writer.WriteBoolValue("soundsEnabled", SoundsEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}