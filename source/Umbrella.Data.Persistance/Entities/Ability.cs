// ---------------------------------------------------------------------------------------------
// <copyright file="Ability.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Persistance.Entities
{
    /// <summary>
    /// Defines a character's main statistic.
    /// </summary>
    public class Ability : INamedEntity
    {
        /// <inheritdoc/>
        public string Name { get; }

        /// <summary>
        /// Gets the description text for this ability.
        /// </summary>
        public string Description { get; }
    }
}
