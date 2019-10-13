// ---------------------------------------------------------------------------------------------
// <copyright file="INamedEntity.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Persistance
{
    /// <summary>
    /// Defines an entity with a name property.
    /// </summary>
    public interface INamedEntity
    {
        /// <summary>
        /// Gets the name of this entity.
        /// </summary>
        string Name { get; }
    }
}
