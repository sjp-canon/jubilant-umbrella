// ---------------------------------------------------------------------------------------------
// <copyright file="Character.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Framework.Domain
{
    using Umbrella.Native.Shell.Framework;

    /// <summary>
    /// A domain object that represents a playable character.
    /// </summary>
    public class Character : PropertyChangedBase
    {
        /// <summary>
        /// Gets a collection of standard ability scores for this character.
        /// </summary>
        public Ability[] Abilities { get; private set; }

        /// <summary>
        /// Gets or sets the ancestry chosen for this character.
        /// </summary>
        public Ancestry Ancestry { get; set; }
    }
}
