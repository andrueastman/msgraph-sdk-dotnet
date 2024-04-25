// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    #pragma warning disable CS1591
    public enum UserExperienceAnalyticsHealthState
    #pragma warning restore CS1591
    {
        /// <summary>Indicates that the health state is unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates that the health state is insufficient data.</summary>
        [EnumMember(Value = "insufficientData")]
        InsufficientData,
        /// <summary>Indicates that the health state needs attention.</summary>
        [EnumMember(Value = "needsAttention")]
        NeedsAttention,
        /// <summary>Indicates that the health state is meeting goals.</summary>
        [EnumMember(Value = "meetingGoals")]
        MeetingGoals,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
