using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum AttendeeType {
        [EnumMember(Value = "required")]
        Required,
        [EnumMember(Value = "optional")]
        Optional,
        [EnumMember(Value = "resource")]
        Resource,
    }
}