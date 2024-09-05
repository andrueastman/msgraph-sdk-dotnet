// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class ThumbnailSet : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A 1920x1920 scaled thumbnail.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Thumbnail? Large
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Thumbnail?>("large"); }
            set { BackingStore?.Set("large", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Thumbnail Large
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Thumbnail>("large"); }
            set { BackingStore?.Set("large", value); }
        }
#endif
        /// <summary>A 176x176 scaled thumbnail.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Thumbnail? Medium
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Thumbnail?>("medium"); }
            set { BackingStore?.Set("medium", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Thumbnail Medium
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Thumbnail>("medium"); }
            set { BackingStore?.Set("medium", value); }
        }
#endif
        /// <summary>A 48x48 cropped thumbnail.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Thumbnail? Small
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Thumbnail?>("small"); }
            set { BackingStore?.Set("small", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Thumbnail Small
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Thumbnail>("small"); }
            set { BackingStore?.Set("small", value); }
        }
#endif
        /// <summary>A custom thumbnail image or the original image used to generate other thumbnails.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Thumbnail? Source
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Thumbnail?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Thumbnail Source
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Thumbnail>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ThumbnailSet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ThumbnailSet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ThumbnailSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "large", n => { Large = n.GetObjectValue<global::Microsoft.Graph.Models.Thumbnail>(global::Microsoft.Graph.Models.Thumbnail.CreateFromDiscriminatorValue); } },
                { "medium", n => { Medium = n.GetObjectValue<global::Microsoft.Graph.Models.Thumbnail>(global::Microsoft.Graph.Models.Thumbnail.CreateFromDiscriminatorValue); } },
                { "small", n => { Small = n.GetObjectValue<global::Microsoft.Graph.Models.Thumbnail>(global::Microsoft.Graph.Models.Thumbnail.CreateFromDiscriminatorValue); } },
                { "source", n => { Source = n.GetObjectValue<global::Microsoft.Graph.Models.Thumbnail>(global::Microsoft.Graph.Models.Thumbnail.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Thumbnail>("large", Large);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Thumbnail>("medium", Medium);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Thumbnail>("small", Small);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Thumbnail>("source", Source);
        }
    }
}
#pragma warning restore CS0618
