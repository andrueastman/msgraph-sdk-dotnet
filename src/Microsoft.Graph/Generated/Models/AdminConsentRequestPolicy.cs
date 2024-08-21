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
    public partial class AdminConsentRequestPolicy : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies whether the admin consent request feature is enabled or disabled. Required.</summary>
        public bool? IsEnabled
        {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>Specifies whether reviewers will receive notifications. Required.</summary>
        public bool? NotifyReviewers
        {
            get { return BackingStore?.Get<bool?>("notifyReviewers"); }
            set { BackingStore?.Set("notifyReviewers", value); }
        }
        /// <summary>Specifies whether reviewers will receive reminder emails. Required.</summary>
        public bool? RemindersEnabled
        {
            get { return BackingStore?.Get<bool?>("remindersEnabled"); }
            set { BackingStore?.Set("remindersEnabled", value); }
        }
        /// <summary>Specifies the duration the request is active before it automatically expires if no decision is applied.</summary>
        public int? RequestDurationInDays
        {
            get { return BackingStore?.Get<int?>("requestDurationInDays"); }
            set { BackingStore?.Set("requestDurationInDays", value); }
        }
        /// <summary>The list of reviewers for the admin consent. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AccessReviewReviewerScope>? Reviewers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewReviewerScope>?>("reviewers"); }
            set { BackingStore?.Set("reviewers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AccessReviewReviewerScope> Reviewers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewReviewerScope>>("reviewers"); }
            set { BackingStore?.Set("reviewers", value); }
        }
#endif
        /// <summary>Specifies the version of this policy. When the policy is updated, this version is updated. Read-only.</summary>
        public int? Version
        {
            get { return BackingStore?.Get<int?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AdminConsentRequestPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AdminConsentRequestPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AdminConsentRequestPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                { "notifyReviewers", n => { NotifyReviewers = n.GetBoolValue(); } },
                { "remindersEnabled", n => { RemindersEnabled = n.GetBoolValue(); } },
                { "requestDurationInDays", n => { RequestDurationInDays = n.GetIntValue(); } },
                { "reviewers", n => { Reviewers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewReviewerScope>(global::Microsoft.Graph.Models.AccessReviewReviewerScope.CreateFromDiscriminatorValue)?.AsList(); } },
                { "version", n => { Version = n.GetIntValue(); } },
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
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteBoolValue("notifyReviewers", NotifyReviewers);
            writer.WriteBoolValue("remindersEnabled", RemindersEnabled);
            writer.WriteIntValue("requestDurationInDays", RequestDurationInDays);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewReviewerScope>("reviewers", Reviewers);
            writer.WriteIntValue("version", Version);
        }
    }
}
