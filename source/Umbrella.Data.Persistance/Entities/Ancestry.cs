// ---------------------------------------------------------------------------------------------
// <copyright file="Ancestry.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Persistance.Entities
{
    using System.Collections.Generic;

    using Umbrella.Data.Persistance.Enums;

    /// <summary>
    /// Defines a character's race and racial traits.
    /// </summary>
    public class Ancestry : INamedEntity
    {
        /// <inheritdoc/>
        public string Name { get; }

        /// <summary>
        /// Gets a collection of <see cref="Ability"/> score adjustments by how they're adjusted.
        /// </summary>
        public IDictionary<AbilityBonusTypes, Ability[]> AbilityAdjustments { get; }

        /// <summary>
        /// Gets the size a creature with this ancestry is.
        /// </summary>
        public Sizes Size { get; }

        /// <summary>
        /// Gets the number of hit points a character of this ancestry starts with.
        /// </summary>
        public uint HitPoints { get; }

        /// <summary>
        /// Gets the number of feet a character of this ancestry can move with a single move action while unencumbered.
        /// </summary>
        public uint SpeedInFeet { get; }
    }
}
