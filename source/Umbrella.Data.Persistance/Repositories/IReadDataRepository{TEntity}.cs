// ---------------------------------------------------------------------------------------------
// <copyright file="IReadDataRepository{TEntity}.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Persistance.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines a repository interface for retrieving entities from a data source.
    /// </summary>
    public interface IReadDataRepository<TEntity>
    {
        /// <summary>
        /// Gets the entity with the given id from the data source.
        /// </summary>
        Task<TEntity> Get(Guid id);

        /// <summary>
        /// Gets the entity with the given name from the data source.
        /// </summary>
        Task<TEntity> Get(string name);

        /// <summary>
        /// Gets all entities from the data source.
        /// </summary>
        Task<IEnumerable<TEntity>> GetAll();
    }
}
