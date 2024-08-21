// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class UnifiedRoleAssignmentScheduleRequest : global::Microsoft.Graph.Models.Request, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the type of the operation on the role assignment request. The possible values are: adminAssign, adminUpdate, adminRemove, selfActivate, selfDeactivate, adminExtend, adminRenew, selfExtend, selfRenew, unknownFutureValue. adminAssign: For administrators to assign roles to principals.adminRemove: For administrators to remove principals from roles. adminUpdate: For administrators to change existing role assignments.adminExtend: For administrators to extend expiring assignments.adminRenew: For administrators to renew expired assignments.selfActivate: For principals to activate their assignments.selfDeactivate: For principals to deactivate their active assignments.selfExtend: For principals to request to extend their expiring assignments.selfRenew: For principals to request to renew their expired assignments.</summary>
        public global::Microsoft.Graph.Models.UnifiedRoleScheduleRequestActions? Action
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UnifiedRoleScheduleRequestActions?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation. Otherwise, it&apos;s null. Supports $expand and $select nested in $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule? ActivatedUsing
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule?>("activatedUsing"); }
            set { BackingStore?.Set("activatedUsing", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule ActivatedUsing
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule>("activatedUsing"); }
            set { BackingStore?.Set("activatedUsing", value); }
        }
#endif
        /// <summary>Read-only property with details of the app-specific scope when the assignment is scoped to an app. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AppScope? AppScope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AppScope?>("appScope"); }
            set { BackingStore?.Set("appScope", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AppScope AppScope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AppScope>("appScope"); }
            set { BackingStore?.Set("appScope", value); }
        }
#endif
        /// <summary>Identifier of the app-specific scope when the assignment is scoped to an app. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units. Supports $filter (eq, ne, and on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppScopeId
        {
            get { return BackingStore?.Get<string?>("appScopeId"); }
            set { BackingStore?.Set("appScopeId", value); }
        }
#nullable restore
#else
        public string AppScopeId
        {
            get { return BackingStore?.Get<string>("appScopeId"); }
            set { BackingStore?.Set("appScopeId", value); }
        }
#endif
        /// <summary>The directory object that is the scope of the assignment. Read-only. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DirectoryObject? DirectoryScope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DirectoryObject?>("directoryScope"); }
            set { BackingStore?.Set("directoryScope", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DirectoryObject DirectoryScope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DirectoryObject>("directoryScope"); }
            set { BackingStore?.Set("directoryScope", value); }
        }
#endif
        /// <summary>Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only. Supports $filter (eq, ne, and on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DirectoryScopeId
        {
            get { return BackingStore?.Get<string?>("directoryScopeId"); }
            set { BackingStore?.Set("directoryScopeId", value); }
        }
#nullable restore
#else
        public string DirectoryScopeId
        {
            get { return BackingStore?.Get<string>("directoryScopeId"); }
            set { BackingStore?.Set("directoryScopeId", value); }
        }
#endif
        /// <summary>Determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.</summary>
        public bool? IsValidationOnly
        {
            get { return BackingStore?.Get<bool?>("isValidationOnly"); }
            set { BackingStore?.Set("isValidationOnly", value); }
        }
        /// <summary>A message provided by users and administrators when create they create the unifiedRoleAssignmentScheduleRequest object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification
        {
            get { return BackingStore?.Get<string?>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#nullable restore
#else
        public string Justification
        {
            get { return BackingStore?.Get<string>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#endif
        /// <summary>The principal that&apos;s getting a role assignment through the request. Supports $expand and $select nested in $expand for id only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DirectoryObject? Principal
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DirectoryObject?>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DirectoryObject Principal
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DirectoryObject>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#endif
        /// <summary>Identifier of the principal that has been granted the assignment. Can be a user, role-assignable group, or a service principal. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalId
        {
            get { return BackingStore?.Get<string?>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#nullable restore
#else
        public string PrincipalId
        {
            get { return BackingStore?.Get<string>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#endif
        /// <summary>Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property. Supports $expand and $select nested in $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.UnifiedRoleDefinition? RoleDefinition
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UnifiedRoleDefinition?>("roleDefinition"); }
            set { BackingStore?.Set("roleDefinition", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.UnifiedRoleDefinition RoleDefinition
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UnifiedRoleDefinition>("roleDefinition"); }
            set { BackingStore?.Set("roleDefinition", value); }
        }
#endif
        /// <summary>Identifier of the unifiedRoleDefinition object that is being assigned to the principal. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDefinitionId
        {
            get { return BackingStore?.Get<string?>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#nullable restore
#else
        public string RoleDefinitionId
        {
            get { return BackingStore?.Get<string>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#endif
        /// <summary>The period of the role assignment. Recurring schedules are currently unsupported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.RequestSchedule? ScheduleInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RequestSchedule?>("scheduleInfo"); }
            set { BackingStore?.Set("scheduleInfo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.RequestSchedule ScheduleInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RequestSchedule>("scheduleInfo"); }
            set { BackingStore?.Set("scheduleInfo", value); }
        }
#endif
        /// <summary>The schedule for an eligible role assignment that is referenced through the targetScheduleId property. Supports $expand and $select nested in $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.UnifiedRoleAssignmentSchedule? TargetSchedule
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UnifiedRoleAssignmentSchedule?>("targetSchedule"); }
            set { BackingStore?.Set("targetSchedule", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.UnifiedRoleAssignmentSchedule TargetSchedule
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UnifiedRoleAssignmentSchedule>("targetSchedule"); }
            set { BackingStore?.Set("targetSchedule", value); }
        }
#endif
        /// <summary>Identifier of the schedule object that&apos;s linked to the assignment request. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetScheduleId
        {
            get { return BackingStore?.Get<string?>("targetScheduleId"); }
            set { BackingStore?.Set("targetScheduleId", value); }
        }
#nullable restore
#else
        public string TargetScheduleId
        {
            get { return BackingStore?.Get<string>("targetScheduleId"); }
            set { BackingStore?.Set("targetScheduleId", value); }
        }
#endif
        /// <summary>Ticket details linked to the role assignment request including details of the ticket number and ticket system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TicketInfo? TicketInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TicketInfo?>("ticketInfo"); }
            set { BackingStore?.Set("ticketInfo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TicketInfo TicketInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TicketInfo>("ticketInfo"); }
            set { BackingStore?.Set("ticketInfo", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "action", n => { Action = n.GetEnumValue<global::Microsoft.Graph.Models.UnifiedRoleScheduleRequestActions>(); } },
                { "activatedUsing", n => { ActivatedUsing = n.GetObjectValue<global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule>(global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule.CreateFromDiscriminatorValue); } },
                { "appScope", n => { AppScope = n.GetObjectValue<global::Microsoft.Graph.Models.AppScope>(global::Microsoft.Graph.Models.AppScope.CreateFromDiscriminatorValue); } },
                { "appScopeId", n => { AppScopeId = n.GetStringValue(); } },
                { "directoryScope", n => { DirectoryScope = n.GetObjectValue<global::Microsoft.Graph.Models.DirectoryObject>(global::Microsoft.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue); } },
                { "directoryScopeId", n => { DirectoryScopeId = n.GetStringValue(); } },
                { "isValidationOnly", n => { IsValidationOnly = n.GetBoolValue(); } },
                { "justification", n => { Justification = n.GetStringValue(); } },
                { "principal", n => { Principal = n.GetObjectValue<global::Microsoft.Graph.Models.DirectoryObject>(global::Microsoft.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue); } },
                { "principalId", n => { PrincipalId = n.GetStringValue(); } },
                { "roleDefinition", n => { RoleDefinition = n.GetObjectValue<global::Microsoft.Graph.Models.UnifiedRoleDefinition>(global::Microsoft.Graph.Models.UnifiedRoleDefinition.CreateFromDiscriminatorValue); } },
                { "roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                { "scheduleInfo", n => { ScheduleInfo = n.GetObjectValue<global::Microsoft.Graph.Models.RequestSchedule>(global::Microsoft.Graph.Models.RequestSchedule.CreateFromDiscriminatorValue); } },
                { "targetSchedule", n => { TargetSchedule = n.GetObjectValue<global::Microsoft.Graph.Models.UnifiedRoleAssignmentSchedule>(global::Microsoft.Graph.Models.UnifiedRoleAssignmentSchedule.CreateFromDiscriminatorValue); } },
                { "targetScheduleId", n => { TargetScheduleId = n.GetStringValue(); } },
                { "ticketInfo", n => { TicketInfo = n.GetObjectValue<global::Microsoft.Graph.Models.TicketInfo>(global::Microsoft.Graph.Models.TicketInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.UnifiedRoleScheduleRequestActions>("action", Action);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule>("activatedUsing", ActivatedUsing);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AppScope>("appScope", AppScope);
            writer.WriteStringValue("appScopeId", AppScopeId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DirectoryObject>("directoryScope", DirectoryScope);
            writer.WriteStringValue("directoryScopeId", DirectoryScopeId);
            writer.WriteBoolValue("isValidationOnly", IsValidationOnly);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.UnifiedRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.RequestSchedule>("scheduleInfo", ScheduleInfo);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.UnifiedRoleAssignmentSchedule>("targetSchedule", TargetSchedule);
            writer.WriteStringValue("targetScheduleId", TargetScheduleId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TicketInfo>("ticketInfo", TicketInfo);
        }
    }
}
