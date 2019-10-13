// ---------------------------------------------------------------------------------------------
// <copyright file="IManageDataRepository{TEntity}.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Persistance.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines a repository interface that creates or removes entities in a data source.
    /// </summary>
    public interface IManageDataRepository<TEntity>
    {
        /// <summary>
        /// Creates a new entity record in the data source.
        /// </summary>
        Task Create(TEntity entity);

        /// <summary>
        /// Creates multiple new entity records in the data source.
        /// </summary>
        Task CreateBulk(IEnumerable<TEntity> entities);

        /// <summary>
        /// Destroys an entity record in the data source.
        /// </summary>
        Task Destroy(TEntity entity);

        /// <summary>
        /// Destroys multiple entity reocrds in the data source.
        /// </summary>
        Task DestroyBulk(IEnumerable<TEntity> entities);
    }
}
