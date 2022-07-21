// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EdiscoveryReviewSetReferenceRequestBuilder.
    /// </summary>
    public partial class EdiscoveryReviewSetReferenceRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IEdiscoveryReviewSetReferenceRequestBuilder
    {
        /// <summary>
        /// Constructs a new EdiscoveryReviewSetReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public EdiscoveryReviewSetReferenceRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEdiscoveryReviewSetReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEdiscoveryReviewSetReferenceRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new EdiscoveryReviewSetReferenceRequest(this.RequestUrl, this.Client, options);
        }
    }
}