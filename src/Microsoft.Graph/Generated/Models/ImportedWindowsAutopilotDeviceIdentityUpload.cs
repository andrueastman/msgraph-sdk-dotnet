// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Import windows autopilot devices using upload.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ImportedWindowsAutopilotDeviceIdentityUpload : global::Microsoft.Graph.Models.Entity, IParsable
    {
        /// <summary>DateTime when the entity is created.</summary>
        public DateTimeOffset? CreatedDateTimeUtc
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTimeUtc"); }
            set { BackingStore?.Set("createdDateTimeUtc", value); }
        }
        /// <summary>Collection of all Autopilot devices as a part of this upload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ImportedWindowsAutopilotDeviceIdentity>? DeviceIdentities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ImportedWindowsAutopilotDeviceIdentity>?>("deviceIdentities"); }
            set { BackingStore?.Set("deviceIdentities", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ImportedWindowsAutopilotDeviceIdentity> DeviceIdentities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ImportedWindowsAutopilotDeviceIdentity>>("deviceIdentities"); }
            set { BackingStore?.Set("deviceIdentities", value); }
        }
#endif
        /// <summary>The status property</summary>
        public global::Microsoft.Graph.Models.ImportedWindowsAutopilotDeviceIdentityUploadStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ImportedWindowsAutopilotDeviceIdentityUploadStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ImportedWindowsAutopilotDeviceIdentityUpload"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ImportedWindowsAutopilotDeviceIdentityUpload CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ImportedWindowsAutopilotDeviceIdentityUpload();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdDateTimeUtc", n => { CreatedDateTimeUtc = n.GetDateTimeOffsetValue(); } },
                { "deviceIdentities", n => { DeviceIdentities = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ImportedWindowsAutopilotDeviceIdentity>(global::Microsoft.Graph.Models.ImportedWindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue)?.AsList(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Models.ImportedWindowsAutopilotDeviceIdentityUploadStatus>(); } },
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
            writer.WriteDateTimeOffsetValue("createdDateTimeUtc", CreatedDateTimeUtc);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ImportedWindowsAutopilotDeviceIdentity>("deviceIdentities", DeviceIdentities);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ImportedWindowsAutopilotDeviceIdentityUploadStatus>("status", Status);
        }
    }
}
