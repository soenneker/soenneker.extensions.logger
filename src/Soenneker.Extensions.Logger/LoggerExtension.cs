using System;
using Microsoft.Extensions.Logging;
using Soenneker.Extensions.DateTimeOffsets;

namespace Soenneker.Extensions.Logger;

/// <summary>
/// A collection of helpful ILogger extension methods
/// </summary>
public static class LoggerExtension
{
    /// <summary>
    /// Logs startup information, including the current time in the specified time zone, using the provided logger.
    /// </summary>
    /// <param name="logger">The logger instance used to write the startup information messages. Cannot be null.</param>
    /// <param name="timeZoneInfo">The time zone to use when formatting the current time in the log output. Cannot be null.</param>
    public static void LogStartupInformation(this ILogger logger, TimeZoneInfo timeZoneInfo)
    {
        if (!logger.IsEnabled(LogLevel.Debug))
            return;

        logger.LogDebug("----- Startup information -----");

        logger.LogDebug("Current time: {time} ({timeZoneId})", DateTimeOffset.UtcNow.ToTz(timeZoneInfo).ToPreciseFormat(), timeZoneInfo.Id);

        logger.LogDebug("----- /Startup information -----");
    }
}
