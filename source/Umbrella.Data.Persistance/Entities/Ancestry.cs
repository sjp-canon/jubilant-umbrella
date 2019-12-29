// ---------------------------------------------------------------------------------------------
// <copyright file="Ancestry.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Persistance.Entities
{
    using System;
    using System.Collections.Generic;

    using Umbrella.Data.Persistance.Enums;

    /// <summary>
    /// Defines a character's race and racial traits.
    /// </summary>
    public class Ancestry : INamedEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ancestry"/> class.
        /// </summary>
        public Ancestry(
            string name,
            IDictionary<AbilityBonusTypes, Ability[]> abilityAdjustments,
            IList<Feat> feats,
            IList<Languages> languages,
            IList<Heritage> heritages,
            IList<Trait> traits,
            IList<SpecialAbility> specialAbilities,
            Sizes size,
            uint hitPoints,
            uint speedInFeet)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            AbilityAdjustments = abilityAdjustments ?? throw new ArgumentNullException(nameof(abilityAdjustments));
            Feats = feats ?? throw new ArgumentNullException(nameof(feats));
            Languages = languages ?? throw new ArgumentNullException(nameof(languages));
            Heritages = heritages ?? throw new ArgumentNullException(nameof(heritages));
            Traits = traits ?? throw new ArgumentNullException(nameof(traits));
            SpecialAbilities = specialAbilities ?? throw new ArgumentNullException(nameof(specialAbilities));
            Size = size;
            HitPoints = hitPoints;
            SpeedInFeet = speedInFeet;
        }

        /// <inheritdoc/>
        public string Name { get; }

        /// <summary>
        /// Gets a collection of <see cref="Ability"/> score adjustments by how they're adjusted.
        /// </summary>
        public IDictionary<AbilityBonusTypes, Ability[]> AbilityAdjustments { get; }

        /// <summary>
        /// Gets a collection of <see cref="Feat"/>s this ancestry provides.
        /// </summary>
        public IList<Feat> Feats { get; }

        /// <summary>
        /// Gets the collection of <see cref="Languages"/> that adventurers of this ancestry can speak and read.
        /// </summary>
        public IList<Languages> Languages { get; }

        /// <summary>
        /// Gets the collection of <see cref="Heritage"/>s an adventurer can be when choosing this ancestry.
        /// </summary>
        public IList<Heritage> Heritages { get; }

        /// <summary>
        /// Gets the collection of <see cref="Trait"/>s this ancestry has.
        /// </summary>
        public IList<Trait> Traits { get; }

        /// <summary>
        /// Gets the collection of <see cref="SpecialAbility"/>s this ancestry has.
        /// </summary>
        public IList<SpecialAbility> SpecialAbilities { get; }

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
