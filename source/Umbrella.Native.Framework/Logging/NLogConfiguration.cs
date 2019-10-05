// --------------------------------------------------------------
// <copyright file="NLogConfiguration.cs" company="Canon Games Studio">
// © 2019, Canon Games Studio. All rights reserved.
// Licensed under the MIT license. See LICENSE in the project root for full license information.
// </copyright>
// --------------------------------------------------------------

namespace Umbrella.Native.Framework.Logging
{
    using NLog;

    /// <summary>
    /// Configures the NLog wrapper.
    /// </summary>
    public static class NLogConfiguration
    {
        private static bool Configured { get; set; } = false;

        /// <summary>
        /// Configures the logger.
        /// </summary>
        public static void Configure()
        {
            if (Configured == false)
            {
                var config = new NLog.Config.LoggingConfiguration();

                var logFile = new NLog.Targets.FileTarget("logFile") { FileName = "log.txt" };
                var logConsole = new NLog.Targets.ConsoleTarget("logConsole");

                config.AddRule(LogLevel.Trace, LogLevel.Fatal, logConsole);
                config.AddRule(LogLevel.Debug, LogLevel.Fatal, logFile);

                LogManager.Configuration = config;

                Configured = true;
            }
        }
    }
}
