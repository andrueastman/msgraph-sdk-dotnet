using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class SynchronizationJob : Entity, IParsable {
        /// <summary>Schedule used to run the job. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SynchronizationSchedule? Schedule {
            get { return BackingStore?.Get<SynchronizationSchedule?>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#nullable restore
#else
        public SynchronizationSchedule Schedule {
            get { return BackingStore?.Get<SynchronizationSchedule>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#endif
        /// <summary>The synchronization schema configured for the job.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SynchronizationSchema? Schema {
            get { return BackingStore?.Get<SynchronizationSchema?>("schema"); }
            set { BackingStore?.Set("schema", value); }
        }
#nullable restore
#else
        public SynchronizationSchema Schema {
            get { return BackingStore?.Get<SynchronizationSchema>("schema"); }
            set { BackingStore?.Set("schema", value); }
        }
#endif
        /// <summary>Status of the job, which includes when the job was last run, current job state, and errors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SynchronizationStatus? Status {
            get { return BackingStore?.Get<SynchronizationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public SynchronizationStatus Status {
            get { return BackingStore?.Get<SynchronizationStatus>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>Settings associated with the job. Some settings are inherited from the template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? SynchronizationJobSettings {
            get { return BackingStore?.Get<List<KeyValuePair>?>("synchronizationJobSettings"); }
            set { BackingStore?.Set("synchronizationJobSettings", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> SynchronizationJobSettings {
            get { return BackingStore?.Get<List<KeyValuePair>>("synchronizationJobSettings"); }
            set { BackingStore?.Set("synchronizationJobSettings", value); }
        }
#endif
        /// <summary>Identifier of the synchronization template this job is based on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TemplateId {
            get { return BackingStore?.Get<string?>("templateId"); }
            set { BackingStore?.Set("templateId", value); }
        }
#nullable restore
#else
        public string TemplateId {
            get { return BackingStore?.Get<string>("templateId"); }
            set { BackingStore?.Set("templateId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SynchronizationJob CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationJob();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"schedule", n => { Schedule = n.GetObjectValue<SynchronizationSchedule>(SynchronizationSchedule.CreateFromDiscriminatorValue); } },
                {"schema", n => { Schema = n.GetObjectValue<SynchronizationSchema>(SynchronizationSchema.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetObjectValue<SynchronizationStatus>(SynchronizationStatus.CreateFromDiscriminatorValue); } },
                {"synchronizationJobSettings", n => { SynchronizationJobSettings = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"templateId", n => { TemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<SynchronizationSchedule>("schedule", Schedule);
            writer.WriteObjectValue<SynchronizationSchema>("schema", Schema);
            writer.WriteObjectValue<SynchronizationStatus>("status", Status);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("synchronizationJobSettings", SynchronizationJobSettings);
            writer.WriteStringValue("templateId", TemplateId);
        }
    }
}