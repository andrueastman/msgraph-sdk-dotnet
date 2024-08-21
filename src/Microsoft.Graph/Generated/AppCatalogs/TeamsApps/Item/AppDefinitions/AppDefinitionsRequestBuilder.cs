// <auto-generated/>
using Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.Count;
using Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.Item;
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
namespace Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions
{
    /// <summary>
    /// Provides operations to manage the appDefinitions property of the microsoft.graph.teamsApp entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class AppDefinitionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public global::Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.Count.CountRequestBuilder Count
        {
            get => new global::Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appDefinitions property of the microsoft.graph.teamsApp entity.</summary>
        /// <param name="position">The unique identifier of teamsAppDefinition</param>
        /// <returns>A <see cref="global::Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.TeamsAppDefinitionItemRequestBuilder"/></returns>
        public global::Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.TeamsAppDefinitionItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("teamsAppDefinition%2Did", position);
                return new global::Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.Item.TeamsAppDefinitionItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.AppDefinitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppDefinitionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/appCatalogs/teamsApps/{teamsApp%2Did}/appDefinitions{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.AppDefinitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppDefinitionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/appCatalogs/teamsApps/{teamsApp%2Did}/appDefinitions{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// The details for each version of the app.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TeamsAppDefinitionCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.TeamsAppDefinitionCollectionResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.AppDefinitionsRequestBuilder.AppDefinitionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.TeamsAppDefinitionCollectionResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.AppDefinitionsRequestBuilder.AppDefinitionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.TeamsAppDefinitionCollectionResponse>(requestInfo, global::Microsoft.Graph.Models.TeamsAppDefinitionCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update an app previously published to the Microsoft Teams app catalog. To update an app, the distributionMethod property for the app must be set to organization. This API specifically updates an app published to your organization&apos;s app catalog (the tenant app catalog).
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/teamsapp-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TeamsAppDefinition"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.TeamsAppDefinition?> PostAsync(global::Microsoft.Graph.Models.TeamsAppDefinition body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.TeamsAppDefinition> PostAsync(global::Microsoft.Graph.Models.TeamsAppDefinition body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.TeamsAppDefinition>(requestInfo, global::Microsoft.Graph.Models.TeamsAppDefinition.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The details for each version of the app.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.AppDefinitionsRequestBuilder.AppDefinitionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.AppDefinitionsRequestBuilder.AppDefinitionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update an app previously published to the Microsoft Teams app catalog. To update an app, the distributionMethod property for the app must be set to organization. This API specifically updates an app published to your organization&apos;s app catalog (the tenant app catalog).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Models.TeamsAppDefinition body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Models.TeamsAppDefinition body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.AppDefinitionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.AppDefinitionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.AppDefinitionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// The details for each version of the app.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class AppDefinitionsRequestBuilderGetQueryParameters 
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
        public partial class AppDefinitionsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.AppCatalogs.TeamsApps.Item.AppDefinitions.AppDefinitionsRequestBuilder.AppDefinitionsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class AppDefinitionsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
