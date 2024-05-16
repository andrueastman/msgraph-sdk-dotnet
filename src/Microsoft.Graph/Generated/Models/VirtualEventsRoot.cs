// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class VirtualEventsRoot : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The events property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VirtualEvent>? Events
        {
            get { return BackingStore?.Get<List<VirtualEvent>?>("events"); }
            set { BackingStore?.Set("events", value); }
        }
#nullable restore
#else
        public List<VirtualEvent> Events
        {
            get { return BackingStore?.Get<List<VirtualEvent>>("events"); }
            set { BackingStore?.Set("events", value); }
        }
#endif
        /// <summary>The webinars property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VirtualEventWebinar>? Webinars
        {
            get { return BackingStore?.Get<List<VirtualEventWebinar>?>("webinars"); }
            set { BackingStore?.Set("webinars", value); }
        }
#nullable restore
#else
        public List<VirtualEventWebinar> Webinars
        {
            get { return BackingStore?.Get<List<VirtualEventWebinar>>("webinars"); }
            set { BackingStore?.Set("webinars", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="VirtualEventsRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VirtualEventsRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualEventsRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "events", n => { Events = n.GetCollectionOfObjectValues<VirtualEvent>(VirtualEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                { "webinars", n => { Webinars = n.GetCollectionOfObjectValues<VirtualEventWebinar>(VirtualEventWebinar.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<VirtualEvent>("events", Events);
            writer.WriteCollectionOfObjectValues<VirtualEventWebinar>("webinars", Webinars);
        }
    }
}
