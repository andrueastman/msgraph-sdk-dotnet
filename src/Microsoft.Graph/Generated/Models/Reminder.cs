// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class Reminder : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Identifies the version of the reminder. Every time the reminder is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangeKey
        {
            get { return BackingStore?.Get<string?>("changeKey"); }
            set { BackingStore?.Set("changeKey", value); }
        }
#nullable restore
#else
        public string ChangeKey
        {
            get { return BackingStore?.Get<string>("changeKey"); }
            set { BackingStore?.Set("changeKey", value); }
        }
#endif
        /// <summary>The date, time and time zone that the event ends.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DateTimeTimeZone? EventEndTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone?>("eventEndTime"); }
            set { BackingStore?.Set("eventEndTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DateTimeTimeZone EventEndTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone>("eventEndTime"); }
            set { BackingStore?.Set("eventEndTime", value); }
        }
#endif
        /// <summary>The unique ID of the event. Read only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventId
        {
            get { return BackingStore?.Get<string?>("eventId"); }
            set { BackingStore?.Set("eventId", value); }
        }
#nullable restore
#else
        public string EventId
        {
            get { return BackingStore?.Get<string>("eventId"); }
            set { BackingStore?.Set("eventId", value); }
        }
#endif
        /// <summary>The location of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Location? EventLocation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Location?>("eventLocation"); }
            set { BackingStore?.Set("eventLocation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Location EventLocation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Location>("eventLocation"); }
            set { BackingStore?.Set("eventLocation", value); }
        }
#endif
        /// <summary>The date, time, and time zone that the event starts.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DateTimeTimeZone? EventStartTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone?>("eventStartTime"); }
            set { BackingStore?.Set("eventStartTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DateTimeTimeZone EventStartTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone>("eventStartTime"); }
            set { BackingStore?.Set("eventStartTime", value); }
        }
#endif
        /// <summary>The text of the event&apos;s subject line.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventSubject
        {
            get { return BackingStore?.Get<string?>("eventSubject"); }
            set { BackingStore?.Set("eventSubject", value); }
        }
#nullable restore
#else
        public string EventSubject
        {
            get { return BackingStore?.Get<string>("eventSubject"); }
            set { BackingStore?.Set("eventSubject", value); }
        }
#endif
        /// <summary>The URL to open the event in Outlook on the web.The event opens in the browser if you&apos;re logged in to your mailbox via Outlook on the web. You&apos;re prompted to log in if you aren&apos;t already logged in with the browser.This URL can&apos;t be accessed from within an iFrame.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventWebLink
        {
            get { return BackingStore?.Get<string?>("eventWebLink"); }
            set { BackingStore?.Set("eventWebLink", value); }
        }
#nullable restore
#else
        public string EventWebLink
        {
            get { return BackingStore?.Get<string>("eventWebLink"); }
            set { BackingStore?.Set("eventWebLink", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The date, time, and time zone that the reminder is set to occur.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DateTimeTimeZone? ReminderFireTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone?>("reminderFireTime"); }
            set { BackingStore?.Set("reminderFireTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DateTimeTimeZone ReminderFireTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeTimeZone>("reminderFireTime"); }
            set { BackingStore?.Set("reminderFireTime", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Reminder"/> and sets the default values.
        /// </summary>
        public Reminder()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Reminder"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.Reminder CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Reminder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "changeKey", n => { ChangeKey = n.GetStringValue(); } },
                { "eventEndTime", n => { EventEndTime = n.GetObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>(global::Microsoft.Graph.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "eventId", n => { EventId = n.GetStringValue(); } },
                { "eventLocation", n => { EventLocation = n.GetObjectValue<global::Microsoft.Graph.Models.Location>(global::Microsoft.Graph.Models.Location.CreateFromDiscriminatorValue); } },
                { "eventStartTime", n => { EventStartTime = n.GetObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>(global::Microsoft.Graph.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "eventSubject", n => { EventSubject = n.GetStringValue(); } },
                { "eventWebLink", n => { EventWebLink = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "reminderFireTime", n => { ReminderFireTime = n.GetObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>(global::Microsoft.Graph.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("changeKey", ChangeKey);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>("eventEndTime", EventEndTime);
            writer.WriteStringValue("eventId", EventId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Location>("eventLocation", EventLocation);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>("eventStartTime", EventStartTime);
            writer.WriteStringValue("eventSubject", EventSubject);
            writer.WriteStringValue("eventWebLink", EventWebLink);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DateTimeTimeZone>("reminderFireTime", ReminderFireTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
