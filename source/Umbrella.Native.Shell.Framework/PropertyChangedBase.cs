// ---------------------------------------------------------------------------------------------
// <copyright file="PropertyChangedBase.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Native.Shell.Framework
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// A base implementation of <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    public abstract class PropertyChangedBase : INotifyPropertyChanged
    {
        /// <summary>
        /// The Property Changed event.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Sets the property value and raises the Property Changed event.
        /// </summary>
        /// <typeparam name="TProperty">The type of the property being set.</typeparam>
        /// <param name="oldValue">The original value of the property.</param>
        /// <param name="newValue">The new value of the property.</param>
        /// <param name="propertyName">The name of the property being set.</param>
        public void Set<TProperty>(ref TProperty oldValue, TProperty newValue, [CallerMemberName] string propertyName = null)
        {
            if (Equals(oldValue, newValue) == false)
            {
                oldValue = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
