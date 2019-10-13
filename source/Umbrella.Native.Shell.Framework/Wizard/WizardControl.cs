// ---------------------------------------------------------------------------------------------
// <copyright file="WizardControl.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Native.Shell.Framework.Wizard
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Windows.Input;

    using GalaSoft.MvvmLight.Command;
    using Umbrella.Native.Shell.Framework.ViewModels;

    internal sealed class WizardControl : PropertyChangedBase, IWizardControl
    {
        private IList<ViewModelBase> _viewModels;
        private ViewModelBase _currentViewModel;
        private int _currentViewModelIndex;

        public WizardControl()
        {
            NextCommand = new RelayCommand(ExecuteNextCommand, CanExecuteNextCommand);
            PreviousCommand = new RelayCommand(ExecutePreviousCommand, CanExecutePreviousCommand);
        }

        public ICommand NextCommand { get; }

        public ICommand PreviousCommand { get; }

        public ICommand CancelCommand => throw new NotImplementedException();

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            private set => Set(ref _currentViewModel, value);
        }

        public bool CanLoop { get; set; }

        private IList<ViewModelBase> ViewModels
        {
            get => _viewModels;
            set => Set(ref _viewModels, value.ToList());
        }

        public void StartWizard(IEnumerable<ViewModelBase> viewModels)
        {
            Contract.Requires<ArgumentException>(
                viewModels?.Any() == true,
                "Cannot start a Wizard control with no view models.");
            Contract.Requires<ArgumentException>(
                viewModels.All(v => v != null) == true,
                "Cannot start a Wizard with invalid view models.");

            if (ViewModels.Any())
            {
                ViewModels.Clear();
            }

            _currentViewModelIndex = 0;
            ViewModels = viewModels.ToList();
            CurrentViewModel = ViewModels.First();
        }

        private bool CanExecuteNextCommand() => CanLoop ? true : _currentViewModelIndex < ViewModels.Count - 1;

        private void ExecuteNextCommand()
        {
            var newIndex = _currentViewModelIndex + 1;
            if (newIndex >= ViewModels.Count && CanLoop == false)
            {
                return;
            }
            else if (newIndex >= ViewModels.Count && CanLoop)
            {
                newIndex = 0;
            }

            _currentViewModelIndex = newIndex;
            CurrentViewModel = ViewModels[_currentViewModelIndex];
        }

        private bool CanExecutePreviousCommand() => CanLoop ? true : _currentViewModelIndex > 0;

        private void ExecutePreviousCommand()
        {
            var newIndex = _currentViewModelIndex - 1;
            if (newIndex < 0 && CanLoop == false)
            {
                return;
            }
            else if (newIndex < 0 && CanLoop)
            {
                newIndex = ViewModels.Count - 1;
            }

            _currentViewModelIndex = newIndex;
            CurrentViewModel = ViewModels[_currentViewModelIndex];
        }
    }
}
