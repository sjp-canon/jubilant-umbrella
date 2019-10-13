// ---------------------------------------------------------------------------------------------
// <copyright file="IWriteDataRepository{TEntity}.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Persistance.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines a repository interface for updating entities in a data source.
    /// </summary>
    public interface IWriteDataRepository<TEntity>
    {
        /// <summary>
        /// Updates an existing entity in the data source.
        /// </summary>
        Task Update(TEntity entity);

        /// <summary>
        /// Updates multiple entities in the data source.
        /// </summary>
        Task UpdateBulk(IEnumerable<TEntity> entities);
    }
}
