// ---------------------------------------------------------------------------------------------
// <copyright file="Feat.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Data.Persistance.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Defines an ability that a character can use or benefits from, but is not a spell or a basic action.
    /// </summary>
    public class Feat : INamedEntity
    {
        /// <inheritdoc/>
        public string Name { get; }
    }
}
