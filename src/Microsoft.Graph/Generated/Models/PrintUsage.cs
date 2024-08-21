// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class PrintUsage : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The blackAndWhitePageCount property</summary>
        public long? BlackAndWhitePageCount
        {
            get { return BackingStore?.Get<long?>("blackAndWhitePageCount"); }
            set { BackingStore?.Set("blackAndWhitePageCount", value); }
        }
        /// <summary>The colorPageCount property</summary>
        public long? ColorPageCount
        {
            get { return BackingStore?.Get<long?>("colorPageCount"); }
            set { BackingStore?.Set("colorPageCount", value); }
        }
        /// <summary>The completedBlackAndWhiteJobCount property</summary>
        public long? CompletedBlackAndWhiteJobCount
        {
            get { return BackingStore?.Get<long?>("completedBlackAndWhiteJobCount"); }
            set { BackingStore?.Set("completedBlackAndWhiteJobCount", value); }
        }
        /// <summary>The completedColorJobCount property</summary>
        public long? CompletedColorJobCount
        {
            get { return BackingStore?.Get<long?>("completedColorJobCount"); }
            set { BackingStore?.Set("completedColorJobCount", value); }
        }
        /// <summary>The completedJobCount property</summary>
        public long? CompletedJobCount
        {
            get { return BackingStore?.Get<long?>("completedJobCount"); }
            set { BackingStore?.Set("completedJobCount", value); }
        }
        /// <summary>The doubleSidedSheetCount property</summary>
        public long? DoubleSidedSheetCount
        {
            get { return BackingStore?.Get<long?>("doubleSidedSheetCount"); }
            set { BackingStore?.Set("doubleSidedSheetCount", value); }
        }
        /// <summary>The incompleteJobCount property</summary>
        public long? IncompleteJobCount
        {
            get { return BackingStore?.Get<long?>("incompleteJobCount"); }
            set { BackingStore?.Set("incompleteJobCount", value); }
        }
        /// <summary>The mediaSheetCount property</summary>
        public long? MediaSheetCount
        {
            get { return BackingStore?.Get<long?>("mediaSheetCount"); }
            set { BackingStore?.Set("mediaSheetCount", value); }
        }
        /// <summary>The pageCount property</summary>
        public long? PageCount
        {
            get { return BackingStore?.Get<long?>("pageCount"); }
            set { BackingStore?.Set("pageCount", value); }
        }
        /// <summary>The singleSidedSheetCount property</summary>
        public long? SingleSidedSheetCount
        {
            get { return BackingStore?.Get<long?>("singleSidedSheetCount"); }
            set { BackingStore?.Set("singleSidedSheetCount", value); }
        }
        /// <summary>The usageDate property</summary>
        public Date? UsageDate
        {
            get { return BackingStore?.Get<Date?>("usageDate"); }
            set { BackingStore?.Set("usageDate", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.PrintUsage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.PrintUsage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.printUsageByPrinter" => new global::Microsoft.Graph.Models.PrintUsageByPrinter(),
                "#microsoft.graph.printUsageByUser" => new global::Microsoft.Graph.Models.PrintUsageByUser(),
                _ => new global::Microsoft.Graph.Models.PrintUsage(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "blackAndWhitePageCount", n => { BlackAndWhitePageCount = n.GetLongValue(); } },
                { "colorPageCount", n => { ColorPageCount = n.GetLongValue(); } },
                { "completedBlackAndWhiteJobCount", n => { CompletedBlackAndWhiteJobCount = n.GetLongValue(); } },
                { "completedColorJobCount", n => { CompletedColorJobCount = n.GetLongValue(); } },
                { "completedJobCount", n => { CompletedJobCount = n.GetLongValue(); } },
                { "doubleSidedSheetCount", n => { DoubleSidedSheetCount = n.GetLongValue(); } },
                { "incompleteJobCount", n => { IncompleteJobCount = n.GetLongValue(); } },
                { "mediaSheetCount", n => { MediaSheetCount = n.GetLongValue(); } },
                { "pageCount", n => { PageCount = n.GetLongValue(); } },
                { "singleSidedSheetCount", n => { SingleSidedSheetCount = n.GetLongValue(); } },
                { "usageDate", n => { UsageDate = n.GetDateValue(); } },
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
            writer.WriteLongValue("blackAndWhitePageCount", BlackAndWhitePageCount);
            writer.WriteLongValue("colorPageCount", ColorPageCount);
            writer.WriteLongValue("completedBlackAndWhiteJobCount", CompletedBlackAndWhiteJobCount);
            writer.WriteLongValue("completedColorJobCount", CompletedColorJobCount);
            writer.WriteLongValue("completedJobCount", CompletedJobCount);
            writer.WriteLongValue("doubleSidedSheetCount", DoubleSidedSheetCount);
            writer.WriteLongValue("incompleteJobCount", IncompleteJobCount);
            writer.WriteLongValue("mediaSheetCount", MediaSheetCount);
            writer.WriteLongValue("pageCount", PageCount);
            writer.WriteLongValue("singleSidedSheetCount", SingleSidedSheetCount);
            writer.WriteDateValue("usageDate", UsageDate);
        }
    }
}
