using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum ScheduleChangeRequestActor {
        [EnumMember(Value = "sender")]
        Sender,
        [EnumMember(Value = "recipient")]
        Recipient,
        [EnumMember(Value = "manager")]
        Manager,
        [EnumMember(Value = "system")]
        System,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}