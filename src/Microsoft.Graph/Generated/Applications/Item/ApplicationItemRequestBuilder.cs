// <auto-generated/>
using Microsoft.Graph.Applications.Item.AddKey;
using Microsoft.Graph.Applications.Item.AddPassword;
using Microsoft.Graph.Applications.Item.AppManagementPolicies;
using Microsoft.Graph.Applications.Item.CheckMemberGroups;
using Microsoft.Graph.Applications.Item.CheckMemberObjects;
using Microsoft.Graph.Applications.Item.CreatedOnBehalfOf;
using Microsoft.Graph.Applications.Item.ExtensionProperties;
using Microsoft.Graph.Applications.Item.FederatedIdentityCredentials;
using Microsoft.Graph.Applications.Item.FederatedIdentityCredentialsWithName;
using Microsoft.Graph.Applications.Item.GetMemberGroups;
using Microsoft.Graph.Applications.Item.GetMemberObjects;
using Microsoft.Graph.Applications.Item.HomeRealmDiscoveryPolicies;
using Microsoft.Graph.Applications.Item.Logo;
using Microsoft.Graph.Applications.Item.Owners;
using Microsoft.Graph.Applications.Item.RemoveKey;
using Microsoft.Graph.Applications.Item.RemovePassword;
using Microsoft.Graph.Applications.Item.Restore;
using Microsoft.Graph.Applications.Item.SetVerifiedPublisher;
using Microsoft.Graph.Applications.Item.Synchronization;
using Microsoft.Graph.Applications.Item.TokenIssuancePolicies;
using Microsoft.Graph.Applications.Item.TokenLifetimePolicies;
using Microsoft.Graph.Applications.Item.UnsetVerifiedPublisher;
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
namespace Microsoft.Graph.Applications.Item
{
    /// <summary>
    /// Provides operations to manage the collection of application entities.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ApplicationItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the addKey method.</summary>
        public global::Microsoft.Graph.Applications.Item.AddKey.AddKeyRequestBuilder AddKey
        {
            get => new global::Microsoft.Graph.Applications.Item.AddKey.AddKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the addPassword method.</summary>
        public global::Microsoft.Graph.Applications.Item.AddPassword.AddPasswordRequestBuilder AddPassword
        {
            get => new global::Microsoft.Graph.Applications.Item.AddPassword.AddPasswordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appManagementPolicies property of the microsoft.graph.application entity.</summary>
        public global::Microsoft.Graph.Applications.Item.AppManagementPolicies.AppManagementPoliciesRequestBuilder AppManagementPolicies
        {
            get => new global::Microsoft.Graph.Applications.Item.AppManagementPolicies.AppManagementPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberGroups method.</summary>
        public global::Microsoft.Graph.Applications.Item.CheckMemberGroups.CheckMemberGroupsRequestBuilder CheckMemberGroups
        {
            get => new global::Microsoft.Graph.Applications.Item.CheckMemberGroups.CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberObjects method.</summary>
        public global::Microsoft.Graph.Applications.Item.CheckMemberObjects.CheckMemberObjectsRequestBuilder CheckMemberObjects
        {
            get => new global::Microsoft.Graph.Applications.Item.CheckMemberObjects.CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the createdOnBehalfOf property of the microsoft.graph.application entity.</summary>
        public global::Microsoft.Graph.Applications.Item.CreatedOnBehalfOf.CreatedOnBehalfOfRequestBuilder CreatedOnBehalfOf
        {
            get => new global::Microsoft.Graph.Applications.Item.CreatedOnBehalfOf.CreatedOnBehalfOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the extensionProperties property of the microsoft.graph.application entity.</summary>
        public global::Microsoft.Graph.Applications.Item.ExtensionProperties.ExtensionPropertiesRequestBuilder ExtensionProperties
        {
            get => new global::Microsoft.Graph.Applications.Item.ExtensionProperties.ExtensionPropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the federatedIdentityCredentials property of the microsoft.graph.application entity.</summary>
        public global::Microsoft.Graph.Applications.Item.FederatedIdentityCredentials.FederatedIdentityCredentialsRequestBuilder FederatedIdentityCredentials
        {
            get => new global::Microsoft.Graph.Applications.Item.FederatedIdentityCredentials.FederatedIdentityCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberGroups method.</summary>
        public global::Microsoft.Graph.Applications.Item.GetMemberGroups.GetMemberGroupsRequestBuilder GetMemberGroups
        {
            get => new global::Microsoft.Graph.Applications.Item.GetMemberGroups.GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberObjects method.</summary>
        public global::Microsoft.Graph.Applications.Item.GetMemberObjects.GetMemberObjectsRequestBuilder GetMemberObjects
        {
            get => new global::Microsoft.Graph.Applications.Item.GetMemberObjects.GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the homeRealmDiscoveryPolicies property of the microsoft.graph.application entity.</summary>
        public global::Microsoft.Graph.Applications.Item.HomeRealmDiscoveryPolicies.HomeRealmDiscoveryPoliciesRequestBuilder HomeRealmDiscoveryPolicies
        {
            get => new global::Microsoft.Graph.Applications.Item.HomeRealmDiscoveryPolicies.HomeRealmDiscoveryPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the application entity.</summary>
        public global::Microsoft.Graph.Applications.Item.Logo.LogoRequestBuilder Logo
        {
            get => new global::Microsoft.Graph.Applications.Item.Logo.LogoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the owners property of the microsoft.graph.application entity.</summary>
        public global::Microsoft.Graph.Applications.Item.Owners.OwnersRequestBuilder Owners
        {
            get => new global::Microsoft.Graph.Applications.Item.Owners.OwnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the removeKey method.</summary>
        public global::Microsoft.Graph.Applications.Item.RemoveKey.RemoveKeyRequestBuilder RemoveKey
        {
            get => new global::Microsoft.Graph.Applications.Item.RemoveKey.RemoveKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the removePassword method.</summary>
        public global::Microsoft.Graph.Applications.Item.RemovePassword.RemovePasswordRequestBuilder RemovePassword
        {
            get => new global::Microsoft.Graph.Applications.Item.RemovePassword.RemovePasswordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restore method.</summary>
        public global::Microsoft.Graph.Applications.Item.Restore.RestoreRequestBuilder Restore
        {
            get => new global::Microsoft.Graph.Applications.Item.Restore.RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setVerifiedPublisher method.</summary>
        public global::Microsoft.Graph.Applications.Item.SetVerifiedPublisher.SetVerifiedPublisherRequestBuilder SetVerifiedPublisher
        {
            get => new global::Microsoft.Graph.Applications.Item.SetVerifiedPublisher.SetVerifiedPublisherRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the synchronization property of the microsoft.graph.application entity.</summary>
        public global::Microsoft.Graph.Applications.Item.Synchronization.SynchronizationRequestBuilder Synchronization
        {
            get => new global::Microsoft.Graph.Applications.Item.Synchronization.SynchronizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tokenIssuancePolicies property of the microsoft.graph.application entity.</summary>
        public global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder TokenIssuancePolicies
        {
            get => new global::Microsoft.Graph.Applications.Item.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tokenLifetimePolicies property of the microsoft.graph.application entity.</summary>
        public global::Microsoft.Graph.Applications.Item.TokenLifetimePolicies.TokenLifetimePoliciesRequestBuilder TokenLifetimePolicies
        {
            get => new global::Microsoft.Graph.Applications.Item.TokenLifetimePolicies.TokenLifetimePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unsetVerifiedPublisher method.</summary>
        public global::Microsoft.Graph.Applications.Item.UnsetVerifiedPublisher.UnsetVerifiedPublisherRequestBuilder UnsetVerifiedPublisher
        {
            get => new global::Microsoft.Graph.Applications.Item.UnsetVerifiedPublisher.UnsetVerifiedPublisherRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Applications.Item.ApplicationItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApplicationItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications/{application%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Applications.Item.ApplicationItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApplicationItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications/{application%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete an application object. When deleted, apps are moved to a temporary container and can be restored within 30 days. After that time, they are permanently deleted.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/application-delete?view=graph-rest-1.0" />
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
        /// Provides operations to manage the federatedIdentityCredentials property of the microsoft.graph.application entity.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Applications.Item.FederatedIdentityCredentialsWithName.FederatedIdentityCredentialsWithNameRequestBuilder"/></returns>
        /// <param name="name">Alternate key of federatedIdentityCredential</param>
        public global::Microsoft.Graph.Applications.Item.FederatedIdentityCredentialsWithName.FederatedIdentityCredentialsWithNameRequestBuilder FederatedIdentityCredentialsWithName(string name)
        {
            if(string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
            return new global::Microsoft.Graph.Applications.Item.FederatedIdentityCredentialsWithName.FederatedIdentityCredentialsWithNameRequestBuilder(PathParameters, RequestAdapter, name);
        }
        /// <summary>
        /// Get the properties and relationships of an application object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/application-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Application"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Application?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Applications.Item.ApplicationItemRequestBuilder.ApplicationItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Application> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Applications.Item.ApplicationItemRequestBuilder.ApplicationItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Application>(requestInfo, global::Microsoft.Graph.Models.Application.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new application object if it doesn&apos;t exist, or update the properties of an existing application object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/application-upsert?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Application"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Application?> PatchAsync(global::Microsoft.Graph.Models.Application body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Application> PatchAsync(global::Microsoft.Graph.Models.Application body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Application>(requestInfo, global::Microsoft.Graph.Models.Application.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete an application object. When deleted, apps are moved to a temporary container and can be restored within 30 days. After that time, they are permanently deleted.
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
        /// Get the properties and relationships of an application object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Applications.Item.ApplicationItemRequestBuilder.ApplicationItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Applications.Item.ApplicationItemRequestBuilder.ApplicationItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new application object if it doesn&apos;t exist, or update the properties of an existing application object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Application body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Application body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Applications.Item.ApplicationItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Applications.Item.ApplicationItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Applications.Item.ApplicationItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ApplicationItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Get the properties and relationships of an application object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ApplicationItemRequestBuilderGetQueryParameters 
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
        public partial class ApplicationItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Applications.Item.ApplicationItemRequestBuilder.ApplicationItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ApplicationItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
