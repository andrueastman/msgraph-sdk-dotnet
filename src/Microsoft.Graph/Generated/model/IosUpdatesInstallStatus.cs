// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum IosUpdatesInstallStatus.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum IosUpdatesInstallStatus
    {
    
        /// <summary>
        /// Success
        /// </summary>
        Success = 0,
	
        /// <summary>
        /// Available
        /// </summary>
        Available = 1,
	
        /// <summary>
        /// Idle
        /// </summary>
        Idle = 2,
	
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 3,
	
        /// <summary>
        /// Downloading
        /// </summary>
        Downloading = -2016330712,
	
        /// <summary>
        /// Download Failed
        /// </summary>
        DownloadFailed = -2016330711,
	
        /// <summary>
        /// Download Requires Computer
        /// </summary>
        DownloadRequiresComputer = -2016330710,
	
        /// <summary>
        /// Download Insufficient Space
        /// </summary>
        DownloadInsufficientSpace = -2016330709,
	
        /// <summary>
        /// Download Insufficient Power
        /// </summary>
        DownloadInsufficientPower = -2016330708,
	
        /// <summary>
        /// Download Insufficient Network
        /// </summary>
        DownloadInsufficientNetwork = -2016330707,
	
        /// <summary>
        /// Installing
        /// </summary>
        Installing = -2016330706,
	
        /// <summary>
        /// Install Insufficient Space
        /// </summary>
        InstallInsufficientSpace = -2016330705,
	
        /// <summary>
        /// Install Insufficient Power
        /// </summary>
        InstallInsufficientPower = -2016330704,
	
        /// <summary>
        /// Install Phone Call In Progress
        /// </summary>
        InstallPhoneCallInProgress = -2016330703,
	
        /// <summary>
        /// Install Failed
        /// </summary>
        InstallFailed = -2016330702,
	
        /// <summary>
        /// Not Supported Operation
        /// </summary>
        NotSupportedOperation = -2016330701,
	
        /// <summary>
        /// Shared Device User Logged In Error
        /// </summary>
        SharedDeviceUserLoggedInError = -2016330699,
	
        /// <summary>
        /// Device Os Higher Than Desired Os Version
        /// </summary>
        DeviceOsHigherThanDesiredOsVersion = -2016330696,
	
    }
}