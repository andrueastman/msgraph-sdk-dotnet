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
    public partial class WorkbookTable : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The list of all the columns in the table. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WorkbookTableColumn>? Columns
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookTableColumn>?>("columns"); }
            set { BackingStore?.Set("columns", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WorkbookTableColumn> Columns
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookTableColumn>>("columns"); }
            set { BackingStore?.Set("columns", value); }
        }
#endif
        /// <summary>Indicates whether the first column contains special formatting.</summary>
        public bool? HighlightFirstColumn
        {
            get { return BackingStore?.Get<bool?>("highlightFirstColumn"); }
            set { BackingStore?.Set("highlightFirstColumn", value); }
        }
        /// <summary>Indicates whether the last column contains special formatting.</summary>
        public bool? HighlightLastColumn
        {
            get { return BackingStore?.Get<bool?>("highlightLastColumn"); }
            set { BackingStore?.Set("highlightLastColumn", value); }
        }
        /// <summary>A legacy identifier used in older Excel clients. The value of the identifier remains the same even when the table is renamed. This property should be interpreted as an opaque string value and shouldn&apos;t be parsed to any other type. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LegacyId
        {
            get { return BackingStore?.Get<string?>("legacyId"); }
            set { BackingStore?.Set("legacyId", value); }
        }
#nullable restore
#else
        public string LegacyId
        {
            get { return BackingStore?.Get<string>("legacyId"); }
            set { BackingStore?.Set("legacyId", value); }
        }
#endif
        /// <summary>The name of the table.</summary>
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
        /// <summary>The list of all the rows in the table. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WorkbookTableRow>? Rows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookTableRow>?>("rows"); }
            set { BackingStore?.Set("rows", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WorkbookTableRow> Rows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookTableRow>>("rows"); }
            set { BackingStore?.Set("rows", value); }
        }
#endif
        /// <summary>Indicates whether the columns show banded formatting in which odd columns are highlighted differently from even ones to make reading the table easier.</summary>
        public bool? ShowBandedColumns
        {
            get { return BackingStore?.Get<bool?>("showBandedColumns"); }
            set { BackingStore?.Set("showBandedColumns", value); }
        }
        /// <summary>Indicates whether the rows show banded formatting in which odd rows are highlighted differently from even ones to make reading the table easier.</summary>
        public bool? ShowBandedRows
        {
            get { return BackingStore?.Get<bool?>("showBandedRows"); }
            set { BackingStore?.Set("showBandedRows", value); }
        }
        /// <summary>Indicates whether the filter buttons are visible at the top of each column header. Setting this is only allowed if the table contains a header row.</summary>
        public bool? ShowFilterButton
        {
            get { return BackingStore?.Get<bool?>("showFilterButton"); }
            set { BackingStore?.Set("showFilterButton", value); }
        }
        /// <summary>Indicates whether the header row is visible or not. This value can be set to show or remove the header row.</summary>
        public bool? ShowHeaders
        {
            get { return BackingStore?.Get<bool?>("showHeaders"); }
            set { BackingStore?.Set("showHeaders", value); }
        }
        /// <summary>Indicates whether the total row is visible or not. This value can be set to show or remove the total row.</summary>
        public bool? ShowTotals
        {
            get { return BackingStore?.Get<bool?>("showTotals"); }
            set { BackingStore?.Set("showTotals", value); }
        }
        /// <summary>The sorting for the table. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.WorkbookTableSort? Sort
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookTableSort?>("sort"); }
            set { BackingStore?.Set("sort", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.WorkbookTableSort Sort
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookTableSort>("sort"); }
            set { BackingStore?.Set("sort", value); }
        }
#endif
        /// <summary>A constant value that represents the Table style. Possible values are: TableStyleLight1 through TableStyleLight21, TableStyleMedium1 through TableStyleMedium28, TableStyleStyleDark1 through TableStyleStyleDark11. A custom user-defined style present in the workbook can also be specified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Style
        {
            get { return BackingStore?.Get<string?>("style"); }
            set { BackingStore?.Set("style", value); }
        }
#nullable restore
#else
        public string Style
        {
            get { return BackingStore?.Get<string>("style"); }
            set { BackingStore?.Set("style", value); }
        }
#endif
        /// <summary>The worksheet containing the current table. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.WorkbookWorksheet? Worksheet
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookWorksheet?>("worksheet"); }
            set { BackingStore?.Set("worksheet", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.WorkbookWorksheet Worksheet
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookWorksheet>("worksheet"); }
            set { BackingStore?.Set("worksheet", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.WorkbookTable"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.WorkbookTable CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.WorkbookTable();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "columns", n => { Columns = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookTableColumn>(global::Microsoft.Graph.Models.WorkbookTableColumn.CreateFromDiscriminatorValue)?.AsList(); } },
                { "highlightFirstColumn", n => { HighlightFirstColumn = n.GetBoolValue(); } },
                { "highlightLastColumn", n => { HighlightLastColumn = n.GetBoolValue(); } },
                { "legacyId", n => { LegacyId = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "rows", n => { Rows = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookTableRow>(global::Microsoft.Graph.Models.WorkbookTableRow.CreateFromDiscriminatorValue)?.AsList(); } },
                { "showBandedColumns", n => { ShowBandedColumns = n.GetBoolValue(); } },
                { "showBandedRows", n => { ShowBandedRows = n.GetBoolValue(); } },
                { "showFilterButton", n => { ShowFilterButton = n.GetBoolValue(); } },
                { "showHeaders", n => { ShowHeaders = n.GetBoolValue(); } },
                { "showTotals", n => { ShowTotals = n.GetBoolValue(); } },
                { "sort", n => { Sort = n.GetObjectValue<global::Microsoft.Graph.Models.WorkbookTableSort>(global::Microsoft.Graph.Models.WorkbookTableSort.CreateFromDiscriminatorValue); } },
                { "style", n => { Style = n.GetStringValue(); } },
                { "worksheet", n => { Worksheet = n.GetObjectValue<global::Microsoft.Graph.Models.WorkbookWorksheet>(global::Microsoft.Graph.Models.WorkbookWorksheet.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookTableColumn>("columns", Columns);
            writer.WriteBoolValue("highlightFirstColumn", HighlightFirstColumn);
            writer.WriteBoolValue("highlightLastColumn", HighlightLastColumn);
            writer.WriteStringValue("legacyId", LegacyId);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookTableRow>("rows", Rows);
            writer.WriteBoolValue("showBandedColumns", ShowBandedColumns);
            writer.WriteBoolValue("showBandedRows", ShowBandedRows);
            writer.WriteBoolValue("showFilterButton", ShowFilterButton);
            writer.WriteBoolValue("showHeaders", ShowHeaders);
            writer.WriteBoolValue("showTotals", ShowTotals);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.WorkbookTableSort>("sort", Sort);
            writer.WriteStringValue("style", Style);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.WorkbookWorksheet>("worksheet", Worksheet);
        }
    }
}
#pragma warning restore CS0618
