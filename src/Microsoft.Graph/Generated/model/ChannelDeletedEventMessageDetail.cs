// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ChannelDeletedEventMessageDetail.
    /// </summary>
    public partial class ChannelDeletedEventMessageDetail : EventMessageDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelDeletedEventMessageDetail"/> class.
        /// </summary>
        public ChannelDeletedEventMessageDetail()
        {
            this.ODataType = "microsoft.graph.channelDeletedEventMessageDetail";
        }

        /// <summary>
        /// Gets or sets channelDisplayName.
        /// Display name of the channel.
        /// </summary>
        [JsonPropertyName("channelDisplayName")]
        public string ChannelDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets channelId.
        /// Unique identifier of the channel.
        /// </summary>
        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }
    
        /// <summary>
        /// Gets or sets initiator.
        /// Initiator of the event.
        /// </summary>
        [JsonPropertyName("initiator")]
        public IdentitySet Initiator { get; set; }
    
    }
}
