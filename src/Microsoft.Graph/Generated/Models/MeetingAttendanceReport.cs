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
    public partial class MeetingAttendanceReport : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of attendance records of an attendance report. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AttendanceRecord>? AttendanceRecords
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AttendanceRecord>?>("attendanceRecords"); }
            set { BackingStore?.Set("attendanceRecords", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AttendanceRecord> AttendanceRecords
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AttendanceRecord>>("attendanceRecords"); }
            set { BackingStore?.Set("attendanceRecords", value); }
        }
#endif
        /// <summary>UTC time when the meeting ended. Read-only.</summary>
        public DateTimeOffset? MeetingEndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("meetingEndDateTime"); }
            set { BackingStore?.Set("meetingEndDateTime", value); }
        }
        /// <summary>UTC time when the meeting started. Read-only.</summary>
        public DateTimeOffset? MeetingStartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("meetingStartDateTime"); }
            set { BackingStore?.Set("meetingStartDateTime", value); }
        }
        /// <summary>Total number of participants. Read-only.</summary>
        public int? TotalParticipantCount
        {
            get { return BackingStore?.Get<int?>("totalParticipantCount"); }
            set { BackingStore?.Set("totalParticipantCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.MeetingAttendanceReport"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.MeetingAttendanceReport CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.MeetingAttendanceReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "attendanceRecords", n => { AttendanceRecords = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AttendanceRecord>(global::Microsoft.Graph.Models.AttendanceRecord.CreateFromDiscriminatorValue)?.AsList(); } },
                { "meetingEndDateTime", n => { MeetingEndDateTime = n.GetDateTimeOffsetValue(); } },
                { "meetingStartDateTime", n => { MeetingStartDateTime = n.GetDateTimeOffsetValue(); } },
                { "totalParticipantCount", n => { TotalParticipantCount = n.GetIntValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AttendanceRecord>("attendanceRecords", AttendanceRecords);
            writer.WriteDateTimeOffsetValue("meetingEndDateTime", MeetingEndDateTime);
            writer.WriteDateTimeOffsetValue("meetingStartDateTime", MeetingStartDateTime);
            writer.WriteIntValue("totalParticipantCount", TotalParticipantCount);
        }
    }
}
