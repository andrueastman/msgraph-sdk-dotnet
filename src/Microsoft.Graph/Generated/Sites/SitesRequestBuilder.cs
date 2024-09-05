// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.Sites.Add;
using Microsoft.Graph.Sites.Count;
using Microsoft.Graph.Sites.Delta;
using Microsoft.Graph.Sites.GetAllSites;
using Microsoft.Graph.Sites.Item;
using Microsoft.Graph.Sites.Remove;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Sites
{
    /// <summary>
    /// Provides operations to manage the collection of site entities.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class SitesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the add method.</summary>
        public global::Microsoft.Graph.Sites.Add.AddRequestBuilder Add
        {
            get => new global::Microsoft.Graph.Sites.Add.AddRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public global::Microsoft.Graph.Sites.Count.CountRequestBuilder Count
        {
            get => new global::Microsoft.Graph.Sites.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the delta method.</summary>
        public global::Microsoft.Graph.Sites.Delta.DeltaRequestBuilder Delta
        {
            get => new global::Microsoft.Graph.Sites.Delta.DeltaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getAllSites method.</summary>
        public global::Microsoft.Graph.Sites.GetAllSites.GetAllSitesRequestBuilder GetAllSites
        {
            get => new global::Microsoft.Graph.Sites.GetAllSites.GetAllSitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the remove method.</summary>
        public global::Microsoft.Graph.Sites.Remove.RemoveRequestBuilder Remove
        {
            get => new global::Microsoft.Graph.Sites.Remove.RemoveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of site entities.</summary>
        /// <param name="position">The unique identifier of site</param>
        /// <returns>A <see cref="global::Microsoft.Graph.Sites.Item.SiteItemRequestBuilder"/></returns>
        public global::Microsoft.Graph.Sites.Item.SiteItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("site%2Did", position);
                return new global::Microsoft.Graph.Sites.Item.SiteItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Sites.SitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SitesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sites{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Sites.SitesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SitesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sites{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// List all available sites in an organization. Specific filter criteria and query options are also supported and described below: In addition, you can use a $search query against the /sites collection to find sites matching given keywords.If you want to list all sites across all geographies, refer to getAllSites. For more guidance about building applications that use site discovery for scanning purposes, see Best practices for discovering files and detecting changes at scale.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/site-list?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SiteCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.SiteCollectionResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Sites.SitesRequestBuilder.SitesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.SiteCollectionResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Sites.SitesRequestBuilder.SitesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.SiteCollectionResponse>(requestInfo, global::Microsoft.Graph.Models.SiteCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List all available sites in an organization. Specific filter criteria and query options are also supported and described below: In addition, you can use a $search query against the /sites collection to find sites matching given keywords.If you want to list all sites across all geographies, refer to getAllSites. For more guidance about building applications that use site discovery for scanning purposes, see Best practices for discovering files and detecting changes at scale.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Sites.SitesRequestBuilder.SitesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Sites.SitesRequestBuilder.SitesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Sites.SitesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Sites.SitesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Sites.SitesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List all available sites in an organization. Specific filter criteria and query options are also supported and described below: In addition, you can use a $search query against the /sites collection to find sites matching given keywords.If you want to list all sites across all geographies, refer to getAllSites. For more guidance about building applications that use site discovery for scanning purposes, see Best practices for discovering files and detecting changes at scale.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class SitesRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
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
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
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
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class SitesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Sites.SitesRequestBuilder.SitesRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
