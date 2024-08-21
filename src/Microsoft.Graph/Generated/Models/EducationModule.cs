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
    public partial class EducationModule : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The display name of the user that created the module.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentitySet? CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentitySet CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Date time the module was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description of the module.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Name of the module.</summary>
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
        /// <summary>Indicates whether the module is pinned or not.</summary>
        public bool? IsPinned
        {
            get { return BackingStore?.Get<bool?>("isPinned"); }
            set { BackingStore?.Set("isPinned", value); }
        }
        /// <summary>The last user that modified the module.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentitySet? LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentitySet LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>Date time the module was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Learning objects that are associated with this module. Only teachers can modify this list. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.EducationModuleResource>? Resources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.EducationModuleResource>?>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.EducationModuleResource> Resources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.EducationModuleResource>>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#endif
        /// <summary>Folder URL where all the file resources for this module are stored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourcesFolderUrl
        {
            get { return BackingStore?.Get<string?>("resourcesFolderUrl"); }
            set { BackingStore?.Set("resourcesFolderUrl", value); }
        }
#nullable restore
#else
        public string ResourcesFolderUrl
        {
            get { return BackingStore?.Get<string>("resourcesFolderUrl"); }
            set { BackingStore?.Set("resourcesFolderUrl", value); }
        }
#endif
        /// <summary>Status of the module. You can&apos;t use a PATCH operation to update this value. Possible values are: draft and published.</summary>
        public global::Microsoft.Graph.Models.EducationModuleStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationModuleStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.EducationModule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.EducationModule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.EducationModule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::Microsoft.Graph.Models.IdentitySet>(global::Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "isPinned", n => { IsPinned = n.GetBoolValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::Microsoft.Graph.Models.IdentitySet>(global::Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "resources", n => { Resources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.EducationModuleResource>(global::Microsoft.Graph.Models.EducationModuleResource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "resourcesFolderUrl", n => { ResourcesFolderUrl = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Models.EducationModuleStatus>(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isPinned", IsPinned);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.EducationModuleResource>("resources", Resources);
        }
    }
}
