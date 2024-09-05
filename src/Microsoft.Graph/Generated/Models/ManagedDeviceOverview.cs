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
    /// Summary data for managed devices
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ManagedDeviceOverview : global::Microsoft.Graph.Models.Entity, IParsable
    {
        /// <summary>Distribution of Exchange Access State in Intune</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DeviceExchangeAccessStateSummary? DeviceExchangeAccessStateSummary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DeviceExchangeAccessStateSummary?>("deviceExchangeAccessStateSummary"); }
            set { BackingStore?.Set("deviceExchangeAccessStateSummary", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DeviceExchangeAccessStateSummary DeviceExchangeAccessStateSummary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DeviceExchangeAccessStateSummary>("deviceExchangeAccessStateSummary"); }
            set { BackingStore?.Set("deviceExchangeAccessStateSummary", value); }
        }
#endif
        /// <summary>Device operating system summary.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DeviceOperatingSystemSummary? DeviceOperatingSystemSummary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DeviceOperatingSystemSummary?>("deviceOperatingSystemSummary"); }
            set { BackingStore?.Set("deviceOperatingSystemSummary", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DeviceOperatingSystemSummary DeviceOperatingSystemSummary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DeviceOperatingSystemSummary>("deviceOperatingSystemSummary"); }
            set { BackingStore?.Set("deviceOperatingSystemSummary", value); }
        }
#endif
        /// <summary>The number of devices enrolled in both MDM and EAS</summary>
        public int? DualEnrolledDeviceCount
        {
            get { return BackingStore?.Get<int?>("dualEnrolledDeviceCount"); }
            set { BackingStore?.Set("dualEnrolledDeviceCount", value); }
        }
        /// <summary>Total enrolled device count. Does not include PC devices managed via Intune PC Agent</summary>
        public int? EnrolledDeviceCount
        {
            get { return BackingStore?.Get<int?>("enrolledDeviceCount"); }
            set { BackingStore?.Set("enrolledDeviceCount", value); }
        }
        /// <summary>The number of devices enrolled in MDM</summary>
        public int? MdmEnrolledCount
        {
            get { return BackingStore?.Get<int?>("mdmEnrolledCount"); }
            set { BackingStore?.Set("mdmEnrolledCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ManagedDeviceOverview"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ManagedDeviceOverview CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ManagedDeviceOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deviceExchangeAccessStateSummary", n => { DeviceExchangeAccessStateSummary = n.GetObjectValue<global::Microsoft.Graph.Models.DeviceExchangeAccessStateSummary>(global::Microsoft.Graph.Models.DeviceExchangeAccessStateSummary.CreateFromDiscriminatorValue); } },
                { "deviceOperatingSystemSummary", n => { DeviceOperatingSystemSummary = n.GetObjectValue<global::Microsoft.Graph.Models.DeviceOperatingSystemSummary>(global::Microsoft.Graph.Models.DeviceOperatingSystemSummary.CreateFromDiscriminatorValue); } },
                { "dualEnrolledDeviceCount", n => { DualEnrolledDeviceCount = n.GetIntValue(); } },
                { "enrolledDeviceCount", n => { EnrolledDeviceCount = n.GetIntValue(); } },
                { "mdmEnrolledCount", n => { MdmEnrolledCount = n.GetIntValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DeviceExchangeAccessStateSummary>("deviceExchangeAccessStateSummary", DeviceExchangeAccessStateSummary);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DeviceOperatingSystemSummary>("deviceOperatingSystemSummary", DeviceOperatingSystemSummary);
            writer.WriteIntValue("dualEnrolledDeviceCount", DualEnrolledDeviceCount);
            writer.WriteIntValue("enrolledDeviceCount", EnrolledDeviceCount);
            writer.WriteIntValue("mdmEnrolledCount", MdmEnrolledCount);
        }
    }
}
#pragma warning restore CS0618
