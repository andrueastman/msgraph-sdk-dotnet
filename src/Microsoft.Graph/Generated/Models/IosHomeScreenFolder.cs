// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// A folder containing pages of apps and web clips on the Home Screen.
    /// </summary>
    public class IosHomeScreenFolder : IosHomeScreenItem, IParsable
    {
        /// <summary>Pages of Home Screen Layout Icons which must be applications or web clips. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IosHomeScreenFolderPage>? Pages
        {
            get { return BackingStore?.Get<List<IosHomeScreenFolderPage>?>("pages"); }
            set { BackingStore?.Set("pages", value); }
        }
#nullable restore
#else
        public List<IosHomeScreenFolderPage> Pages
        {
            get { return BackingStore?.Get<List<IosHomeScreenFolderPage>>("pages"); }
            set { BackingStore?.Set("pages", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="IosHomeScreenFolder"/> and sets the default values.
        /// </summary>
        public IosHomeScreenFolder() : base()
        {
            OdataType = "#microsoft.graph.iosHomeScreenFolder";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IosHomeScreenFolder"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosHomeScreenFolder CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosHomeScreenFolder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "pages", n => { Pages = n.GetCollectionOfObjectValues<IosHomeScreenFolderPage>(IosHomeScreenFolderPage.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<IosHomeScreenFolderPage>("pages", Pages);
        }
    }
}
