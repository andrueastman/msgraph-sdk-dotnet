using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum ConditionalAccessExternalTenantsMembershipKind {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "enumerated")]
        Enumerated,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}