// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.DirectoryRoles.Item.GetMemberGroups {
    [Obsolete("This class is obsolete. Use GetMemberGroupsPostResponse instead.")]
    #pragma warning disable CS1591
    public class GetMemberGroupsResponse : GetMemberGroupsPostResponse, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GetMemberGroupsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GetMemberGroupsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetMemberGroupsResponse();
        }
    }
}
