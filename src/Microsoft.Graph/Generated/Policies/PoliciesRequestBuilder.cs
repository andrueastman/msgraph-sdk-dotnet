// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.Policies.ActivityBasedTimeoutPolicies;
using Microsoft.Graph.Policies.AdminConsentRequestPolicy;
using Microsoft.Graph.Policies.AppManagementPolicies;
using Microsoft.Graph.Policies.AuthenticationFlowsPolicy;
using Microsoft.Graph.Policies.AuthenticationMethodsPolicy;
using Microsoft.Graph.Policies.AuthenticationStrengthPolicies;
using Microsoft.Graph.Policies.AuthorizationPolicy;
using Microsoft.Graph.Policies.ClaimsMappingPolicies;
using Microsoft.Graph.Policies.ConditionalAccessPolicies;
using Microsoft.Graph.Policies.CrossTenantAccessPolicy;
using Microsoft.Graph.Policies.DefaultAppManagementPolicy;
using Microsoft.Graph.Policies.DeviceRegistrationPolicy;
using Microsoft.Graph.Policies.FeatureRolloutPolicies;
using Microsoft.Graph.Policies.HomeRealmDiscoveryPolicies;
using Microsoft.Graph.Policies.IdentitySecurityDefaultsEnforcementPolicy;
using Microsoft.Graph.Policies.PermissionGrantPolicies;
using Microsoft.Graph.Policies.RoleManagementPolicies;
using Microsoft.Graph.Policies.RoleManagementPolicyAssignments;
using Microsoft.Graph.Policies.TokenIssuancePolicies;
using Microsoft.Graph.Policies.TokenLifetimePolicies;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Policies
{
    /// <summary>
    /// Provides operations to manage the policyRoot singleton.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class PoliciesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the activityBasedTimeoutPolicies property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.ActivityBasedTimeoutPolicies.ActivityBasedTimeoutPoliciesRequestBuilder ActivityBasedTimeoutPolicies
        {
            get => new global::Microsoft.Graph.Policies.ActivityBasedTimeoutPolicies.ActivityBasedTimeoutPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the adminConsentRequestPolicy property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.AdminConsentRequestPolicy.AdminConsentRequestPolicyRequestBuilder AdminConsentRequestPolicy
        {
            get => new global::Microsoft.Graph.Policies.AdminConsentRequestPolicy.AdminConsentRequestPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appManagementPolicies property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.AppManagementPolicies.AppManagementPoliciesRequestBuilder AppManagementPolicies
        {
            get => new global::Microsoft.Graph.Policies.AppManagementPolicies.AppManagementPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the authenticationFlowsPolicy property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.AuthenticationFlowsPolicy.AuthenticationFlowsPolicyRequestBuilder AuthenticationFlowsPolicy
        {
            get => new global::Microsoft.Graph.Policies.AuthenticationFlowsPolicy.AuthenticationFlowsPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the authenticationMethodsPolicy property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.AuthenticationMethodsPolicy.AuthenticationMethodsPolicyRequestBuilder AuthenticationMethodsPolicy
        {
            get => new global::Microsoft.Graph.Policies.AuthenticationMethodsPolicy.AuthenticationMethodsPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the authenticationStrengthPolicies property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.AuthenticationStrengthPolicies.AuthenticationStrengthPoliciesRequestBuilder AuthenticationStrengthPolicies
        {
            get => new global::Microsoft.Graph.Policies.AuthenticationStrengthPolicies.AuthenticationStrengthPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the authorizationPolicy property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.AuthorizationPolicy.AuthorizationPolicyRequestBuilder AuthorizationPolicy
        {
            get => new global::Microsoft.Graph.Policies.AuthorizationPolicy.AuthorizationPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the claimsMappingPolicies property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.ClaimsMappingPolicies.ClaimsMappingPoliciesRequestBuilder ClaimsMappingPolicies
        {
            get => new global::Microsoft.Graph.Policies.ClaimsMappingPolicies.ClaimsMappingPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the conditionalAccessPolicies property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.ConditionalAccessPolicies.ConditionalAccessPoliciesRequestBuilder ConditionalAccessPolicies
        {
            get => new global::Microsoft.Graph.Policies.ConditionalAccessPolicies.ConditionalAccessPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the crossTenantAccessPolicy property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.CrossTenantAccessPolicy.CrossTenantAccessPolicyRequestBuilder CrossTenantAccessPolicy
        {
            get => new global::Microsoft.Graph.Policies.CrossTenantAccessPolicy.CrossTenantAccessPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the defaultAppManagementPolicy property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.DefaultAppManagementPolicy.DefaultAppManagementPolicyRequestBuilder DefaultAppManagementPolicy
        {
            get => new global::Microsoft.Graph.Policies.DefaultAppManagementPolicy.DefaultAppManagementPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceRegistrationPolicy property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.DeviceRegistrationPolicy.DeviceRegistrationPolicyRequestBuilder DeviceRegistrationPolicy
        {
            get => new global::Microsoft.Graph.Policies.DeviceRegistrationPolicy.DeviceRegistrationPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the featureRolloutPolicies property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.FeatureRolloutPolicies.FeatureRolloutPoliciesRequestBuilder FeatureRolloutPolicies
        {
            get => new global::Microsoft.Graph.Policies.FeatureRolloutPolicies.FeatureRolloutPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the homeRealmDiscoveryPolicies property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.HomeRealmDiscoveryPolicies.HomeRealmDiscoveryPoliciesRequestBuilder HomeRealmDiscoveryPolicies
        {
            get => new global::Microsoft.Graph.Policies.HomeRealmDiscoveryPolicies.HomeRealmDiscoveryPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the identitySecurityDefaultsEnforcementPolicy property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.IdentitySecurityDefaultsEnforcementPolicy.IdentitySecurityDefaultsEnforcementPolicyRequestBuilder IdentitySecurityDefaultsEnforcementPolicy
        {
            get => new global::Microsoft.Graph.Policies.IdentitySecurityDefaultsEnforcementPolicy.IdentitySecurityDefaultsEnforcementPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the permissionGrantPolicies property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.PermissionGrantPolicies.PermissionGrantPoliciesRequestBuilder PermissionGrantPolicies
        {
            get => new global::Microsoft.Graph.Policies.PermissionGrantPolicies.PermissionGrantPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleManagementPolicies property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.RoleManagementPolicies.RoleManagementPoliciesRequestBuilder RoleManagementPolicies
        {
            get => new global::Microsoft.Graph.Policies.RoleManagementPolicies.RoleManagementPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleManagementPolicyAssignments property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.RoleManagementPolicyAssignments.RoleManagementPolicyAssignmentsRequestBuilder RoleManagementPolicyAssignments
        {
            get => new global::Microsoft.Graph.Policies.RoleManagementPolicyAssignments.RoleManagementPolicyAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tokenIssuancePolicies property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder TokenIssuancePolicies
        {
            get => new global::Microsoft.Graph.Policies.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tokenLifetimePolicies property of the microsoft.graph.policyRoot entity.</summary>
        public global::Microsoft.Graph.Policies.TokenLifetimePolicies.TokenLifetimePoliciesRequestBuilder TokenLifetimePolicies
        {
            get => new global::Microsoft.Graph.Policies.TokenLifetimePolicies.TokenLifetimePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Policies.PoliciesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PoliciesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/policies{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Policies.PoliciesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PoliciesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/policies{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get policies
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.PolicyRoot"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.PolicyRoot?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Policies.PoliciesRequestBuilder.PoliciesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.PolicyRoot> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Policies.PoliciesRequestBuilder.PoliciesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.PolicyRoot>(requestInfo, global::Microsoft.Graph.Models.PolicyRoot.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update policies
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.PolicyRoot"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.PolicyRoot?> PatchAsync(global::Microsoft.Graph.Models.PolicyRoot body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.PolicyRoot> PatchAsync(global::Microsoft.Graph.Models.PolicyRoot body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.PolicyRoot>(requestInfo, global::Microsoft.Graph.Models.PolicyRoot.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get policies
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Policies.PoliciesRequestBuilder.PoliciesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Policies.PoliciesRequestBuilder.PoliciesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update policies
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.PolicyRoot body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.PolicyRoot body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Policies.PoliciesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Policies.PoliciesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Policies.PoliciesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get policies
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class PoliciesRequestBuilderGetQueryParameters 
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
        public partial class PoliciesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Policies.PoliciesRequestBuilder.PoliciesRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class PoliciesRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
