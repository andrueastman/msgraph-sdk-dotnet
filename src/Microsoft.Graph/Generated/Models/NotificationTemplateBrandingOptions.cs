// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Branding Options for the Message Template. Branding is defined in the Intune Admin Console.</summary>
    [Flags]
    public enum NotificationTemplateBrandingOptions {
        /// <summary>Indicates that no branding options are set in the message template.</summary>
        [EnumMember(Value = "none")]
        None = 1,
        /// <summary>Indicates to include company logo in the message template.</summary>
        [EnumMember(Value = "includeCompanyLogo")]
        IncludeCompanyLogo = 2,
        /// <summary>Indicates to include company name in the message template.</summary>
        [EnumMember(Value = "includeCompanyName")]
        IncludeCompanyName = 4,
        /// <summary>Indicates to include contact information in the message template.</summary>
        [EnumMember(Value = "includeContactInformation")]
        IncludeContactInformation = 8,
        /// <summary>Indicates to include company portal website link in the message template.</summary>
        [EnumMember(Value = "includeCompanyPortalLink")]
        IncludeCompanyPortalLink = 16,
        /// <summary>Indicates to include device details in the message template.</summary>
        [EnumMember(Value = "includeDeviceDetails")]
        IncludeDeviceDetails = 32,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 64,
    }
}
