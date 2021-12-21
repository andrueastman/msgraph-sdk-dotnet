// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface ISolutionsRootBookingBusinessesCollectionRequestBuilder.
    /// </summary>
    public partial interface ISolutionsRootBookingBusinessesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ISolutionsRootBookingBusinessesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ISolutionsRootBookingBusinessesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IBookingBusinessRequestBuilder"/> for the specified BookingBusiness.
        /// </summary>
        /// <param name="id">The ID for the BookingBusiness.</param>
        /// <returns>The <see cref="IBookingBusinessRequestBuilder"/>.</returns>
        IBookingBusinessRequestBuilder this[string id] { get; }

        
    }
}
