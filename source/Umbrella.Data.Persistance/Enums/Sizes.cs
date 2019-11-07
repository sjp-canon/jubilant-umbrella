// ---------------------------------------------------------------------------------------------
// <copyright file="Sizes.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Persistance.Enums
{
    /// <summary>
    /// Defines physical sizes of creatures.
    /// </summary>
    public enum Sizes
    {
        /// <summary>
        /// Invalid/default size.
        /// </summary>
        Invalid = 0,

        /// <summary>
        /// Tiny size; about half the size of a small creature.
        /// </summary>
        Tiny = 1,

        /// <summary>
        /// Small size; about half the size of a medium creature.
        /// </summary>
        Small = 2,

        /// <summary>
        /// Medium size; roughly a normal human adult.
        /// </summary>
        Medium = 3,

        /// <summary>
        /// Large size; about double the size of a medium creature.
        /// </summary>
        Large = 4,

        /// <summary>
        /// Huge size; about double the size of a large creature.
        /// </summary>
        Huge = 5,

        /// <summary>
        /// Gargantuan size; about double the size of a huge creature.
        /// </summary>
        Gargantuan = 6,
    }
}
