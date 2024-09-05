// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class SynchronizationQuarantine : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Date and time when the quarantine was last evaluated and imposed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CurrentBegan
        {
            get { return BackingStore?.Get<DateTimeOffset?>("currentBegan"); }
            set { BackingStore?.Set("currentBegan", value); }
        }
        /// <summary>Describes the error(s) that occurred when putting the synchronization job into quarantine.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SynchronizationError? Error
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SynchronizationError?>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SynchronizationError Error
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SynchronizationError>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#endif
        /// <summary>Date and time when the next attempt to re-evaluate the quarantine will be made. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? NextAttempt
        {
            get { return BackingStore?.Get<DateTimeOffset?>("nextAttempt"); }
            set { BackingStore?.Set("nextAttempt", value); }
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
        /// <summary>The reason property</summary>
        public global::Microsoft.Graph.Models.QuarantineReason? Reason
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.QuarantineReason?>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
        /// <summary>Date and time when the quarantine was first imposed in this series (a series starts when a quarantine is first imposed, and is reset as soon as the quarantine is lifted). The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? SeriesBegan
        {
            get { return BackingStore?.Get<DateTimeOffset?>("seriesBegan"); }
            set { BackingStore?.Set("seriesBegan", value); }
        }
        /// <summary>Number of times in this series the quarantine was re-evaluated and left in effect (a series starts when quarantine is first imposed, and is reset as soon as quarantine is lifted).</summary>
        public long? SeriesCount
        {
            get { return BackingStore?.Get<long?>("seriesCount"); }
            set { BackingStore?.Set("seriesCount", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.SynchronizationQuarantine"/> and sets the default values.
        /// </summary>
        public SynchronizationQuarantine()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SynchronizationQuarantine"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.SynchronizationQuarantine CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.SynchronizationQuarantine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "currentBegan", n => { CurrentBegan = n.GetDateTimeOffsetValue(); } },
                { "error", n => { Error = n.GetObjectValue<global::Microsoft.Graph.Models.SynchronizationError>(global::Microsoft.Graph.Models.SynchronizationError.CreateFromDiscriminatorValue); } },
                { "nextAttempt", n => { NextAttempt = n.GetDateTimeOffsetValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "reason", n => { Reason = n.GetEnumValue<global::Microsoft.Graph.Models.QuarantineReason>(); } },
                { "seriesBegan", n => { SeriesBegan = n.GetDateTimeOffsetValue(); } },
                { "seriesCount", n => { SeriesCount = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("currentBegan", CurrentBegan);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SynchronizationError>("error", Error);
            writer.WriteDateTimeOffsetValue("nextAttempt", NextAttempt);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.QuarantineReason>("reason", Reason);
            writer.WriteDateTimeOffsetValue("seriesBegan", SeriesBegan);
            writer.WriteLongValue("seriesCount", SeriesCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
