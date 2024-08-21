// <auto-generated/>
using Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.Assign;
using Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.Assignments;
using Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceSettingStateSummaries;
using Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceStatusOverview;
using Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceStatuses;
using Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.GetOmaSettingPlainTextValueWithSecretReferenceValueId;
using Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.UserStatusOverview;
using Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.UserStatuses;
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
namespace Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item
{
    /// <summary>
    /// Provides operations to manage the deviceConfigurations property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class DeviceConfigurationItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the assign method.</summary>
        public global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.Assign.AssignRequestBuilder Assign
        {
            get => new global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.Assign.AssignRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the assignments property of the microsoft.graph.deviceConfiguration entity.</summary>
        public global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.Assignments.AssignmentsRequestBuilder Assignments
        {
            get => new global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.Assignments.AssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceSettingStateSummaries property of the microsoft.graph.deviceConfiguration entity.</summary>
        public global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceSettingStateSummaries.DeviceSettingStateSummariesRequestBuilder DeviceSettingStateSummaries
        {
            get => new global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceSettingStateSummaries.DeviceSettingStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceStatuses property of the microsoft.graph.deviceConfiguration entity.</summary>
        public global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceStatuses.DeviceStatusesRequestBuilder DeviceStatuses
        {
            get => new global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceStatuses.DeviceStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceStatusOverview property of the microsoft.graph.deviceConfiguration entity.</summary>
        public global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceStatusOverview.DeviceStatusOverviewRequestBuilder DeviceStatusOverview
        {
            get => new global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceStatusOverview.DeviceStatusOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userStatuses property of the microsoft.graph.deviceConfiguration entity.</summary>
        public global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.UserStatuses.UserStatusesRequestBuilder UserStatuses
        {
            get => new global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.UserStatuses.UserStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userStatusOverview property of the microsoft.graph.deviceConfiguration entity.</summary>
        public global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.UserStatusOverview.UserStatusOverviewRequestBuilder UserStatusOverview
        {
            get => new global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.UserStatusOverview.UserStatusOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceConfigurationItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceConfigurationItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/deviceConfigurations/{deviceConfiguration%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceConfigurationItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceConfigurationItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/deviceConfigurations/{deviceConfiguration%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Deletes a iosUpdateConfiguration.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-deviceconfig-iosupdateconfiguration-delete?view=graph-rest-1.0" />
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
        /// Read properties and relationships of the sharedPCConfiguration object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-deviceconfig-sharedpcconfiguration-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceConfiguration"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.DeviceConfiguration?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceConfigurationItemRequestBuilder.DeviceConfigurationItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.DeviceConfiguration> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceConfigurationItemRequestBuilder.DeviceConfigurationItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.DeviceConfiguration>(requestInfo, global::Microsoft.Graph.Models.DeviceConfiguration.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the getOmaSettingPlainTextValue method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.GetOmaSettingPlainTextValueWithSecretReferenceValueId.GetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilder"/></returns>
        /// <param name="secretReferenceValueId">Usage: secretReferenceValueId=&apos;{secretReferenceValueId}&apos;</param>
        public global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.GetOmaSettingPlainTextValueWithSecretReferenceValueId.GetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilder GetOmaSettingPlainTextValueWithSecretReferenceValueId(string secretReferenceValueId)
        {
            if(string.IsNullOrEmpty(secretReferenceValueId)) throw new ArgumentNullException(nameof(secretReferenceValueId));
            return new global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.GetOmaSettingPlainTextValueWithSecretReferenceValueId.GetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilder(PathParameters, RequestAdapter, secretReferenceValueId);
        }
        /// <summary>
        /// Update the properties of a windowsUpdateForBusinessConfiguration object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-deviceconfig-windowsupdateforbusinessconfiguration-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceConfiguration"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.DeviceConfiguration?> PatchAsync(global::Microsoft.Graph.Models.DeviceConfiguration body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.DeviceConfiguration> PatchAsync(global::Microsoft.Graph.Models.DeviceConfiguration body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.DeviceConfiguration>(requestInfo, global::Microsoft.Graph.Models.DeviceConfiguration.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes a iosUpdateConfiguration.
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
        /// Read properties and relationships of the sharedPCConfiguration object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceConfigurationItemRequestBuilder.DeviceConfigurationItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceConfigurationItemRequestBuilder.DeviceConfigurationItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a windowsUpdateForBusinessConfiguration object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.DeviceConfiguration body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.DeviceConfiguration body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceConfigurationItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceConfigurationItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceConfigurationItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class DeviceConfigurationItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Read properties and relationships of the sharedPCConfiguration object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class DeviceConfigurationItemRequestBuilderGetQueryParameters 
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
        public partial class DeviceConfigurationItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.DeviceManagement.DeviceConfigurations.Item.DeviceConfigurationItemRequestBuilder.DeviceConfigurationItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class DeviceConfigurationItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
