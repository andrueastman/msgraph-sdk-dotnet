// <auto-generated/>
using Microsoft.Graph.Me.ManagedDevices.Item.BypassActivationLock;
using Microsoft.Graph.Me.ManagedDevices.Item.CleanWindowsDevice;
using Microsoft.Graph.Me.ManagedDevices.Item.DeleteUserFromSharedAppleDevice;
using Microsoft.Graph.Me.ManagedDevices.Item.DeviceCategory;
using Microsoft.Graph.Me.ManagedDevices.Item.DeviceCompliancePolicyStates;
using Microsoft.Graph.Me.ManagedDevices.Item.DeviceConfigurationStates;
using Microsoft.Graph.Me.ManagedDevices.Item.DisableLostMode;
using Microsoft.Graph.Me.ManagedDevices.Item.LocateDevice;
using Microsoft.Graph.Me.ManagedDevices.Item.LogCollectionRequests;
using Microsoft.Graph.Me.ManagedDevices.Item.LogoutSharedAppleDeviceActiveUser;
using Microsoft.Graph.Me.ManagedDevices.Item.RebootNow;
using Microsoft.Graph.Me.ManagedDevices.Item.RecoverPasscode;
using Microsoft.Graph.Me.ManagedDevices.Item.RemoteLock;
using Microsoft.Graph.Me.ManagedDevices.Item.RequestRemoteAssistance;
using Microsoft.Graph.Me.ManagedDevices.Item.ResetPasscode;
using Microsoft.Graph.Me.ManagedDevices.Item.Retire;
using Microsoft.Graph.Me.ManagedDevices.Item.ShutDown;
using Microsoft.Graph.Me.ManagedDevices.Item.SyncDevice;
using Microsoft.Graph.Me.ManagedDevices.Item.UpdateWindowsDeviceAccount;
using Microsoft.Graph.Me.ManagedDevices.Item.Users;
using Microsoft.Graph.Me.ManagedDevices.Item.WindowsDefenderScan;
using Microsoft.Graph.Me.ManagedDevices.Item.WindowsDefenderUpdateSignatures;
using Microsoft.Graph.Me.ManagedDevices.Item.WindowsProtectionState;
using Microsoft.Graph.Me.ManagedDevices.Item.Wipe;
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
namespace Microsoft.Graph.Me.ManagedDevices.Item
{
    /// <summary>
    /// Provides operations to manage the managedDevices property of the microsoft.graph.user entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ManagedDeviceItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the bypassActivationLock method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.BypassActivationLock.BypassActivationLockRequestBuilder BypassActivationLock
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.BypassActivationLock.BypassActivationLockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the cleanWindowsDevice method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.CleanWindowsDevice.CleanWindowsDeviceRequestBuilder CleanWindowsDevice
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.CleanWindowsDevice.CleanWindowsDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the deleteUserFromSharedAppleDevice method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.DeleteUserFromSharedAppleDevice.DeleteUserFromSharedAppleDeviceRequestBuilder DeleteUserFromSharedAppleDevice
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.DeleteUserFromSharedAppleDevice.DeleteUserFromSharedAppleDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCategory property of the microsoft.graph.managedDevice entity.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.DeviceCategory.DeviceCategoryRequestBuilder DeviceCategory
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.DeviceCategory.DeviceCategoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCompliancePolicyStates property of the microsoft.graph.managedDevice entity.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.DeviceCompliancePolicyStates.DeviceCompliancePolicyStatesRequestBuilder DeviceCompliancePolicyStates
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.DeviceCompliancePolicyStates.DeviceCompliancePolicyStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceConfigurationStates property of the microsoft.graph.managedDevice entity.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.DeviceConfigurationStates.DeviceConfigurationStatesRequestBuilder DeviceConfigurationStates
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.DeviceConfigurationStates.DeviceConfigurationStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the disableLostMode method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.DisableLostMode.DisableLostModeRequestBuilder DisableLostMode
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.DisableLostMode.DisableLostModeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the locateDevice method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.LocateDevice.LocateDeviceRequestBuilder LocateDevice
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.LocateDevice.LocateDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the logCollectionRequests property of the microsoft.graph.managedDevice entity.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.LogCollectionRequests.LogCollectionRequestsRequestBuilder LogCollectionRequests
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.LogCollectionRequests.LogCollectionRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the logoutSharedAppleDeviceActiveUser method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.LogoutSharedAppleDeviceActiveUser.LogoutSharedAppleDeviceActiveUserRequestBuilder LogoutSharedAppleDeviceActiveUser
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.LogoutSharedAppleDeviceActiveUser.LogoutSharedAppleDeviceActiveUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rebootNow method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.RebootNow.RebootNowRequestBuilder RebootNow
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.RebootNow.RebootNowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the recoverPasscode method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.RecoverPasscode.RecoverPasscodeRequestBuilder RecoverPasscode
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.RecoverPasscode.RecoverPasscodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the remoteLock method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.RemoteLock.RemoteLockRequestBuilder RemoteLock
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.RemoteLock.RemoteLockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the requestRemoteAssistance method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.RequestRemoteAssistance.RequestRemoteAssistanceRequestBuilder RequestRemoteAssistance
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.RequestRemoteAssistance.RequestRemoteAssistanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the resetPasscode method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.ResetPasscode.ResetPasscodeRequestBuilder ResetPasscode
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.ResetPasscode.ResetPasscodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the retire method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.Retire.RetireRequestBuilder Retire
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.Retire.RetireRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the shutDown method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.ShutDown.ShutDownRequestBuilder ShutDown
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.ShutDown.ShutDownRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the syncDevice method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.SyncDevice.SyncDeviceRequestBuilder SyncDevice
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.SyncDevice.SyncDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateWindowsDeviceAccount method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.UpdateWindowsDeviceAccount.UpdateWindowsDeviceAccountRequestBuilder UpdateWindowsDeviceAccount
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.UpdateWindowsDeviceAccount.UpdateWindowsDeviceAccountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the users property of the microsoft.graph.managedDevice entity.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.Users.UsersRequestBuilder Users
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.Users.UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the windowsDefenderScan method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.WindowsDefenderScan.WindowsDefenderScanRequestBuilder WindowsDefenderScan
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.WindowsDefenderScan.WindowsDefenderScanRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the windowsDefenderUpdateSignatures method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.WindowsDefenderUpdateSignatures.WindowsDefenderUpdateSignaturesRequestBuilder WindowsDefenderUpdateSignatures
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.WindowsDefenderUpdateSignatures.WindowsDefenderUpdateSignaturesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsProtectionState property of the microsoft.graph.managedDevice entity.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.WindowsProtectionState.WindowsProtectionStateRequestBuilder WindowsProtectionState
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.WindowsProtectionState.WindowsProtectionStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the wipe method.</summary>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.Wipe.WipeRequestBuilder Wipe
        {
            get => new global::Microsoft.Graph.Me.ManagedDevices.Item.Wipe.WipeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.ManagedDevices.Item.ManagedDeviceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedDeviceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/managedDevices/{managedDevice%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.ManagedDevices.Item.ManagedDeviceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedDeviceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/managedDevices/{managedDevice%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property managedDevices for me
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
        /// The managed devices associated with the user.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ManagedDevice"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.ManagedDevice?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.ManagedDevices.Item.ManagedDeviceItemRequestBuilder.ManagedDeviceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.ManagedDevice> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.ManagedDevices.Item.ManagedDeviceItemRequestBuilder.ManagedDeviceItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.ManagedDevice>(requestInfo, global::Microsoft.Graph.Models.ManagedDevice.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property managedDevices in me
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ManagedDevice"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.ManagedDevice?> PatchAsync(global::Microsoft.Graph.Models.ManagedDevice body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.ManagedDevice> PatchAsync(global::Microsoft.Graph.Models.ManagedDevice body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.ManagedDevice>(requestInfo, global::Microsoft.Graph.Models.ManagedDevice.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property managedDevices for me
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
        /// The managed devices associated with the user.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.ManagedDevices.Item.ManagedDeviceItemRequestBuilder.ManagedDeviceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.ManagedDevices.Item.ManagedDeviceItemRequestBuilder.ManagedDeviceItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property managedDevices in me
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.ManagedDevice body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.ManagedDevice body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Me.ManagedDevices.Item.ManagedDeviceItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Me.ManagedDevices.Item.ManagedDeviceItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Me.ManagedDevices.Item.ManagedDeviceItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ManagedDeviceItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ManagedDeviceItemRequestBuilderGetQueryParameters 
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
        public partial class ManagedDeviceItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Me.ManagedDevices.Item.ManagedDeviceItemRequestBuilder.ManagedDeviceItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ManagedDeviceItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
