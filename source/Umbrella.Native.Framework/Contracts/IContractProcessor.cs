// ---------------------------------------------------------------------------------------------
// <copyright file="IContractProcessor.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Native.Framework.Contracts
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Defines a processor of contractual pre- and post-conditions.
    /// </summary>
    public interface IContractProcessor
    {
        /// <summary>
        /// The contract failed event.
        /// </summary>
        event EventHandler<ContractFailedEventArgs> ContractFailed;

        /// <summary>
        /// Determines if the condition resolves to true; should be used to determing validity of outputs.
        /// </summary>
        void EnsuresPostcondition(bool condition, [Optional] string message);

        /// <summary>
        /// Determines if the condition resolves to true; should be used to determing validity of outputs.
        /// </summary>
        void EnsuresPostcondition<TException>(bool condition, [Optional] string message)
            where TException : Exception, new();

        /// <summary>
        /// Raises the contract failed event.
        /// </summary>
        void RaiseContractFailed([Optional] string message, [Optional] Exception exception);

        /// <summary>
        /// Determines if the condition resolves to true; should be used to determing validity of inputs.
        /// </summary>
        void RequiresPrecondition(bool condition, [Optional] string message);

        /// <summary>
        /// Determines if the condition resolves to true; should be used to determing validity of inputs.
        /// </summary>
        void RequiresPrecondition<TException>(bool condition, [Optional] string message)
            where TException : Exception, new();
    }
}