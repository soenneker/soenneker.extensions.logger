[![](https://img.shields.io/nuget/v/soenneker.extensions.logger.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.logger/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.logger/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.logger/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.logger.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.logger/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.logger/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.logger/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Logger
Extension methods for writing consistent application lifecycle and diagnostic information through `ILogger`.

## Installation

```bash
dotnet add package Soenneker.Extensions.Logger
```

## Usage

```csharp
using Soenneker.Extensions.Logger;

TimeZoneInfo reportingZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
logger.LogStartupInformation(reportingZone);
```

`LogStartupInformation()` emits three `Debug` messages:

```text
----- Startup information -----
Current time: <precise local timestamp> (<time-zone ID>)
----- /Startup information -----
```

The timestamp is captured in UTC, converted with the supplied `TimeZoneInfo`, and formatted with the Soenneker precise date format. The time-zone ID is logged separately as structured data under `timeZoneId`; the formatted timestamp is stored under `time`.

When Debug logging is disabled, the method returns before capturing or formatting the timestamp. The logger must be non-null. The time zone must be non-null when Debug logging is enabled.

This method reports process startup timing only. It does not log environment names, assembly versions, configuration, machine identity, or health status.
