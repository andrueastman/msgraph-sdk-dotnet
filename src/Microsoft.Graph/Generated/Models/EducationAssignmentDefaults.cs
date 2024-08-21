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
    public partial class EducationAssignmentDefaults : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Class-level default behavior for handling students who are added after the assignment is published. Possible values are: none, assignIfOpen.</summary>
        public global::Microsoft.Graph.Models.EducationAddedStudentAction? AddedStudentAction
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationAddedStudentAction?>("addedStudentAction"); }
            set { BackingStore?.Set("addedStudentAction", value); }
        }
        /// <summary>Optional field to control adding assignments to students&apos; and teachers&apos; calendars when the assignment is published. The possible values are: none, studentsAndPublisher, studentsAndTeamOwners, unknownFutureValue, and studentsOnly. You must use the Prefer: include-unknown-enum-members request header to get the following value in this evolvable enum: studentsOnly. The default value is none.</summary>
        public global::Microsoft.Graph.Models.EducationAddToCalendarOptions? AddToCalendarAction
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationAddToCalendarOptions?>("addToCalendarAction"); }
            set { BackingStore?.Set("addToCalendarAction", value); }
        }
        /// <summary>Class-level default value for due time field. Default value is 23:59:00.</summary>
        public Time? DueTime
        {
            get { return BackingStore?.Get<Time?>("dueTime"); }
            set { BackingStore?.Set("dueTime", value); }
        }
        /// <summary>Default Teams channel to which notifications are sent. Default value is null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationChannelUrl
        {
            get { return BackingStore?.Get<string?>("notificationChannelUrl"); }
            set { BackingStore?.Set("notificationChannelUrl", value); }
        }
#nullable restore
#else
        public string NotificationChannelUrl
        {
            get { return BackingStore?.Get<string>("notificationChannelUrl"); }
            set { BackingStore?.Set("notificationChannelUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.EducationAssignmentDefaults"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.EducationAssignmentDefaults CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.EducationAssignmentDefaults();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "addToCalendarAction", n => { AddToCalendarAction = n.GetEnumValue<global::Microsoft.Graph.Models.EducationAddToCalendarOptions>(); } },
                { "addedStudentAction", n => { AddedStudentAction = n.GetEnumValue<global::Microsoft.Graph.Models.EducationAddedStudentAction>(); } },
                { "dueTime", n => { DueTime = n.GetTimeValue(); } },
                { "notificationChannelUrl", n => { NotificationChannelUrl = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.EducationAddedStudentAction>("addedStudentAction", AddedStudentAction);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.EducationAddToCalendarOptions>("addToCalendarAction", AddToCalendarAction);
            writer.WriteTimeValue("dueTime", DueTime);
            writer.WriteStringValue("notificationChannelUrl", NotificationChannelUrl);
        }
    }
}
