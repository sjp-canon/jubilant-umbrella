// ---------------------------------------------------------------------------------------------
// <copyright file="ContractFailedEventArgs.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// ---------------------------------------------------------------------------------------------

namespace Umbrella.Native.Framework.Contracts
{
    using System;

    /// <summary>
    /// Event arguments detailing a failed contract.
    /// </summary>
    public class ContractFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractFailedEventArgs"/> class.
        /// </summary>
        public ContractFailedEventArgs(string message, Exception exception)
        {
            Message = message;
            OriginalException = exception;
        }

        /// <summary>
        /// Gets the original exception object that generated the failed contract event.
        /// </summary>
        public Exception OriginalException { get; }

        /// <summary>
        /// Gets the message detailing the failed contract event.
        /// </summary>
        public string Message { get; }
    }
}
