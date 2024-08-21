// <auto-generated/>
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.Count;
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.Item;
using Microsoft.Graph.Models.IdentityGovernance;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope
{
    /// <summary>
    /// Provides operations to manage the executionScope property of the microsoft.graph.identityGovernance.workflow entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ExecutionScopeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.Count.CountRequestBuilder Count
        {
            get => new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the executionScope property of the microsoft.graph.identityGovernance.workflow entity.</summary>
        /// <param name="position">The unique identifier of userProcessingResult</param>
        /// <returns>A <see cref="global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.Item.UserProcessingResultItemRequestBuilder"/></returns>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.Item.UserProcessingResultItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("userProcessingResult%2Did", position);
                return new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.Item.UserProcessingResultItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.ExecutionScopeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ExecutionScopeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/lifecycleWorkflows/deletedItems/workflows/{workflow%2Did}/executionScope{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.ExecutionScopeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ExecutionScopeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/lifecycleWorkflows/deletedItems/workflows/{workflow%2Did}/executionScope{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// The unique identifier of the Microsoft Entra identity that last modified the workflow object.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResultCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResultCollectionResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.ExecutionScopeRequestBuilder.ExecutionScopeRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResultCollectionResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.ExecutionScopeRequestBuilder.ExecutionScopeRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResultCollectionResponse>(requestInfo, global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResultCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The unique identifier of the Microsoft Entra identity that last modified the workflow object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.ExecutionScopeRequestBuilder.ExecutionScopeRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.ExecutionScopeRequestBuilder.ExecutionScopeRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.ExecutionScopeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.ExecutionScopeRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.ExecutionScopeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// The unique identifier of the Microsoft Entra identity that last modified the workflow object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ExecutionScopeRequestBuilderGetQueryParameters 
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
        public partial class ExecutionScopeRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.ExecutionScope.ExecutionScopeRequestBuilder.ExecutionScopeRequestBuilderGetQueryParameters>
        {
        }
    }
}
