// ---------------------------------------------------------------------------------------------
// <copyright file="IManageDataService{TDomain}.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Framework.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines a data service that creates or deletes domain objects in the data layer.
    /// </summary>
    public interface IManageDataService<TDomain>
    {
        /// <summary>
        /// Creates a new domain object in the data layer.
        /// </summary>
        Task Create(TDomain model);

        /// <summary>
        /// Creates multiple new domain objects in the data layer.
        /// </summary>
        Task CreateBulk(IEnumerable<TDomain> models);

        /// <summary>
        /// Destroys a domain object in the data layer.
        /// </summary>
        Task Destroy(TDomain model);

        /// <summary>
        /// Destroys multiple domain objects in the data layer.
        /// </summary>
        Task DestroyBulk(IEnumerable<TDomain> models);
    }
}
