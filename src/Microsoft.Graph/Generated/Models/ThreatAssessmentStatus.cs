using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum ThreatAssessmentStatus {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "completed")]
        Completed,
    }
}