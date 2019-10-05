// ---------------------------------------------------------------------------------------------
// <copyright file="IWizardControl.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Native.Shell.Framework.Wizard
{
    using System.Windows.Input;

    using Umbrella.Native.Shell.Framework.ViewModels;

    /// <summary>
    /// Defines a control that takes the user through various steps in an application.
    /// </summary>
    public interface IWizardControl
    {
        /// <summary>
        /// Gets the command to perform to go to the next screen in the wizard.
        /// </summary>
        ICommand NextCommand { get; }

        /// <summary>
        /// Gets the command to perform to go to the previous screen in the wizard.
        /// </summary>
        ICommand PreviousCommand { get; }

        /// <summary>
        /// Gets the command to perform to cancel the wizard process.
        /// </summary>
        ICommand CancelCommand { get; }

        /// <summary>
        /// Gets the view model for the current view on the wizard.
        /// </summary>
        ViewModelBase CurrentViewModel { get; }
    }
}
