using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum PostType {
        [EnumMember(Value = "regular")]
        Regular,
        [EnumMember(Value = "quick")]
        Quick,
        [EnumMember(Value = "strategic")]
        Strategic,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}