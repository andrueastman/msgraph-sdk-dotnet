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
    /// The type UnifiedRoleManagementPolicyRuleTarget.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UnifiedRoleManagementPolicyRuleTarget>))]
    public partial class UnifiedRoleManagementPolicyRuleTarget
    {

        /// <summary>
        /// Gets or sets caller.
        /// The type of caller that's the target of the policy rule. Allowed values are: None, Admin, EndUser.
        /// </summary>
        [JsonPropertyName("caller")]
        public string Caller { get; set; }
    
        /// <summary>
        /// Gets or sets enforcedSettings.
        /// The list of role settings that are enforced and cannot be overridden by child scopes. Use All for all settings.
        /// </summary>
        [JsonPropertyName("enforcedSettings")]
        public IEnumerable<string> EnforcedSettings { get; set; }
    
        /// <summary>
        /// Gets or sets inheritableSettings.
        /// The list of role settings that can be inherited by child scopes. Use All for all settings.
        /// </summary>
        [JsonPropertyName("inheritableSettings")]
        public IEnumerable<string> InheritableSettings { get; set; }
    
        /// <summary>
        /// Gets or sets level.
        /// The role assignment type that's the target of policy rule. Allowed values are: Eligibility, Assignment.
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// The role management operations that are the target of the policy rule. Allowed values are: All, Activate, Deactivate, Assign, Update, Remove, Extend, Renew.
        /// </summary>
        [JsonPropertyName("operations")]
        public IEnumerable<UnifiedRoleManagementPolicyRuleTargetOperations> Operations { get; set; }
    
        /// <summary>
        /// Gets or sets targetObjects.
        /// </summary>
        [JsonPropertyName("targetObjects")]
        public IEnumerable<DirectoryObject> TargetObjects { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
