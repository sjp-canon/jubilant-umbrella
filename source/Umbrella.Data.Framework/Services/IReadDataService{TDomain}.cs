// ---------------------------------------------------------------------------------------------
// <copyright file="IReadDataService{TDomain}.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Framework.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines a data service that gets domain objects from the data layer.
    /// </summary>
    public interface IReadDataService<TDomain>
    {
        /// <summary>
        /// Gets all domain objects from the data layer.
        /// </summary>
        Task<IEnumerable<TDomain>> Get();

        /// <summary>
        /// Gets the domain object from the data layer with the given id.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if the id is default.</exception>
        /// <exception cref="InvalidOperationException">Thrown if the entity could not be found.</exception>
        Task<TDomain> Get(Guid id);

        /// <summary>
        /// Gets the domain object from the data layer with the given name.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if the name is null.</exception>
        /// <exception cref="InvalidOperationException">Thrown if the entity could not be found.</exception>
        Task<TDomain> Get(string name);
    }
}
