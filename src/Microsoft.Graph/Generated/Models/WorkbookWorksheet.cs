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
    public partial class WorkbookWorksheet : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The list of charts that are part of the worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WorkbookChart>? Charts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookChart>?>("charts"); }
            set { BackingStore?.Set("charts", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WorkbookChart> Charts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookChart>>("charts"); }
            set { BackingStore?.Set("charts", value); }
        }
#endif
        /// <summary>The display name of the worksheet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The list of names that are associated with the worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WorkbookNamedItem>? Names
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookNamedItem>?>("names"); }
            set { BackingStore?.Set("names", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WorkbookNamedItem> Names
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookNamedItem>>("names"); }
            set { BackingStore?.Set("names", value); }
        }
#endif
        /// <summary>The list of piot tables that are part of the worksheet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WorkbookPivotTable>? PivotTables
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookPivotTable>?>("pivotTables"); }
            set { BackingStore?.Set("pivotTables", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WorkbookPivotTable> PivotTables
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookPivotTable>>("pivotTables"); }
            set { BackingStore?.Set("pivotTables", value); }
        }
#endif
        /// <summary>The zero-based position of the worksheet within the workbook.</summary>
        public int? Position
        {
            get { return BackingStore?.Get<int?>("position"); }
            set { BackingStore?.Set("position", value); }
        }
        /// <summary>The sheet protection object for a worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.WorkbookWorksheetProtection? Protection
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookWorksheetProtection?>("protection"); }
            set { BackingStore?.Set("protection", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.WorkbookWorksheetProtection Protection
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookWorksheetProtection>("protection"); }
            set { BackingStore?.Set("protection", value); }
        }
#endif
        /// <summary>The list of tables that are part of the worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WorkbookTable>? Tables
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookTable>?>("tables"); }
            set { BackingStore?.Set("tables", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WorkbookTable> Tables
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookTable>>("tables"); }
            set { BackingStore?.Set("tables", value); }
        }
#endif
        /// <summary>The visibility of the worksheet. The possible values are: Visible, Hidden, VeryHidden.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Visibility
        {
            get { return BackingStore?.Get<string?>("visibility"); }
            set { BackingStore?.Set("visibility", value); }
        }
#nullable restore
#else
        public string Visibility
        {
            get { return BackingStore?.Get<string>("visibility"); }
            set { BackingStore?.Set("visibility", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.WorkbookWorksheet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.WorkbookWorksheet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.WorkbookWorksheet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "charts", n => { Charts = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookChart>(global::Microsoft.Graph.Models.WorkbookChart.CreateFromDiscriminatorValue)?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "names", n => { Names = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookNamedItem>(global::Microsoft.Graph.Models.WorkbookNamedItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pivotTables", n => { PivotTables = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookPivotTable>(global::Microsoft.Graph.Models.WorkbookPivotTable.CreateFromDiscriminatorValue)?.AsList(); } },
                { "position", n => { Position = n.GetIntValue(); } },
                { "protection", n => { Protection = n.GetObjectValue<global::Microsoft.Graph.Models.WorkbookWorksheetProtection>(global::Microsoft.Graph.Models.WorkbookWorksheetProtection.CreateFromDiscriminatorValue); } },
                { "tables", n => { Tables = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookTable>(global::Microsoft.Graph.Models.WorkbookTable.CreateFromDiscriminatorValue)?.AsList(); } },
                { "visibility", n => { Visibility = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookChart>("charts", Charts);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookNamedItem>("names", Names);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookPivotTable>("pivotTables", PivotTables);
            writer.WriteIntValue("position", Position);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.WorkbookWorksheetProtection>("protection", Protection);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookTable>("tables", Tables);
            writer.WriteStringValue("visibility", Visibility);
        }
    }
}
