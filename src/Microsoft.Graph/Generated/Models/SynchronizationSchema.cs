using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class SynchronizationSchema : Entity, IParsable {
        /// <summary>Contains the collection of directories and all of their objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryDefinition>? Directories {
            get { return BackingStore?.Get<List<DirectoryDefinition>?>("directories"); }
            set { BackingStore?.Set("directories", value); }
        }
#nullable restore
#else
        public List<DirectoryDefinition> Directories {
            get { return BackingStore?.Get<List<DirectoryDefinition>>("directories"); }
            set { BackingStore?.Set("directories", value); }
        }
#endif
        /// <summary>A collection of synchronization rules configured for the synchronizationJob or synchronizationTemplate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SynchronizationRule>? SynchronizationRules {
            get { return BackingStore?.Get<List<SynchronizationRule>?>("synchronizationRules"); }
            set { BackingStore?.Set("synchronizationRules", value); }
        }
#nullable restore
#else
        public List<SynchronizationRule> SynchronizationRules {
            get { return BackingStore?.Get<List<SynchronizationRule>>("synchronizationRules"); }
            set { BackingStore?.Set("synchronizationRules", value); }
        }
#endif
        /// <summary>The version of the schema, updated automatically with every schema change.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SynchronizationSchema CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationSchema();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"directories", n => { Directories = n.GetCollectionOfObjectValues<DirectoryDefinition>(DirectoryDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"synchronizationRules", n => { SynchronizationRules = n.GetCollectionOfObjectValues<SynchronizationRule>(SynchronizationRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DirectoryDefinition>("directories", Directories);
            writer.WriteCollectionOfObjectValues<SynchronizationRule>("synchronizationRules", SynchronizationRules);
            writer.WriteStringValue("version", Version);
        }
    }
}