using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum InferenceClassificationType {
        [EnumMember(Value = "focused")]
        Focused,
        [EnumMember(Value = "other")]
        Other,
    }
}