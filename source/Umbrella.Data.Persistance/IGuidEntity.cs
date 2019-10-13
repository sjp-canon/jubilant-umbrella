// ---------------------------------------------------------------------------------------------
// <copyright file="IGuidEntity.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Persistance
{
    using System;

    /// <summary>
    /// Defines an entity that uses a <see cref="Guid"/> key property.
    /// </summary>
    public interface IGuidEntity
    {
        /// <summary>
        /// Gets the id of this entity.
        /// </summary>
        Guid Id { get; }
    }
}
