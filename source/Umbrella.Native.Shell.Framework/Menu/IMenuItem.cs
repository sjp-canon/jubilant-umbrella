// ---------------------------------------------------------------------------------------------
// <copyright file="IMenuItem.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Native.Shell.Framework.Menu
{
    using System.Collections.Generic;
    using System.Windows.Input;

    /// <summary>
    /// Describes a standard menu item.
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Gets a collection of children menu items.
        /// </summary>
        IList<IMenuItem> ChildrenMenuItems { get; }

        /// <summary>
        /// Gets the parent menu item.
        /// </summary>
        IMenuItem ParentMenuItem { get; }

        /// <summary>
        /// Gets the command to execute when the menu item is chosen.
        /// </summary>
        ICommand MenuCommand { get; }

        /// <summary>
        /// Gets the text to display for this menu item.
        /// </summary>
        string Text { get; }
    }
}
