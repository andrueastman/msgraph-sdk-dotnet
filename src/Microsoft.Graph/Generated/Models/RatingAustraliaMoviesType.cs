using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Movies rating labels in Australia</summary>
    public enum RatingAustraliaMoviesType {
        /// <summary>Default value, allow all movies content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any movies content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>The G classification is suitable for everyone</summary>
        [EnumMember(Value = "general")]
        General,
        /// <summary>The PG recommends viewers under 15 with guidance from parents or guardians</summary>
        [EnumMember(Value = "parentalGuidance")]
        ParentalGuidance,
        /// <summary>The M classification is not recommended for viewers under 15</summary>
        [EnumMember(Value = "mature")]
        Mature,
        /// <summary>The MA15+ classification is not suitable for viewers under 15</summary>
        [EnumMember(Value = "agesAbove15")]
        AgesAbove15,
        /// <summary>The R18+ classification is not suitable for viewers under 18</summary>
        [EnumMember(Value = "agesAbove18")]
        AgesAbove18,
    }
}