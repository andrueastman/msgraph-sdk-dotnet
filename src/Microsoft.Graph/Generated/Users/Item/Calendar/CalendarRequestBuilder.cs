// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.Users.Item.Calendar.AllowedCalendarSharingRolesWithUser;
using Microsoft.Graph.Users.Item.Calendar.CalendarPermissions;
using Microsoft.Graph.Users.Item.Calendar.CalendarView;
using Microsoft.Graph.Users.Item.Calendar.Events;
using Microsoft.Graph.Users.Item.Calendar.GetSchedule;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Users.Item.Calendar {
    /// <summary>
    /// Provides operations to manage the calendar property of the microsoft.graph.user entity.
    /// </summary>
    public class CalendarRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Provides operations to manage the calendarPermissions property of the microsoft.graph.calendar entity.</summary>
        public CalendarPermissionsRequestBuilder CalendarPermissions
        {
            get => new CalendarPermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendarView property of the microsoft.graph.calendar entity.</summary>
        public CalendarViewRequestBuilder CalendarView
        {
            get => new CalendarViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the events property of the microsoft.graph.calendar entity.</summary>
        public EventsRequestBuilder Events
        {
            get => new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getSchedule method.</summary>
        public GetScheduleRequestBuilder GetSchedule
        {
            get => new GetScheduleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the allowedCalendarSharingRoles method.
        /// </summary>
        /// <returns>A <see cref="AllowedCalendarSharingRolesWithUserRequestBuilder"/></returns>
        /// <param name="user">Usage: User=&apos;{User}&apos;</param>
        public AllowedCalendarSharingRolesWithUserRequestBuilder AllowedCalendarSharingRolesWithUser(string user)
        {
            if(string.IsNullOrEmpty(user)) throw new ArgumentNullException(nameof(user));
            return new AllowedCalendarSharingRolesWithUserRequestBuilder(PathParameters, RequestAdapter, user);
        }
        /// <summary>
        /// Instantiates a new <see cref="CalendarRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CalendarRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/calendar{?%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CalendarRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CalendarRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/calendar{?%24select}", rawUrl)
        {
        }
        /// <summary>
        /// The user&apos;s primary calendar. Read-only.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.Calendar"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.Calendar?> GetAsync(Action<RequestConfiguration<CalendarRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.Calendar> GetAsync(Action<RequestConfiguration<CalendarRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.Calendar>(requestInfo, Microsoft.Graph.Models.Calendar.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property calendar in users
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.Calendar"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.Calendar?> PatchAsync(Microsoft.Graph.Models.Calendar body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.Calendar> PatchAsync(Microsoft.Graph.Models.Calendar body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.Calendar>(requestInfo, Microsoft.Graph.Models.Calendar.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The user&apos;s primary calendar. Read-only.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CalendarRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CalendarRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property calendar in users
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.Calendar body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.Calendar body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="CalendarRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CalendarRequestBuilder WithUrl(string rawUrl)
        {
            return new CalendarRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// The user&apos;s primary calendar. Read-only.
        /// </summary>
        public class CalendarRequestBuilderGetQueryParameters 
        {
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
        public class CalendarRequestBuilderGetRequestConfiguration : RequestConfiguration<CalendarRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CalendarRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
