// ---------------------------------------------------------------------------------------------
// <copyright file="PropertyChangedBase.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Native.Shell.Framework
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;
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
        public void Set<TProperty>(ref TProperty oldValue, TProperty newValue, [CallerMemberName] string propertyName = null)
        {
            if (Equals(oldValue, newValue) == false)
            {
                oldValue = newValue;
                NotifyPropertyChanged(propertyName);
            }
        }

        /// <summary>
        /// Notifies all listeners that the property's value has changed.
        /// </summary>
        public void NotifyPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Notifies all listeners that the property's value has changed.
        /// </summary>
        public void NotifyPropertyChanged<TProperty>(Expression<Func<TProperty>> projection)
        {
            var memberExpression = (MemberExpression)projection.Body;
            NotifyPropertyChanged(memberExpression.Member.Name);
        }
    }
}
