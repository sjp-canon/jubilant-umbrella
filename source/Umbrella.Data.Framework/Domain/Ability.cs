// ---------------------------------------------------------------------------------------------
// <copyright file="Ability.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Framework.Domain
{
    using System;

    using Umbrella.Native.Shell.Framework;

    /// <summary>
    /// Defines a modifiable version of the <see cref="Persistance.Entities.Ability"/> object for use in a UI.
    /// </summary>
    public class Ability : PropertyChangedBase
    {
        private uint _score;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ability"/> class.
        /// </summary>
        public Ability(Persistance.Entities.Ability entity)
        {
            var ability = entity ?? throw new ArgumentNullException(nameof(entity));

            Name = ability.Name;
            Description = ability.Description;
            Score = 10;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ability"/> class.
        /// </summary>
        public Ability(string name, string description, uint score = 10)
        {
            Name = name;
            Description = description;
            Score = score;
        }

        /// <summary>
        /// Gets the name of this ability score.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the description text of this ability score.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets the text abbreviation for this ability.
        /// </summary>
        public string Abbreviation => Name.Substring(0, 3).ToUpperInvariant();

        /// <summary>
        /// Gets or sets the current score of this ability.
        /// </summary>
        public uint Score
        {
            get => _score;
            set
            {
                Set(ref _score, value);
                NotifyPropertyChanged(() => Modifier);
            }
        }

        /// <summary>
        /// Gets the modifier for the current <see cref="Score"/> value.
        /// </summary>
        public int Modifier => (int)((Score / 2) - 5);
    }
}
