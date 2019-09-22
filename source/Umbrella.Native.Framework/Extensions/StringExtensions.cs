// --------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// --------------------------------------------------------------

namespace Umbrella.Native.Framework.Extensions
{
    using System;

    /// <summary>
    /// Common extensions for <see cref="string"/> objects.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Determines if the source contains the token string, using a culture-sensitive string comparison.
        /// </summary>
        /// <param name="source">The source string to search over.</param>
        /// <param name="token">The substring to search for.</param>
        /// <param name="comparison">The comparison setting.</param>
        /// <returns>True if the token is located in the source; false otherwise.</returns>
        public static bool Contains(this string source, string token, StringComparison comparison = StringComparison.InvariantCulture)
        {
            return source?.IndexOf(token, comparison) >= 0;
        }
    }
}
