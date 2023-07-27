using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.Security {
    public enum AlertClassification {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "falsePositive")]
        FalsePositive,
        [EnumMember(Value = "truePositive")]
        TruePositive,
        [EnumMember(Value = "informationalExpectedActivity")]
        InformationalExpectedActivity,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}