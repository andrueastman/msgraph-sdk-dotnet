// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Contains properties and inherited properties for iOS Volume-Purchased Program (VPP) Apps.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class IosVppApp : global::Microsoft.Graph.Models.MobileApp, IParsable
    {
        /// <summary>The applicable iOS Device Type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IosDeviceType? ApplicableDeviceType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IosDeviceType?>("applicableDeviceType"); }
            set { BackingStore?.Set("applicableDeviceType", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IosDeviceType ApplicableDeviceType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IosDeviceType>("applicableDeviceType"); }
            set { BackingStore?.Set("applicableDeviceType", value); }
        }
#endif
        /// <summary>The store URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppStoreUrl
        {
            get { return BackingStore?.Get<string?>("appStoreUrl"); }
            set { BackingStore?.Set("appStoreUrl", value); }
        }
#nullable restore
#else
        public string AppStoreUrl
        {
            get { return BackingStore?.Get<string>("appStoreUrl"); }
            set { BackingStore?.Set("appStoreUrl", value); }
        }
#endif
        /// <summary>The Identity Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BundleId
        {
            get { return BackingStore?.Get<string?>("bundleId"); }
            set { BackingStore?.Set("bundleId", value); }
        }
#nullable restore
#else
        public string BundleId
        {
            get { return BackingStore?.Get<string>("bundleId"); }
            set { BackingStore?.Set("bundleId", value); }
        }
#endif
        /// <summary>The supported License Type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.VppLicensingType? LicensingType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.VppLicensingType?>("licensingType"); }
            set { BackingStore?.Set("licensingType", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.VppLicensingType LicensingType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.VppLicensingType>("licensingType"); }
            set { BackingStore?.Set("licensingType", value); }
        }
#endif
        /// <summary>The VPP application release date and time.</summary>
        public DateTimeOffset? ReleaseDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("releaseDateTime"); }
            set { BackingStore?.Set("releaseDateTime", value); }
        }
        /// <summary>The total number of VPP licenses.</summary>
        public int? TotalLicenseCount
        {
            get { return BackingStore?.Get<int?>("totalLicenseCount"); }
            set { BackingStore?.Set("totalLicenseCount", value); }
        }
        /// <summary>The number of VPP licenses in use.</summary>
        public int? UsedLicenseCount
        {
            get { return BackingStore?.Get<int?>("usedLicenseCount"); }
            set { BackingStore?.Set("usedLicenseCount", value); }
        }
        /// <summary>Possible types of an Apple Volume Purchase Program token.</summary>
        public global::Microsoft.Graph.Models.VppTokenAccountType? VppTokenAccountType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.VppTokenAccountType?>("vppTokenAccountType"); }
            set { BackingStore?.Set("vppTokenAccountType", value); }
        }
        /// <summary>The Apple Id associated with the given Apple Volume Purchase Program Token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VppTokenAppleId
        {
            get { return BackingStore?.Get<string?>("vppTokenAppleId"); }
            set { BackingStore?.Set("vppTokenAppleId", value); }
        }
#nullable restore
#else
        public string VppTokenAppleId
        {
            get { return BackingStore?.Get<string>("vppTokenAppleId"); }
            set { BackingStore?.Set("vppTokenAppleId", value); }
        }
#endif
        /// <summary>The organization associated with the Apple Volume Purchase Program Token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VppTokenOrganizationName
        {
            get { return BackingStore?.Get<string?>("vppTokenOrganizationName"); }
            set { BackingStore?.Set("vppTokenOrganizationName", value); }
        }
#nullable restore
#else
        public string VppTokenOrganizationName
        {
            get { return BackingStore?.Get<string>("vppTokenOrganizationName"); }
            set { BackingStore?.Set("vppTokenOrganizationName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.IosVppApp"/> and sets the default values.
        /// </summary>
        public IosVppApp() : base()
        {
            OdataType = "#microsoft.graph.iosVppApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IosVppApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.IosVppApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.IosVppApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appStoreUrl", n => { AppStoreUrl = n.GetStringValue(); } },
                { "applicableDeviceType", n => { ApplicableDeviceType = n.GetObjectValue<global::Microsoft.Graph.Models.IosDeviceType>(global::Microsoft.Graph.Models.IosDeviceType.CreateFromDiscriminatorValue); } },
                { "bundleId", n => { BundleId = n.GetStringValue(); } },
                { "licensingType", n => { LicensingType = n.GetObjectValue<global::Microsoft.Graph.Models.VppLicensingType>(global::Microsoft.Graph.Models.VppLicensingType.CreateFromDiscriminatorValue); } },
                { "releaseDateTime", n => { ReleaseDateTime = n.GetDateTimeOffsetValue(); } },
                { "totalLicenseCount", n => { TotalLicenseCount = n.GetIntValue(); } },
                { "usedLicenseCount", n => { UsedLicenseCount = n.GetIntValue(); } },
                { "vppTokenAccountType", n => { VppTokenAccountType = n.GetEnumValue<global::Microsoft.Graph.Models.VppTokenAccountType>(); } },
                { "vppTokenAppleId", n => { VppTokenAppleId = n.GetStringValue(); } },
                { "vppTokenOrganizationName", n => { VppTokenOrganizationName = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IosDeviceType>("applicableDeviceType", ApplicableDeviceType);
            writer.WriteStringValue("appStoreUrl", AppStoreUrl);
            writer.WriteStringValue("bundleId", BundleId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.VppLicensingType>("licensingType", LicensingType);
            writer.WriteDateTimeOffsetValue("releaseDateTime", ReleaseDateTime);
            writer.WriteIntValue("totalLicenseCount", TotalLicenseCount);
            writer.WriteIntValue("usedLicenseCount", UsedLicenseCount);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.VppTokenAccountType>("vppTokenAccountType", VppTokenAccountType);
            writer.WriteStringValue("vppTokenAppleId", VppTokenAppleId);
            writer.WriteStringValue("vppTokenOrganizationName", VppTokenOrganizationName);
        }
    }
}
