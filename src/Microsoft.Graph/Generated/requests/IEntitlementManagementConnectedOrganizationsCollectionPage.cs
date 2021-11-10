// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IEntitlementManagementConnectedOrganizationsCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<EntitlementManagementConnectedOrganizationsCollectionPage>))]
    public interface IEntitlementManagementConnectedOrganizationsCollectionPage : ICollectionPage<ConnectedOrganization>
    {
        /// <summary>
        /// Gets the next page <see cref="IEntitlementManagementConnectedOrganizationsCollectionRequest"/> instance.
        /// </summary>
        IEntitlementManagementConnectedOrganizationsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
