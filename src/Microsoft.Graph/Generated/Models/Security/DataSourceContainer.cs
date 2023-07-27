using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class DataSourceContainer : Entity, IParsable {
        /// <summary>Created date and time of the dataSourceContainer entity.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Display name of the dataSourceContainer entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The hold status of the dataSourceContainer. The possible values are: notApplied, applied, applying, removing, partial</summary>
        public DataSourceHoldStatus? HoldStatus {
            get { return BackingStore?.Get<DataSourceHoldStatus?>("holdStatus"); }
            set { BackingStore?.Set("holdStatus", value); }
        }
        /// <summary>Last modified date and time of the dataSourceContainer.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Date and time that the dataSourceContainer was released from the case.</summary>
        public DateTimeOffset? ReleasedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("releasedDateTime"); }
            set { BackingStore?.Set("releasedDateTime", value); }
        }
        /// <summary>Latest status of the dataSourceContainer. Possible values are: Active, Released.</summary>
        public DataSourceContainerStatus? Status {
            get { return BackingStore?.Get<DataSourceContainerStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DataSourceContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.security.ediscoveryCustodian" => new EdiscoveryCustodian(),
                "#microsoft.graph.security.ediscoveryNoncustodialDataSource" => new EdiscoveryNoncustodialDataSource(),
                _ => new DataSourceContainer(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"holdStatus", n => { HoldStatus = n.GetEnumValue<DataSourceHoldStatus>(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"releasedDateTime", n => { ReleasedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<DataSourceContainerStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<DataSourceHoldStatus>("holdStatus", HoldStatus);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("releasedDateTime", ReleasedDateTime);
            writer.WriteEnumValue<DataSourceContainerStatus>("status", Status);
        }
    }
}