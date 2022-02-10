// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Permission Grant Condition Set.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PermissionGrantConditionSet>))]
    public partial class PermissionGrantConditionSet : Entity
    {
    
        /// <summary>
        /// Gets or sets client application ids.
        /// A list of appId values for the client applications to match with, or a list with the single value all to match any client application. Default is the single value all.
        /// </summary>
        [JsonPropertyName("clientApplicationIds")]
        public IEnumerable<string> ClientApplicationIds { get; set; }
    
        /// <summary>
        /// Gets or sets client application publisher ids.
        /// A list of Microsoft Partner Network (MPN) IDs for verified publishers of the client application, or a list with the single value all to match with client apps from any publisher. Default is the single value all.
        /// </summary>
        [JsonPropertyName("clientApplicationPublisherIds")]
        public IEnumerable<string> ClientApplicationPublisherIds { get; set; }
    
        /// <summary>
        /// Gets or sets client applications from verified publisher only.
        /// Set to true to only match on client applications with a verified publisher. Set to false to match on any client app, even if it does not have a verified publisher. Default is false.
        /// </summary>
        [JsonPropertyName("clientApplicationsFromVerifiedPublisherOnly")]
        public bool? ClientApplicationsFromVerifiedPublisherOnly { get; set; }
    
        /// <summary>
        /// Gets or sets client application tenant ids.
        /// A list of Azure Active Directory tenant IDs in which the client application is registered, or a list with the single value all to match with client apps registered in any tenant. Default is the single value all.
        /// </summary>
        [JsonPropertyName("clientApplicationTenantIds")]
        public IEnumerable<string> ClientApplicationTenantIds { get; set; }
    
        /// <summary>
        /// Gets or sets permission classification.
        /// The permission classification for the permission being granted, or all to match with any permission classification (including permissions which are not classified). Default is all.
        /// </summary>
        [JsonPropertyName("permissionClassification")]
        public string PermissionClassification { get; set; }
    
        /// <summary>
        /// Gets or sets permissions.
        /// The list of id values for the specific permissions to match with, or a list with the single value all to match with any permission. The id of delegated permissions can be found in the oauth2PermissionScopes property of the API's **servicePrincipal** object. The id of application permissions can be found in the appRoles property of the API's **servicePrincipal** object. The id of resource-specific application permissions can be found in the resourceSpecificApplicationPermissions property of the API's **servicePrincipal** object. Default is the single value all.
        /// </summary>
        [JsonPropertyName("permissions")]
        public IEnumerable<string> Permissions { get; set; }
    
        /// <summary>
        /// Gets or sets permission type.
        /// The permission type of the permission being granted. Possible values: application for application permissions (e.g. app roles), or delegated for delegated permissions. The value delegatedUserConsentable indicates delegated permissions which have not been configured by the API publisher to require admin consent—this value may be used in built-in permission grant policies, but cannot be used in custom permission grant policies. Required.
        /// </summary>
        [JsonPropertyName("permissionType")]
        public PermissionType? PermissionType { get; set; }
    
        /// <summary>
        /// Gets or sets resource application.
        /// The appId of the resource application (e.g. the API) for which a permission is being granted, or any to match with any resource application or API. Default is any.
        /// </summary>
        [JsonPropertyName("resourceApplication")]
        public string ResourceApplication { get; set; }
    
    }
}

