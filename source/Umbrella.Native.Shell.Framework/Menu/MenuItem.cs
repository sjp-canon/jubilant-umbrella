// ---------------------------------------------------------------------------------------------
// <copyright file="MenuItem.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Native.Shell.Framework.Menu
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Input;

    /// <summary>
    /// Standard implementation of <see cref="IMenuItem"/>.
    /// </summary>
    public class MenuItem : IMenuItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItem"/> class.
        /// </summary>
        /// <param name="command">The command to execute.</param>
        /// <param name="text">The menu text to display.</param>
        /// <param name="children">A collection of sub menu items.</param>
        /// <param name="parent">The parent menu item.</param>
        public MenuItem(ICommand command, string text, IList<IMenuItem> children = null, IMenuItem parent = null)
        {
            MenuCommand = command ?? throw new ArgumentNullException(nameof(command));
            Text = string.IsNullOrWhiteSpace(text) == false ? text : throw new ArgumentException("Menu requires displayable text", nameof(text));
            ChildrenMenuItems = children?.Any() == false ? throw new ArgumentException("Empty list not supported", nameof(children)) : children;
            ParentMenuItem = parent;
        }

        /// <inheritdoc/>
        public IList<IMenuItem> ChildrenMenuItems { get; }

        /// <inheritdoc/>
        public IMenuItem ParentMenuItem { get; }

        /// <inheritdoc/>
        public ICommand MenuCommand { get; }

        /// <inheritdoc/>
        public string Text { get; }
    }
}
