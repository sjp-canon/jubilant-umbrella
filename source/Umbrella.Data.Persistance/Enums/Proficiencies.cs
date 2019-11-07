// ---------------------------------------------------------------------------------------------
// <copyright file="Proficiencies.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Persistance.Enums
{
    /// <summary>
    /// Defines levels of proficiency.
    /// </summary>
    public enum Proficiencies
    {
        /// <summary>
        /// Invalid/default value.
        /// </summary>
        Invalid = 0,

        /// <summary>
        /// Trained proficiency; adds a bonus equal to character's level.
        /// </summary>
        Trained = 1,

        /// <summary>
        /// Expert proficiency; adds a bonus equal to character's level + 1.
        /// </summary>
        Expert = 2,

        /// <summary>
        /// Master proficiency; adds a bonus equal to character's level + 2.
        /// </summary>
        Master = 3,

        /// <summary>
        /// Legendary proficiency; adds a bonus equal to character's level + 3.
        /// </summary>
        Legendary = 4,
    }
}
