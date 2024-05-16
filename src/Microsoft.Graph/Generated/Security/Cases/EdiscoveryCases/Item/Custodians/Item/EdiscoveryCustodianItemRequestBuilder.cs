// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models.Security;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Custodians.Item.LastIndexOperation;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Custodians.Item.MicrosoftGraphSecurityActivate;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Custodians.Item.MicrosoftGraphSecurityApplyHold;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Custodians.Item.MicrosoftGraphSecurityRelease;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Custodians.Item.MicrosoftGraphSecurityRemoveHold;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Custodians.Item.MicrosoftGraphSecurityUpdateIndex;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Custodians.Item.SiteSources;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Custodians.Item.UnifiedGroupSources;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Custodians.Item.UserSources;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Custodians.Item
{
    /// <summary>
    /// Provides operations to manage the custodians property of the microsoft.graph.security.ediscoveryCase entity.
    /// </summary>
    public class EdiscoveryCustodianItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the lastIndexOperation property of the microsoft.graph.security.ediscoveryCustodian entity.</summary>
        public LastIndexOperationRequestBuilder LastIndexOperation
        {
            get => new LastIndexOperationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the activate method.</summary>
        public MicrosoftGraphSecurityActivateRequestBuilder MicrosoftGraphSecurityActivate
        {
            get => new MicrosoftGraphSecurityActivateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the applyHold method.</summary>
        public MicrosoftGraphSecurityApplyHoldRequestBuilder MicrosoftGraphSecurityApplyHold
        {
            get => new MicrosoftGraphSecurityApplyHoldRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the release method.</summary>
        public MicrosoftGraphSecurityReleaseRequestBuilder MicrosoftGraphSecurityRelease
        {
            get => new MicrosoftGraphSecurityReleaseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the removeHold method.</summary>
        public MicrosoftGraphSecurityRemoveHoldRequestBuilder MicrosoftGraphSecurityRemoveHold
        {
            get => new MicrosoftGraphSecurityRemoveHoldRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateIndex method.</summary>
        public MicrosoftGraphSecurityUpdateIndexRequestBuilder MicrosoftGraphSecurityUpdateIndex
        {
            get => new MicrosoftGraphSecurityUpdateIndexRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the siteSources property of the microsoft.graph.security.ediscoveryCustodian entity.</summary>
        public SiteSourcesRequestBuilder SiteSources
        {
            get => new SiteSourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the unifiedGroupSources property of the microsoft.graph.security.ediscoveryCustodian entity.</summary>
        public UnifiedGroupSourcesRequestBuilder UnifiedGroupSources
        {
            get => new UnifiedGroupSourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userSources property of the microsoft.graph.security.ediscoveryCustodian entity.</summary>
        public UserSourcesRequestBuilder UserSources
        {
            get => new UserSourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="EdiscoveryCustodianItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EdiscoveryCustodianItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/custodians/{ediscoveryCustodian%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="EdiscoveryCustodianItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EdiscoveryCustodianItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/custodians/{ediscoveryCustodian%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property custodians for security
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
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
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Read the properties and relationships of an ediscoveryCustodian object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/security-ediscoverycustodian-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="EdiscoveryCustodian"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<EdiscoveryCustodian?> GetAsync(Action<RequestConfiguration<EdiscoveryCustodianItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<EdiscoveryCustodian> GetAsync(Action<RequestConfiguration<EdiscoveryCustodianItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<EdiscoveryCustodian>(requestInfo, EdiscoveryCustodian.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property custodians in security
        /// </summary>
        /// <returns>A <see cref="EdiscoveryCustodian"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<EdiscoveryCustodian?> PatchAsync(EdiscoveryCustodian body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<EdiscoveryCustodian> PatchAsync(EdiscoveryCustodian body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<EdiscoveryCustodian>(requestInfo, EdiscoveryCustodian.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property custodians for security
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
        /// Read the properties and relationships of an ediscoveryCustodian object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EdiscoveryCustodianItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EdiscoveryCustodianItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property custodians in security
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(EdiscoveryCustodian body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(EdiscoveryCustodian body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="EdiscoveryCustodianItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public EdiscoveryCustodianItemRequestBuilder WithUrl(string rawUrl)
        {
            return new EdiscoveryCustodianItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class EdiscoveryCustodianItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Read the properties and relationships of an ediscoveryCustodian object.
        /// </summary>
        public class EdiscoveryCustodianItemRequestBuilderGetQueryParameters 
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
        public class EdiscoveryCustodianItemRequestBuilderGetRequestConfiguration : RequestConfiguration<EdiscoveryCustodianItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class EdiscoveryCustodianItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
