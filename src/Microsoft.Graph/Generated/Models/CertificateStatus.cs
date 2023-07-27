using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum CertificateStatus {
        [EnumMember(Value = "notProvisioned")]
        NotProvisioned,
        [EnumMember(Value = "provisioned")]
        Provisioned,
    }
}