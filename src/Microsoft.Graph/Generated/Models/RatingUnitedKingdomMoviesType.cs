using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Movies rating labels in United Kingdom</summary>
    public enum RatingUnitedKingdomMoviesType {
        /// <summary>Default value, allow all movies content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any movies content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>The U classification is suitable for all ages</summary>
        [EnumMember(Value = "general")]
        General,
        /// <summary>The UC classification is suitable for pre-school children, an old rating label</summary>
        [EnumMember(Value = "universalChildren")]
        UniversalChildren,
        /// <summary>The PG classification is suitable for mature</summary>
        [EnumMember(Value = "parentalGuidance")]
        ParentalGuidance,
        /// <summary>12, video release suitable for 12 years and over</summary>
        [EnumMember(Value = "agesAbove12Video")]
        AgesAbove12Video,
        /// <summary>12A, cinema release suitable for 12 years and over</summary>
        [EnumMember(Value = "agesAbove12Cinema")]
        AgesAbove12Cinema,
        /// <summary>15, suitable only for 15 years and older</summary>
        [EnumMember(Value = "agesAbove15")]
        AgesAbove15,
        /// <summary>Suitable only for adults</summary>
        [EnumMember(Value = "adults")]
        Adults,
    }
}