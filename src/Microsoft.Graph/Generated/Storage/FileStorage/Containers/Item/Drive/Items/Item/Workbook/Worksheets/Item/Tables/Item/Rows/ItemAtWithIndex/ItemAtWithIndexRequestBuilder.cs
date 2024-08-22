// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Rows.ItemAtWithIndex.RangeNamespace;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Rows.ItemAtWithIndex
{
    /// <summary>
    /// Provides operations to call the itemAt method.
    /// </summary>
    public class ItemAtWithIndexRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the range method.</summary>
        public Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Rows.ItemAtWithIndex.RangeNamespace.RangeRequestBuilder Range
        {
            get => new Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Rows.ItemAtWithIndex.RangeNamespace.RangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Rows.ItemAtWithIndex.ItemAtWithIndexRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="index">Usage: index={index}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemAtWithIndexRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, int? index = default) : base(requestAdapter, "{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/tables/{workbookTable%2Did}/rows/itemAt(index={index})", pathParameters)
        {
            if (index != null) PathParameters.Add("index", index);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Rows.ItemAtWithIndex.ItemAtWithIndexRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemAtWithIndexRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/tables/{workbookTable%2Did}/rows/itemAt(index={index})", rawUrl)
        {
        }
        /// <summary>
        /// Gets a row based on its position in the collection.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/tablerowcollection-itemat?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.WorkbookTableRow"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.WorkbookTableRow?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.WorkbookTableRow> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.WorkbookTableRow>(requestInfo, Microsoft.Graph.Models.WorkbookTableRow.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a row based on its position in the collection.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Rows.ItemAtWithIndex.ItemAtWithIndexRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Rows.ItemAtWithIndex.ItemAtWithIndexRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Rows.ItemAtWithIndex.ItemAtWithIndexRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ItemAtWithIndexRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}