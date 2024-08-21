// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.AssociateWithHubSites;
using Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.Base;
using Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.BaseTypes;
using Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ColumnLinks;
using Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ColumnPositions;
using Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.Columns;
using Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.CopyToDefaultContentLocation;
using Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.IsPublished;
using Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.Publish;
using Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.Unpublish;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item
{
    /// <summary>
    /// Provides operations to manage the contentTypes property of the microsoft.graph.list entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ContentTypeItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the associateWithHubSites method.</summary>
        public global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.AssociateWithHubSites.AssociateWithHubSitesRequestBuilder AssociateWithHubSites
        {
            get => new global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.AssociateWithHubSites.AssociateWithHubSitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the base property of the microsoft.graph.contentType entity.</summary>
        public global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.Base.BaseRequestBuilderEscaped Base
        {
            get => new global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.Base.BaseRequestBuilderEscaped(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the baseTypes property of the microsoft.graph.contentType entity.</summary>
        public global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.BaseTypes.BaseTypesRequestBuilder BaseTypes
        {
            get => new global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.BaseTypes.BaseTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columnLinks property of the microsoft.graph.contentType entity.</summary>
        public global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ColumnLinks.ColumnLinksRequestBuilder ColumnLinks
        {
            get => new global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ColumnLinks.ColumnLinksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columnPositions property of the microsoft.graph.contentType entity.</summary>
        public global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ColumnPositions.ColumnPositionsRequestBuilder ColumnPositions
        {
            get => new global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ColumnPositions.ColumnPositionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columns property of the microsoft.graph.contentType entity.</summary>
        public global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.Columns.ColumnsRequestBuilder Columns
        {
            get => new global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.Columns.ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the copyToDefaultContentLocation method.</summary>
        public global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.CopyToDefaultContentLocation.CopyToDefaultContentLocationRequestBuilder CopyToDefaultContentLocation
        {
            get => new global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.CopyToDefaultContentLocation.CopyToDefaultContentLocationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the isPublished method.</summary>
        public global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.IsPublished.IsPublishedRequestBuilder IsPublished
        {
            get => new global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.IsPublished.IsPublishedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the publish method.</summary>
        public global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.Publish.PublishRequestBuilder Publish
        {
            get => new global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.Publish.PublishRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unpublish method.</summary>
        public global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.Unpublish.UnpublishRequestBuilder Unpublish
        {
            get => new global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.Unpublish.UnpublishRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ContentTypeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContentTypeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sites/{site%2Did}/lists/{list%2Did}/contentTypes/{contentType%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ContentTypeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContentTypeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sites/{site%2Did}/lists/{list%2Did}/contentTypes/{contentType%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property contentTypes for sites
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
        /// The collection of content types present in this list.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ContentType"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.ContentType?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ContentTypeItemRequestBuilder.ContentTypeItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.ContentType> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ContentTypeItemRequestBuilder.ContentTypeItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.ContentType>(requestInfo, global::Microsoft.Graph.Models.ContentType.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property contentTypes in sites
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ContentType"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.ContentType?> PatchAsync(global::Microsoft.Graph.Models.ContentType body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.ContentType> PatchAsync(global::Microsoft.Graph.Models.ContentType body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.ContentType>(requestInfo, global::Microsoft.Graph.Models.ContentType.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property contentTypes for sites
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
        /// The collection of content types present in this list.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ContentTypeItemRequestBuilder.ContentTypeItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ContentTypeItemRequestBuilder.ContentTypeItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property contentTypes in sites
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.ContentType body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.ContentType body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ContentTypeItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ContentTypeItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ContentTypeItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ContentTypeItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// The collection of content types present in this list.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ContentTypeItemRequestBuilderGetQueryParameters 
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
        public partial class ContentTypeItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Sites.Item.Lists.Item.ContentTypes.Item.ContentTypeItemRequestBuilder.ContentTypeItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ContentTypeItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
