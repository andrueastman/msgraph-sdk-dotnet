// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Groups.Item.Sites.Item.ContentTypes.Item.IsPublished
{
    [Obsolete("This class is obsolete. Use IsPublishedGetResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class IsPublishedResponse : global::Microsoft.Graph.Groups.Item.Sites.Item.ContentTypes.Item.IsPublished.IsPublishedGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Groups.Item.Sites.Item.ContentTypes.Item.IsPublished.IsPublishedResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Groups.Item.Sites.Item.ContentTypes.Item.IsPublished.IsPublishedResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Groups.Item.Sites.Item.ContentTypes.Item.IsPublished.IsPublishedResponse();
        }
    }
}
