// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Singleton entity which is used to specify IE mode site metadata
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class BrowserSite : global::Microsoft.Graph.Models.Entity, IParsable
    {
        /// <summary>Controls the behavior of redirected sites. If true, indicates that the site will open in Internet Explorer 11 or Microsoft Edge even if the site is navigated to as part of a HTTP or meta refresh redirection chain.</summary>
        public bool? AllowRedirect
        {
            get { return BackingStore?.Get<bool?>("allowRedirect"); }
            set { BackingStore?.Set("allowRedirect", value); }
        }
        /// <summary>The comment for the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment
        {
            get { return BackingStore?.Get<string?>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#nullable restore
#else
        public string Comment
        {
            get { return BackingStore?.Get<string>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#endif
        /// <summary>The compatibilityMode property</summary>
        public global::Microsoft.Graph.Models.BrowserSiteCompatibilityMode? CompatibilityMode
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.BrowserSiteCompatibilityMode?>("compatibilityMode"); }
            set { BackingStore?.Set("compatibilityMode", value); }
        }
        /// <summary>The date and time when the site was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The date and time when the site was deleted.</summary>
        public DateTimeOffset? DeletedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("deletedDateTime"); }
            set { BackingStore?.Set("deletedDateTime", value); }
        }
        /// <summary>The history of modifications applied to the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.BrowserSiteHistory>? History
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.BrowserSiteHistory>?>("history"); }
            set { BackingStore?.Set("history", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.BrowserSiteHistory> History
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.BrowserSiteHistory>>("history"); }
            set { BackingStore?.Set("history", value); }
        }
#endif
        /// <summary>The user who last modified the site.</summary>
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
        /// <summary>The date and time when the site was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The mergeType property</summary>
        public global::Microsoft.Graph.Models.BrowserSiteMergeType? MergeType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.BrowserSiteMergeType?>("mergeType"); }
            set { BackingStore?.Set("mergeType", value); }
        }
        /// <summary>The status property</summary>
        public global::Microsoft.Graph.Models.BrowserSiteStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.BrowserSiteStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The targetEnvironment property</summary>
        public global::Microsoft.Graph.Models.BrowserSiteTargetEnvironment? TargetEnvironment
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.BrowserSiteTargetEnvironment?>("targetEnvironment"); }
            set { BackingStore?.Set("targetEnvironment", value); }
        }
        /// <summary>The URL of the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl
        {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl
        {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.BrowserSite"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.BrowserSite CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.BrowserSite();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowRedirect", n => { AllowRedirect = n.GetBoolValue(); } },
                { "comment", n => { Comment = n.GetStringValue(); } },
                { "compatibilityMode", n => { CompatibilityMode = n.GetEnumValue<global::Microsoft.Graph.Models.BrowserSiteCompatibilityMode>(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                { "history", n => { History = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.BrowserSiteHistory>(global::Microsoft.Graph.Models.BrowserSiteHistory.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::Microsoft.Graph.Models.IdentitySet>(global::Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "mergeType", n => { MergeType = n.GetEnumValue<global::Microsoft.Graph.Models.BrowserSiteMergeType>(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Models.BrowserSiteStatus>(); } },
                { "targetEnvironment", n => { TargetEnvironment = n.GetEnumValue<global::Microsoft.Graph.Models.BrowserSiteTargetEnvironment>(); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
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
            writer.WriteBoolValue("allowRedirect", AllowRedirect);
            writer.WriteStringValue("comment", Comment);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.BrowserSiteCompatibilityMode>("compatibilityMode", CompatibilityMode);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.BrowserSiteHistory>("history", History);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.BrowserSiteMergeType>("mergeType", MergeType);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.BrowserSiteStatus>("status", Status);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.BrowserSiteTargetEnvironment>("targetEnvironment", TargetEnvironment);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
