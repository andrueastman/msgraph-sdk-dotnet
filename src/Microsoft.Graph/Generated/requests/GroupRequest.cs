// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type GroupRequest.
    /// </summary>
    public partial class GroupRequest : BaseRequest, IGroupRequest
    {
        /// <summary>
        /// Constructs a new GroupRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Group using POST.
        /// </summary>
        /// <param name="groupToCreate">The Group to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Group.</returns>
        public async System.Threading.Tasks.Task<Group> CreateAsync(Group groupToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Group>(groupToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Group using POST and returns a <see cref="GraphResponse{Group}"/> object.
        /// </summary>
        /// <param name="groupToCreate">The Group to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Group}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Group>> CreateResponseAsync(Group groupToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Group>(groupToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Group.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Group>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Group and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Group.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Group.</returns>
        public async System.Threading.Tasks.Task<Group> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Group>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Group and returns a <see cref="GraphResponse{Group}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Group}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Group>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Group>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Group using PATCH.
        /// </summary>
        /// <param name="groupToUpdate">The Group to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Group.</returns>
        public async System.Threading.Tasks.Task<Group> UpdateAsync(Group groupToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Group>(groupToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Group using PATCH and returns a <see cref="GraphResponse{Group}"/> object.
        /// </summary>
        /// <param name="groupToUpdate">The Group to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Group}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Group>> UpdateResponseAsync(Group groupToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Group>(groupToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Group using PUT.
        /// </summary>
        /// <param name="groupToUpdate">The Group object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Group> PutAsync(Group groupToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Group>(groupToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Group using PUT and returns a <see cref="GraphResponse{Group}"/> object.
        /// </summary>
        /// <param name="groupToUpdate">The Group object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Group}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Group>> PutResponseAsync(Group groupToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Group>(groupToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupRequest Expand(Expression<Func<Group, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupRequest Select(Expression<Func<Group, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="groupToInitialize">The <see cref="Group"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Group groupToInitialize)
        {

            if (groupToInitialize != null)
            {
                if (groupToInitialize.AppRoleAssignments != null && groupToInitialize.AppRoleAssignments.CurrentPage != null)
                {
                    groupToInitialize.AppRoleAssignments.InitializeNextPageRequest(this.Client, groupToInitialize.AppRoleAssignmentsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.AppRoleAssignments.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.MemberOf != null && groupToInitialize.MemberOf.CurrentPage != null)
                {
                    groupToInitialize.MemberOf.InitializeNextPageRequest(this.Client, groupToInitialize.MemberOfNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.MemberOf.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.Members != null && groupToInitialize.Members.CurrentPage != null)
                {
                    groupToInitialize.Members.InitializeNextPageRequest(this.Client, groupToInitialize.MembersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.Members.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.MembersWithLicenseErrors != null && groupToInitialize.MembersWithLicenseErrors.CurrentPage != null)
                {
                    groupToInitialize.MembersWithLicenseErrors.InitializeNextPageRequest(this.Client, groupToInitialize.MembersWithLicenseErrorsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.MembersWithLicenseErrors.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.Owners != null && groupToInitialize.Owners.CurrentPage != null)
                {
                    groupToInitialize.Owners.InitializeNextPageRequest(this.Client, groupToInitialize.OwnersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.Owners.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.PermissionGrants != null && groupToInitialize.PermissionGrants.CurrentPage != null)
                {
                    groupToInitialize.PermissionGrants.InitializeNextPageRequest(this.Client, groupToInitialize.PermissionGrantsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.PermissionGrants.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.Settings != null && groupToInitialize.Settings.CurrentPage != null)
                {
                    groupToInitialize.Settings.InitializeNextPageRequest(this.Client, groupToInitialize.SettingsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.Settings.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.TransitiveMemberOf != null && groupToInitialize.TransitiveMemberOf.CurrentPage != null)
                {
                    groupToInitialize.TransitiveMemberOf.InitializeNextPageRequest(this.Client, groupToInitialize.TransitiveMemberOfNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.TransitiveMemberOf.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.TransitiveMembers != null && groupToInitialize.TransitiveMembers.CurrentPage != null)
                {
                    groupToInitialize.TransitiveMembers.InitializeNextPageRequest(this.Client, groupToInitialize.TransitiveMembersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.TransitiveMembers.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.AcceptedSenders != null && groupToInitialize.AcceptedSenders.CurrentPage != null)
                {
                    groupToInitialize.AcceptedSenders.InitializeNextPageRequest(this.Client, groupToInitialize.AcceptedSendersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.AcceptedSenders.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.CalendarView != null && groupToInitialize.CalendarView.CurrentPage != null)
                {
                    groupToInitialize.CalendarView.InitializeNextPageRequest(this.Client, groupToInitialize.CalendarViewNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.CalendarView.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.Conversations != null && groupToInitialize.Conversations.CurrentPage != null)
                {
                    groupToInitialize.Conversations.InitializeNextPageRequest(this.Client, groupToInitialize.ConversationsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.Conversations.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.Events != null && groupToInitialize.Events.CurrentPage != null)
                {
                    groupToInitialize.Events.InitializeNextPageRequest(this.Client, groupToInitialize.EventsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.Events.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.RejectedSenders != null && groupToInitialize.RejectedSenders.CurrentPage != null)
                {
                    groupToInitialize.RejectedSenders.InitializeNextPageRequest(this.Client, groupToInitialize.RejectedSendersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.RejectedSenders.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.Threads != null && groupToInitialize.Threads.CurrentPage != null)
                {
                    groupToInitialize.Threads.InitializeNextPageRequest(this.Client, groupToInitialize.ThreadsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.Threads.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.Drives != null && groupToInitialize.Drives.CurrentPage != null)
                {
                    groupToInitialize.Drives.InitializeNextPageRequest(this.Client, groupToInitialize.DrivesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.Drives.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.Sites != null && groupToInitialize.Sites.CurrentPage != null)
                {
                    groupToInitialize.Sites.InitializeNextPageRequest(this.Client, groupToInitialize.SitesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.Sites.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.Extensions != null && groupToInitialize.Extensions.CurrentPage != null)
                {
                    groupToInitialize.Extensions.InitializeNextPageRequest(this.Client, groupToInitialize.ExtensionsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.Extensions.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.GroupLifecyclePolicies != null && groupToInitialize.GroupLifecyclePolicies.CurrentPage != null)
                {
                    groupToInitialize.GroupLifecyclePolicies.InitializeNextPageRequest(this.Client, groupToInitialize.GroupLifecyclePoliciesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.GroupLifecyclePolicies.AdditionalData = groupToInitialize.AdditionalData;
                }
                if (groupToInitialize.Photos != null && groupToInitialize.Photos.CurrentPage != null)
                {
                    groupToInitialize.Photos.InitializeNextPageRequest(this.Client, groupToInitialize.PhotosNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupToInitialize.Photos.AdditionalData = groupToInitialize.AdditionalData;
                }

            }


        }
    }
}
