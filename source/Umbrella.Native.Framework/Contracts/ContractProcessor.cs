// ---------------------------------------------------------------------------------------------
// <copyright file="ContractProcessor.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Native.Framework.Contracts
{
    using System;
    using System.Runtime.InteropServices;

    /// <inheritdoc cref="IContractProcessor" />
    public class ContractProcessor : IContractProcessor
    {
        /// <inheritdoc />
        public event EventHandler<ContractFailedEventArgs> ContractFailed;

        /// <inheritdoc />
        public void RequiresPrecondition(bool condition, [Optional] string message) => TestCondition(condition, message);

        /// <inheritdoc />
        public void RequiresPrecondition<TException>(bool condition, [Optional] string message)
            where TException : Exception, new() =>
            TestCondition<TException>(condition, message);

        /// <inheritdoc />
        public void EnsuresPostcondition(bool condition, [Optional] string message) => TestCondition(condition, message);

        /// <inheritdoc />
        public void EnsuresPostcondition<TException>(bool condition, [Optional] string message)
            where TException : Exception, new() =>
            TestCondition<TException>(condition, message);

        /// <inheritdoc />
        public void RaiseContractFailed(
            [Optional] string message,
            [Optional] Exception exception) =>
            ContractFailed?.Invoke(
                this,
                new ContractFailedEventArgs(
                    message,
                    exception));

        private void TestCondition(bool condition, [Optional] string message)
        {
            if (condition == false)
            {
                RaiseContractFailed(message);
            }
        }

        private void TestCondition<TException>(bool condition, [Optional] string message)
            where TException : Exception, new()
        {
            if (condition == false)
            {
                RaiseContractFailed(message, new TException());
            }
        }
    }
}
