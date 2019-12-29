// ---------------------------------------------------------------------------------------------
// <copyright file="Ancestry.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Framework.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;

    using Umbrella.Data.Persistance.Entities;
    using Umbrella.Data.Persistance.Enums;
    using Umbrella.Native.Shell.Framework;

    /// <summary>
    /// A domain object that represents an adventurer's <see cref="Persistance.Entities.Ancestry"/> and related options.
    /// </summary>
    public class Ancestry : PropertyChangedBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ancestry"/> class.
        /// </summary>
        public Ancestry(Persistance.Entities.Ancestry ancestry)
        {
            Contract.Requires<ArgumentNullException>(
                ancestry != null,
                nameof(ancestry));

            Name = ancestry.Name;
            AncestryAbilityAdjustments = ancestry
                .AbilityAdjustments
                .ToDictionary(
                    p => p.Key,
                    p => p
                        .Value
                        .Select(e => new Ability(e))
                        .ToArray());
            Languages = ancestry.Languages;
            Heritages = ancestry.Heritages;
            AncestryFeats = ancestry.Feats;
            Traits = ancestry.Traits;
            SpecialAbilities = ancestry.SpecialAbilities;
            Size = ancestry.Size;
            HitPoints = ancestry.HitPoints;
            SpeedInFeet = ancestry.SpeedInFeet;

            Heritage = null;
            Feats = new List<Feat>();
        }

        /// <summary>
        /// Gets the name of this Ancestry.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the collection of ability score adjustments this ancestry provides.
        /// </summary>
        public IDictionary<AbilityBonusTypes, Ability[]> AncestryAbilityAdjustments { get; }

        /// <summary>
        /// Gets the ability score adjustments allowed by this ancestry that the player has chosen to apply to this character.
        /// </summary>
        public IList<Ability> AbilityScoreAdjustments { get; }

        /// <summary>
        /// Gets the collection of ancestry feats this ancestry offers.
        /// </summary>
        public IList<Feat> AncestryFeats { get; }

        /// <summary>
        /// Gets the ancestry feats that the player has chosen to apply to this character.
        /// </summary>
        public IList<Feat> Feats { get; }

        /// <summary>
        /// Gets the languages a character of this ancestry can speak. Also includes any chosen languages for having a higher Intelligence score.
        /// </summary>
        public IList<Languages> Languages { get; }

        /// <summary>
        /// Gets the collection of heritages available to a character of this ancestry.
        /// </summary>
        public IList<Heritage> Heritages { get; }

        /// <summary>
        /// Gets or sets the heritage the player has chosen for this character to belong to.
        /// </summary>
        public Heritage Heritage { get; set; }

        /// <summary>
        /// Gets the collection of traits that apply to a character of this ancestry.
        /// </summary>
        public IList<Trait> Traits { get; }

        /// <summary>
        /// Gets the collection of special abilities that apply to a character of this ancestry.
        /// </summary>
        public IList<SpecialAbility> SpecialAbilities { get; }

        /// <summary>
        /// Gets the size of a character of this ancestry.
        /// </summary>
        public Sizes Size { get; }

        /// <summary>
        /// Gets the number of starting hit points a character of this ancestry has.
        /// </summary>
        public uint HitPoints { get; }

        /// <summary>
        /// Gets the number of feet a character of this ancestry can move in one action.
        /// </summary>
        public uint SpeedInFeet { get; }
    }
}
