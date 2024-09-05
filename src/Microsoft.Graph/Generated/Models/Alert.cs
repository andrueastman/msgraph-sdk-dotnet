// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class Alert : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Name or alias of the activity group (attacker) this alert is attributed to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityGroupName
        {
            get { return BackingStore?.Get<string?>("activityGroupName"); }
            set { BackingStore?.Set("activityGroupName", value); }
        }
#nullable restore
#else
        public string ActivityGroupName
        {
            get { return BackingStore?.Get<string>("activityGroupName"); }
            set { BackingStore?.Set("activityGroupName", value); }
        }
#endif
        /// <summary>The alertDetections property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AlertDetection>? AlertDetections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AlertDetection>?>("alertDetections"); }
            set { BackingStore?.Set("alertDetections", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AlertDetection> AlertDetections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AlertDetection>>("alertDetections"); }
            set { BackingStore?.Set("alertDetections", value); }
        }
#endif
        /// <summary>Name of the analyst the alert is assigned to for triage, investigation, or remediation (supports update).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedTo
        {
            get { return BackingStore?.Get<string?>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
#nullable restore
#else
        public string AssignedTo
        {
            get { return BackingStore?.Get<string>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
#endif
        /// <summary>Azure subscription ID, present if this alert is related to an Azure resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureSubscriptionId
        {
            get { return BackingStore?.Get<string?>("azureSubscriptionId"); }
            set { BackingStore?.Set("azureSubscriptionId", value); }
        }
#nullable restore
#else
        public string AzureSubscriptionId
        {
            get { return BackingStore?.Get<string>("azureSubscriptionId"); }
            set { BackingStore?.Set("azureSubscriptionId", value); }
        }
#endif
        /// <summary>Microsoft Entra tenant ID. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureTenantId
        {
            get { return BackingStore?.Get<string?>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
#nullable restore
#else
        public string AzureTenantId
        {
            get { return BackingStore?.Get<string>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
#endif
        /// <summary>Category of the alert (for example, credentialTheft, ransomware).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category
        {
            get { return BackingStore?.Get<string?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#nullable restore
#else
        public string Category
        {
            get { return BackingStore?.Get<string>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#endif
        /// <summary>Time at which the alert was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z (supports update).</summary>
        public DateTimeOffset? ClosedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("closedDateTime"); }
            set { BackingStore?.Set("closedDateTime", value); }
        }
        /// <summary>Security-related stateful information generated by the provider about the cloud application/s related to this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.CloudAppSecurityState>? CloudAppStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CloudAppSecurityState>?>("cloudAppStates"); }
            set { BackingStore?.Set("cloudAppStates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.CloudAppSecurityState> CloudAppStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CloudAppSecurityState>>("cloudAppStates"); }
            set { BackingStore?.Set("cloudAppStates", value); }
        }
#endif
        /// <summary>Customer-provided comments on alert (for customer alert management) (supports update).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Comments
        {
            get { return BackingStore?.Get<List<string>?>("comments"); }
            set { BackingStore?.Set("comments", value); }
        }
#nullable restore
#else
        public List<string> Comments
        {
            get { return BackingStore?.Get<List<string>>("comments"); }
            set { BackingStore?.Set("comments", value); }
        }
#endif
        /// <summary>Confidence of the detection logic (percentage between 1-100).</summary>
        public int? Confidence
        {
            get { return BackingStore?.Get<int?>("confidence"); }
            set { BackingStore?.Set("confidence", value); }
        }
        /// <summary>Time at which the alert was created by the alert provider. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Alert description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Set of alerts related to this alert entity (each alert is pushed to the SIEM as a separate record).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DetectionIds
        {
            get { return BackingStore?.Get<List<string>?>("detectionIds"); }
            set { BackingStore?.Set("detectionIds", value); }
        }
#nullable restore
#else
        public List<string> DetectionIds
        {
            get { return BackingStore?.Get<List<string>>("detectionIds"); }
            set { BackingStore?.Set("detectionIds", value); }
        }
#endif
        /// <summary>Time at which the event or events that served as the trigger to generate the alert occurred. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.</summary>
        public DateTimeOffset? EventDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("eventDateTime"); }
            set { BackingStore?.Set("eventDateTime", value); }
        }
        /// <summary>Analyst feedback on the alert. Possible values are: unknown, truePositive, falsePositive, benignPositive. Supports update.</summary>
        public global::Microsoft.Graph.Models.AlertFeedback? Feedback
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AlertFeedback?>("feedback"); }
            set { BackingStore?.Set("feedback", value); }
        }
        /// <summary>Security-related stateful information generated by the provider about the file(s) related to this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.FileSecurityState>? FileStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.FileSecurityState>?>("fileStates"); }
            set { BackingStore?.Set("fileStates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.FileSecurityState> FileStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.FileSecurityState>>("fileStates"); }
            set { BackingStore?.Set("fileStates", value); }
        }
#endif
        /// <summary>The historyStates property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AlertHistoryState>? HistoryStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AlertHistoryState>?>("historyStates"); }
            set { BackingStore?.Set("historyStates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AlertHistoryState> HistoryStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AlertHistoryState>>("historyStates"); }
            set { BackingStore?.Set("historyStates", value); }
        }
#endif
        /// <summary>Security-related stateful information generated by the provider about the host(s) related to this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.HostSecurityState>? HostStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.HostSecurityState>?>("hostStates"); }
            set { BackingStore?.Set("hostStates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.HostSecurityState> HostStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.HostSecurityState>>("hostStates"); }
            set { BackingStore?.Set("hostStates", value); }
        }
#endif
        /// <summary>IDs of incidents related to current alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IncidentIds
        {
            get { return BackingStore?.Get<List<string>?>("incidentIds"); }
            set { BackingStore?.Set("incidentIds", value); }
        }
#nullable restore
#else
        public List<string> IncidentIds
        {
            get { return BackingStore?.Get<List<string>>("incidentIds"); }
            set { BackingStore?.Set("incidentIds", value); }
        }
#endif
        /// <summary>The investigationSecurityStates property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.InvestigationSecurityState>? InvestigationSecurityStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.InvestigationSecurityState>?>("investigationSecurityStates"); }
            set { BackingStore?.Set("investigationSecurityStates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.InvestigationSecurityState> InvestigationSecurityStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.InvestigationSecurityState>>("investigationSecurityStates"); }
            set { BackingStore?.Set("investigationSecurityStates", value); }
        }
#endif
        /// <summary>The lastEventDateTime property</summary>
        public DateTimeOffset? LastEventDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastEventDateTime"); }
            set { BackingStore?.Set("lastEventDateTime", value); }
        }
        /// <summary>Time at which the alert entity was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Threat Intelligence pertaining to malware related to this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.MalwareState>? MalwareStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MalwareState>?>("malwareStates"); }
            set { BackingStore?.Set("malwareStates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.MalwareState> MalwareStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MalwareState>>("malwareStates"); }
            set { BackingStore?.Set("malwareStates", value); }
        }
#endif
        /// <summary>The messageSecurityStates property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.MessageSecurityState>? MessageSecurityStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MessageSecurityState>?>("messageSecurityStates"); }
            set { BackingStore?.Set("messageSecurityStates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.MessageSecurityState> MessageSecurityStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MessageSecurityState>>("messageSecurityStates"); }
            set { BackingStore?.Set("messageSecurityStates", value); }
        }
#endif
        /// <summary>Security-related stateful information generated by the provider about the network connection(s) related to this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.NetworkConnection>? NetworkConnections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.NetworkConnection>?>("networkConnections"); }
            set { BackingStore?.Set("networkConnections", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.NetworkConnection> NetworkConnections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.NetworkConnection>>("networkConnections"); }
            set { BackingStore?.Set("networkConnections", value); }
        }
#endif
        /// <summary>Security-related stateful information generated by the provider about the process or processes related to this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Process>? Processes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Process>?>("processes"); }
            set { BackingStore?.Set("processes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Process> Processes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Process>>("processes"); }
            set { BackingStore?.Set("processes", value); }
        }
#endif
        /// <summary>Vendor/provider recommended action(s) to take as a result of the alert (for example, isolate machine, enforce2FA, reimage host).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RecommendedActions
        {
            get { return BackingStore?.Get<List<string>?>("recommendedActions"); }
            set { BackingStore?.Set("recommendedActions", value); }
        }
#nullable restore
#else
        public List<string> RecommendedActions
        {
            get { return BackingStore?.Get<List<string>>("recommendedActions"); }
            set { BackingStore?.Set("recommendedActions", value); }
        }
#endif
        /// <summary>Security-related stateful information generated by the provider about the registry keys related to this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.RegistryKeyState>? RegistryKeyStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RegistryKeyState>?>("registryKeyStates"); }
            set { BackingStore?.Set("registryKeyStates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.RegistryKeyState> RegistryKeyStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RegistryKeyState>>("registryKeyStates"); }
            set { BackingStore?.Set("registryKeyStates", value); }
        }
#endif
        /// <summary>Resources related to current alert. For example, for some alerts this can have the Azure Resource value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SecurityResource>? SecurityResources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SecurityResource>?>("securityResources"); }
            set { BackingStore?.Set("securityResources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SecurityResource> SecurityResources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SecurityResource>>("securityResources"); }
            set { BackingStore?.Set("securityResources", value); }
        }
#endif
        /// <summary>The severity property</summary>
        public global::Microsoft.Graph.Models.AlertSeverity? Severity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AlertSeverity?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>Hyperlinks (URIs) to the source material related to the alert, for example, provider&apos;s user interface for alerts or log search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SourceMaterials
        {
            get { return BackingStore?.Get<List<string>?>("sourceMaterials"); }
            set { BackingStore?.Set("sourceMaterials", value); }
        }
#nullable restore
#else
        public List<string> SourceMaterials
        {
            get { return BackingStore?.Get<List<string>>("sourceMaterials"); }
            set { BackingStore?.Set("sourceMaterials", value); }
        }
#endif
        /// <summary>The status property</summary>
        public global::Microsoft.Graph.Models.AlertStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AlertStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>User-definable labels that can be applied to an alert and can serve as filter conditions (for example &apos;HVA&apos;, &apos;SAW&apos;) (supports update).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags
        {
            get { return BackingStore?.Get<List<string>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<string> Tags
        {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>Alert title. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title
        {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title
        {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>Security-related information about the specific properties that triggered the alert (properties appearing in the alert). Alerts might contain information about multiple users, hosts, files, ip addresses. This field indicates which properties triggered the alert generation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AlertTrigger>? Triggers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AlertTrigger>?>("triggers"); }
            set { BackingStore?.Set("triggers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AlertTrigger> Triggers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AlertTrigger>>("triggers"); }
            set { BackingStore?.Set("triggers", value); }
        }
#endif
        /// <summary>The uriClickSecurityStates property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.UriClickSecurityState>? UriClickSecurityStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.UriClickSecurityState>?>("uriClickSecurityStates"); }
            set { BackingStore?.Set("uriClickSecurityStates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.UriClickSecurityState> UriClickSecurityStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.UriClickSecurityState>>("uriClickSecurityStates"); }
            set { BackingStore?.Set("uriClickSecurityStates", value); }
        }
#endif
        /// <summary>Security-related stateful information generated by the provider about the user accounts related to this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.UserSecurityState>? UserStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.UserSecurityState>?>("userStates"); }
            set { BackingStore?.Set("userStates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.UserSecurityState> UserStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.UserSecurityState>>("userStates"); }
            set { BackingStore?.Set("userStates", value); }
        }
#endif
        /// <summary>Complex type containing details about the security product/service vendor, provider, and subprovider (for example, vendor=Microsoft; provider=Windows Defender ATP; subProvider=AppLocker). Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SecurityVendorInformation? VendorInformation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SecurityVendorInformation?>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SecurityVendorInformation VendorInformation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SecurityVendorInformation>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
#endif
        /// <summary>Threat intelligence pertaining to one or more vulnerabilities related to this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.VulnerabilityState>? VulnerabilityStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.VulnerabilityState>?>("vulnerabilityStates"); }
            set { BackingStore?.Set("vulnerabilityStates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.VulnerabilityState> VulnerabilityStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.VulnerabilityState>>("vulnerabilityStates"); }
            set { BackingStore?.Set("vulnerabilityStates", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Alert"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Alert CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Alert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activityGroupName", n => { ActivityGroupName = n.GetStringValue(); } },
                { "alertDetections", n => { AlertDetections = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AlertDetection>(global::Microsoft.Graph.Models.AlertDetection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                { "azureSubscriptionId", n => { AzureSubscriptionId = n.GetStringValue(); } },
                { "azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                { "category", n => { Category = n.GetStringValue(); } },
                { "closedDateTime", n => { ClosedDateTime = n.GetDateTimeOffsetValue(); } },
                { "cloudAppStates", n => { CloudAppStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.CloudAppSecurityState>(global::Microsoft.Graph.Models.CloudAppSecurityState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "comments", n => { Comments = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "confidence", n => { Confidence = n.GetIntValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "detectionIds", n => { DetectionIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                { "feedback", n => { Feedback = n.GetEnumValue<global::Microsoft.Graph.Models.AlertFeedback>(); } },
                { "fileStates", n => { FileStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.FileSecurityState>(global::Microsoft.Graph.Models.FileSecurityState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "historyStates", n => { HistoryStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AlertHistoryState>(global::Microsoft.Graph.Models.AlertHistoryState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hostStates", n => { HostStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.HostSecurityState>(global::Microsoft.Graph.Models.HostSecurityState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "incidentIds", n => { IncidentIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "investigationSecurityStates", n => { InvestigationSecurityStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.InvestigationSecurityState>(global::Microsoft.Graph.Models.InvestigationSecurityState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lastEventDateTime", n => { LastEventDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "malwareStates", n => { MalwareStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.MalwareState>(global::Microsoft.Graph.Models.MalwareState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "messageSecurityStates", n => { MessageSecurityStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.MessageSecurityState>(global::Microsoft.Graph.Models.MessageSecurityState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "networkConnections", n => { NetworkConnections = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.NetworkConnection>(global::Microsoft.Graph.Models.NetworkConnection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "processes", n => { Processes = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Process>(global::Microsoft.Graph.Models.Process.CreateFromDiscriminatorValue)?.AsList(); } },
                { "recommendedActions", n => { RecommendedActions = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "registryKeyStates", n => { RegistryKeyStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.RegistryKeyState>(global::Microsoft.Graph.Models.RegistryKeyState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "securityResources", n => { SecurityResources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SecurityResource>(global::Microsoft.Graph.Models.SecurityResource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "severity", n => { Severity = n.GetEnumValue<global::Microsoft.Graph.Models.AlertSeverity>(); } },
                { "sourceMaterials", n => { SourceMaterials = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Models.AlertStatus>(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "triggers", n => { Triggers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AlertTrigger>(global::Microsoft.Graph.Models.AlertTrigger.CreateFromDiscriminatorValue)?.AsList(); } },
                { "uriClickSecurityStates", n => { UriClickSecurityStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.UriClickSecurityState>(global::Microsoft.Graph.Models.UriClickSecurityState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userStates", n => { UserStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.UserSecurityState>(global::Microsoft.Graph.Models.UserSecurityState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "vendorInformation", n => { VendorInformation = n.GetObjectValue<global::Microsoft.Graph.Models.SecurityVendorInformation>(global::Microsoft.Graph.Models.SecurityVendorInformation.CreateFromDiscriminatorValue); } },
                { "vulnerabilityStates", n => { VulnerabilityStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.VulnerabilityState>(global::Microsoft.Graph.Models.VulnerabilityState.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteStringValue("activityGroupName", ActivityGroupName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AlertDetection>("alertDetections", AlertDetections);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteStringValue("category", Category);
            writer.WriteDateTimeOffsetValue("closedDateTime", ClosedDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.CloudAppSecurityState>("cloudAppStates", CloudAppStates);
            writer.WriteCollectionOfPrimitiveValues<string>("comments", Comments);
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfPrimitiveValues<string>("detectionIds", DetectionIds);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.AlertFeedback>("feedback", Feedback);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.FileSecurityState>("fileStates", FileStates);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AlertHistoryState>("historyStates", HistoryStates);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.HostSecurityState>("hostStates", HostStates);
            writer.WriteCollectionOfPrimitiveValues<string>("incidentIds", IncidentIds);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.InvestigationSecurityState>("investigationSecurityStates", InvestigationSecurityStates);
            writer.WriteDateTimeOffsetValue("lastEventDateTime", LastEventDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.MalwareState>("malwareStates", MalwareStates);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.MessageSecurityState>("messageSecurityStates", MessageSecurityStates);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.NetworkConnection>("networkConnections", NetworkConnections);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Process>("processes", Processes);
            writer.WriteCollectionOfPrimitiveValues<string>("recommendedActions", RecommendedActions);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.RegistryKeyState>("registryKeyStates", RegistryKeyStates);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SecurityResource>("securityResources", SecurityResources);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.AlertSeverity>("severity", Severity);
            writer.WriteCollectionOfPrimitiveValues<string>("sourceMaterials", SourceMaterials);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.AlertStatus>("status", Status);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("title", Title);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AlertTrigger>("triggers", Triggers);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.UriClickSecurityState>("uriClickSecurityStates", UriClickSecurityStates);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.UserSecurityState>("userStates", UserStates);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SecurityVendorInformation>("vendorInformation", VendorInformation);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.VulnerabilityState>("vulnerabilityStates", VulnerabilityStates);
        }
    }
}
#pragma warning restore CS0618
