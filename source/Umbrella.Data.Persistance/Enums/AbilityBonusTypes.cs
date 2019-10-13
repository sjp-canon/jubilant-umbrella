// ---------------------------------------------------------------------------------------------
// <copyright file="AbilityBonusTypes.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Persistance.Enums
{
    /// <summary>
    /// Defines how an ability bonus should be applied.
    /// </summary>
    public enum AbilityBonusTypes
    {
        /// <summary>
        /// Invalid/default value.
        /// </summary>
        Invalid = 0,

        /// <summary>
        /// Apply as a bonus.
        /// </summary>
        Bonus = 1,

        /// <summary>
        /// Apply as a flaw.
        /// </summary>
        Flaw = 2,

        /// <summary>
        /// Apply as a free bonus.
        /// </summary>
        Free = 3,
    }
}
