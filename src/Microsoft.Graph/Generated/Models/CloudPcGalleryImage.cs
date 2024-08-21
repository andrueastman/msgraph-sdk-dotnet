// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class CloudPcGalleryImage : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The display name of this gallery image. For example, Windows 11 Enterprise + Microsoft 365 Apps 22H2. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The date when the status of the image becomes supportedWithWarning. Users can still provision new Cloud PCs if the current time is later than endDate and earlier than expirationDate. For example, assume the endDate of a gallery image is 2023-9-14 and expirationDate is 2024-3-14, users are able to provision new Cloud PCs if today is 2023-10-01. Read-only.</summary>
        public Date? EndDate
        {
            get { return BackingStore?.Get<Date?>("endDate"); }
            set { BackingStore?.Set("endDate", value); }
        }
        /// <summary>The date when the image is no longer available. Users are unable to provision new Cloud PCs if the current time is later than expirationDate. The value is usually endDate plus six months. For example, if the startDate is 2025-10-14, the expirationDate is usually 2026-04-14. Read-only.</summary>
        public Date? ExpirationDate
        {
            get { return BackingStore?.Get<Date?>("expirationDate"); }
            set { BackingStore?.Set("expirationDate", value); }
        }
        /// <summary>The offer name of this gallery image that is passed to Azure Resource Manager (ARM) to retrieve the image resource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OfferName
        {
            get { return BackingStore?.Get<string?>("offerName"); }
            set { BackingStore?.Set("offerName", value); }
        }
#nullable restore
#else
        public string OfferName
        {
            get { return BackingStore?.Get<string>("offerName"); }
            set { BackingStore?.Set("offerName", value); }
        }
#endif
        /// <summary>The publisher name of this gallery image that is passed to Azure Resource Manager (ARM) to retrieve the image resource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublisherName
        {
            get { return BackingStore?.Get<string?>("publisherName"); }
            set { BackingStore?.Set("publisherName", value); }
        }
#nullable restore
#else
        public string PublisherName
        {
            get { return BackingStore?.Get<string>("publisherName"); }
            set { BackingStore?.Set("publisherName", value); }
        }
#endif
        /// <summary>Indicates the size of this image in gigabytes. For example, 64. Read-only.</summary>
        public int? SizeInGB
        {
            get { return BackingStore?.Get<int?>("sizeInGB"); }
            set { BackingStore?.Set("sizeInGB", value); }
        }
        /// <summary>The SKU name of this image that is passed to Azure Resource Manager (ARM) to retrieve the image resource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SkuName
        {
            get { return BackingStore?.Get<string?>("skuName"); }
            set { BackingStore?.Set("skuName", value); }
        }
#nullable restore
#else
        public string SkuName
        {
            get { return BackingStore?.Get<string>("skuName"); }
            set { BackingStore?.Set("skuName", value); }
        }
#endif
        /// <summary>The date when the Cloud PC image is available for provisioning new Cloud PCs. For example, 2022-09-20. Read-only.</summary>
        public Date? StartDate
        {
            get { return BackingStore?.Get<Date?>("startDate"); }
            set { BackingStore?.Set("startDate", value); }
        }
        /// <summary>The status of the gallery image on the Cloud PC. Possible values are: supported, supportedWithWarning, notSupported, unknownFutureValue. The default value is supported. Read-only.</summary>
        public global::Microsoft.Graph.Models.CloudPcGalleryImageStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CloudPcGalleryImageStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.CloudPcGalleryImage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.CloudPcGalleryImage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.CloudPcGalleryImage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "endDate", n => { EndDate = n.GetDateValue(); } },
                { "expirationDate", n => { ExpirationDate = n.GetDateValue(); } },
                { "offerName", n => { OfferName = n.GetStringValue(); } },
                { "publisherName", n => { PublisherName = n.GetStringValue(); } },
                { "sizeInGB", n => { SizeInGB = n.GetIntValue(); } },
                { "skuName", n => { SkuName = n.GetStringValue(); } },
                { "startDate", n => { StartDate = n.GetDateValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Models.CloudPcGalleryImageStatus>(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateValue("endDate", EndDate);
            writer.WriteDateValue("expirationDate", ExpirationDate);
            writer.WriteStringValue("offerName", OfferName);
            writer.WriteStringValue("publisherName", PublisherName);
            writer.WriteIntValue("sizeInGB", SizeInGB);
            writer.WriteStringValue("skuName", SkuName);
            writer.WriteDateValue("startDate", StartDate);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.CloudPcGalleryImageStatus>("status", Status);
        }
    }
}
