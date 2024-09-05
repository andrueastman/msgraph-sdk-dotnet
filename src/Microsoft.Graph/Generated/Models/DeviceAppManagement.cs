// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Singleton entity that acts as a container for all device app management functionality.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class DeviceAppManagement : global::Microsoft.Graph.Models.Entity, IParsable
    {
        /// <summary>Android managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AndroidManagedAppProtection>? AndroidManagedAppProtections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AndroidManagedAppProtection>?>("androidManagedAppProtections"); }
            set { BackingStore?.Set("androidManagedAppProtections", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AndroidManagedAppProtection> AndroidManagedAppProtections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AndroidManagedAppProtection>>("androidManagedAppProtections"); }
            set { BackingStore?.Set("androidManagedAppProtections", value); }
        }
#endif
        /// <summary>Default managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.DefaultManagedAppProtection>? DefaultManagedAppProtections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DefaultManagedAppProtection>?>("defaultManagedAppProtections"); }
            set { BackingStore?.Set("defaultManagedAppProtections", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.DefaultManagedAppProtection> DefaultManagedAppProtections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DefaultManagedAppProtection>>("defaultManagedAppProtections"); }
            set { BackingStore?.Set("defaultManagedAppProtections", value); }
        }
#endif
        /// <summary>iOS managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.IosManagedAppProtection>? IosManagedAppProtections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.IosManagedAppProtection>?>("iosManagedAppProtections"); }
            set { BackingStore?.Set("iosManagedAppProtections", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.IosManagedAppProtection> IosManagedAppProtections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.IosManagedAppProtection>>("iosManagedAppProtections"); }
            set { BackingStore?.Set("iosManagedAppProtections", value); }
        }
#endif
        /// <summary>Whether the account is enabled for syncing applications from the Microsoft Store for Business.</summary>
        public bool? IsEnabledForMicrosoftStoreForBusiness
        {
            get { return BackingStore?.Get<bool?>("isEnabledForMicrosoftStoreForBusiness"); }
            set { BackingStore?.Set("isEnabledForMicrosoftStoreForBusiness", value); }
        }
        /// <summary>Managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ManagedAppPolicy>? ManagedAppPolicies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ManagedAppPolicy>?>("managedAppPolicies"); }
            set { BackingStore?.Set("managedAppPolicies", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ManagedAppPolicy> ManagedAppPolicies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ManagedAppPolicy>>("managedAppPolicies"); }
            set { BackingStore?.Set("managedAppPolicies", value); }
        }
#endif
        /// <summary>The managed app registrations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ManagedAppRegistration>? ManagedAppRegistrations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ManagedAppRegistration>?>("managedAppRegistrations"); }
            set { BackingStore?.Set("managedAppRegistrations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ManagedAppRegistration> ManagedAppRegistrations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ManagedAppRegistration>>("managedAppRegistrations"); }
            set { BackingStore?.Set("managedAppRegistrations", value); }
        }
#endif
        /// <summary>The managed app statuses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ManagedAppStatus>? ManagedAppStatuses
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ManagedAppStatus>?>("managedAppStatuses"); }
            set { BackingStore?.Set("managedAppStatuses", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ManagedAppStatus> ManagedAppStatuses
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ManagedAppStatus>>("managedAppStatuses"); }
            set { BackingStore?.Set("managedAppStatuses", value); }
        }
#endif
        /// <summary>The Managed eBook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ManagedEBook>? ManagedEBooks
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ManagedEBook>?>("managedEBooks"); }
            set { BackingStore?.Set("managedEBooks", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ManagedEBook> ManagedEBooks
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ManagedEBook>>("managedEBooks"); }
            set { BackingStore?.Set("managedEBooks", value); }
        }
#endif
        /// <summary>Windows information protection for apps running on devices which are MDM enrolled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.MdmWindowsInformationProtectionPolicy>? MdmWindowsInformationProtectionPolicies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MdmWindowsInformationProtectionPolicy>?>("mdmWindowsInformationProtectionPolicies"); }
            set { BackingStore?.Set("mdmWindowsInformationProtectionPolicies", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.MdmWindowsInformationProtectionPolicy> MdmWindowsInformationProtectionPolicies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MdmWindowsInformationProtectionPolicy>>("mdmWindowsInformationProtectionPolicies"); }
            set { BackingStore?.Set("mdmWindowsInformationProtectionPolicies", value); }
        }
#endif
        /// <summary>The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is -&lt;country/regioncode2&gt;, where  is a lowercase two-letter code derived from ISO 639-1 and &lt;country/regioncode2&gt; is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MicrosoftStoreForBusinessLanguage
        {
            get { return BackingStore?.Get<string?>("microsoftStoreForBusinessLanguage"); }
            set { BackingStore?.Set("microsoftStoreForBusinessLanguage", value); }
        }
#nullable restore
#else
        public string MicrosoftStoreForBusinessLanguage
        {
            get { return BackingStore?.Get<string>("microsoftStoreForBusinessLanguage"); }
            set { BackingStore?.Set("microsoftStoreForBusinessLanguage", value); }
        }
#endif
        /// <summary>The last time an application sync from the Microsoft Store for Business was completed.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastCompletedApplicationSyncTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("microsoftStoreForBusinessLastCompletedApplicationSyncTime"); }
            set { BackingStore?.Set("microsoftStoreForBusinessLastCompletedApplicationSyncTime", value); }
        }
        /// <summary>The last time the apps from the Microsoft Store for Business were synced successfully for the account.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastSuccessfulSyncDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("microsoftStoreForBusinessLastSuccessfulSyncDateTime"); }
            set { BackingStore?.Set("microsoftStoreForBusinessLastSuccessfulSyncDateTime", value); }
        }
        /// <summary>The mobile app categories.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.MobileAppCategory>? MobileAppCategories
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MobileAppCategory>?>("mobileAppCategories"); }
            set { BackingStore?.Set("mobileAppCategories", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.MobileAppCategory> MobileAppCategories
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MobileAppCategory>>("mobileAppCategories"); }
            set { BackingStore?.Set("mobileAppCategories", value); }
        }
#endif
        /// <summary>The Managed Device Mobile Application Configurations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ManagedDeviceMobileAppConfiguration>? MobileAppConfigurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ManagedDeviceMobileAppConfiguration>?>("mobileAppConfigurations"); }
            set { BackingStore?.Set("mobileAppConfigurations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ManagedDeviceMobileAppConfiguration> MobileAppConfigurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ManagedDeviceMobileAppConfiguration>>("mobileAppConfigurations"); }
            set { BackingStore?.Set("mobileAppConfigurations", value); }
        }
#endif
        /// <summary>The mobile apps.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.MobileApp>? MobileApps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MobileApp>?>("mobileApps"); }
            set { BackingStore?.Set("mobileApps", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.MobileApp> MobileApps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MobileApp>>("mobileApps"); }
            set { BackingStore?.Set("mobileApps", value); }
        }
#endif
        /// <summary>Targeted managed app configurations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TargetedManagedAppConfiguration>? TargetedManagedAppConfigurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TargetedManagedAppConfiguration>?>("targetedManagedAppConfigurations"); }
            set { BackingStore?.Set("targetedManagedAppConfigurations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TargetedManagedAppConfiguration> TargetedManagedAppConfigurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TargetedManagedAppConfiguration>>("targetedManagedAppConfigurations"); }
            set { BackingStore?.Set("targetedManagedAppConfigurations", value); }
        }
#endif
        /// <summary>List of Vpp tokens for this organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.VppToken>? VppTokens
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.VppToken>?>("vppTokens"); }
            set { BackingStore?.Set("vppTokens", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.VppToken> VppTokens
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.VppToken>>("vppTokens"); }
            set { BackingStore?.Set("vppTokens", value); }
        }
#endif
        /// <summary>Windows information protection for apps running on devices which are not MDM enrolled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WindowsInformationProtectionPolicy>? WindowsInformationProtectionPolicies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WindowsInformationProtectionPolicy>?>("windowsInformationProtectionPolicies"); }
            set { BackingStore?.Set("windowsInformationProtectionPolicies", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WindowsInformationProtectionPolicy> WindowsInformationProtectionPolicies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WindowsInformationProtectionPolicy>>("windowsInformationProtectionPolicies"); }
            set { BackingStore?.Set("windowsInformationProtectionPolicies", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceAppManagement"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.DeviceAppManagement CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.DeviceAppManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "androidManagedAppProtections", n => { AndroidManagedAppProtections = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AndroidManagedAppProtection>(global::Microsoft.Graph.Models.AndroidManagedAppProtection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "defaultManagedAppProtections", n => { DefaultManagedAppProtections = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.DefaultManagedAppProtection>(global::Microsoft.Graph.Models.DefaultManagedAppProtection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "iosManagedAppProtections", n => { IosManagedAppProtections = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.IosManagedAppProtection>(global::Microsoft.Graph.Models.IosManagedAppProtection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isEnabledForMicrosoftStoreForBusiness", n => { IsEnabledForMicrosoftStoreForBusiness = n.GetBoolValue(); } },
                { "managedAppPolicies", n => { ManagedAppPolicies = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ManagedAppPolicy>(global::Microsoft.Graph.Models.ManagedAppPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedAppRegistrations", n => { ManagedAppRegistrations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ManagedAppRegistration>(global::Microsoft.Graph.Models.ManagedAppRegistration.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedAppStatuses", n => { ManagedAppStatuses = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ManagedAppStatus>(global::Microsoft.Graph.Models.ManagedAppStatus.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedEBooks", n => { ManagedEBooks = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ManagedEBook>(global::Microsoft.Graph.Models.ManagedEBook.CreateFromDiscriminatorValue)?.AsList(); } },
                { "mdmWindowsInformationProtectionPolicies", n => { MdmWindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.MdmWindowsInformationProtectionPolicy>(global::Microsoft.Graph.Models.MdmWindowsInformationProtectionPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "microsoftStoreForBusinessLanguage", n => { MicrosoftStoreForBusinessLanguage = n.GetStringValue(); } },
                { "microsoftStoreForBusinessLastCompletedApplicationSyncTime", n => { MicrosoftStoreForBusinessLastCompletedApplicationSyncTime = n.GetDateTimeOffsetValue(); } },
                { "microsoftStoreForBusinessLastSuccessfulSyncDateTime", n => { MicrosoftStoreForBusinessLastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                { "mobileAppCategories", n => { MobileAppCategories = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.MobileAppCategory>(global::Microsoft.Graph.Models.MobileAppCategory.CreateFromDiscriminatorValue)?.AsList(); } },
                { "mobileAppConfigurations", n => { MobileAppConfigurations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ManagedDeviceMobileAppConfiguration>(global::Microsoft.Graph.Models.ManagedDeviceMobileAppConfiguration.CreateFromDiscriminatorValue)?.AsList(); } },
                { "mobileApps", n => { MobileApps = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.MobileApp>(global::Microsoft.Graph.Models.MobileApp.CreateFromDiscriminatorValue)?.AsList(); } },
                { "targetedManagedAppConfigurations", n => { TargetedManagedAppConfigurations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TargetedManagedAppConfiguration>(global::Microsoft.Graph.Models.TargetedManagedAppConfiguration.CreateFromDiscriminatorValue)?.AsList(); } },
                { "vppTokens", n => { VppTokens = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.VppToken>(global::Microsoft.Graph.Models.VppToken.CreateFromDiscriminatorValue)?.AsList(); } },
                { "windowsInformationProtectionPolicies", n => { WindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WindowsInformationProtectionPolicy>(global::Microsoft.Graph.Models.WindowsInformationProtectionPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AndroidManagedAppProtection>("androidManagedAppProtections", AndroidManagedAppProtections);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.DefaultManagedAppProtection>("defaultManagedAppProtections", DefaultManagedAppProtections);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.IosManagedAppProtection>("iosManagedAppProtections", IosManagedAppProtections);
            writer.WriteBoolValue("isEnabledForMicrosoftStoreForBusiness", IsEnabledForMicrosoftStoreForBusiness);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ManagedAppPolicy>("managedAppPolicies", ManagedAppPolicies);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ManagedAppRegistration>("managedAppRegistrations", ManagedAppRegistrations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ManagedAppStatus>("managedAppStatuses", ManagedAppStatuses);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ManagedEBook>("managedEBooks", ManagedEBooks);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.MdmWindowsInformationProtectionPolicy>("mdmWindowsInformationProtectionPolicies", MdmWindowsInformationProtectionPolicies);
            writer.WriteStringValue("microsoftStoreForBusinessLanguage", MicrosoftStoreForBusinessLanguage);
            writer.WriteDateTimeOffsetValue("microsoftStoreForBusinessLastCompletedApplicationSyncTime", MicrosoftStoreForBusinessLastCompletedApplicationSyncTime);
            writer.WriteDateTimeOffsetValue("microsoftStoreForBusinessLastSuccessfulSyncDateTime", MicrosoftStoreForBusinessLastSuccessfulSyncDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.MobileAppCategory>("mobileAppCategories", MobileAppCategories);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ManagedDeviceMobileAppConfiguration>("mobileAppConfigurations", MobileAppConfigurations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.MobileApp>("mobileApps", MobileApps);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TargetedManagedAppConfiguration>("targetedManagedAppConfigurations", TargetedManagedAppConfigurations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.VppToken>("vppTokens", VppTokens);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WindowsInformationProtectionPolicy>("windowsInformationProtectionPolicies", WindowsInformationProtectionPolicies);
        }
    }
}
#pragma warning restore CS0618
