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
    public partial class ServiceUpdateMessage : global::Microsoft.Graph.Models.ServiceAnnouncementBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The expected deadline of the action for the message.</summary>
        public DateTimeOffset? ActionRequiredByDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("actionRequiredByDateTime"); }
            set { BackingStore?.Set("actionRequiredByDateTime", value); }
        }
        /// <summary>A collection of serviceAnnouncementAttachments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ServiceAnnouncementAttachment>? Attachments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ServiceAnnouncementAttachment>?>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ServiceAnnouncementAttachment> Attachments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ServiceAnnouncementAttachment>>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#endif
        /// <summary>The zip file that contains all attachments for a message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? AttachmentsArchive
        {
            get { return BackingStore?.Get<byte[]?>("attachmentsArchive"); }
            set { BackingStore?.Set("attachmentsArchive", value); }
        }
#nullable restore
#else
        public byte[] AttachmentsArchive
        {
            get { return BackingStore?.Get<byte[]>("attachmentsArchive"); }
            set { BackingStore?.Set("attachmentsArchive", value); }
        }
#endif
        /// <summary>The body property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ItemBody? Body
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ItemBody?>("body"); }
            set { BackingStore?.Set("body", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ItemBody Body
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ItemBody>("body"); }
            set { BackingStore?.Set("body", value); }
        }
#endif
        /// <summary>The category property</summary>
        public global::Microsoft.Graph.Models.ServiceUpdateCategory? Category
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ServiceUpdateCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>Indicates whether the message has any attachment.</summary>
        public bool? HasAttachments
        {
            get { return BackingStore?.Get<bool?>("hasAttachments"); }
            set { BackingStore?.Set("hasAttachments", value); }
        }
        /// <summary>Indicates whether the message describes a major update for the service.</summary>
        public bool? IsMajorChange
        {
            get { return BackingStore?.Get<bool?>("isMajorChange"); }
            set { BackingStore?.Set("isMajorChange", value); }
        }
        /// <summary>The affected services by the service message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Services
        {
            get { return BackingStore?.Get<List<string>?>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#nullable restore
#else
        public List<string> Services
        {
            get { return BackingStore?.Get<List<string>>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#endif
        /// <summary>The severity property</summary>
        public global::Microsoft.Graph.Models.ServiceUpdateSeverity? Severity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ServiceUpdateSeverity?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>A collection of tags for the service message. Tags are provided by the service team/support team who post the message to tell whether this message contains privacy data, or whether this message is for a service new feature update, and so on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags
        {
            get { return BackingStore?.Get<List<string>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<string> Tags
        {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>Represents user viewpoints data of the service message. This data includes message status such as whether the user has archived, read, or marked the message as favorite. This property is null when accessed with application permissions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ServiceUpdateMessageViewpoint? ViewPoint
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ServiceUpdateMessageViewpoint?>("viewPoint"); }
            set { BackingStore?.Set("viewPoint", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ServiceUpdateMessageViewpoint ViewPoint
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ServiceUpdateMessageViewpoint>("viewPoint"); }
            set { BackingStore?.Set("viewPoint", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.ServiceUpdateMessage"/> and sets the default values.
        /// </summary>
        public ServiceUpdateMessage() : base()
        {
            OdataType = "#microsoft.graph.serviceUpdateMessage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ServiceUpdateMessage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ServiceUpdateMessage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ServiceUpdateMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actionRequiredByDateTime", n => { ActionRequiredByDateTime = n.GetDateTimeOffsetValue(); } },
                { "attachments", n => { Attachments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ServiceAnnouncementAttachment>(global::Microsoft.Graph.Models.ServiceAnnouncementAttachment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "attachmentsArchive", n => { AttachmentsArchive = n.GetByteArrayValue(); } },
                { "body", n => { Body = n.GetObjectValue<global::Microsoft.Graph.Models.ItemBody>(global::Microsoft.Graph.Models.ItemBody.CreateFromDiscriminatorValue); } },
                { "category", n => { Category = n.GetEnumValue<global::Microsoft.Graph.Models.ServiceUpdateCategory>(); } },
                { "hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                { "isMajorChange", n => { IsMajorChange = n.GetBoolValue(); } },
                { "services", n => { Services = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "severity", n => { Severity = n.GetEnumValue<global::Microsoft.Graph.Models.ServiceUpdateSeverity>(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "viewPoint", n => { ViewPoint = n.GetObjectValue<global::Microsoft.Graph.Models.ServiceUpdateMessageViewpoint>(global::Microsoft.Graph.Models.ServiceUpdateMessageViewpoint.CreateFromDiscriminatorValue); } },
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
            writer.WriteDateTimeOffsetValue("actionRequiredByDateTime", ActionRequiredByDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ServiceAnnouncementAttachment>("attachments", Attachments);
            writer.WriteByteArrayValue("attachmentsArchive", AttachmentsArchive);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ItemBody>("body", Body);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ServiceUpdateCategory>("category", Category);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteBoolValue("isMajorChange", IsMajorChange);
            writer.WriteCollectionOfPrimitiveValues<string>("services", Services);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ServiceUpdateSeverity>("severity", Severity);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ServiceUpdateMessageViewpoint>("viewPoint", ViewPoint);
        }
    }
}
