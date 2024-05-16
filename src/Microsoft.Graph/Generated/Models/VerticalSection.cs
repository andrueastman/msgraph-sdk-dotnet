// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class VerticalSection : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Enumeration value that indicates the emphasis of the section background. The possible values are: none, netural, soft, strong, unknownFutureValue.</summary>
        public SectionEmphasisType? Emphasis
        {
            get { return BackingStore?.Get<SectionEmphasisType?>("emphasis"); }
            set { BackingStore?.Set("emphasis", value); }
        }
        /// <summary>The set of web parts in this section.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WebPart>? Webparts
        {
            get { return BackingStore?.Get<List<WebPart>?>("webparts"); }
            set { BackingStore?.Set("webparts", value); }
        }
#nullable restore
#else
        public List<WebPart> Webparts
        {
            get { return BackingStore?.Get<List<WebPart>>("webparts"); }
            set { BackingStore?.Set("webparts", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="VerticalSection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VerticalSection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VerticalSection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "emphasis", n => { Emphasis = n.GetEnumValue<SectionEmphasisType>(); } },
                { "webparts", n => { Webparts = n.GetCollectionOfObjectValues<WebPart>(WebPart.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteEnumValue<SectionEmphasisType>("emphasis", Emphasis);
            writer.WriteCollectionOfObjectValues<WebPart>("webparts", Webparts);
        }
    }
}
