// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Workbook Operation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookOperation : Entity
    {
    
		///<summary>
		/// The WorkbookOperation constructor
		///</summary>
        public WorkbookOperation()
        {
            this.ODataType = "microsoft.graph.workbookOperation";
        }
	
        /// <summary>
        /// Gets or sets error.
        /// The error returned by the operation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "error", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookOperationError Error { get; set; }
    
        /// <summary>
        /// Gets or sets resource location.
        /// The resource URI for the result.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceLocation", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceLocation { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The current status of the operation. Possible values are: NotStarted, Running, Completed, Failed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookOperationStatus? Status { get; set; }
    
    }
}

