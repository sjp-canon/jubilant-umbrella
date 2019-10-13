// ---------------------------------------------------------------------------------------------
// <copyright file="IWriteDataService{TDomain}.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Framework.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines a data service that updates domain objects in the data layer.
    /// </summary>
    public interface IWriteDataService<TDomain>
    {
        /// <summary>
        /// Updates a domain object in the data layer.
        /// </summary>
        Task Update(TDomain model);

        /// <summary>
        /// Updates multiple domain objects in the data layer.
        /// </summary>
        Task UpdateBulk(IEnumerable<TDomain> models);
    }
}
