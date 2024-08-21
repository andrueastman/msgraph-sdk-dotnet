// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration
{
    /// <summary>
    /// Provides operations to call the getUserIdsWithFlaggedAppRegistration method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class GetUserIdsWithFlaggedAppRegistrationRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetUserIdsWithFlaggedAppRegistrationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/managedAppRegistrations/getUserIdsWithFlaggedAppRegistration(){?%24count,%24filter,%24search,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetUserIdsWithFlaggedAppRegistrationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/managedAppRegistrations/getUserIdsWithFlaggedAppRegistration(){?%24count,%24filter,%24search,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Not yet documented
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-mam-managedappregistration-getuseridswithflaggedappregistration?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationGetResponse?> GetAsGetUserIdsWithFlaggedAppRegistrationGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationRequestBuilder.GetUserIdsWithFlaggedAppRegistrationRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationGetResponse> GetAsGetUserIdsWithFlaggedAppRegistrationGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationRequestBuilder.GetUserIdsWithFlaggedAppRegistrationRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationGetResponse>(requestInfo, global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Not yet documented
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-mam-managedappregistration-getuseridswithflaggedappregistration?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsGetUserIdsWithFlaggedAppRegistrationGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationRequestBuilder.GetUserIdsWithFlaggedAppRegistrationRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationRequestBuilder.GetUserIdsWithFlaggedAppRegistrationRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationResponse>(requestInfo, global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Not yet documented
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationRequestBuilder.GetUserIdsWithFlaggedAppRegistrationRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationRequestBuilder.GetUserIdsWithFlaggedAppRegistrationRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Not yet documented
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class GetUserIdsWithFlaggedAppRegistrationRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
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
        public partial class GetUserIdsWithFlaggedAppRegistrationRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.DeviceAppManagement.ManagedAppRegistrations.GetUserIdsWithFlaggedAppRegistration.GetUserIdsWithFlaggedAppRegistrationRequestBuilder.GetUserIdsWithFlaggedAppRegistrationRequestBuilderGetQueryParameters>
        {
        }
    }
}
