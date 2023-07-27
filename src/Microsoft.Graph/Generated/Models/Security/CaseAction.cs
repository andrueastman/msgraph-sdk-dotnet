using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.Security {
    public enum CaseAction {
        [EnumMember(Value = "contentExport")]
        ContentExport,
        [EnumMember(Value = "applyTags")]
        ApplyTags,
        [EnumMember(Value = "convertToPdf")]
        ConvertToPdf,
        [EnumMember(Value = "index")]
        Index,
        [EnumMember(Value = "estimateStatistics")]
        EstimateStatistics,
        [EnumMember(Value = "addToReviewSet")]
        AddToReviewSet,
        [EnumMember(Value = "holdUpdate")]
        HoldUpdate,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "purgeData")]
        PurgeData,
    }
}