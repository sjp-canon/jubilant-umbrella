// ---------------------------------------------------------------------------------------------
// <copyright file="Feat.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Persistance.Entities
{
    using System;

    /// <summary>
    /// Defines an ability that a character can use or benefits from, but is not a spell or a basic action.
    /// </summary>
    public class Feat : INamedEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Feat"/> class.
        /// </summary>
        public Feat(string name, string description)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        /// <inheritdoc/>
        public string Name { get; }

        /// <summary>
        /// Gets the description of this feat.
        /// </summary>
        public string Description { get; }
    }
}
