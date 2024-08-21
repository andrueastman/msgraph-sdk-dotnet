// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class DeviceLocalCredentialInfo : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The credentials of the device&apos;s local administrator account backed up to Azure Active Directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.DeviceLocalCredential>? Credentials
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DeviceLocalCredential>?>("credentials"); }
            set { BackingStore?.Set("credentials", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.DeviceLocalCredential> Credentials
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DeviceLocalCredential>>("credentials"); }
            set { BackingStore?.Set("credentials", value); }
        }
#endif
        /// <summary>Display name of the device that the local credentials are associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName
        {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName
        {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>When the local administrator account credential was backed up to Azure Active Directory.</summary>
        public DateTimeOffset? LastBackupDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastBackupDateTime"); }
            set { BackingStore?.Set("lastBackupDateTime", value); }
        }
        /// <summary>When the local administrator account credential will be refreshed and backed up to Azure Active Directory.</summary>
        public DateTimeOffset? RefreshDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("refreshDateTime"); }
            set { BackingStore?.Set("refreshDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceLocalCredentialInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.DeviceLocalCredentialInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.DeviceLocalCredentialInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "credentials", n => { Credentials = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.DeviceLocalCredential>(global::Microsoft.Graph.Models.DeviceLocalCredential.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deviceName", n => { DeviceName = n.GetStringValue(); } },
                { "lastBackupDateTime", n => { LastBackupDateTime = n.GetDateTimeOffsetValue(); } },
                { "refreshDateTime", n => { RefreshDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.DeviceLocalCredential>("credentials", Credentials);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteDateTimeOffsetValue("lastBackupDateTime", LastBackupDateTime);
            writer.WriteDateTimeOffsetValue("refreshDateTime", RefreshDateTime);
        }
    }
}
