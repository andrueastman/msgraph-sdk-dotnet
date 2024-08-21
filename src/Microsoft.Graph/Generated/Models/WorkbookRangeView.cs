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
    public partial class WorkbookRangeView : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The cell addresses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? CellAddresses
        {
            get { return BackingStore?.Get<UntypedNode?>("cellAddresses"); }
            set { BackingStore?.Set("cellAddresses", value); }
        }
#nullable restore
#else
        public UntypedNode CellAddresses
        {
            get { return BackingStore?.Get<UntypedNode>("cellAddresses"); }
            set { BackingStore?.Set("cellAddresses", value); }
        }
#endif
        /// <summary>The number of visible columns. Read-only.</summary>
        public int? ColumnCount
        {
            get { return BackingStore?.Get<int?>("columnCount"); }
            set { BackingStore?.Set("columnCount", value); }
        }
        /// <summary>The formula in A1-style notation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Formulas
        {
            get { return BackingStore?.Get<UntypedNode?>("formulas"); }
            set { BackingStore?.Set("formulas", value); }
        }
#nullable restore
#else
        public UntypedNode Formulas
        {
            get { return BackingStore?.Get<UntypedNode>("formulas"); }
            set { BackingStore?.Set("formulas", value); }
        }
#endif
        /// <summary>The formula in A1-style notation, in the user&apos;s language and number-formatting locale. For example, the English &apos;=SUM(A1, 1.5)&apos; formula would become &apos;=SUMME(A1; 1,5)&apos; in German.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? FormulasLocal
        {
            get { return BackingStore?.Get<UntypedNode?>("formulasLocal"); }
            set { BackingStore?.Set("formulasLocal", value); }
        }
#nullable restore
#else
        public UntypedNode FormulasLocal
        {
            get { return BackingStore?.Get<UntypedNode>("formulasLocal"); }
            set { BackingStore?.Set("formulasLocal", value); }
        }
#endif
        /// <summary>Represents the formula in R1C1-style notation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? FormulasR1C1
        {
            get { return BackingStore?.Get<UntypedNode?>("formulasR1C1"); }
            set { BackingStore?.Set("formulasR1C1", value); }
        }
#nullable restore
#else
        public UntypedNode FormulasR1C1
        {
            get { return BackingStore?.Get<UntypedNode>("formulasR1C1"); }
            set { BackingStore?.Set("formulasR1C1", value); }
        }
#endif
        /// <summary>The index of the range.</summary>
        public int? Index
        {
            get { return BackingStore?.Get<int?>("index"); }
            set { BackingStore?.Set("index", value); }
        }
        /// <summary>Excel&apos;s number format code for the given cell. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? NumberFormat
        {
            get { return BackingStore?.Get<UntypedNode?>("numberFormat"); }
            set { BackingStore?.Set("numberFormat", value); }
        }
#nullable restore
#else
        public UntypedNode NumberFormat
        {
            get { return BackingStore?.Get<UntypedNode>("numberFormat"); }
            set { BackingStore?.Set("numberFormat", value); }
        }
#endif
        /// <summary>The number of visible rows. Read-only.</summary>
        public int? RowCount
        {
            get { return BackingStore?.Get<int?>("rowCount"); }
            set { BackingStore?.Set("rowCount", value); }
        }
        /// <summary>The collection of range views associated with the range. Read-only. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WorkbookRangeView>? Rows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookRangeView>?>("rows"); }
            set { BackingStore?.Set("rows", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WorkbookRangeView> Rows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookRangeView>>("rows"); }
            set { BackingStore?.Set("rows", value); }
        }
#endif
        /// <summary>The text values of the specified range. The Text value won&apos;t depend on the cell width. The # sign substitution that happens in Excel UI won&apos;t affect the text value returned by the API. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Text
        {
            get { return BackingStore?.Get<UntypedNode?>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#nullable restore
#else
        public UntypedNode Text
        {
            get { return BackingStore?.Get<UntypedNode>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#endif
        /// <summary>The raw values of the specified range view. The data returned could be of type string, number, or a Boolean. Cell that contains an error returns the error string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Values
        {
            get { return BackingStore?.Get<UntypedNode?>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#nullable restore
#else
        public UntypedNode Values
        {
            get { return BackingStore?.Get<UntypedNode>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#endif
        /// <summary>The type of data of each cell. Read-only. The possible values are: Unknown, Empty, String, Integer, Double, Boolean, Error.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? ValueTypes
        {
            get { return BackingStore?.Get<UntypedNode?>("valueTypes"); }
            set { BackingStore?.Set("valueTypes", value); }
        }
#nullable restore
#else
        public UntypedNode ValueTypes
        {
            get { return BackingStore?.Get<UntypedNode>("valueTypes"); }
            set { BackingStore?.Set("valueTypes", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.WorkbookRangeView"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.WorkbookRangeView CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.WorkbookRangeView();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "cellAddresses", n => { CellAddresses = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "columnCount", n => { ColumnCount = n.GetIntValue(); } },
                { "formulas", n => { Formulas = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "formulasLocal", n => { FormulasLocal = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "formulasR1C1", n => { FormulasR1C1 = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "index", n => { Index = n.GetIntValue(); } },
                { "numberFormat", n => { NumberFormat = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "rowCount", n => { RowCount = n.GetIntValue(); } },
                { "rows", n => { Rows = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookRangeView>(global::Microsoft.Graph.Models.WorkbookRangeView.CreateFromDiscriminatorValue)?.AsList(); } },
                { "text", n => { Text = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "valueTypes", n => { ValueTypes = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "values", n => { Values = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<UntypedNode>("cellAddresses", CellAddresses);
            writer.WriteIntValue("columnCount", ColumnCount);
            writer.WriteObjectValue<UntypedNode>("formulas", Formulas);
            writer.WriteObjectValue<UntypedNode>("formulasLocal", FormulasLocal);
            writer.WriteObjectValue<UntypedNode>("formulasR1C1", FormulasR1C1);
            writer.WriteIntValue("index", Index);
            writer.WriteObjectValue<UntypedNode>("numberFormat", NumberFormat);
            writer.WriteIntValue("rowCount", RowCount);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookRangeView>("rows", Rows);
            writer.WriteObjectValue<UntypedNode>("text", Text);
            writer.WriteObjectValue<UntypedNode>("values", Values);
            writer.WriteObjectValue<UntypedNode>("valueTypes", ValueTypes);
        }
    }
}
