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
    public partial class PlannerTaskDetails : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The collection of checklist items on the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.PlannerChecklistItems? Checklist
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PlannerChecklistItems?>("checklist"); }
            set { BackingStore?.Set("checklist", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.PlannerChecklistItems Checklist
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PlannerChecklistItems>("checklist"); }
            set { BackingStore?.Set("checklist", value); }
        }
#endif
        /// <summary>Description of the task.</summary>
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
        /// <summary>This sets the type of preview that shows up on the task. The possible values are: automatic, noPreview, checklist, description, reference. When set to automatic the displayed preview is chosen by the app viewing the task.</summary>
        public global::Microsoft.Graph.Models.PlannerPreviewType? PreviewType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PlannerPreviewType?>("previewType"); }
            set { BackingStore?.Set("previewType", value); }
        }
        /// <summary>The collection of references on the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.PlannerExternalReferences? References
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PlannerExternalReferences?>("references"); }
            set { BackingStore?.Set("references", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.PlannerExternalReferences References
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PlannerExternalReferences>("references"); }
            set { BackingStore?.Set("references", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.PlannerTaskDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.PlannerTaskDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.PlannerTaskDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "checklist", n => { Checklist = n.GetObjectValue<global::Microsoft.Graph.Models.PlannerChecklistItems>(global::Microsoft.Graph.Models.PlannerChecklistItems.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "previewType", n => { PreviewType = n.GetEnumValue<global::Microsoft.Graph.Models.PlannerPreviewType>(); } },
                { "references", n => { References = n.GetObjectValue<global::Microsoft.Graph.Models.PlannerExternalReferences>(global::Microsoft.Graph.Models.PlannerExternalReferences.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.PlannerChecklistItems>("checklist", Checklist);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.PlannerPreviewType>("previewType", PreviewType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.PlannerExternalReferences>("references", References);
        }
    }
}
