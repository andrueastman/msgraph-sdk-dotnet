// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IListRequest.
    /// </summary>
    public partial interface IListRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified List using POST.
        /// </summary>
        /// <param name="listToCreate">The List to create.</param>
        /// <returns>The created List.</returns>
        System.Threading.Tasks.Task<List> CreateAsync(List listToCreate);        /// <summary>
        /// Creates the specified List using POST.
        /// </summary>
        /// <param name="listToCreate">The List to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created List.</returns>
        System.Threading.Tasks.Task<List> CreateAsync(List listToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified List.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified List.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified List.
        /// </summary>
        /// <returns>The List.</returns>
        System.Threading.Tasks.Task<List> GetAsync();

        /// <summary>
        /// Gets the specified List.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The List.</returns>
        System.Threading.Tasks.Task<List> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified List using PATCH.
        /// </summary>
        /// <param name="listToUpdate">The List to update.</param>
        /// <returns>The updated List.</returns>
        System.Threading.Tasks.Task<List> UpdateAsync(List listToUpdate);

        /// <summary>
        /// Updates the specified List using PATCH.
        /// </summary>
        /// <param name="listToUpdate">The List to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated List.</returns>
        System.Threading.Tasks.Task<List> UpdateAsync(List listToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IListRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IListRequest Expand(Expression<Func<List, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IListRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IListRequest Select(Expression<Func<List, object>> selectExpression);

    }
}