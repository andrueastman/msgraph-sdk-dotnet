// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models.Security;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.DataSource;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.LastIndexOperation;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.MicrosoftGraphSecurityApplyHold;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.MicrosoftGraphSecurityRelease;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.MicrosoftGraphSecurityRemoveHold;
using Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.MicrosoftGraphSecurityUpdateIndex;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item
{
    /// <summary>
    /// Provides operations to manage the noncustodialDataSources property of the microsoft.graph.security.ediscoveryCase entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class EdiscoveryNoncustodialDataSourceItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the dataSource property of the microsoft.graph.security.ediscoveryNoncustodialDataSource entity.</summary>
        public global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.DataSource.DataSourceRequestBuilder DataSource
        {
            get => new global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.DataSource.DataSourceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastIndexOperation property of the microsoft.graph.security.ediscoveryNoncustodialDataSource entity.</summary>
        public global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.LastIndexOperation.LastIndexOperationRequestBuilder LastIndexOperation
        {
            get => new global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.LastIndexOperation.LastIndexOperationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the applyHold method.</summary>
        public global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.MicrosoftGraphSecurityApplyHold.MicrosoftGraphSecurityApplyHoldRequestBuilder MicrosoftGraphSecurityApplyHold
        {
            get => new global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.MicrosoftGraphSecurityApplyHold.MicrosoftGraphSecurityApplyHoldRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the release method.</summary>
        public global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.MicrosoftGraphSecurityRelease.MicrosoftGraphSecurityReleaseRequestBuilder MicrosoftGraphSecurityRelease
        {
            get => new global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.MicrosoftGraphSecurityRelease.MicrosoftGraphSecurityReleaseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the removeHold method.</summary>
        public global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.MicrosoftGraphSecurityRemoveHold.MicrosoftGraphSecurityRemoveHoldRequestBuilder MicrosoftGraphSecurityRemoveHold
        {
            get => new global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.MicrosoftGraphSecurityRemoveHold.MicrosoftGraphSecurityRemoveHoldRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateIndex method.</summary>
        public global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.MicrosoftGraphSecurityUpdateIndex.MicrosoftGraphSecurityUpdateIndexRequestBuilder MicrosoftGraphSecurityUpdateIndex
        {
            get => new global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.MicrosoftGraphSecurityUpdateIndex.MicrosoftGraphSecurityUpdateIndexRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.EdiscoveryNoncustodialDataSourceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EdiscoveryNoncustodialDataSourceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/noncustodialDataSources/{ediscoveryNoncustodialDataSource%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.EdiscoveryNoncustodialDataSourceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EdiscoveryNoncustodialDataSourceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/noncustodialDataSources/{ediscoveryNoncustodialDataSource%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property noncustodialDataSources for security
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
        /// Returns a list of case ediscoveryNoncustodialDataSource objects for this case.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.EdiscoveryNoncustodialDataSourceItemRequestBuilder.EdiscoveryNoncustodialDataSourceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.EdiscoveryNoncustodialDataSourceItemRequestBuilder.EdiscoveryNoncustodialDataSourceItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource>(requestInfo, global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property noncustodialDataSources in security
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource?> PatchAsync(global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource> PatchAsync(global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource>(requestInfo, global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property noncustodialDataSources for security
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
        /// Returns a list of case ediscoveryNoncustodialDataSource objects for this case.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.EdiscoveryNoncustodialDataSourceItemRequestBuilder.EdiscoveryNoncustodialDataSourceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.EdiscoveryNoncustodialDataSourceItemRequestBuilder.EdiscoveryNoncustodialDataSourceItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property noncustodialDataSources in security
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Security.EdiscoveryNoncustodialDataSource body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.EdiscoveryNoncustodialDataSourceItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.EdiscoveryNoncustodialDataSourceItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.EdiscoveryNoncustodialDataSourceItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class EdiscoveryNoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Returns a list of case ediscoveryNoncustodialDataSource objects for this case.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class EdiscoveryNoncustodialDataSourceItemRequestBuilderGetQueryParameters 
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
        public partial class EdiscoveryNoncustodialDataSourceItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.EdiscoveryNoncustodialDataSourceItemRequestBuilder.EdiscoveryNoncustodialDataSourceItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class EdiscoveryNoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
