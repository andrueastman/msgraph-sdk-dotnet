using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum ServiceHealthOrigin {
        [EnumMember(Value = "microsoft")]
        Microsoft,
        [EnumMember(Value = "thirdParty")]
        ThirdParty,
        [EnumMember(Value = "customer")]
        Customer,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}