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
    /// The type File Assessment Request.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class FileAssessmentRequestObject : ThreatAssessmentRequestObject
    {
    
		///<summary>
		/// The FileAssessmentRequest constructor
		///</summary>
        public FileAssessmentRequestObject()
        {
            this.ODataType = "microsoft.graph.fileAssessmentRequest";
        }
	
        /// <summary>
        /// Gets or sets file name.
        /// The file name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileName", Required = Newtonsoft.Json.Required.Default)]
        public string FileName { get; set; }
    
        /// <summary>
        /// Gets or sets content data.
        /// Base64 encoded file content. The file content cannot fetch back because it isn't stored.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentData", Required = Newtonsoft.Json.Required.Default)]
        public string ContentData { get; set; }
    
    }
}

