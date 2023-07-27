using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class EducationSchool : EducationOrganization, IParsable {
        /// <summary>Address of the school.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PhysicalAddress? Address {
            get { return BackingStore?.Get<PhysicalAddress?>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#nullable restore
#else
        public PhysicalAddress Address {
            get { return BackingStore?.Get<PhysicalAddress>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#endif
        /// <summary>The underlying administrativeUnit for this school.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.AdministrativeUnit? AdministrativeUnit {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AdministrativeUnit?>("administrativeUnit"); }
            set { BackingStore?.Set("administrativeUnit", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.AdministrativeUnit AdministrativeUnit {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AdministrativeUnit>("administrativeUnit"); }
            set { BackingStore?.Set("administrativeUnit", value); }
        }
#endif
        /// <summary>Classes taught at the school. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationClass>? Classes {
            get { return BackingStore?.Get<List<EducationClass>?>("classes"); }
            set { BackingStore?.Set("classes", value); }
        }
#nullable restore
#else
        public List<EducationClass> Classes {
            get { return BackingStore?.Get<List<EducationClass>>("classes"); }
            set { BackingStore?.Set("classes", value); }
        }
#endif
        /// <summary>Entity who created the school.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? CreatedBy {
            get { return BackingStore?.Get<IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>ID of school in syncing system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId {
            get { return BackingStore?.Get<string?>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#nullable restore
#else
        public string ExternalId {
            get { return BackingStore?.Get<string>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#endif
        /// <summary>ID of principal in syncing system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalPrincipalId {
            get { return BackingStore?.Get<string?>("externalPrincipalId"); }
            set { BackingStore?.Set("externalPrincipalId", value); }
        }
#nullable restore
#else
        public string ExternalPrincipalId {
            get { return BackingStore?.Get<string>("externalPrincipalId"); }
            set { BackingStore?.Set("externalPrincipalId", value); }
        }
#endif
        /// <summary>The fax property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fax {
            get { return BackingStore?.Get<string?>("fax"); }
            set { BackingStore?.Set("fax", value); }
        }
#nullable restore
#else
        public string Fax {
            get { return BackingStore?.Get<string>("fax"); }
            set { BackingStore?.Set("fax", value); }
        }
#endif
        /// <summary>Highest grade taught.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HighestGrade {
            get { return BackingStore?.Get<string?>("highestGrade"); }
            set { BackingStore?.Set("highestGrade", value); }
        }
#nullable restore
#else
        public string HighestGrade {
            get { return BackingStore?.Get<string>("highestGrade"); }
            set { BackingStore?.Set("highestGrade", value); }
        }
#endif
        /// <summary>Lowest grade taught.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LowestGrade {
            get { return BackingStore?.Get<string?>("lowestGrade"); }
            set { BackingStore?.Set("lowestGrade", value); }
        }
#nullable restore
#else
        public string LowestGrade {
            get { return BackingStore?.Get<string>("lowestGrade"); }
            set { BackingStore?.Set("lowestGrade", value); }
        }
#endif
        /// <summary>Phone number of school.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone {
            get { return BackingStore?.Get<string?>("phone"); }
            set { BackingStore?.Set("phone", value); }
        }
#nullable restore
#else
        public string Phone {
            get { return BackingStore?.Get<string>("phone"); }
            set { BackingStore?.Set("phone", value); }
        }
#endif
        /// <summary>Email address of the principal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalEmail {
            get { return BackingStore?.Get<string?>("principalEmail"); }
            set { BackingStore?.Set("principalEmail", value); }
        }
#nullable restore
#else
        public string PrincipalEmail {
            get { return BackingStore?.Get<string>("principalEmail"); }
            set { BackingStore?.Set("principalEmail", value); }
        }
#endif
        /// <summary>Name of the principal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalName {
            get { return BackingStore?.Get<string?>("principalName"); }
            set { BackingStore?.Set("principalName", value); }
        }
#nullable restore
#else
        public string PrincipalName {
            get { return BackingStore?.Get<string>("principalName"); }
            set { BackingStore?.Set("principalName", value); }
        }
#endif
        /// <summary>School Number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SchoolNumber {
            get { return BackingStore?.Get<string?>("schoolNumber"); }
            set { BackingStore?.Set("schoolNumber", value); }
        }
#nullable restore
#else
        public string SchoolNumber {
            get { return BackingStore?.Get<string>("schoolNumber"); }
            set { BackingStore?.Set("schoolNumber", value); }
        }
#endif
        /// <summary>Users in the school. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationUser>? Users {
            get { return BackingStore?.Get<List<EducationUser>?>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#nullable restore
#else
        public List<EducationUser> Users {
            get { return BackingStore?.Get<List<EducationUser>>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new educationSchool and sets the default values.
        /// </summary>
        public EducationSchool() : base() {
            OdataType = "#microsoft.graph.educationSchool";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationSchool CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSchool();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"address", n => { Address = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"administrativeUnit", n => { AdministrativeUnit = n.GetObjectValue<Microsoft.Graph.Models.AdministrativeUnit>(Microsoft.Graph.Models.AdministrativeUnit.CreateFromDiscriminatorValue); } },
                {"classes", n => { Classes = n.GetCollectionOfObjectValues<EducationClass>(EducationClass.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"externalPrincipalId", n => { ExternalPrincipalId = n.GetStringValue(); } },
                {"fax", n => { Fax = n.GetStringValue(); } },
                {"highestGrade", n => { HighestGrade = n.GetStringValue(); } },
                {"lowestGrade", n => { LowestGrade = n.GetStringValue(); } },
                {"phone", n => { Phone = n.GetStringValue(); } },
                {"principalEmail", n => { PrincipalEmail = n.GetStringValue(); } },
                {"principalName", n => { PrincipalName = n.GetStringValue(); } },
                {"schoolNumber", n => { SchoolNumber = n.GetStringValue(); } },
                {"users", n => { Users = n.GetCollectionOfObjectValues<EducationUser>(EducationUser.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PhysicalAddress>("address", Address);
            writer.WriteObjectValue<Microsoft.Graph.Models.AdministrativeUnit>("administrativeUnit", AdministrativeUnit);
            writer.WriteCollectionOfObjectValues<EducationClass>("classes", Classes);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("externalPrincipalId", ExternalPrincipalId);
            writer.WriteStringValue("fax", Fax);
            writer.WriteStringValue("highestGrade", HighestGrade);
            writer.WriteStringValue("lowestGrade", LowestGrade);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("principalEmail", PrincipalEmail);
            writer.WriteStringValue("principalName", PrincipalName);
            writer.WriteStringValue("schoolNumber", SchoolNumber);
            writer.WriteCollectionOfObjectValues<EducationUser>("users", Users);
        }
    }
}