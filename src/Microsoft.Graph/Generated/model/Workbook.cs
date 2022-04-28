// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Workbook.
    /// </summary>
    public partial class Workbook : Entity
    {
    
        /// <summary>
        /// Gets or sets application.
        /// </summary>
        [JsonPropertyName("application")]
        public WorkbookApplication Application { get; set; }
    
        /// <summary>
        /// Gets or sets comments.
        /// </summary>
        [JsonPropertyName("comments")]
        public IWorkbookCommentsCollectionPage Comments { get; set; }

        /// <summary>
        /// Gets or sets commentsNextLink.
        /// </summary>
        [JsonPropertyName("comments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CommentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets functions.
        /// </summary>
        [JsonPropertyName("functions")]
        public WorkbookFunctions Functions { get; set; }
    
        /// <summary>
        /// Gets or sets names.
        /// Represents a collection of workbooks scoped named items (named ranges and constants). Read-only.
        /// </summary>
        [JsonPropertyName("names")]
        public IWorkbookNamesCollectionPage Names { get; set; }

        /// <summary>
        /// Gets or sets namesNextLink.
        /// </summary>
        [JsonPropertyName("names@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string NamesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// The status of Workbook operations. Getting an operation collection is not supported, but you can get the status of a long-running operation if the Location header is returned in the response. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("operations")]
        public IWorkbookOperationsCollectionPage Operations { get; set; }

        /// <summary>
        /// Gets or sets operationsNextLink.
        /// </summary>
        [JsonPropertyName("operations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string OperationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets tables.
        /// Represents a collection of tables associated with the workbook. Read-only.
        /// </summary>
        [JsonPropertyName("tables")]
        public IWorkbookTablesCollectionPage Tables { get; set; }

        /// <summary>
        /// Gets or sets tablesNextLink.
        /// </summary>
        [JsonPropertyName("tables@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TablesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets worksheets.
        /// Represents a collection of worksheets associated with the workbook. Read-only.
        /// </summary>
        [JsonPropertyName("worksheets")]
        public IWorkbookWorksheetsCollectionPage Worksheets { get; set; }

        /// <summary>
        /// Gets or sets worksheetsNextLink.
        /// </summary>
        [JsonPropertyName("worksheets@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string WorksheetsNextLink { get; set; }
    
    }
}

