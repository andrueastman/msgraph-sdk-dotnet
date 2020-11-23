// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IMethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IWorkbookRangeBorderItemAtRequestBuilder.
    /// </summary>
    public partial interface IWorkbookRangeBorderItemAtRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookRangeBorderItemAtRequest Request(IEnumerable<Option> options = null);
        /// <summary>
        /// Gets the request builder for WorkbookRangeBorderCountRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeBorderCountRequestBuilder"/>.</returns>
        IWorkbookRangeBorderCountRequestBuilder Count();
        /// <summary>
        /// Gets the request builder for WorkbookRangeBorderItemAtRequestBuilder.
        /// </summary>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeBorderItemAtRequestBuilder"/>.</returns>
        IWorkbookRangeBorderItemAtRequestBuilder ItemAt(
            Int32 index);
    }
}
