using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class Planner : Entity, IParsable {
        /// <summary>Read-only. Nullable. Returns a collection of the specified buckets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PlannerBucket>? Buckets {
            get { return BackingStore?.Get<List<PlannerBucket>?>("buckets"); }
            set { BackingStore?.Set("buckets", value); }
        }
#nullable restore
#else
        public List<PlannerBucket> Buckets {
            get { return BackingStore?.Get<List<PlannerBucket>>("buckets"); }
            set { BackingStore?.Set("buckets", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Returns a collection of the specified plans</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PlannerPlan>? Plans {
            get { return BackingStore?.Get<List<PlannerPlan>?>("plans"); }
            set { BackingStore?.Set("plans", value); }
        }
#nullable restore
#else
        public List<PlannerPlan> Plans {
            get { return BackingStore?.Get<List<PlannerPlan>>("plans"); }
            set { BackingStore?.Set("plans", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Returns a collection of the specified tasks</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PlannerTask>? Tasks {
            get { return BackingStore?.Get<List<PlannerTask>?>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#nullable restore
#else
        public List<PlannerTask> Tasks {
            get { return BackingStore?.Get<List<PlannerTask>>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Planner CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Planner();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"buckets", n => { Buckets = n.GetCollectionOfObjectValues<PlannerBucket>(PlannerBucket.CreateFromDiscriminatorValue)?.ToList(); } },
                {"plans", n => { Plans = n.GetCollectionOfObjectValues<PlannerPlan>(PlannerPlan.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<PlannerTask>(PlannerTask.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PlannerBucket>("buckets", Buckets);
            writer.WriteCollectionOfObjectValues<PlannerPlan>("plans", Plans);
            writer.WriteCollectionOfObjectValues<PlannerTask>("tasks", Tasks);
        }
    }
}