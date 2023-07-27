using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum DelegateMeetingMessageDeliveryOptions {
        [EnumMember(Value = "sendToDelegateAndInformationToPrincipal")]
        SendToDelegateAndInformationToPrincipal,
        [EnumMember(Value = "sendToDelegateAndPrincipal")]
        SendToDelegateAndPrincipal,
        [EnumMember(Value = "sendToDelegateOnly")]
        SendToDelegateOnly,
    }
}