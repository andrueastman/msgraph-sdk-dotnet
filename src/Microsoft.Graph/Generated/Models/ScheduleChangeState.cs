using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum ScheduleChangeState {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "declined")]
        Declined,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}