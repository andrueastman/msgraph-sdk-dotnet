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
    /// The type Unified Role Schedule Base.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UnifiedRoleScheduleBase>))]
    public partial class UnifiedRoleScheduleBase : Entity
    {
    
        /// <summary>
        /// Gets or sets app scope id.
        /// Identifier of the app-specific scope when the assignment or eligibility is scoped to an app. The scope of an assignment or eligibility determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.
        /// </summary>
        [JsonPropertyName("appScopeId")]
        public string AppScopeId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// When the schedule was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets created using.
        /// Identifier of the object through which this schedule was created.
        /// </summary>
        [JsonPropertyName("createdUsing")]
        public string CreatedUsing { get; set; }
    
        /// <summary>
        /// Gets or sets directory scope id.
        /// Identifier of the directory object representing the scope of the assignment or eligibility. The scope of an assignment or eligibility determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
        /// </summary>
        [JsonPropertyName("directoryScopeId")]
        public string DirectoryScopeId { get; set; }
    
        /// <summary>
        /// Gets or sets modified date time.
        /// When the schedule was last modified.
        /// </summary>
        [JsonPropertyName("modifiedDateTime")]
        public DateTimeOffset? ModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets principal id.
        /// Identifier of the principal that has been granted the role assignment or eligibility.
        /// </summary>
        [JsonPropertyName("principalId")]
        public string PrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets role definition id.
        /// Identifier of the unifiedRoleDefinition object that is being assigned to the principal or that a principal is eligible for.
        /// </summary>
        [JsonPropertyName("roleDefinitionId")]
        public string RoleDefinitionId { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The status of the role assignment or eligibility request.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets app scope.
        /// Read-only property with details of the app-specific scope when the role eligibility or assignment is scoped to an app. Nullable.
        /// </summary>
        [JsonPropertyName("appScope")]
        public AppScope AppScope { get; set; }
    
        /// <summary>
        /// Gets or sets directory scope.
        /// The directory object that is the scope of the role eligibility or assignment. Read-only.
        /// </summary>
        [JsonPropertyName("directoryScope")]
        public DirectoryObject DirectoryScope { get; set; }
    
        /// <summary>
        /// Gets or sets principal.
        /// The principal that's getting a role assignment or that's eligible for a role through the request.
        /// </summary>
        [JsonPropertyName("principal")]
        public DirectoryObject Principal { get; set; }
    
        /// <summary>
        /// Gets or sets role definition.
        /// Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.
        /// </summary>
        [JsonPropertyName("roleDefinition")]
        public UnifiedRoleDefinition RoleDefinition { get; set; }
    
    }
}
