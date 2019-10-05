// ---------------------------------------------------------------------------------------------
// <copyright file="ViewModelBase.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Native.Shell.Framework.ViewModels
{
    using NLog;

    /// <summary>
    /// A base view-model implementation.
    /// </summary>
    public abstract class ViewModelBase : PropertyChangedBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelBase"/> class.
        /// </summary>
        protected ViewModelBase()
        {
            Logger = LogManager.GetLogger(GetType().ToString());
        }

        /// <summary>
        /// Gets a logger for writing to log targets.
        /// </summary>
        protected Logger Logger { get; }
    }
}
