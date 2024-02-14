// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class SasTokenEvidence : AlertEvidence, IParsable {
        /// <summary>The allowedIpAddresses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AllowedIpAddresses {
            get { return BackingStore?.Get<string?>("allowedIpAddresses"); }
            set { BackingStore?.Set("allowedIpAddresses", value); }
        }
#nullable restore
#else
        public string AllowedIpAddresses {
            get { return BackingStore?.Get<string>("allowedIpAddresses"); }
            set { BackingStore?.Set("allowedIpAddresses", value); }
        }
#endif
        /// <summary>The allowedResourceTypes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedResourceTypes {
            get { return BackingStore?.Get<List<string>?>("allowedResourceTypes"); }
            set { BackingStore?.Set("allowedResourceTypes", value); }
        }
#nullable restore
#else
        public List<string> AllowedResourceTypes {
            get { return BackingStore?.Get<List<string>>("allowedResourceTypes"); }
            set { BackingStore?.Set("allowedResourceTypes", value); }
        }
#endif
        /// <summary>The allowedServices property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedServices {
            get { return BackingStore?.Get<List<string>?>("allowedServices"); }
            set { BackingStore?.Set("allowedServices", value); }
        }
#nullable restore
#else
        public List<string> AllowedServices {
            get { return BackingStore?.Get<List<string>>("allowedServices"); }
            set { BackingStore?.Set("allowedServices", value); }
        }
#endif
        /// <summary>The expiryDateTime property</summary>
        public DateTimeOffset? ExpiryDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expiryDateTime"); }
            set { BackingStore?.Set("expiryDateTime", value); }
        }
        /// <summary>The permissions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Permissions {
            get { return BackingStore?.Get<List<string>?>("permissions"); }
            set { BackingStore?.Set("permissions", value); }
        }
#nullable restore
#else
        public List<string> Permissions {
            get { return BackingStore?.Get<List<string>>("permissions"); }
            set { BackingStore?.Set("permissions", value); }
        }
#endif
        /// <summary>The protocol property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Protocol {
            get { return BackingStore?.Get<string?>("protocol"); }
            set { BackingStore?.Set("protocol", value); }
        }
#nullable restore
#else
        public string Protocol {
            get { return BackingStore?.Get<string>("protocol"); }
            set { BackingStore?.Set("protocol", value); }
        }
#endif
        /// <summary>The signatureHash property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignatureHash {
            get { return BackingStore?.Get<string?>("signatureHash"); }
            set { BackingStore?.Set("signatureHash", value); }
        }
#nullable restore
#else
        public string SignatureHash {
            get { return BackingStore?.Get<string>("signatureHash"); }
            set { BackingStore?.Set("signatureHash", value); }
        }
#endif
        /// <summary>The signedWith property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignedWith {
            get { return BackingStore?.Get<string?>("signedWith"); }
            set { BackingStore?.Set("signedWith", value); }
        }
#nullable restore
#else
        public string SignedWith {
            get { return BackingStore?.Get<string>("signedWith"); }
            set { BackingStore?.Set("signedWith", value); }
        }
#endif
        /// <summary>The startDateTime property</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The storageResource property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AzureResourceEvidence? StorageResource {
            get { return BackingStore?.Get<AzureResourceEvidence?>("storageResource"); }
            set { BackingStore?.Set("storageResource", value); }
        }
#nullable restore
#else
        public AzureResourceEvidence StorageResource {
            get { return BackingStore?.Get<AzureResourceEvidence>("storageResource"); }
            set { BackingStore?.Set("storageResource", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SasTokenEvidence"/> and sets the default values.
        /// </summary>
        public SasTokenEvidence() : base() {
            OdataType = "#microsoft.graph.security.sasTokenEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SasTokenEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SasTokenEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SasTokenEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedIpAddresses", n => { AllowedIpAddresses = n.GetStringValue(); } },
                {"allowedResourceTypes", n => { AllowedResourceTypes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"allowedServices", n => { AllowedServices = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"expiryDateTime", n => { ExpiryDateTime = n.GetDateTimeOffsetValue(); } },
                {"permissions", n => { Permissions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"protocol", n => { Protocol = n.GetStringValue(); } },
                {"signatureHash", n => { SignatureHash = n.GetStringValue(); } },
                {"signedWith", n => { SignedWith = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"storageResource", n => { StorageResource = n.GetObjectValue<AzureResourceEvidence>(AzureResourceEvidence.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("allowedIpAddresses", AllowedIpAddresses);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedResourceTypes", AllowedResourceTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedServices", AllowedServices);
            writer.WriteDateTimeOffsetValue("expiryDateTime", ExpiryDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("permissions", Permissions);
            writer.WriteStringValue("protocol", Protocol);
            writer.WriteStringValue("signatureHash", SignatureHash);
            writer.WriteStringValue("signedWith", SignedWith);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteObjectValue<AzureResourceEvidence>("storageResource", StorageResource);
        }
    }
}
