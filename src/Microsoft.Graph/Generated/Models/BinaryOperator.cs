using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum BinaryOperator {
        [EnumMember(Value = "or")]
        Or,
        [EnumMember(Value = "and")]
        And,
    }
}