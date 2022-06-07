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
    /// The type Unified Role Assignment Schedule Request.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UnifiedRoleAssignmentScheduleRequestObject>))]
    public partial class UnifiedRoleAssignmentScheduleRequestObject : RequestObject
    {
    
        /// <summary>
        /// Gets or sets action.
        /// Represents the type of the operation on the role assignment request. The possible values are: adminAssign, adminUpdate, adminRemove, selfActivate, selfDeactivate, adminExtend, adminRenew, selfExtend, selfRenew, unknownFutureValue. adminAssign: For administrators to assign roles to principals.adminRemove: For administrators to remove principals from roles. adminUpdate: For administrators to change existing role assignments.adminExtend: For administrators to extend expiring assignments.adminRenew: For administrators to renew expired assignments.selfActivate: For principals to activate their assignments.selfDeactivate: For principals to deactivate their active assignments.selfExtend: For principals to request to extend their expiring assignments.selfRenew: For principals to request to renew their expired assignments.
        /// </summary>
        [JsonPropertyName("action")]
        public UnifiedRoleScheduleRequestActions? Action { get; set; }
    
        /// <summary>
        /// Gets or sets app scope id.
        /// Identifier of the app-specific scope when the assignment is scoped to an app. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units. Supports $filter (eq, ne, and on null values).
        /// </summary>
        [JsonPropertyName("appScopeId")]
        public string AppScopeId { get; set; }
    
        /// <summary>
        /// Gets or sets directory scope id.
        /// Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only. Supports $filter (eq, ne, and on null values).
        /// </summary>
        [JsonPropertyName("directoryScopeId")]
        public string DirectoryScopeId { get; set; }
    
        /// <summary>
        /// Gets or sets is validation only.
        /// Determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.
        /// </summary>
        [JsonPropertyName("isValidationOnly")]
        public bool? IsValidationOnly { get; set; }
    
        /// <summary>
        /// Gets or sets justification.
        /// A message provided by users and administrators when create they create the unifiedRoleAssignmentScheduleRequest object.
        /// </summary>
        [JsonPropertyName("justification")]
        public string Justification { get; set; }
    
        /// <summary>
        /// Gets or sets principal id.
        /// Identifier of the principal that has been granted the assignment. Supports $filter (eq, ne).
        /// </summary>
        [JsonPropertyName("principalId")]
        public string PrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets role definition id.
        /// Identifier of the unifiedRoleDefinition object that is being assigned to the principal. Supports $filter (eq, ne).
        /// </summary>
        [JsonPropertyName("roleDefinitionId")]
        public string RoleDefinitionId { get; set; }
    
        /// <summary>
        /// Gets or sets schedule info.
        /// The period of the role assignment. Recurring schedules are currently unsupported.
        /// </summary>
        [JsonPropertyName("scheduleInfo")]
        public RequestSchedule ScheduleInfo { get; set; }
    
        /// <summary>
        /// Gets or sets target schedule id.
        /// Identifier of the schedule object that's linked to the assignment request. Supports $filter (eq, ne).
        /// </summary>
        [JsonPropertyName("targetScheduleId")]
        public string TargetScheduleId { get; set; }
    
        /// <summary>
        /// Gets or sets ticket info.
        /// Ticket details linked to the role assignment request including details of the ticket number and ticket system.
        /// </summary>
        [JsonPropertyName("ticketInfo")]
        public TicketInfo TicketInfo { get; set; }
    
        /// <summary>
        /// Gets or sets activated using.
        /// If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation. Otherwise, it's null. Supports $expand.
        /// </summary>
        [JsonPropertyName("activatedUsing")]
        public UnifiedRoleEligibilitySchedule ActivatedUsing { get; set; }
    
        /// <summary>
        /// Gets or sets app scope.
        /// Read-only property with details of the app-specific scope when the assignment is scoped to an app. Nullable. Supports $expand.
        /// </summary>
        [JsonPropertyName("appScope")]
        public AppScope AppScope { get; set; }
    
        /// <summary>
        /// Gets or sets directory scope.
        /// The directory object that is the scope of the assignment. Read-only. Supports $expand.
        /// </summary>
        [JsonPropertyName("directoryScope")]
        public DirectoryObject DirectoryScope { get; set; }
    
        /// <summary>
        /// Gets or sets principal.
        /// The principal that's getting a role assignment through the request. Supports $expand.
        /// </summary>
        [JsonPropertyName("principal")]
        public DirectoryObject Principal { get; set; }
    
        /// <summary>
        /// Gets or sets role definition.
        /// Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property. Supports $expand.
        /// </summary>
        [JsonPropertyName("roleDefinition")]
        public UnifiedRoleDefinition RoleDefinition { get; set; }
    
        /// <summary>
        /// Gets or sets target schedule.
        /// The schedule for an eligible role assignment that is referenced through the targetScheduleId property. Supports $expand.
        /// </summary>
        [JsonPropertyName("targetSchedule")]
        public UnifiedRoleAssignmentSchedule TargetSchedule { get; set; }
    
    }
}

