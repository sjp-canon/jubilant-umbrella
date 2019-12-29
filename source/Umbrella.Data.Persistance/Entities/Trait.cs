// ---------------------------------------------------------------------------------------------
// <copyright file="Trait.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Persistance.Entities
{
    using System;

    /// <summary>
    /// Defines a specific trait that helps define an entity.
    /// </summary>
    public class Trait : INamedEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Trait"/> class.
        /// </summary>
        public Trait(string name, string description)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        /// <inheritdoc/>
        public string Name { get; }

        /// <summary>
        /// Gets the description of this trait.
        /// </summary>
        public string Description { get; }
    }
}
