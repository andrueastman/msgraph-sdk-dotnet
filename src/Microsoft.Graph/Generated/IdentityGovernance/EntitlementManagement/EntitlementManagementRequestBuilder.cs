// <auto-generated/>
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentApprovals;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackages;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.AssignmentPolicies;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.AssignmentRequests;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.Assignments;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.Catalogs;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.ConnectedOrganizations;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceEnvironments;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRoleScopes;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.Resources;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement.Settings;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.IdentityGovernance.EntitlementManagement
{
    /// <summary>
    /// Provides operations to manage the entitlementManagement property of the microsoft.graph.identityGovernance entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class EntitlementManagementRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the accessPackageAssignmentApprovals property of the microsoft.graph.entitlementManagement entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentApprovals.AccessPackageAssignmentApprovalsRequestBuilder AccessPackageAssignmentApprovals
        {
            get => new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentApprovals.AccessPackageAssignmentApprovalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the accessPackages property of the microsoft.graph.entitlementManagement entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackages.AccessPackagesRequestBuilder AccessPackages
        {
            get => new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackages.AccessPackagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the assignmentPolicies property of the microsoft.graph.entitlementManagement entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.AssignmentPolicies.AssignmentPoliciesRequestBuilder AssignmentPolicies
        {
            get => new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.AssignmentPolicies.AssignmentPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the assignmentRequests property of the microsoft.graph.entitlementManagement entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.AssignmentRequests.AssignmentRequestsRequestBuilder AssignmentRequests
        {
            get => new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.AssignmentRequests.AssignmentRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the assignments property of the microsoft.graph.entitlementManagement entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.Assignments.AssignmentsRequestBuilder Assignments
        {
            get => new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.Assignments.AssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the catalogs property of the microsoft.graph.entitlementManagement entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.Catalogs.CatalogsRequestBuilder Catalogs
        {
            get => new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.Catalogs.CatalogsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the connectedOrganizations property of the microsoft.graph.entitlementManagement entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ConnectedOrganizations.ConnectedOrganizationsRequestBuilder ConnectedOrganizations
        {
            get => new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ConnectedOrganizations.ConnectedOrganizationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the resourceEnvironments property of the microsoft.graph.entitlementManagement entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceEnvironments.ResourceEnvironmentsRequestBuilder ResourceEnvironments
        {
            get => new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceEnvironments.ResourceEnvironmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the resourceRequests property of the microsoft.graph.entitlementManagement entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.ResourceRequestsRequestBuilder ResourceRequests
        {
            get => new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRequests.ResourceRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the resourceRoleScopes property of the microsoft.graph.entitlementManagement entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRoleScopes.ResourceRoleScopesRequestBuilder ResourceRoleScopes
        {
            get => new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.ResourceRoleScopes.ResourceRoleScopesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the resources property of the microsoft.graph.entitlementManagement entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.Resources.ResourcesRequestBuilder Resources
        {
            get => new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.Resources.ResourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the settings property of the microsoft.graph.entitlementManagement entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.Settings.SettingsRequestBuilder Settings
        {
            get => new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.Settings.SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.EntitlementManagementRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EntitlementManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.EntitlementManagementRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EntitlementManagementRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property entitlementManagement for identityGovernance
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get entitlementManagement from identityGovernance
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.EntitlementManagement"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.EntitlementManagement?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.EntitlementManagementRequestBuilder.EntitlementManagementRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.EntitlementManagement> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.EntitlementManagementRequestBuilder.EntitlementManagementRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.EntitlementManagement>(requestInfo, global::Microsoft.Graph.Models.EntitlementManagement.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property entitlementManagement in identityGovernance
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.EntitlementManagement"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.EntitlementManagement?> PatchAsync(global::Microsoft.Graph.Models.EntitlementManagement body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.EntitlementManagement> PatchAsync(global::Microsoft.Graph.Models.EntitlementManagement body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.EntitlementManagement>(requestInfo, global::Microsoft.Graph.Models.EntitlementManagement.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property entitlementManagement for identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get entitlementManagement from identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.EntitlementManagementRequestBuilder.EntitlementManagementRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.EntitlementManagementRequestBuilder.EntitlementManagementRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property entitlementManagement in identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.EntitlementManagement body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.EntitlementManagement body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.EntitlementManagementRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.EntitlementManagementRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.EntitlementManagementRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class EntitlementManagementRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Get entitlementManagement from identityGovernance
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class EntitlementManagementRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class EntitlementManagementRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.EntitlementManagement.EntitlementManagementRequestBuilder.EntitlementManagementRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class EntitlementManagementRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
