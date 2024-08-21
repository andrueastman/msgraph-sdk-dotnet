// <auto-generated/>
using Microsoft.Graph.IdentityProtection.RiskDetections;
using Microsoft.Graph.IdentityProtection.RiskyServicePrincipals;
using Microsoft.Graph.IdentityProtection.RiskyUsers;
using Microsoft.Graph.IdentityProtection.ServicePrincipalRiskDetections;
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
namespace Microsoft.Graph.IdentityProtection
{
    /// <summary>
    /// Provides operations to manage the identityProtectionRoot singleton.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class IdentityProtectionRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the riskDetections property of the microsoft.graph.identityProtectionRoot entity.</summary>
        public global::Microsoft.Graph.IdentityProtection.RiskDetections.RiskDetectionsRequestBuilder RiskDetections
        {
            get => new global::Microsoft.Graph.IdentityProtection.RiskDetections.RiskDetectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the riskyServicePrincipals property of the microsoft.graph.identityProtectionRoot entity.</summary>
        public global::Microsoft.Graph.IdentityProtection.RiskyServicePrincipals.RiskyServicePrincipalsRequestBuilder RiskyServicePrincipals
        {
            get => new global::Microsoft.Graph.IdentityProtection.RiskyServicePrincipals.RiskyServicePrincipalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the riskyUsers property of the microsoft.graph.identityProtectionRoot entity.</summary>
        public global::Microsoft.Graph.IdentityProtection.RiskyUsers.RiskyUsersRequestBuilder RiskyUsers
        {
            get => new global::Microsoft.Graph.IdentityProtection.RiskyUsers.RiskyUsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the servicePrincipalRiskDetections property of the microsoft.graph.identityProtectionRoot entity.</summary>
        public global::Microsoft.Graph.IdentityProtection.ServicePrincipalRiskDetections.ServicePrincipalRiskDetectionsRequestBuilder ServicePrincipalRiskDetections
        {
            get => new global::Microsoft.Graph.IdentityProtection.ServicePrincipalRiskDetections.ServicePrincipalRiskDetectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityProtection.IdentityProtectionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityProtectionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityProtection{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityProtection.IdentityProtectionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityProtectionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityProtection{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get identityProtection
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityProtectionRoot"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.IdentityProtectionRoot?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityProtection.IdentityProtectionRequestBuilder.IdentityProtectionRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.IdentityProtectionRoot> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityProtection.IdentityProtectionRequestBuilder.IdentityProtectionRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.IdentityProtectionRoot>(requestInfo, global::Microsoft.Graph.Models.IdentityProtectionRoot.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update identityProtection
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityProtectionRoot"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.IdentityProtectionRoot?> PatchAsync(global::Microsoft.Graph.Models.IdentityProtectionRoot body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.IdentityProtectionRoot> PatchAsync(global::Microsoft.Graph.Models.IdentityProtectionRoot body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.IdentityProtectionRoot>(requestInfo, global::Microsoft.Graph.Models.IdentityProtectionRoot.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get identityProtection
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityProtection.IdentityProtectionRequestBuilder.IdentityProtectionRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityProtection.IdentityProtectionRequestBuilder.IdentityProtectionRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update identityProtection
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.IdentityProtectionRoot body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.IdentityProtectionRoot body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.IdentityProtection.IdentityProtectionRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.IdentityProtection.IdentityProtectionRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.IdentityProtection.IdentityProtectionRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get identityProtection
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class IdentityProtectionRequestBuilderGetQueryParameters 
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
        public partial class IdentityProtectionRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.IdentityProtection.IdentityProtectionRequestBuilder.IdentityProtectionRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class IdentityProtectionRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
