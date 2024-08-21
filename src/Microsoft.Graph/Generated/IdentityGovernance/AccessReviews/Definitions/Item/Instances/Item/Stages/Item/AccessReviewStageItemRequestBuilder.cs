// <auto-generated/>
using Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions;
using Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Stop;
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
namespace Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item
{
    /// <summary>
    /// Provides operations to manage the stages property of the microsoft.graph.accessReviewInstance entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class AccessReviewStageItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the decisions property of the microsoft.graph.accessReviewStage entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.DecisionsRequestBuilder Decisions
        {
            get => new global::Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.DecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the stop method.</summary>
        public global::Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Stop.StopRequestBuilder Stop
        {
            get => new global::Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Stop.StopRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.AccessReviewStageItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessReviewStageItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition%2Did}/instances/{accessReviewInstance%2Did}/stages/{accessReviewStage%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.AccessReviewStageItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessReviewStageItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition%2Did}/instances/{accessReviewInstance%2Did}/stages/{accessReviewStage%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property stages for identityGovernance
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
        /// Retrieve the properties and relationships of an accessReviewStage object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreviewstage-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AccessReviewStage"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.AccessReviewStage?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.AccessReviewStageItemRequestBuilder.AccessReviewStageItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.AccessReviewStage> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.AccessReviewStageItemRequestBuilder.AccessReviewStageItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.AccessReviewStage>(requestInfo, global::Microsoft.Graph.Models.AccessReviewStage.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the properties of an accessReviewStage object. Only the reviewers and fallbackReviewers properties can be updated. You can only add reviewers to the fallbackReviewers property but can&apos;t remove existing fallbackReviewers. To update an accessReviewStage, its status must be NotStarted, Initializing, or InProgress.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreviewstage-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AccessReviewStage"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.AccessReviewStage?> PatchAsync(global::Microsoft.Graph.Models.AccessReviewStage body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.AccessReviewStage> PatchAsync(global::Microsoft.Graph.Models.AccessReviewStage body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.AccessReviewStage>(requestInfo, global::Microsoft.Graph.Models.AccessReviewStage.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property stages for identityGovernance
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
        /// Retrieve the properties and relationships of an accessReviewStage object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.AccessReviewStageItemRequestBuilder.AccessReviewStageItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.AccessReviewStageItemRequestBuilder.AccessReviewStageItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of an accessReviewStage object. Only the reviewers and fallbackReviewers properties can be updated. You can only add reviewers to the fallbackReviewers property but can&apos;t remove existing fallbackReviewers. To update an accessReviewStage, its status must be NotStarted, Initializing, or InProgress.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.AccessReviewStage body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.AccessReviewStage body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.AccessReviewStageItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.AccessReviewStageItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.AccessReviewStageItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class AccessReviewStageItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Retrieve the properties and relationships of an accessReviewStage object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class AccessReviewStageItemRequestBuilderGetQueryParameters 
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
        public partial class AccessReviewStageItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.AccessReviewStageItemRequestBuilder.AccessReviewStageItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class AccessReviewStageItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
