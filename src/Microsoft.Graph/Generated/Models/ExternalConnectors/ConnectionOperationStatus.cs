using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.ExternalConnectors {
    public enum ConnectionOperationStatus {
        [EnumMember(Value = "unspecified")]
        Unspecified,
        [EnumMember(Value = "inprogress")]
        Inprogress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}