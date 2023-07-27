using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum EducationAddToCalendarOptions {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "studentsAndPublisher")]
        StudentsAndPublisher,
        [EnumMember(Value = "studentsAndTeamOwners")]
        StudentsAndTeamOwners,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "studentsOnly")]
        StudentsOnly,
    }
}