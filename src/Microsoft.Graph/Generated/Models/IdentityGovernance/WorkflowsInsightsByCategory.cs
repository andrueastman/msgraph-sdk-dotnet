// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.IdentityGovernance
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class WorkflowsInsightsByCategory : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Failed &apos;Joiner&apos; workflows processed in a tenant.</summary>
        public int? FailedJoinerRuns
        {
            get { return BackingStore?.Get<int?>("failedJoinerRuns"); }
            set { BackingStore?.Set("failedJoinerRuns", value); }
        }
        /// <summary>Failed &apos;Leaver&apos; workflows processed in a tenant.</summary>
        public int? FailedLeaverRuns
        {
            get { return BackingStore?.Get<int?>("failedLeaverRuns"); }
            set { BackingStore?.Set("failedLeaverRuns", value); }
        }
        /// <summary>Failed &apos;Mover&apos; workflows processed in a tenant.</summary>
        public int? FailedMoverRuns
        {
            get { return BackingStore?.Get<int?>("failedMoverRuns"); }
            set { BackingStore?.Set("failedMoverRuns", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Successful &apos;Joiner&apos; workflows processed in a tenant.</summary>
        public int? SuccessfulJoinerRuns
        {
            get { return BackingStore?.Get<int?>("successfulJoinerRuns"); }
            set { BackingStore?.Set("successfulJoinerRuns", value); }
        }
        /// <summary>Successful &apos;Leaver&apos; workflows processed in a tenant.</summary>
        public int? SuccessfulLeaverRuns
        {
            get { return BackingStore?.Get<int?>("successfulLeaverRuns"); }
            set { BackingStore?.Set("successfulLeaverRuns", value); }
        }
        /// <summary>Successful &apos;Mover&apos; workflows processed in a tenant.</summary>
        public int? SuccessfulMoverRuns
        {
            get { return BackingStore?.Get<int?>("successfulMoverRuns"); }
            set { BackingStore?.Set("successfulMoverRuns", value); }
        }
        /// <summary>Total &apos;Joiner&apos; workflows processed in a tenant.</summary>
        public int? TotalJoinerRuns
        {
            get { return BackingStore?.Get<int?>("totalJoinerRuns"); }
            set { BackingStore?.Set("totalJoinerRuns", value); }
        }
        /// <summary>Total &apos;Leaver&apos; workflows processed in a tenant.</summary>
        public int? TotalLeaverRuns
        {
            get { return BackingStore?.Get<int?>("totalLeaverRuns"); }
            set { BackingStore?.Set("totalLeaverRuns", value); }
        }
        /// <summary>Total &apos;Mover&apos; workflows processed in a tenant.</summary>
        public int? TotalMoverRuns
        {
            get { return BackingStore?.Get<int?>("totalMoverRuns"); }
            set { BackingStore?.Set("totalMoverRuns", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.IdentityGovernance.WorkflowsInsightsByCategory"/> and sets the default values.
        /// </summary>
        public WorkflowsInsightsByCategory()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityGovernance.WorkflowsInsightsByCategory"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.IdentityGovernance.WorkflowsInsightsByCategory CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.IdentityGovernance.WorkflowsInsightsByCategory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "failedJoinerRuns", n => { FailedJoinerRuns = n.GetIntValue(); } },
                { "failedLeaverRuns", n => { FailedLeaverRuns = n.GetIntValue(); } },
                { "failedMoverRuns", n => { FailedMoverRuns = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "successfulJoinerRuns", n => { SuccessfulJoinerRuns = n.GetIntValue(); } },
                { "successfulLeaverRuns", n => { SuccessfulLeaverRuns = n.GetIntValue(); } },
                { "successfulMoverRuns", n => { SuccessfulMoverRuns = n.GetIntValue(); } },
                { "totalJoinerRuns", n => { TotalJoinerRuns = n.GetIntValue(); } },
                { "totalLeaverRuns", n => { TotalLeaverRuns = n.GetIntValue(); } },
                { "totalMoverRuns", n => { TotalMoverRuns = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("failedJoinerRuns", FailedJoinerRuns);
            writer.WriteIntValue("failedLeaverRuns", FailedLeaverRuns);
            writer.WriteIntValue("failedMoverRuns", FailedMoverRuns);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("successfulJoinerRuns", SuccessfulJoinerRuns);
            writer.WriteIntValue("successfulLeaverRuns", SuccessfulLeaverRuns);
            writer.WriteIntValue("successfulMoverRuns", SuccessfulMoverRuns);
            writer.WriteIntValue("totalJoinerRuns", TotalJoinerRuns);
            writer.WriteIntValue("totalLeaverRuns", TotalLeaverRuns);
            writer.WriteIntValue("totalMoverRuns", TotalMoverRuns);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618