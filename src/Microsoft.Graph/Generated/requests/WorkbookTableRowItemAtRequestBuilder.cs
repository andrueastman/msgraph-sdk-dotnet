// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookTableRowItemAtRequestBuilder.
    /// </summary>
    public partial class WorkbookTableRowItemAtRequestBuilder : BaseFunctionMethodRequestBuilder<IWorkbookTableRowItemAtRequest>, IWorkbookTableRowItemAtRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookTableRowItemAtRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="index">A index parameter for the OData method call.</param>
        public WorkbookTableRowItemAtRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Int32 index)
            : base(requestUrl, client)
        {
            this.SetParameter("index", index, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookTableRowItemAtRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookTableRowItemAtRequest(functionUrl, this.Client, options);

            return request;
        }
        /// <summary>
        /// Gets the request builder for WorkbookTableRowAddRequestBuilder.
        /// </summary>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <param name="values">A values parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookTableRowAddRequestBuilder"/>.</returns>
        public IWorkbookTableRowAddRequestBuilder Add(
            Int32? index,
            Newtonsoft.Json.Linq.JToken values)
        {
            return new WorkbookTableRowAddRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.add"),
                this.Client,
                index,
                values);
        }
        /// <summary>
        /// Gets the request builder for WorkbookTableRowCountRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableRowCountRequestBuilder"/>.</returns>
        public IWorkbookTableRowCountRequestBuilder Count()
        {
            return new WorkbookTableRowCountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.count"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookTableRowItemAtRequestBuilder.
        /// </summary>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookTableRowItemAtRequestBuilder"/>.</returns>
        public IWorkbookTableRowItemAtRequestBuilder ItemAt(
            Int32 index)
        {
            return new WorkbookTableRowItemAtRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.itemAt"),
                this.Client,
                index);
        }
        /// <summary>
        /// Gets the request builder for WorkbookTableRowRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableRowRangeRequestBuilder"/>.</returns>
        public IWorkbookTableRowRangeRequestBuilder Range()
        {
            return new WorkbookTableRowRangeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.range"),
                this.Client);
        }
    }
}
