// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.Count;
using Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.Delta;
using Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances
{
    /// <summary>
    /// Provides operations to manage the instances property of the microsoft.graph.event entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class InstancesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.Count.CountRequestBuilder Count
        {
            get => new global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the delta method.</summary>
        public global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.Delta.DeltaRequestBuilder Delta
        {
            get => new global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.Delta.DeltaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the instances property of the microsoft.graph.event entity.</summary>
        /// <param name="position">The unique identifier of event</param>
        /// <returns>A <see cref="global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.Item.EventItemRequestBuilder"/></returns>
        public global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.Item.EventItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("event%2Did1", position);
                return new global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.Item.EventItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.InstancesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstancesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/calendar/calendarView/{event%2Did}/instances?endDateTime={endDateTime}&startDateTime={startDateTime}{&%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.InstancesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstancesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/calendar/calendarView/{event%2Did}/instances?endDateTime={endDateTime}&startDateTime={startDateTime}{&%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.EventCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.EventCollectionResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.InstancesRequestBuilder.InstancesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.EventCollectionResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.InstancesRequestBuilder.InstancesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.EventCollectionResponse>(requestInfo, global::Microsoft.Graph.Models.EventCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.InstancesRequestBuilder.InstancesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.InstancesRequestBuilder.InstancesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.InstancesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.InstancesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.InstancesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class InstancesRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>The end date and time of the time range, represented in ISO 8601 format. For example, 2019-11-08T20:00:00-08:00</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("endDateTime")]
            public string? EndDateTime { get; set; }
#nullable restore
#else
            [QueryParameter("endDateTime")]
            public string EndDateTime { get; set; }
#endif
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
            /// <summary>The start date and time of the time range, represented in ISO 8601 format. For example, 2019-11-08T19:00:00-08:00</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("startDateTime")]
            public string? StartDateTime { get; set; }
#nullable restore
#else
            [QueryParameter("startDateTime")]
            public string StartDateTime { get; set; }
#endif
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class InstancesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Users.Item.Calendar.CalendarView.Item.Instances.InstancesRequestBuilder.InstancesRequestBuilderGetQueryParameters>
        {
        }
    }
}
