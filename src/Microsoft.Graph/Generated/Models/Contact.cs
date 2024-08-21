// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class Contact : global::Microsoft.Graph.Models.OutlookItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The name of the contact&apos;s assistant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssistantName
        {
            get { return BackingStore?.Get<string?>("assistantName"); }
            set { BackingStore?.Set("assistantName", value); }
        }
#nullable restore
#else
        public string AssistantName
        {
            get { return BackingStore?.Get<string>("assistantName"); }
            set { BackingStore?.Set("assistantName", value); }
        }
#endif
        /// <summary>The contact&apos;s birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? Birthday
        {
            get { return BackingStore?.Get<DateTimeOffset?>("birthday"); }
            set { BackingStore?.Set("birthday", value); }
        }
        /// <summary>The contact&apos;s business address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.PhysicalAddress? BusinessAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PhysicalAddress?>("businessAddress"); }
            set { BackingStore?.Set("businessAddress", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.PhysicalAddress BusinessAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PhysicalAddress>("businessAddress"); }
            set { BackingStore?.Set("businessAddress", value); }
        }
#endif
        /// <summary>The business home page of the contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessHomePage
        {
            get { return BackingStore?.Get<string?>("businessHomePage"); }
            set { BackingStore?.Set("businessHomePage", value); }
        }
#nullable restore
#else
        public string BusinessHomePage
        {
            get { return BackingStore?.Get<string>("businessHomePage"); }
            set { BackingStore?.Set("businessHomePage", value); }
        }
#endif
        /// <summary>The contact&apos;s business phone numbers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? BusinessPhones
        {
            get { return BackingStore?.Get<List<string>?>("businessPhones"); }
            set { BackingStore?.Set("businessPhones", value); }
        }
#nullable restore
#else
        public List<string> BusinessPhones
        {
            get { return BackingStore?.Get<List<string>>("businessPhones"); }
            set { BackingStore?.Set("businessPhones", value); }
        }
#endif
        /// <summary>The names of the contact&apos;s children.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Children
        {
            get { return BackingStore?.Get<List<string>?>("children"); }
            set { BackingStore?.Set("children", value); }
        }
#nullable restore
#else
        public List<string> Children
        {
            get { return BackingStore?.Get<List<string>>("children"); }
            set { BackingStore?.Set("children", value); }
        }
#endif
        /// <summary>The name of the contact&apos;s company.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName
        {
            get { return BackingStore?.Get<string?>("companyName"); }
            set { BackingStore?.Set("companyName", value); }
        }
#nullable restore
#else
        public string CompanyName
        {
            get { return BackingStore?.Get<string>("companyName"); }
            set { BackingStore?.Set("companyName", value); }
        }
#endif
        /// <summary>The contact&apos;s department.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Department
        {
            get { return BackingStore?.Get<string?>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#nullable restore
#else
        public string Department
        {
            get { return BackingStore?.Get<string>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#endif
        /// <summary>The contact&apos;s display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The contact&apos;s email addresses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.EmailAddress>? EmailAddresses
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.EmailAddress>?>("emailAddresses"); }
            set { BackingStore?.Set("emailAddresses", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.EmailAddress> EmailAddresses
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.EmailAddress>>("emailAddresses"); }
            set { BackingStore?.Set("emailAddresses", value); }
        }
#endif
        /// <summary>The collection of open extensions defined for the contact. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Extension>? Extensions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Extension>?>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Extension> Extensions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Extension>>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#endif
        /// <summary>The name the contact is filed under.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileAs
        {
            get { return BackingStore?.Get<string?>("fileAs"); }
            set { BackingStore?.Set("fileAs", value); }
        }
#nullable restore
#else
        public string FileAs
        {
            get { return BackingStore?.Get<string>("fileAs"); }
            set { BackingStore?.Set("fileAs", value); }
        }
#endif
        /// <summary>The contact&apos;s suffix.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Generation
        {
            get { return BackingStore?.Get<string?>("generation"); }
            set { BackingStore?.Set("generation", value); }
        }
#nullable restore
#else
        public string Generation
        {
            get { return BackingStore?.Get<string>("generation"); }
            set { BackingStore?.Set("generation", value); }
        }
#endif
        /// <summary>The contact&apos;s given name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GivenName
        {
            get { return BackingStore?.Get<string?>("givenName"); }
            set { BackingStore?.Set("givenName", value); }
        }
#nullable restore
#else
        public string GivenName
        {
            get { return BackingStore?.Get<string>("givenName"); }
            set { BackingStore?.Set("givenName", value); }
        }
#endif
        /// <summary>The contact&apos;s home address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.PhysicalAddress? HomeAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PhysicalAddress?>("homeAddress"); }
            set { BackingStore?.Set("homeAddress", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.PhysicalAddress HomeAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PhysicalAddress>("homeAddress"); }
            set { BackingStore?.Set("homeAddress", value); }
        }
#endif
        /// <summary>The contact&apos;s home phone numbers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? HomePhones
        {
            get { return BackingStore?.Get<List<string>?>("homePhones"); }
            set { BackingStore?.Set("homePhones", value); }
        }
#nullable restore
#else
        public List<string> HomePhones
        {
            get { return BackingStore?.Get<List<string>>("homePhones"); }
            set { BackingStore?.Set("homePhones", value); }
        }
#endif
        /// <summary>The contact&apos;s instant messaging (IM) addresses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ImAddresses
        {
            get { return BackingStore?.Get<List<string>?>("imAddresses"); }
            set { BackingStore?.Set("imAddresses", value); }
        }
#nullable restore
#else
        public List<string> ImAddresses
        {
            get { return BackingStore?.Get<List<string>>("imAddresses"); }
            set { BackingStore?.Set("imAddresses", value); }
        }
#endif
        /// <summary>The contact&apos;s initials.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Initials
        {
            get { return BackingStore?.Get<string?>("initials"); }
            set { BackingStore?.Set("initials", value); }
        }
#nullable restore
#else
        public string Initials
        {
            get { return BackingStore?.Get<string>("initials"); }
            set { BackingStore?.Set("initials", value); }
        }
#endif
        /// <summary>The contact’s job title.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobTitle
        {
            get { return BackingStore?.Get<string?>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#nullable restore
#else
        public string JobTitle
        {
            get { return BackingStore?.Get<string>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#endif
        /// <summary>The name of the contact&apos;s manager.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manager
        {
            get { return BackingStore?.Get<string?>("manager"); }
            set { BackingStore?.Set("manager", value); }
        }
#nullable restore
#else
        public string Manager
        {
            get { return BackingStore?.Get<string>("manager"); }
            set { BackingStore?.Set("manager", value); }
        }
#endif
        /// <summary>The contact&apos;s middle name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MiddleName
        {
            get { return BackingStore?.Get<string?>("middleName"); }
            set { BackingStore?.Set("middleName", value); }
        }
#nullable restore
#else
        public string MiddleName
        {
            get { return BackingStore?.Get<string>("middleName"); }
            set { BackingStore?.Set("middleName", value); }
        }
#endif
        /// <summary>The contact&apos;s mobile phone number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MobilePhone
        {
            get { return BackingStore?.Get<string?>("mobilePhone"); }
            set { BackingStore?.Set("mobilePhone", value); }
        }
#nullable restore
#else
        public string MobilePhone
        {
            get { return BackingStore?.Get<string>("mobilePhone"); }
            set { BackingStore?.Set("mobilePhone", value); }
        }
#endif
        /// <summary>The collection of multi-value extended properties defined for the contact. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty>? MultiValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty>?>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty> MultiValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty>>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#endif
        /// <summary>The contact&apos;s nickname.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NickName
        {
            get { return BackingStore?.Get<string?>("nickName"); }
            set { BackingStore?.Set("nickName", value); }
        }
#nullable restore
#else
        public string NickName
        {
            get { return BackingStore?.Get<string>("nickName"); }
            set { BackingStore?.Set("nickName", value); }
        }
#endif
        /// <summary>The location of the contact&apos;s office.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OfficeLocation
        {
            get { return BackingStore?.Get<string?>("officeLocation"); }
            set { BackingStore?.Set("officeLocation", value); }
        }
#nullable restore
#else
        public string OfficeLocation
        {
            get { return BackingStore?.Get<string>("officeLocation"); }
            set { BackingStore?.Set("officeLocation", value); }
        }
#endif
        /// <summary>Other addresses for the contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.PhysicalAddress? OtherAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PhysicalAddress?>("otherAddress"); }
            set { BackingStore?.Set("otherAddress", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.PhysicalAddress OtherAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PhysicalAddress>("otherAddress"); }
            set { BackingStore?.Set("otherAddress", value); }
        }
#endif
        /// <summary>The ID of the contact&apos;s parent folder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentFolderId
        {
            get { return BackingStore?.Get<string?>("parentFolderId"); }
            set { BackingStore?.Set("parentFolderId", value); }
        }
#nullable restore
#else
        public string ParentFolderId
        {
            get { return BackingStore?.Get<string>("parentFolderId"); }
            set { BackingStore?.Set("parentFolderId", value); }
        }
#endif
        /// <summary>The user&apos;s notes about the contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PersonalNotes
        {
            get { return BackingStore?.Get<string?>("personalNotes"); }
            set { BackingStore?.Set("personalNotes", value); }
        }
#nullable restore
#else
        public string PersonalNotes
        {
            get { return BackingStore?.Get<string>("personalNotes"); }
            set { BackingStore?.Set("personalNotes", value); }
        }
#endif
        /// <summary>Optional contact picture. You can get or set a photo for a contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ProfilePhoto? Photo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ProfilePhoto?>("photo"); }
            set { BackingStore?.Set("photo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ProfilePhoto Photo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ProfilePhoto>("photo"); }
            set { BackingStore?.Set("photo", value); }
        }
#endif
        /// <summary>The contact&apos;s profession.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Profession
        {
            get { return BackingStore?.Get<string?>("profession"); }
            set { BackingStore?.Set("profession", value); }
        }
#nullable restore
#else
        public string Profession
        {
            get { return BackingStore?.Get<string>("profession"); }
            set { BackingStore?.Set("profession", value); }
        }
#endif
        /// <summary>The collection of single-value extended properties defined for the contact. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty>? SingleValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty>?>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty> SingleValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty>>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#endif
        /// <summary>The name of the contact&apos;s spouse/partner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SpouseName
        {
            get { return BackingStore?.Get<string?>("spouseName"); }
            set { BackingStore?.Set("spouseName", value); }
        }
#nullable restore
#else
        public string SpouseName
        {
            get { return BackingStore?.Get<string>("spouseName"); }
            set { BackingStore?.Set("spouseName", value); }
        }
#endif
        /// <summary>The contact&apos;s surname.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Surname
        {
            get { return BackingStore?.Get<string?>("surname"); }
            set { BackingStore?.Set("surname", value); }
        }
#nullable restore
#else
        public string Surname
        {
            get { return BackingStore?.Get<string>("surname"); }
            set { BackingStore?.Set("surname", value); }
        }
#endif
        /// <summary>The contact&apos;s title.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title
        {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title
        {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>The phonetic Japanese company name of the contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? YomiCompanyName
        {
            get { return BackingStore?.Get<string?>("yomiCompanyName"); }
            set { BackingStore?.Set("yomiCompanyName", value); }
        }
#nullable restore
#else
        public string YomiCompanyName
        {
            get { return BackingStore?.Get<string>("yomiCompanyName"); }
            set { BackingStore?.Set("yomiCompanyName", value); }
        }
#endif
        /// <summary>The phonetic Japanese given name (first name) of the contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? YomiGivenName
        {
            get { return BackingStore?.Get<string?>("yomiGivenName"); }
            set { BackingStore?.Set("yomiGivenName", value); }
        }
#nullable restore
#else
        public string YomiGivenName
        {
            get { return BackingStore?.Get<string>("yomiGivenName"); }
            set { BackingStore?.Set("yomiGivenName", value); }
        }
#endif
        /// <summary>The phonetic Japanese surname (last name)  of the contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? YomiSurname
        {
            get { return BackingStore?.Get<string?>("yomiSurname"); }
            set { BackingStore?.Set("yomiSurname", value); }
        }
#nullable restore
#else
        public string YomiSurname
        {
            get { return BackingStore?.Get<string>("yomiSurname"); }
            set { BackingStore?.Set("yomiSurname", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Contact"/> and sets the default values.
        /// </summary>
        public Contact() : base()
        {
            OdataType = "#microsoft.graph.contact";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Contact"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Contact CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Contact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assistantName", n => { AssistantName = n.GetStringValue(); } },
                { "birthday", n => { Birthday = n.GetDateTimeOffsetValue(); } },
                { "businessAddress", n => { BusinessAddress = n.GetObjectValue<global::Microsoft.Graph.Models.PhysicalAddress>(global::Microsoft.Graph.Models.PhysicalAddress.CreateFromDiscriminatorValue); } },
                { "businessHomePage", n => { BusinessHomePage = n.GetStringValue(); } },
                { "businessPhones", n => { BusinessPhones = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "children", n => { Children = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "companyName", n => { CompanyName = n.GetStringValue(); } },
                { "department", n => { Department = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "emailAddresses", n => { EmailAddresses = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.EmailAddress>(global::Microsoft.Graph.Models.EmailAddress.CreateFromDiscriminatorValue)?.AsList(); } },
                { "extensions", n => { Extensions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Extension>(global::Microsoft.Graph.Models.Extension.CreateFromDiscriminatorValue)?.AsList(); } },
                { "fileAs", n => { FileAs = n.GetStringValue(); } },
                { "generation", n => { Generation = n.GetStringValue(); } },
                { "givenName", n => { GivenName = n.GetStringValue(); } },
                { "homeAddress", n => { HomeAddress = n.GetObjectValue<global::Microsoft.Graph.Models.PhysicalAddress>(global::Microsoft.Graph.Models.PhysicalAddress.CreateFromDiscriminatorValue); } },
                { "homePhones", n => { HomePhones = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "imAddresses", n => { ImAddresses = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "initials", n => { Initials = n.GetStringValue(); } },
                { "jobTitle", n => { JobTitle = n.GetStringValue(); } },
                { "manager", n => { Manager = n.GetStringValue(); } },
                { "middleName", n => { MiddleName = n.GetStringValue(); } },
                { "mobilePhone", n => { MobilePhone = n.GetStringValue(); } },
                { "multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty>(global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "nickName", n => { NickName = n.GetStringValue(); } },
                { "officeLocation", n => { OfficeLocation = n.GetStringValue(); } },
                { "otherAddress", n => { OtherAddress = n.GetObjectValue<global::Microsoft.Graph.Models.PhysicalAddress>(global::Microsoft.Graph.Models.PhysicalAddress.CreateFromDiscriminatorValue); } },
                { "parentFolderId", n => { ParentFolderId = n.GetStringValue(); } },
                { "personalNotes", n => { PersonalNotes = n.GetStringValue(); } },
                { "photo", n => { Photo = n.GetObjectValue<global::Microsoft.Graph.Models.ProfilePhoto>(global::Microsoft.Graph.Models.ProfilePhoto.CreateFromDiscriminatorValue); } },
                { "profession", n => { Profession = n.GetStringValue(); } },
                { "singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty>(global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "spouseName", n => { SpouseName = n.GetStringValue(); } },
                { "surname", n => { Surname = n.GetStringValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "yomiCompanyName", n => { YomiCompanyName = n.GetStringValue(); } },
                { "yomiGivenName", n => { YomiGivenName = n.GetStringValue(); } },
                { "yomiSurname", n => { YomiSurname = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assistantName", AssistantName);
            writer.WriteDateTimeOffsetValue("birthday", Birthday);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.PhysicalAddress>("businessAddress", BusinessAddress);
            writer.WriteStringValue("businessHomePage", BusinessHomePage);
            writer.WriteCollectionOfPrimitiveValues<string>("businessPhones", BusinessPhones);
            writer.WriteCollectionOfPrimitiveValues<string>("children", Children);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("department", Department);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.EmailAddress>("emailAddresses", EmailAddresses);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Extension>("extensions", Extensions);
            writer.WriteStringValue("fileAs", FileAs);
            writer.WriteStringValue("generation", Generation);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.PhysicalAddress>("homeAddress", HomeAddress);
            writer.WriteCollectionOfPrimitiveValues<string>("homePhones", HomePhones);
            writer.WriteCollectionOfPrimitiveValues<string>("imAddresses", ImAddresses);
            writer.WriteStringValue("initials", Initials);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("manager", Manager);
            writer.WriteStringValue("middleName", MiddleName);
            writer.WriteStringValue("mobilePhone", MobilePhone);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("nickName", NickName);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.PhysicalAddress>("otherAddress", OtherAddress);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteStringValue("personalNotes", PersonalNotes);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ProfilePhoto>("photo", Photo);
            writer.WriteStringValue("profession", Profession);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteStringValue("spouseName", SpouseName);
            writer.WriteStringValue("surname", Surname);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("yomiCompanyName", YomiCompanyName);
            writer.WriteStringValue("yomiGivenName", YomiGivenName);
            writer.WriteStringValue("yomiSurname", YomiSurname);
        }
    }
}
