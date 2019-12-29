// ---------------------------------------------------------------------------------------------
// <copyright file="SpecialAbility.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Persistance.Entities
{
    using System;

    /// <summary>
    /// Defines an ability, sense, or other quality.
    /// </summary>
    public class SpecialAbility : INamedEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialAbility"/> class.
        /// </summary>
        public SpecialAbility(string name, string description)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        /// <inheritdoc/>
        public string Name { get; }

        /// <summary>
        /// Gets the description of this special ability.
        /// </summary>
        public string Description { get; }
    }
}
