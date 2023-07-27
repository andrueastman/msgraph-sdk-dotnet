using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Policy for Windows information protection to configure detailed management settings
    /// </summary>
    public class WindowsInformationProtection : ManagedAppPolicy, IParsable {
        /// <summary>Navigation property to list of security groups targeted for policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TargetedManagedAppPolicyAssignment>? Assignments {
            get { return BackingStore?.Get<List<TargetedManagedAppPolicyAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<TargetedManagedAppPolicyAssignment> Assignments {
            get { return BackingStore?.Get<List<TargetedManagedAppPolicyAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>Specifies whether to allow Azure RMS encryption for WIP</summary>
        public bool? AzureRightsManagementServicesAllowed {
            get { return BackingStore?.Get<bool?>("azureRightsManagementServicesAllowed"); }
            set { BackingStore?.Set("azureRightsManagementServicesAllowed", value); }
        }
        /// <summary>Specifies a recovery certificate that can be used for data recovery of encrypted files. This is the same as the data recovery agent(DRA) certificate for encrypting file system(EFS)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsInformationProtectionDataRecoveryCertificate? DataRecoveryCertificate {
            get { return BackingStore?.Get<WindowsInformationProtectionDataRecoveryCertificate?>("dataRecoveryCertificate"); }
            set { BackingStore?.Set("dataRecoveryCertificate", value); }
        }
#nullable restore
#else
        public WindowsInformationProtectionDataRecoveryCertificate DataRecoveryCertificate {
            get { return BackingStore?.Get<WindowsInformationProtectionDataRecoveryCertificate>("dataRecoveryCertificate"); }
            set { BackingStore?.Set("dataRecoveryCertificate", value); }
        }
#endif
        /// <summary>Possible values for WIP Protection enforcement levels</summary>
        public WindowsInformationProtectionEnforcementLevel? EnforcementLevel {
            get { return BackingStore?.Get<WindowsInformationProtectionEnforcementLevel?>("enforcementLevel"); }
            set { BackingStore?.Set("enforcementLevel", value); }
        }
        /// <summary>Primary enterprise domain</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnterpriseDomain {
            get { return BackingStore?.Get<string?>("enterpriseDomain"); }
            set { BackingStore?.Set("enterpriseDomain", value); }
        }
#nullable restore
#else
        public string EnterpriseDomain {
            get { return BackingStore?.Get<string>("enterpriseDomain"); }
            set { BackingStore?.Set("enterpriseDomain", value); }
        }
#endif
        /// <summary>This is the comma-separated list of internal proxy servers. For example, &apos;157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59&apos;. These proxies have been configured by the admin to connect to specific resources on the Internet. They are considered to be enterprise network locations. The proxies are only leveraged in configuring the EnterpriseProxiedDomains policy to force traffic to the matched domains through these proxies</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionResourceCollection>? EnterpriseInternalProxyServers {
            get { return BackingStore?.Get<List<WindowsInformationProtectionResourceCollection>?>("enterpriseInternalProxyServers"); }
            set { BackingStore?.Set("enterpriseInternalProxyServers", value); }
        }
#nullable restore
#else
        public List<WindowsInformationProtectionResourceCollection> EnterpriseInternalProxyServers {
            get { return BackingStore?.Get<List<WindowsInformationProtectionResourceCollection>>("enterpriseInternalProxyServers"); }
            set { BackingStore?.Set("enterpriseInternalProxyServers", value); }
        }
#endif
        /// <summary>Sets the enterprise IP ranges that define the computers in the enterprise network. Data that comes from those computers will be considered part of the enterprise and protected. These locations will be considered a safe destination for enterprise data to be shared to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionIPRangeCollection>? EnterpriseIPRanges {
            get { return BackingStore?.Get<List<WindowsInformationProtectionIPRangeCollection>?>("enterpriseIPRanges"); }
            set { BackingStore?.Set("enterpriseIPRanges", value); }
        }
#nullable restore
#else
        public List<WindowsInformationProtectionIPRangeCollection> EnterpriseIPRanges {
            get { return BackingStore?.Get<List<WindowsInformationProtectionIPRangeCollection>>("enterpriseIPRanges"); }
            set { BackingStore?.Set("enterpriseIPRanges", value); }
        }
#endif
        /// <summary>Boolean value that tells the client to accept the configured list and not to use heuristics to attempt to find other subnets. Default is false</summary>
        public bool? EnterpriseIPRangesAreAuthoritative {
            get { return BackingStore?.Get<bool?>("enterpriseIPRangesAreAuthoritative"); }
            set { BackingStore?.Set("enterpriseIPRangesAreAuthoritative", value); }
        }
        /// <summary>This is the list of domains that comprise the boundaries of the enterprise. Data from one of these domains that is sent to a device will be considered enterprise data and protected These locations will be considered a safe destination for enterprise data to be shared to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionResourceCollection>? EnterpriseNetworkDomainNames {
            get { return BackingStore?.Get<List<WindowsInformationProtectionResourceCollection>?>("enterpriseNetworkDomainNames"); }
            set { BackingStore?.Set("enterpriseNetworkDomainNames", value); }
        }
#nullable restore
#else
        public List<WindowsInformationProtectionResourceCollection> EnterpriseNetworkDomainNames {
            get { return BackingStore?.Get<List<WindowsInformationProtectionResourceCollection>>("enterpriseNetworkDomainNames"); }
            set { BackingStore?.Set("enterpriseNetworkDomainNames", value); }
        }
#endif
        /// <summary>List of enterprise domains to be protected</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionResourceCollection>? EnterpriseProtectedDomainNames {
            get { return BackingStore?.Get<List<WindowsInformationProtectionResourceCollection>?>("enterpriseProtectedDomainNames"); }
            set { BackingStore?.Set("enterpriseProtectedDomainNames", value); }
        }
#nullable restore
#else
        public List<WindowsInformationProtectionResourceCollection> EnterpriseProtectedDomainNames {
            get { return BackingStore?.Get<List<WindowsInformationProtectionResourceCollection>>("enterpriseProtectedDomainNames"); }
            set { BackingStore?.Set("enterpriseProtectedDomainNames", value); }
        }
#endif
        /// <summary>Contains a list of Enterprise resource domains hosted in the cloud that need to be protected. Connections to these resources are considered enterprise data. If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80). A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionProxiedDomainCollection>? EnterpriseProxiedDomains {
            get { return BackingStore?.Get<List<WindowsInformationProtectionProxiedDomainCollection>?>("enterpriseProxiedDomains"); }
            set { BackingStore?.Set("enterpriseProxiedDomains", value); }
        }
#nullable restore
#else
        public List<WindowsInformationProtectionProxiedDomainCollection> EnterpriseProxiedDomains {
            get { return BackingStore?.Get<List<WindowsInformationProtectionProxiedDomainCollection>>("enterpriseProxiedDomains"); }
            set { BackingStore?.Set("enterpriseProxiedDomains", value); }
        }
#endif
        /// <summary>This is a list of proxy servers. Any server not on this list is considered non-enterprise</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionResourceCollection>? EnterpriseProxyServers {
            get { return BackingStore?.Get<List<WindowsInformationProtectionResourceCollection>?>("enterpriseProxyServers"); }
            set { BackingStore?.Set("enterpriseProxyServers", value); }
        }
#nullable restore
#else
        public List<WindowsInformationProtectionResourceCollection> EnterpriseProxyServers {
            get { return BackingStore?.Get<List<WindowsInformationProtectionResourceCollection>>("enterpriseProxyServers"); }
            set { BackingStore?.Set("enterpriseProxyServers", value); }
        }
#endif
        /// <summary>Boolean value that tells the client to accept the configured list of proxies and not try to detect other work proxies. Default is false</summary>
        public bool? EnterpriseProxyServersAreAuthoritative {
            get { return BackingStore?.Get<bool?>("enterpriseProxyServersAreAuthoritative"); }
            set { BackingStore?.Set("enterpriseProxyServersAreAuthoritative", value); }
        }
        /// <summary>Another way to input exempt apps through xml files</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionAppLockerFile>? ExemptAppLockerFiles {
            get { return BackingStore?.Get<List<WindowsInformationProtectionAppLockerFile>?>("exemptAppLockerFiles"); }
            set { BackingStore?.Set("exemptAppLockerFiles", value); }
        }
#nullable restore
#else
        public List<WindowsInformationProtectionAppLockerFile> ExemptAppLockerFiles {
            get { return BackingStore?.Get<List<WindowsInformationProtectionAppLockerFile>>("exemptAppLockerFiles"); }
            set { BackingStore?.Set("exemptAppLockerFiles", value); }
        }
#endif
        /// <summary>Exempt applications can also access enterprise data, but the data handled by those applications are not protected. This is because some critical enterprise applications may have compatibility problems with encrypted data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionApp>? ExemptApps {
            get { return BackingStore?.Get<List<WindowsInformationProtectionApp>?>("exemptApps"); }
            set { BackingStore?.Set("exemptApps", value); }
        }
#nullable restore
#else
        public List<WindowsInformationProtectionApp> ExemptApps {
            get { return BackingStore?.Get<List<WindowsInformationProtectionApp>>("exemptApps"); }
            set { BackingStore?.Set("exemptApps", value); }
        }
#endif
        /// <summary>Determines whether overlays are added to icons for WIP protected files in Explorer and enterprise only app tiles in the Start menu. Starting in Windows 10, version 1703 this setting also configures the visibility of the WIP icon in the title bar of a WIP-protected app</summary>
        public bool? IconsVisible {
            get { return BackingStore?.Get<bool?>("iconsVisible"); }
            set { BackingStore?.Set("iconsVisible", value); }
        }
        /// <summary>This switch is for the Windows Search Indexer, to allow or disallow indexing of items</summary>
        public bool? IndexingEncryptedStoresOrItemsBlocked {
            get { return BackingStore?.Get<bool?>("indexingEncryptedStoresOrItemsBlocked"); }
            set { BackingStore?.Set("indexingEncryptedStoresOrItemsBlocked", value); }
        }
        /// <summary>Indicates if the policy is deployed to any inclusion groups or not.</summary>
        public bool? IsAssigned {
            get { return BackingStore?.Get<bool?>("isAssigned"); }
            set { BackingStore?.Set("isAssigned", value); }
        }
        /// <summary>List of domain names that can used for work or personal resource</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionResourceCollection>? NeutralDomainResources {
            get { return BackingStore?.Get<List<WindowsInformationProtectionResourceCollection>?>("neutralDomainResources"); }
            set { BackingStore?.Set("neutralDomainResources", value); }
        }
#nullable restore
#else
        public List<WindowsInformationProtectionResourceCollection> NeutralDomainResources {
            get { return BackingStore?.Get<List<WindowsInformationProtectionResourceCollection>>("neutralDomainResources"); }
            set { BackingStore?.Set("neutralDomainResources", value); }
        }
#endif
        /// <summary>Another way to input protected apps through xml files</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionAppLockerFile>? ProtectedAppLockerFiles {
            get { return BackingStore?.Get<List<WindowsInformationProtectionAppLockerFile>?>("protectedAppLockerFiles"); }
            set { BackingStore?.Set("protectedAppLockerFiles", value); }
        }
#nullable restore
#else
        public List<WindowsInformationProtectionAppLockerFile> ProtectedAppLockerFiles {
            get { return BackingStore?.Get<List<WindowsInformationProtectionAppLockerFile>>("protectedAppLockerFiles"); }
            set { BackingStore?.Set("protectedAppLockerFiles", value); }
        }
#endif
        /// <summary>Protected applications can access enterprise data and the data handled by those applications are protected with encryption</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionApp>? ProtectedApps {
            get { return BackingStore?.Get<List<WindowsInformationProtectionApp>?>("protectedApps"); }
            set { BackingStore?.Set("protectedApps", value); }
        }
#nullable restore
#else
        public List<WindowsInformationProtectionApp> ProtectedApps {
            get { return BackingStore?.Get<List<WindowsInformationProtectionApp>>("protectedApps"); }
            set { BackingStore?.Set("protectedApps", value); }
        }
#endif
        /// <summary>Specifies whether the protection under lock feature (also known as encrypt under pin) should be configured</summary>
        public bool? ProtectionUnderLockConfigRequired {
            get { return BackingStore?.Get<bool?>("protectionUnderLockConfigRequired"); }
            set { BackingStore?.Set("protectionUnderLockConfigRequired", value); }
        }
        /// <summary>This policy controls whether to revoke the WIP keys when a device unenrolls from the management service. If set to 1 (Don&apos;t revoke keys), the keys will not be revoked and the user will continue to have access to protected files after unenrollment. If the keys are not revoked, there will be no revoked file cleanup subsequently.</summary>
        public bool? RevokeOnUnenrollDisabled {
            get { return BackingStore?.Get<bool?>("revokeOnUnenrollDisabled"); }
            set { BackingStore?.Set("revokeOnUnenrollDisabled", value); }
        }
        /// <summary>TemplateID GUID to use for RMS encryption. The RMS template allows the IT admin to configure the details about who has access to RMS-protected file and how long they have access</summary>
        public Guid? RightsManagementServicesTemplateId {
            get { return BackingStore?.Get<Guid?>("rightsManagementServicesTemplateId"); }
            set { BackingStore?.Set("rightsManagementServicesTemplateId", value); }
        }
        /// <summary>Specifies a list of file extensions, so that files with these extensions are encrypted when copying from an SMB share within the corporate boundary</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionResourceCollection>? SmbAutoEncryptedFileExtensions {
            get { return BackingStore?.Get<List<WindowsInformationProtectionResourceCollection>?>("smbAutoEncryptedFileExtensions"); }
            set { BackingStore?.Set("smbAutoEncryptedFileExtensions", value); }
        }
#nullable restore
#else
        public List<WindowsInformationProtectionResourceCollection> SmbAutoEncryptedFileExtensions {
            get { return BackingStore?.Get<List<WindowsInformationProtectionResourceCollection>>("smbAutoEncryptedFileExtensions"); }
            set { BackingStore?.Set("smbAutoEncryptedFileExtensions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new windowsInformationProtection and sets the default values.
        /// </summary>
        public WindowsInformationProtection() : base() {
            OdataType = "#microsoft.graph.windowsInformationProtection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsInformationProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.mdmWindowsInformationProtectionPolicy" => new MdmWindowsInformationProtectionPolicy(),
                "#microsoft.graph.windowsInformationProtectionPolicy" => new WindowsInformationProtectionPolicy(),
                _ => new WindowsInformationProtection(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>(TargetedManagedAppPolicyAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"azureRightsManagementServicesAllowed", n => { AzureRightsManagementServicesAllowed = n.GetBoolValue(); } },
                {"dataRecoveryCertificate", n => { DataRecoveryCertificate = n.GetObjectValue<WindowsInformationProtectionDataRecoveryCertificate>(WindowsInformationProtectionDataRecoveryCertificate.CreateFromDiscriminatorValue); } },
                {"enforcementLevel", n => { EnforcementLevel = n.GetEnumValue<WindowsInformationProtectionEnforcementLevel>(); } },
                {"enterpriseDomain", n => { EnterpriseDomain = n.GetStringValue(); } },
                {"enterpriseInternalProxyServers", n => { EnterpriseInternalProxyServers = n.GetCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>(WindowsInformationProtectionResourceCollection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"enterpriseIPRanges", n => { EnterpriseIPRanges = n.GetCollectionOfObjectValues<WindowsInformationProtectionIPRangeCollection>(WindowsInformationProtectionIPRangeCollection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"enterpriseIPRangesAreAuthoritative", n => { EnterpriseIPRangesAreAuthoritative = n.GetBoolValue(); } },
                {"enterpriseNetworkDomainNames", n => { EnterpriseNetworkDomainNames = n.GetCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>(WindowsInformationProtectionResourceCollection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"enterpriseProtectedDomainNames", n => { EnterpriseProtectedDomainNames = n.GetCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>(WindowsInformationProtectionResourceCollection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"enterpriseProxiedDomains", n => { EnterpriseProxiedDomains = n.GetCollectionOfObjectValues<WindowsInformationProtectionProxiedDomainCollection>(WindowsInformationProtectionProxiedDomainCollection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"enterpriseProxyServers", n => { EnterpriseProxyServers = n.GetCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>(WindowsInformationProtectionResourceCollection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"enterpriseProxyServersAreAuthoritative", n => { EnterpriseProxyServersAreAuthoritative = n.GetBoolValue(); } },
                {"exemptAppLockerFiles", n => { ExemptAppLockerFiles = n.GetCollectionOfObjectValues<WindowsInformationProtectionAppLockerFile>(WindowsInformationProtectionAppLockerFile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"exemptApps", n => { ExemptApps = n.GetCollectionOfObjectValues<WindowsInformationProtectionApp>(WindowsInformationProtectionApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"iconsVisible", n => { IconsVisible = n.GetBoolValue(); } },
                {"indexingEncryptedStoresOrItemsBlocked", n => { IndexingEncryptedStoresOrItemsBlocked = n.GetBoolValue(); } },
                {"isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
                {"neutralDomainResources", n => { NeutralDomainResources = n.GetCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>(WindowsInformationProtectionResourceCollection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"protectedAppLockerFiles", n => { ProtectedAppLockerFiles = n.GetCollectionOfObjectValues<WindowsInformationProtectionAppLockerFile>(WindowsInformationProtectionAppLockerFile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"protectedApps", n => { ProtectedApps = n.GetCollectionOfObjectValues<WindowsInformationProtectionApp>(WindowsInformationProtectionApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"protectionUnderLockConfigRequired", n => { ProtectionUnderLockConfigRequired = n.GetBoolValue(); } },
                {"revokeOnUnenrollDisabled", n => { RevokeOnUnenrollDisabled = n.GetBoolValue(); } },
                {"rightsManagementServicesTemplateId", n => { RightsManagementServicesTemplateId = n.GetGuidValue(); } },
                {"smbAutoEncryptedFileExtensions", n => { SmbAutoEncryptedFileExtensions = n.GetCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>(WindowsInformationProtectionResourceCollection.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>("assignments", Assignments);
            writer.WriteBoolValue("azureRightsManagementServicesAllowed", AzureRightsManagementServicesAllowed);
            writer.WriteObjectValue<WindowsInformationProtectionDataRecoveryCertificate>("dataRecoveryCertificate", DataRecoveryCertificate);
            writer.WriteEnumValue<WindowsInformationProtectionEnforcementLevel>("enforcementLevel", EnforcementLevel);
            writer.WriteStringValue("enterpriseDomain", EnterpriseDomain);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>("enterpriseInternalProxyServers", EnterpriseInternalProxyServers);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionIPRangeCollection>("enterpriseIPRanges", EnterpriseIPRanges);
            writer.WriteBoolValue("enterpriseIPRangesAreAuthoritative", EnterpriseIPRangesAreAuthoritative);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>("enterpriseNetworkDomainNames", EnterpriseNetworkDomainNames);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>("enterpriseProtectedDomainNames", EnterpriseProtectedDomainNames);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionProxiedDomainCollection>("enterpriseProxiedDomains", EnterpriseProxiedDomains);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>("enterpriseProxyServers", EnterpriseProxyServers);
            writer.WriteBoolValue("enterpriseProxyServersAreAuthoritative", EnterpriseProxyServersAreAuthoritative);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionAppLockerFile>("exemptAppLockerFiles", ExemptAppLockerFiles);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionApp>("exemptApps", ExemptApps);
            writer.WriteBoolValue("iconsVisible", IconsVisible);
            writer.WriteBoolValue("indexingEncryptedStoresOrItemsBlocked", IndexingEncryptedStoresOrItemsBlocked);
            writer.WriteBoolValue("isAssigned", IsAssigned);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>("neutralDomainResources", NeutralDomainResources);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionAppLockerFile>("protectedAppLockerFiles", ProtectedAppLockerFiles);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionApp>("protectedApps", ProtectedApps);
            writer.WriteBoolValue("protectionUnderLockConfigRequired", ProtectionUnderLockConfigRequired);
            writer.WriteBoolValue("revokeOnUnenrollDisabled", RevokeOnUnenrollDisabled);
            writer.WriteGuidValue("rightsManagementServicesTemplateId", RightsManagementServicesTemplateId);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionResourceCollection>("smbAutoEncryptedFileExtensions", SmbAutoEncryptedFileExtensions);
        }
    }
}