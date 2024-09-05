// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Groups.Item.Sites.Item.Analytics;
using Microsoft.Graph.Groups.Item.Sites.Item.Columns;
using Microsoft.Graph.Groups.Item.Sites.Item.ContentTypes;
using Microsoft.Graph.Groups.Item.Sites.Item.CreatedByUser;
using Microsoft.Graph.Groups.Item.Sites.Item.Drive;
using Microsoft.Graph.Groups.Item.Sites.Item.Drives;
using Microsoft.Graph.Groups.Item.Sites.Item.ExternalColumns;
using Microsoft.Graph.Groups.Item.Sites.Item.GetActivitiesByInterval;
using Microsoft.Graph.Groups.Item.Sites.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using Microsoft.Graph.Groups.Item.Sites.Item.GetApplicableContentTypesForListWithListId;
using Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath;
using Microsoft.Graph.Groups.Item.Sites.Item.Items;
using Microsoft.Graph.Groups.Item.Sites.Item.LastModifiedByUser;
using Microsoft.Graph.Groups.Item.Sites.Item.Lists;
using Microsoft.Graph.Groups.Item.Sites.Item.Onenote;
using Microsoft.Graph.Groups.Item.Sites.Item.Operations;
using Microsoft.Graph.Groups.Item.Sites.Item.Pages;
using Microsoft.Graph.Groups.Item.Sites.Item.Permissions;
using Microsoft.Graph.Groups.Item.Sites.Item.Sites;
using Microsoft.Graph.Groups.Item.Sites.Item.TermStore;
using Microsoft.Graph.Groups.Item.Sites.Item.TermStores;
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
namespace Microsoft.Graph.Groups.Item.Sites.Item
{
    /// <summary>
    /// Provides operations to manage the sites property of the microsoft.graph.group entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class SiteItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the analytics property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.Analytics.AnalyticsRequestBuilder Analytics
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.Analytics.AnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columns property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.Columns.ColumnsRequestBuilder Columns
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.Columns.ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contentTypes property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.ContentTypes.ContentTypesRequestBuilder ContentTypes
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.ContentTypes.ContentTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the createdByUser property of the microsoft.graph.baseItem entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.CreatedByUser.CreatedByUserRequestBuilder CreatedByUser
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.CreatedByUser.CreatedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drive property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.Drive.DriveRequestBuilder Drive
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.Drive.DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drives property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.Drives.DrivesRequestBuilder Drives
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.Drives.DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the externalColumns property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.ExternalColumns.ExternalColumnsRequestBuilder ExternalColumns
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.ExternalColumns.ExternalColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getActivitiesByInterval method.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.GetActivitiesByInterval.GetActivitiesByIntervalRequestBuilder GetActivitiesByInterval
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.GetActivitiesByInterval.GetActivitiesByIntervalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the items property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.Items.ItemsRequestBuilder Items
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.Items.ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder LastModifiedByUser
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lists property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.Lists.ListsRequestBuilder Lists
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.Lists.ListsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onenote property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.Onenote.OnenoteRequestBuilder Onenote
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.Onenote.OnenoteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.Operations.OperationsRequestBuilder Operations
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.Operations.OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the pages property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.Pages.PagesRequestBuilder Pages
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.Pages.PagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the permissions property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.Permissions.PermissionsRequestBuilder Permissions
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.Permissions.PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sites property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.Sites.SitesRequestBuilder Sites
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.Sites.SitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the termStore property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.TermStore.TermStoreRequestBuilder TermStore
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.TermStore.TermStoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the termStores property of the microsoft.graph.site entity.</summary>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.TermStores.TermStoresRequestBuilder TermStores
        {
            get => new global::Microsoft.Graph.Groups.Item.Sites.Item.TermStores.TermStoresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Groups.Item.Sites.Item.SiteItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SiteItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Groups.Item.Sites.Item.SiteItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SiteItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Provides operations to call the getActivitiesByInterval method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Groups.Item.Sites.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder"/></returns>
        /// <param name="endDateTime">Usage: endDateTime=&apos;{endDateTime}&apos;</param>
        /// <param name="interval">Usage: interval=&apos;{interval}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime=&apos;{startDateTime}&apos;</param>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval(string endDateTime, string interval, string startDateTime)
        {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(interval)) throw new ArgumentNullException(nameof(interval));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new global::Microsoft.Graph.Groups.Item.Sites.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(PathParameters, RequestAdapter, endDateTime, interval, startDateTime);
        }
        /// <summary>
        /// Provides operations to call the getApplicableContentTypesForList method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Groups.Item.Sites.Item.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder"/></returns>
        /// <param name="listId">Usage: listId=&apos;{listId}&apos;</param>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder GetApplicableContentTypesForListWithListId(string listId)
        {
            if(string.IsNullOrEmpty(listId)) throw new ArgumentNullException(nameof(listId));
            return new global::Microsoft.Graph.Groups.Item.Sites.Item.GetApplicableContentTypesForListWithListId.GetApplicableContentTypesForListWithListIdRequestBuilder(PathParameters, RequestAdapter, listId);
        }
        /// <summary>
        /// The list of SharePoint sites in this group. Access the default site with /sites/root.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Site"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Site?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.SiteItemRequestBuilder.SiteItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Site> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.SiteItemRequestBuilder.SiteItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Site>(requestInfo, global::Microsoft.Graph.Models.Site.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the getByPath method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPathRequestBuilder"/></returns>
        /// <param name="path">Usage: path=&apos;{path}&apos;</param>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPathRequestBuilder GetByPathWithPath(string path)
        {
            if(string.IsNullOrEmpty(path)) throw new ArgumentNullException(nameof(path));
            return new global::Microsoft.Graph.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPathRequestBuilder(PathParameters, RequestAdapter, path);
        }
        /// <summary>
        /// Update the navigation property sites in groups
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Site"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Site?> PatchAsync(global::Microsoft.Graph.Models.Site body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Site> PatchAsync(global::Microsoft.Graph.Models.Site body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Site>(requestInfo, global::Microsoft.Graph.Models.Site.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The list of SharePoint sites in this group. Access the default site with /sites/root.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.SiteItemRequestBuilder.SiteItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.SiteItemRequestBuilder.SiteItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property sites in groups
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Site body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Site body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Groups.Item.Sites.Item.SiteItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Groups.Item.Sites.Item.SiteItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Groups.Item.Sites.Item.SiteItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// The list of SharePoint sites in this group. Access the default site with /sites/root.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class SiteItemRequestBuilderGetQueryParameters 
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
        public partial class SiteItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Groups.Item.Sites.Item.SiteItemRequestBuilder.SiteItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class SiteItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
