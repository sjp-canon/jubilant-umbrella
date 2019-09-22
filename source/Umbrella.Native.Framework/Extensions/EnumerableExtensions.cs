// ---------------------------------------------------------------------------------------------
// <copyright file="EnumerableExtensions.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Native.Framework.Extensions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Common extensions for an object implementing <see cref="IEnumerable"/>.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Performs the action on each item in the collection.
        /// </summary>
        /// <typeparam name="T">The type of the source collection.</typeparam>
        /// <param name="source">The source collection.</param>
        /// <param name="action">The action to perform on each item.</param>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action(item);
            }
        }

        /// <summary>
        /// Performs the asynchronous action on each item in the collection while the loop is not cancelled.
        /// </summary>
        /// <typeparam name="T">The type of the source collection.</typeparam>
        /// <param name="source">The source collection.</param>
        /// <param name="action">The action to perform on each item.</param>
        /// <param name="token">A cancellation token.</param>
        /// <returns>A <see cref="Task"/> representing the result of the asynchronous operation.</returns>
        public static async Task ForEachAsync<T>(this IEnumerable<T> source, Func<T, Task> action, CancellationToken token)
        {
            foreach (var item in source)
            {
                if (token.IsCancellationRequested == false)
                {
                    break;
                }

                await action(item);
            }
        }

        /// <summary>
        /// Performs the action on each item in the collection while the condition remains true.
        /// This method does not guarantee the performance of the action on any items.
        /// </summary>
        /// <typeparam name="T">The type of the source collection.</typeparam>
        /// <param name="source">The source collection.</param>
        /// <param name="action">The action to perform on each item.</param>
        /// <param name="condition">The condition that determines the while loop continuance.</param>
        public static void While<T>(this IEnumerable<T> source, Action<T> action, Func<bool> condition)
        {
            var enumerator = source.GetEnumerator();

            while (condition() && enumerator.MoveNext())
            {
                action(enumerator.Current);
            }
        }

        /// <summary>
        /// Performs the action on each item in the collection while the condition remains true.
        /// This method guarantees the performance of the action on at least the first item in the collection.
        /// </summary>
        /// <typeparam name="T">The type of the source collection.</typeparam>
        /// <param name="source">The source collection.</param>
        /// <param name="action">The action to perform on each item.</param>
        /// <param name="condition">The condition that determins the do-while loop continuance.</param>
        public static void DoWhile<T>(this IEnumerable<T> source, Action<T> action, Func<bool> condition)
        {
            var enumerator = source.GetEnumerator();
            enumerator.MoveNext();

            do
            {
                action(enumerator.Current);
            }
            while (condition() && enumerator.MoveNext());
        }
    }
}
