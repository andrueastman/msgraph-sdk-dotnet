// <auto-generated/>
using Microsoft.Graph.Education.Users.Item.Assignments.Item.Activate;
using Microsoft.Graph.Education.Users.Item.Assignments.Item.Categories;
using Microsoft.Graph.Education.Users.Item.Assignments.Item.Deactivate;
using Microsoft.Graph.Education.Users.Item.Assignments.Item.GradingCategory;
using Microsoft.Graph.Education.Users.Item.Assignments.Item.Publish;
using Microsoft.Graph.Education.Users.Item.Assignments.Item.Resources;
using Microsoft.Graph.Education.Users.Item.Assignments.Item.Rubric;
using Microsoft.Graph.Education.Users.Item.Assignments.Item.SetUpFeedbackResourcesFolder;
using Microsoft.Graph.Education.Users.Item.Assignments.Item.SetUpResourcesFolder;
using Microsoft.Graph.Education.Users.Item.Assignments.Item.Submissions;
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
namespace Microsoft.Graph.Education.Users.Item.Assignments.Item
{
    /// <summary>
    /// Provides operations to manage the assignments property of the microsoft.graph.educationUser entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class EducationAssignmentItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the activate method.</summary>
        public global::Microsoft.Graph.Education.Users.Item.Assignments.Item.Activate.ActivateRequestBuilder Activate
        {
            get => new global::Microsoft.Graph.Education.Users.Item.Assignments.Item.Activate.ActivateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the categories property of the microsoft.graph.educationAssignment entity.</summary>
        public global::Microsoft.Graph.Education.Users.Item.Assignments.Item.Categories.CategoriesRequestBuilder Categories
        {
            get => new global::Microsoft.Graph.Education.Users.Item.Assignments.Item.Categories.CategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the deactivate method.</summary>
        public global::Microsoft.Graph.Education.Users.Item.Assignments.Item.Deactivate.DeactivateRequestBuilder Deactivate
        {
            get => new global::Microsoft.Graph.Education.Users.Item.Assignments.Item.Deactivate.DeactivateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the gradingCategory property of the microsoft.graph.educationAssignment entity.</summary>
        public global::Microsoft.Graph.Education.Users.Item.Assignments.Item.GradingCategory.GradingCategoryRequestBuilder GradingCategory
        {
            get => new global::Microsoft.Graph.Education.Users.Item.Assignments.Item.GradingCategory.GradingCategoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the publish method.</summary>
        public global::Microsoft.Graph.Education.Users.Item.Assignments.Item.Publish.PublishRequestBuilder Publish
        {
            get => new global::Microsoft.Graph.Education.Users.Item.Assignments.Item.Publish.PublishRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the resources property of the microsoft.graph.educationAssignment entity.</summary>
        public global::Microsoft.Graph.Education.Users.Item.Assignments.Item.Resources.ResourcesRequestBuilder Resources
        {
            get => new global::Microsoft.Graph.Education.Users.Item.Assignments.Item.Resources.ResourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the rubric property of the microsoft.graph.educationAssignment entity.</summary>
        public global::Microsoft.Graph.Education.Users.Item.Assignments.Item.Rubric.RubricRequestBuilder Rubric
        {
            get => new global::Microsoft.Graph.Education.Users.Item.Assignments.Item.Rubric.RubricRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setUpFeedbackResourcesFolder method.</summary>
        public global::Microsoft.Graph.Education.Users.Item.Assignments.Item.SetUpFeedbackResourcesFolder.SetUpFeedbackResourcesFolderRequestBuilder SetUpFeedbackResourcesFolder
        {
            get => new global::Microsoft.Graph.Education.Users.Item.Assignments.Item.SetUpFeedbackResourcesFolder.SetUpFeedbackResourcesFolderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setUpResourcesFolder method.</summary>
        public global::Microsoft.Graph.Education.Users.Item.Assignments.Item.SetUpResourcesFolder.SetUpResourcesFolderRequestBuilder SetUpResourcesFolder
        {
            get => new global::Microsoft.Graph.Education.Users.Item.Assignments.Item.SetUpResourcesFolder.SetUpResourcesFolderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the submissions property of the microsoft.graph.educationAssignment entity.</summary>
        public global::Microsoft.Graph.Education.Users.Item.Assignments.Item.Submissions.SubmissionsRequestBuilder Submissions
        {
            get => new global::Microsoft.Graph.Education.Users.Item.Assignments.Item.Submissions.SubmissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Education.Users.Item.Assignments.Item.EducationAssignmentItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EducationAssignmentItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/education/users/{educationUser%2Did}/assignments/{educationAssignment%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Education.Users.Item.Assignments.Item.EducationAssignmentItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EducationAssignmentItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/education/users/{educationUser%2Did}/assignments/{educationAssignment%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property assignments for education
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
        /// Assignments belonging to the user.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.EducationAssignment"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.EducationAssignment?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Education.Users.Item.Assignments.Item.EducationAssignmentItemRequestBuilder.EducationAssignmentItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.EducationAssignment> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Education.Users.Item.Assignments.Item.EducationAssignmentItemRequestBuilder.EducationAssignmentItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.EducationAssignment>(requestInfo, global::Microsoft.Graph.Models.EducationAssignment.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property assignments in education
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.EducationAssignment"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.EducationAssignment?> PatchAsync(global::Microsoft.Graph.Models.EducationAssignment body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.EducationAssignment> PatchAsync(global::Microsoft.Graph.Models.EducationAssignment body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.EducationAssignment>(requestInfo, global::Microsoft.Graph.Models.EducationAssignment.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property assignments for education
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
        /// Assignments belonging to the user.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Education.Users.Item.Assignments.Item.EducationAssignmentItemRequestBuilder.EducationAssignmentItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Education.Users.Item.Assignments.Item.EducationAssignmentItemRequestBuilder.EducationAssignmentItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property assignments in education
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.EducationAssignment body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.EducationAssignment body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Education.Users.Item.Assignments.Item.EducationAssignmentItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Education.Users.Item.Assignments.Item.EducationAssignmentItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Education.Users.Item.Assignments.Item.EducationAssignmentItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class EducationAssignmentItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Assignments belonging to the user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class EducationAssignmentItemRequestBuilderGetQueryParameters 
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
        public partial class EducationAssignmentItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Education.Users.Item.Assignments.Item.EducationAssignmentItemRequestBuilder.EducationAssignmentItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class EducationAssignmentItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
