// <auto-generated/>
using Microsoft.Graph.IdentityGovernance.AccessReviews;
using Microsoft.Graph.IdentityGovernance.AppConsent;
using Microsoft.Graph.IdentityGovernance.EntitlementManagement;
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows;
using Microsoft.Graph.IdentityGovernance.PrivilegedAccess;
using Microsoft.Graph.IdentityGovernance.TermsOfUse;
using Microsoft.Graph.Models.IdentityGovernance;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.IdentityGovernance {
    /// <summary>
    /// Provides operations to manage the identityGovernance singleton.
    /// </summary>
    public class IdentityGovernanceRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the accessReviews property of the microsoft.graph.identityGovernance entity.</summary>
        public AccessReviewsRequestBuilder AccessReviews { get =>
            new AccessReviewsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appConsent property of the microsoft.graph.identityGovernance entity.</summary>
        public AppConsentRequestBuilder AppConsent { get =>
            new AppConsentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the entitlementManagement property of the microsoft.graph.identityGovernance entity.</summary>
        public EntitlementManagementRequestBuilder EntitlementManagement { get =>
            new EntitlementManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lifecycleWorkflows property of the microsoft.graph.identityGovernance entity.</summary>
        public LifecycleWorkflowsRequestBuilder LifecycleWorkflows { get =>
            new LifecycleWorkflowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the privilegedAccess property of the microsoft.graph.identityGovernance entity.</summary>
        public PrivilegedAccessRequestBuilder PrivilegedAccess { get =>
            new PrivilegedAccessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the termsOfUse property of the microsoft.graph.identityGovernance entity.</summary>
        public TermsOfUseRequestBuilder TermsOfUse { get =>
            new TermsOfUseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="IdentityGovernanceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityGovernanceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance{?%24expand,%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="IdentityGovernanceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityGovernanceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance{?%24expand,%24select}", rawUrl) {
        }
        /// <summary>
        /// Get identityGovernance
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance?> GetAsync(Action<RequestConfiguration<IdentityGovernanceRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance> GetAsync(Action<RequestConfiguration<IdentityGovernanceRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance>(requestInfo, Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update identityGovernance
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance?> PatchAsync(Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance> PatchAsync(Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance>(requestInfo, Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<IdentityGovernanceRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<IdentityGovernanceRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.IdentityGovernance.IdentityGovernance body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/identityGovernance", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="IdentityGovernanceRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public IdentityGovernanceRequestBuilder WithUrl(string rawUrl) {
            return new IdentityGovernanceRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get identityGovernance
        /// </summary>
        public class IdentityGovernanceRequestBuilderGetQueryParameters {
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
        public class IdentityGovernanceRequestBuilderGetRequestConfiguration : RequestConfiguration<IdentityGovernanceRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class IdentityGovernanceRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
